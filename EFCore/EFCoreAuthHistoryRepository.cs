﻿using danj_backend.Data;
using danj_backend.DB;
using danj_backend.Repository;
using System.Linq.Expressions;
using danj_backend.Authentication;

namespace danj_backend.EFCore
{
    public abstract class EFCoreAuthHistoryRepository<TEntity, TContext> : IAuthHistoryRepository<TEntity>
        where TEntity : class, IAuthHistory
        where TContext : ApiDbContext
    {
        private readonly TContext context;

        public EFCoreAuthHistoryRepository(TContext context)
        {
            this.context = context;
        }

        public dynamic FetchAuthHistoryTokenById(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).Select(t => new
            {
                t.savedAuth
            }).ToList();
        }

        public bool FindInAuthHistoryIfExist(Expression<Func<TEntity, bool>> predicate)
        {
           return context.Set<TEntity>().Any(predicate);
        }


        public TEntity saveAuthHistory(TEntity authHistory)
        {
            string thenEncrypt = new DataAuth().Encrypt(Guid.NewGuid().ToString());
            authHistory.savedAuth = thenEncrypt;
            authHistory.preserve_data = authHistory.preserve_data;
            authHistory.isValid = Convert.ToChar("1");
            authHistory.created_at = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd"));
            authHistory.updated_at = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd"));
            context.Set<TEntity>().Add(authHistory);
            context.SaveChanges();
            return authHistory;
        }

        public TEntity ValueFetchAuthHistoryTokenById(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }
    }
}
