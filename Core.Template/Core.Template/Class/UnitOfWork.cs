using Core.Template.Redis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.Template.Class
{
    /// <summary>
    /// 数据库事务的使用
    /// </summary>
    public class UnitOfWork
    {
        /// <summary>
        /// 普通事务的使用
        /// </summary>
        /// <param name="action">执行的方法</param>
        /// <param name="dbContext">执行的上下文</param>
        public static void DbContextInvoke(Action action,DbContext dbContext)
        {
            using (IDbContextTransaction trans = dbContext.Database.BeginTransaction())
            {
                try
                {
                    action.Invoke();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    if (trans != null)
                        trans.Rollback();
                    throw ex;
                }
                finally
                {
                    trans.Dispose();
                }
            }
        }
        /// <summary>
        /// Redis事务
        /// </summary>
        /// <param name="action">执行的方法</param>
        /// <param name="redisClient">导入redis客户端</param>
        public static void RedisContextInvoke(Action action, IRedisClient redisClient)
        {
            using (IRedisTransaction irt = redisClient.CreateTransaction())
            {
                try
                {
                    action.Invoke();
                    irt.Commit();
                }
                catch (Exception ex)
                {
                    if (irt != null)
                        irt.Rollback();
                    throw ex;
                }
                finally
                {
                    irt.Dispose();
                }
            }
        }
        /// <summary>
        /// 分布式事务
        /// </summary>
        /// <param name="action">执行的方法</param>
        public static void DistributedDbContextInvoke(Action action)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    action.Invoke();
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
        }
    }
}
