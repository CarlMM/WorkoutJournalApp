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
    public class ExerciseRepository : IExerciseRepository
    {

        private readonly IWorkoutDBContext context;


        public ExerciseRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Exercise>> GetAllExerciseAsync()
        {
            return await context.Exercises.ToListAsync();
        }

        public async Task<IEnumerable<Exercise>> GetExercisesByMuscleId(int id)
        {

            var exercisesByMuscleId = await context.Exercises.Where(e => e.MuscleId == id).ToListAsync();
;
            return exercisesByMuscleId;
        }

        public async Task<Exercise> GetExerciseByIdAsync(int id)
        {
            return await context.Exercises.FirstOrDefaultAsync(x => x.Id == id);
        }

        

        public async Task<Exercise> AddNewExercise(Exercise newExercise)
        {
            await context.Exercises.AddAsync(newExercise);

            return newExercise;
        }

        public Exercise RemoveSpecificExercise(Exercise exerciseToRemove)
        {
            return context.Exercises.Remove(exerciseToRemove).Entity;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

    }
}
