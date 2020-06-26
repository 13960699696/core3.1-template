using System;
using Core.models.SqlServerVMTestModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core.models
{
    public partial class hsdataContext : DbContext
    {
        public hsdataContext()
        {
        }

        public hsdataContext(DbContextOptions<hsdataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bom用单价表> Bom用单价表 { get; set; }
        public virtual DbSet<Dd订单请购数量表> Dd订单请购数量表 { get; set; }
        public virtual DbSet<Sy系统导航表> Sy系统导航表 { get; set; }
        public virtual DbSet<Sy系统配置表> Sy系统配置表 { get; set; }
        public virtual DbSet<Wk供应商表> Wk供应商表 { get; set; }
        public virtual DbSet<Wl入库单> Wl入库单 { get; set; }
        public virtual DbSet<Wl入库明细查询> Wl入库明细查询 { get; set; }
        public virtual DbSet<Wl入库明细表> Wl入库明细表 { get; set; }
        public virtual DbSet<Wl出库单> Wl出库单 { get; set; }
        public virtual DbSet<Wl出库明细查询> Wl出库明细查询 { get; set; }
        public virtual DbSet<Wl出库明细表> Wl出库明细表 { get; set; }
        public virtual DbSet<Wl物料编码表> Wl物料编码表 { get; set; }
        public virtual DbSet<Wl物料配方明细表> Wl物料配方明细表 { get; set; }
        public virtual DbSet<Wl物料配方表> Wl物料配方表 { get; set; }
        public virtual DbSet<Wl采购物料单价表> Wl采购物料单价表 { get; set; }
        public virtual DbSet<客户表> 客户表 { get; set; }
        public virtual DbSet<导航> 导航 { get; set; }
        public virtual DbSet<物料入库单> 物料入库单 { get; set; }
        public virtual DbSet<物料入库明细表> 物料入库明细表 { get; set; }
        public virtual DbSet<物料出库单> 物料出库单 { get; set; }
        public virtual DbSet<物料出库明细表> 物料出库明细表 { get; set; }
        public virtual DbSet<物料单价表> 物料单价表 { get; set; }
        public virtual DbSet<物料编码表> 物料编码表 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=120.79.63.89;Initial Catalog=hsdata;User ID=test;Password=1q2w3e4r%T");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bom用单价表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("Bom用单价表_PrimaryKey")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.一级码).HasMaxLength(7);

                entity.Property(e => e.三级码).HasMaxLength(18);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.单价单位).HasMaxLength(5);

                entity.Property(e => e.单位).HasMaxLength(3);

                entity.Property(e => e.备注).HasMaxLength(100);

                entity.Property(e => e.物料名称).HasMaxLength(30);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.状态).HasMaxLength(2);

                entity.Property(e => e.生效日期).HasColumnType("datetime");

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.规格型号).HasMaxLength(40);
            });

            modelBuilder.Entity<Dd订单请购数量表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_DD订单请购数量表")
                    .IsClustered(false);

                entity.ToTable("DD订单请购数量表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.单位).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.完成日期).HasColumnType("datetime");

                entity.Property(e => e.完成状态).HasMaxLength(16);

                entity.Property(e => e.客户id).HasColumnName("客户ID");

                entity.Property(e => e.客户名称).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(64);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.类别).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.规格型号).HasMaxLength(128);

                entity.Property(e => e.订单日期).HasColumnType("datetime");

                entity.Property(e => e.订单编号).HasMaxLength(16);
            });

            modelBuilder.Entity<Sy系统导航表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_SY系统导航表")
                    .IsClustered(false);

                entity.ToTable("SY系统导航表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.代码).HasColumnType("ntext");

                entity.Property(e => e.名称).HasMaxLength(16);

                entity.Property(e => e.图标).HasMaxLength(64);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.字体颜色).HasMaxLength(32);

                entity.Property(e => e.所属系统).HasMaxLength(16);

                entity.Property(e => e.提示).HasMaxLength(128);
            });

            modelBuilder.Entity<Sy系统配置表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_SY系统配置表")
                    .IsClustered(false);

                entity.ToTable("SY系统配置表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.列名称).HasMaxLength(32);

                entity.Property(e => e.所属系统).HasMaxLength(16);

                entity.Property(e => e.控件名称).HasMaxLength(32);

                entity.Property(e => e.状态).HasMaxLength(4);

                entity.Property(e => e.窗口名称).HasMaxLength(32);

                entity.Property(e => e.经办人).HasMaxLength(8);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.表名称).HasMaxLength(32);

                entity.Property(e => e.配置中类).HasMaxLength(16);

                entity.Property(e => e.配置名称).HasMaxLength(16);

                entity.Property(e => e.配置大类).HasMaxLength(16);

                entity.Property(e => e.配置小类).HasMaxLength(16);

                entity.Property(e => e.配置数据).HasColumnType("ntext");
            });

            modelBuilder.Entity<Wk供应商表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("WK供应商表_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("WK供应商表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.产品名称).HasMaxLength(50);

                entity.Property(e => e.企业类型).HasMaxLength(10);

                entity.Property(e => e.供应商名称).HasMaxLength(40);

                entity.Property(e => e.供应商简称).HasMaxLength(16);

                entity.Property(e => e.供应商评级).HasMaxLength(16);

                entity.Property(e => e.公司地址).HasMaxLength(128);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.常规联系人).HasMaxLength(64);

                entity.Property(e => e.状态).HasMaxLength(16);

                entity.Property(e => e.第二人职务).HasMaxLength(16);

                entity.Property(e => e.第二人联系电话).HasMaxLength(64);

                entity.Property(e => e.第二联系人).HasMaxLength(16);

                entity.Property(e => e.类型).HasMaxLength(16);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.职务).HasMaxLength(8);

                entity.Property(e => e.联系电话).HasMaxLength(64);
            });

            modelBuilder.Entity<Wl入库单>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl入库单_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl入库单");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.仓库名称).HasMaxLength(15);

                entity.Property(e => e.供应商id).HasColumnName("供应商ID");

                entity.Property(e => e.供应商名称).HasMaxLength(40);

                entity.Property(e => e.入库单号).HasMaxLength(16);

                entity.Property(e => e.入库日期).HasColumnType("datetime");

                entity.Property(e => e.入库票据单号).HasMaxLength(30);

                entity.Property(e => e.入库类型).HasMaxLength(8);

                entity.Property(e => e.入库车牌号).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(250);

                entity.Property(e => e.审核标志).HasMaxLength(4);

                entity.Property(e => e.经办人).HasMaxLength(32);

                entity.Property(e => e.经办日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<Wl入库明细查询>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wl入库明细查询");

                entity.Property(e => e.一级码).HasMaxLength(16);

                entity.Property(e => e.三级码).HasMaxLength(16);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.仓库名称).HasMaxLength(15);

                entity.Property(e => e.使用状态).HasMaxLength(16);

                entity.Property(e => e.供应商id).HasColumnName("供应商ID");

                entity.Property(e => e.供应商名称).HasMaxLength(40);

                entity.Property(e => e.入单时间).HasColumnType("datetime");

                entity.Property(e => e.入库id).HasColumnName("入库ID");

                entity.Property(e => e.入库单号).HasMaxLength(16);

                entity.Property(e => e.入库单备注).HasMaxLength(250);

                entity.Property(e => e.入库单经办人).HasMaxLength(32);

                entity.Property(e => e.入库单经办日期).HasColumnType("datetime");

                entity.Property(e => e.入库日期).HasColumnType("datetime");

                entity.Property(e => e.入库明细备注).HasMaxLength(150);

                entity.Property(e => e.入库票据单号).HasMaxLength(30);

                entity.Property(e => e.入库类型).HasMaxLength(8);

                entity.Property(e => e.入库车牌号).HasMaxLength(16);

                entity.Property(e => e.单位).HasMaxLength(4);

                entity.Property(e => e.审核标志).HasMaxLength(4);

                entity.Property(e => e.批次号).HasMaxLength(16);

                entity.Property(e => e.有效期).HasColumnType("datetime");

                entity.Property(e => e.标识).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(50);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.生产日期).HasColumnType("datetime");

                entity.Property(e => e.规格型号).HasMaxLength(50);

                entity.Property(e => e.订单id).HasColumnName("订单ID");

                entity.Property(e => e.质量信息).HasMaxLength(255);
            });

            modelBuilder.Entity<Wl入库明细表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl入库明细表_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl入库明细表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.入单时间).HasColumnType("datetime");

                entity.Property(e => e.入库id).HasColumnName("入库ID");

                entity.Property(e => e.入库单号).HasMaxLength(16);

                entity.Property(e => e.单位).HasMaxLength(4);

                entity.Property(e => e.备注).HasMaxLength(150);

                entity.Property(e => e.批次号).HasMaxLength(16);

                entity.Property(e => e.有效期).HasColumnType("datetime");

                entity.Property(e => e.标识).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(50);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.生产日期).HasColumnType("datetime");

                entity.Property(e => e.规格型号).HasMaxLength(50);

                entity.Property(e => e.订单id).HasColumnName("订单ID");

                entity.Property(e => e.质量信息).HasMaxLength(255);
            });

            modelBuilder.Entity<Wl出库单>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl出库单_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl出库单");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.仓库名称).HasMaxLength(16);

                entity.Property(e => e.出库单号).HasMaxLength(9);

                entity.Property(e => e.出库日期).HasColumnType("datetime");

                entity.Property(e => e.出库票据号).HasMaxLength(64);

                entity.Property(e => e.出库类型).HasMaxLength(16);

                entity.Property(e => e.出库车牌号).HasMaxLength(30);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.客户id).HasColumnName("客户ID");

                entity.Property(e => e.客户名称).HasMaxLength(64);

                entity.Property(e => e.经办人).HasMaxLength(64);

                entity.Property(e => e.经办日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<Wl出库明细查询>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wl出库明细查询");

                entity.Property(e => e.一级码).HasMaxLength(16);

                entity.Property(e => e.三级码).HasMaxLength(16);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.仓库名称).HasMaxLength(16);

                entity.Property(e => e.使用状态).HasMaxLength(16);

                entity.Property(e => e.出库单号).HasMaxLength(9);

                entity.Property(e => e.出库单备注).HasMaxLength(255);

                entity.Property(e => e.出库单经办人).HasMaxLength(64);

                entity.Property(e => e.出库单经办日期).HasColumnType("datetime");

                entity.Property(e => e.出库日期).HasColumnType("datetime");

                entity.Property(e => e.出库票据号).HasMaxLength(64);

                entity.Property(e => e.出库类型).HasMaxLength(16);

                entity.Property(e => e.出库车牌号).HasMaxLength(30);

                entity.Property(e => e.单位).HasMaxLength(255);

                entity.Property(e => e.备注).HasMaxLength(150);

                entity.Property(e => e.客户id).HasColumnName("客户ID");

                entity.Property(e => e.客户名称).HasMaxLength(64);

                entity.Property(e => e.批次号).HasMaxLength(16);

                entity.Property(e => e.标识).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(50);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.用途).HasMaxLength(150);

                entity.Property(e => e.规格型号).HasMaxLength(40);

                entity.Property(e => e.订单id).HasColumnName("订单ID");

                entity.Property(e => e.质量).HasMaxLength(4);
            });

            modelBuilder.Entity<Wl出库明细表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl出库明细表_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl出库明细表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.出库id).HasColumnName("出库ID");

                entity.Property(e => e.出库单号).HasMaxLength(16);

                entity.Property(e => e.单位).HasMaxLength(255);

                entity.Property(e => e.备注).HasMaxLength(150);

                entity.Property(e => e.批次号).HasMaxLength(16);

                entity.Property(e => e.标识).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(50);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.用途).HasMaxLength(150);

                entity.Property(e => e.规格型号).HasMaxLength(40);

                entity.Property(e => e.订单id).HasColumnName("订单ID");

                entity.Property(e => e.质量).HasMaxLength(4);
            });

            modelBuilder.Entity<Wl物料编码表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl物料编码表_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl物料编码表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.一级码).HasMaxLength(16);

                entity.Property(e => e.三级码).HasMaxLength(16);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.亮度).HasMaxLength(64);

                entity.Property(e => e.使用状态).HasMaxLength(16);

                entity.Property(e => e.单位).HasMaxLength(16);

                entity.Property(e => e.备注说明).HasMaxLength(255);

                entity.Property(e => e.客户名称).HasMaxLength(128);

                entity.Property(e => e.物料名称).HasMaxLength(64);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.粘度).HasMaxLength(64);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.结存单价).HasMaxLength(255);

                entity.Property(e => e.规格型号).HasMaxLength(128);

                entity.Property(e => e.采购周期).HasMaxLength(64);
            });

            modelBuilder.Entity<Wl物料配方明细表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_wl物料配方明细表")
                    .IsClustered(false);

                entity.ToTable("wl物料配方明细表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.单位).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.物料名称).HasMaxLength(16);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.状态).HasMaxLength(16);

                entity.Property(e => e.规格型号).HasMaxLength(16);

                entity.Property(e => e.配方编码).HasMaxLength(16);
            });

            modelBuilder.Entity<Wl物料配方表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_wl物料配方表")
                    .IsClustered(false);

                entity.ToTable("wl物料配方表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.单位).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.搅拌压力).HasMaxLength(32);

                entity.Property(e => e.搅拌时间).HasMaxLength(32);

                entity.Property(e => e.搅拌温度).HasMaxLength(32);

                entity.Property(e => e.搅拌速度).HasMaxLength(32);

                entity.Property(e => e.物料名称).HasMaxLength(32);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.规格型号).HasMaxLength(64);

                entity.Property(e => e.配方类型).HasMaxLength(16);

                entity.Property(e => e.配方编码).HasMaxLength(16);
            });

            modelBuilder.Entity<Wl采购物料单价表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("wl采购物料单价表_PrimaryKey")
                    .IsClustered(false);

                entity.ToTable("wl采购物料单价表");

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.一级码).HasMaxLength(6);

                entity.Property(e => e.三级码).HasMaxLength(40);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.供应商id).HasColumnName("供应商ID");

                entity.Property(e => e.供应商简称).HasMaxLength(16);

                entity.Property(e => e.单价).HasColumnType("numeric(28, 0)");

                entity.Property(e => e.单价单位).HasMaxLength(16);

                entity.Property(e => e.单价识别码).HasMaxLength(18);

                entity.Property(e => e.单位).HasMaxLength(4);

                entity.Property(e => e.备注).HasMaxLength(150);

                entity.Property(e => e.物料名称).HasMaxLength(30);

                entity.Property(e => e.物料编码).HasMaxLength(12);

                entity.Property(e => e.状态).HasMaxLength(2);

                entity.Property(e => e.生效日期).HasColumnType("datetime");

                entity.Property(e => e.经办人).HasMaxLength(5);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.规格型号).HasMaxLength(50);

                entity.Property(e => e.辅助单位).HasMaxLength(4);
            });

            modelBuilder.Entity<客户表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_客户表")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.客户全称).HasMaxLength(128);

                entity.Property(e => e.客户地址).HasMaxLength(250);

                entity.Property(e => e.客户简称).HasMaxLength(16);

                entity.Property(e => e.客户类型).HasMaxLength(16);

                entity.Property(e => e.客户编码).HasMaxLength(16);

                entity.Property(e => e.状态).HasMaxLength(4);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.联系人).HasMaxLength(64);

                entity.Property(e => e.联系电话).HasMaxLength(128);
            });

            modelBuilder.Entity<导航>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("导航_PrimaryKey")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.代码).HasColumnType("ntext");

                entity.Property(e => e.分组).HasMaxLength(16);

                entity.Property(e => e.名称).HasMaxLength(16);

                entity.Property(e => e.图标).HasMaxLength(100);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.字体颜色).HasMaxLength(16);

                entity.Property(e => e.提示).HasMaxLength(250);
            });

            modelBuilder.Entity<物料入库单>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料入库单")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.入库单号).HasMaxLength(16);

                entity.Property(e => e.入库日期).HasColumnType("datetime");

                entity.Property(e => e.入库类型).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.客户编码).HasMaxLength(16);

                entity.Property(e => e.票据号).HasMaxLength(128);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.车牌号).HasMaxLength(64);
            });

            modelBuilder.Entity<物料入库明细表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料入库明细表")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.入库单号).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.批次号).HasMaxLength(32);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<物料出库单>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料出库单")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.出库单号).HasMaxLength(16);

                entity.Property(e => e.出库日期).HasColumnType("datetime");

                entity.Property(e => e.出库类型).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.客户编码).HasMaxLength(16);

                entity.Property(e => e.票据号).HasMaxLength(128);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.车牌号).HasMaxLength(32);
            });

            modelBuilder.Entity<物料出库明细表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料出库明细表")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.出库单号).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.批次号).HasMaxLength(16);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<物料单价表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料单价表")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.单价编码).HasMaxLength(16);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.客户编码).HasMaxLength(16);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.状态).HasMaxLength(4);

                entity.Property(e => e.生效日期).HasColumnType("datetime");

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<物料编码表>(entity =>
            {
                entity.HasKey(e => e.Identify)
                    .HasName("PrimaryKey_物料编码表")
                    .IsClustered(false);

                entity.Property(e => e.Identify).HasColumnName("_Identify");

                entity.Property(e => e.Locked).HasColumnName("_Locked");

                entity.Property(e => e.SortKey)
                    .HasColumnName("_SortKey")
                    .HasColumnType("numeric(28, 14)");

                entity.Property(e => e.一级码).HasMaxLength(16);

                entity.Property(e => e.二级码).HasMaxLength(16);

                entity.Property(e => e.单位).HasMaxLength(16);

                entity.Property(e => e.物料名称).HasMaxLength(64);

                entity.Property(e => e.物料编码).HasMaxLength(16);

                entity.Property(e => e.状态).HasMaxLength(4);

                entity.Property(e => e.经办人).HasMaxLength(16);

                entity.Property(e => e.经办日期).HasColumnType("datetime");

                entity.Property(e => e.规格型号).HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
