using FoccoEmFrente.Kanban.Application.Context;
using FoccoEmFrente.Kanban.Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoccoEmFrente.Kanban.Application.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        protected readonly KanbanContext DbContext;
        protected readonly DbSet<Activity> DbSet;

        public ActivityRepository(KanbanContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<Activity>();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public async Task<IEnumerable<Activity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public Activity Add(Activity activity)
        {
            var entry = DbSet.Add(activity);

            DbContext.SaveChanges();

            return entry.Entity;
        }
    }
}
