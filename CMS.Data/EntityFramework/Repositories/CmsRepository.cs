﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.EntityFramework;
using CMS.Domain;

namespace CMS.Data.EntityFramework.Repositories
{
    public class CmsRepository<TEntity, TPrimaryKey> : CmsReponsitoryBase<CmsDbContext, TEntity, TPrimaryKey, Guid, Guid>,
        ICmsRepository<TEntity, TPrimaryKey>
         where TEntity : class, IEntity<TPrimaryKey>
    {
        public CmsRepository(IDbContextProvider<CmsDbContext, Guid, Guid> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
