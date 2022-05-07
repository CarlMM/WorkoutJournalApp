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
    public class WorkoutExerciseRepository : IWorkoutExerciseRepository
    {
        private readonly IWorkoutDBContext context;


        public WorkoutExerciseRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<WorkoutExercise>> GetAllWorkoutExercises()
        {
            return await context.WorkoutExercises.Include(r => r.Routine).Include(w => w.Weekday).ToListAsync();
        }


    }
}
