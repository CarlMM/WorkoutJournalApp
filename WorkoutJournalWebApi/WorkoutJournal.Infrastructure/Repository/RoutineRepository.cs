using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Infrastructure.Context;
using WorkoutJournal.Infrastructure.Interfaces;

namespace WorkoutJournal.Infrastructure.Repository
{


    public class RoutineRepository : IRoutineRepository
    {

        private readonly IWorkoutDBContext context;


        public RoutineRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Routine>> GetAllRoutinesAsync()
        {
            return await context.Routines.ToListAsync();
        }


    }
}
