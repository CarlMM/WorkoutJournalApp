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
            return await context.WorkoutExercises.Include(r => r.Routine).Include(w => w.Weekday).Include(e => e.Exercise).ToListAsync();
        }

        public async Task<WorkoutExercise> GetWorkoutExerciseByIdAsync(int id)
        {
            return await context.WorkoutExercises.Include(r => r.Routine).Include(w => w.Weekday).Include(e => e.Exercise).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<WorkoutExercise>> GetAllWorkoutExercisesByRoutineId(int id)
        {
            var listByRoutineId = await context.WorkoutExercises.Include(r => r.Routine).Include(w => w.Weekday).Include(e => e.Exercise).Where(r => r.RoutineId == id).ToListAsync();

            return listByRoutineId;
        }


    }
}
