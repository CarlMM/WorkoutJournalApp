using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public async Task<Routine> GetRoutineByIdAsync(int id)
        {
            return await context.Routines.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<Routine> AddNewRoutine(Routine newRoutine)
        {
            await context.Routines.AddAsync(newRoutine);

            return newRoutine;
        }

        public Routine UpdateRoutineAsync(Routine routineToUpdate)
        {
            return context.Routines.Update(routineToUpdate).Entity;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
