using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.RepositoryInterfaces
{
    public interface IWorkoutExerciseRepository
    {

        Task<IEnumerable<WorkoutExercise>> GetAllWorkoutExercises();

        Task<WorkoutExercise> GetWorkoutExerciseByIdAsync(int id);

        Task<IEnumerable<WorkoutExercise>> GetAllWorkoutExercisesByRoutineId(int id);


    }
}
