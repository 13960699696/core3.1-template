using Autofac;
using Core.models;
using Core.Tool.ManagementClass;
using core3._1_template.Class;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Core.Template
{
    /// <summary>
    /// 初始化服务配置类
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 初始化服务配置类构造函数
        /// </summary>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 初始化服务配置文件
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 注册服务
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            #region 添加Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                // 获取xml文件名
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // 获取xml文件路径
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 添加控制器层注释，true表示显示控制器注释
                options.IncludeXmlComments(xmlPath, true);
            });
            #endregion
            #region 添加jwt校验
            services.Configure<TokenManagement>(Configuration.GetSection("tokenManagement"));
            var token = Configuration.GetSection("tokenManagement").Get<TokenManagement>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,//是否验证Issuer
                    ValidateAudience = true,//是否验证Audience
                    ValidateLifetime = true,//是否验证失效时间
                    ValidateIssuerSigningKey = true,//是否验证SecurityKey用户密钥
                    ValidAudience = token.Audience,//Audience
                    ValidIssuer = token.Issuer,//Issuer，这两项和前面签发jwt的设置一致
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(token.Secret)),//拿到SecurityKey                                                                                                          //},//自定义校验规则，可以新登录后将之前的无效
                };
            });
            #endregion
            #region 添加跨域
            services.AddCors(options =>
            {
                options.AddPolicy("any",
                    builder => builder.AllowAnyOrigin()
                    .WithMethods("GET", "POST", "HEAD", "PUT", "DELETE", "OPTIONS").AllowAnyHeader()
                );
            });
            #endregion
            services.AddControllers();
        }
        /// <summary>
        /// autofact 容器注入
        /// </summary>
        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<CustomAutofacModule>();
        }

        /// <summary>
        /// 使用服务
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region 使用swagger接口可视化
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Demo v1");
            });
            #endregion

            #region 使用jwt校验
            app.UseAuthentication();
            #endregion

            #region 使用log4日志
            loggerFactory.AddLog4Net();
            #endregion

            #region 使用跨域配置
            app.UseCors("any");
            #endregion

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
