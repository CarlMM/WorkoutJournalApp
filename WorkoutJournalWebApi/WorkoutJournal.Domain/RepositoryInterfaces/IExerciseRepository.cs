using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.RepositoryInterfaces
{
    public interface IExerciseRepository
    {

        Task<IEnumerable<Exercise>> GetAllExerciseAsync();

        Task<Exercise> GetMuscleByIdAsync(int id);

        Task<Exercise> AddNewExercise(Exercise newExercise);

        Exercise RemoveSpecific(Exercise exerciseToRemove);


    }
}
