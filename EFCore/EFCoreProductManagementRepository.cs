﻿using danj_backend.Data;
using danj_backend.DB;
using danj_backend.Model;
using danj_backend.Repository;

namespace danj_backend.EFCore;

public class EFCoreProductManagementRepository<TEntity, TContext> : IProductManagementRepository<TEntity>
where TEntity : class, IProductManagement
where TContext: ApiDbContext
{
    private readonly TContext context;

    public EFCoreProductManagementRepository(TContext context)
    {
        this.context = context;
    }

    public async Task<TEntity> createProducts(TEntity entity)
    {
        entity.created_at = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd"));
        entity.updated_at = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd"));
        entity.productStatus = Convert.ToChar("1");
        entity.created_by = "Administrator";
        entity.IsUnderMaintenance = Convert.ToChar("0");
        context.Set<TEntity>().Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}