using AITech.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Interceptors
{
    public class AuditDbContextInterceptor :SaveChangesInterceptor
    {
        //işlemler veritabanına kayıt etmekten araya giricek saving
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            //chan

           foreach(var entry in eventData.Context.ChangeTracker.Entries())
            {
                if(entry.Entity is not BaseEntity baseEntity)
                {
                    continue;
                }

            //global saat = UTC
                if(entry.State is EntityState.Added)
                {
                    eventData.Context.Entry(baseEntity).Property(x => x.CreatedDate).CurrentValue = DateTime.Now;//local
                    eventData.Context.Entry(baseEntity).Property(x => x.UpdatedDate).IsModified = false;
                }
                if(entry.State is EntityState.Modified)
                {
                    eventData.Context.Entry(baseEntity).Property(x => x.UpdatedDate).CurrentValue = DateTime.Now;//local
                    eventData.Context.Entry(baseEntity).Property(x => x.CreatedDate).IsModified = false;
                }

            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
