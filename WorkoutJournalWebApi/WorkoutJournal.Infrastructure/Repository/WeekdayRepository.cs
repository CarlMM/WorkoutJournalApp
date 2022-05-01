using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Domain.RepositoryInterfaces;
using WorkoutJournal.Infrastructure.Context;

namespace WorkoutJournal.Infrastructure.Repository
{
    public class WeekdayRepository : IWeekdayRepository
    {

        private readonly IWorkoutDBContext context;


        public WeekdayRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Weekday>> GetAllWeekdaysAsync()
        {
            return await context.Weekdays.ToListAsync();
        }

    }
}
