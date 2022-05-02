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

        public async Task<Exercise> GetMuscleByIdAsync(int id)
        {
            return await context.Exercises.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Exercise> AddNewExercise(Exercise newExercise)
        {
            await context.Exercises.AddAsync(newExercise);

            return newExercise;
        }

        public Exercise RemoveSpecific(Exercise exerciseToRemove)
        {
            return context.Exercises.Remove(exerciseToRemove).Entity;
        }


    }
}
