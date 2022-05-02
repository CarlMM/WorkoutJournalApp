using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IExerciseService
    {

        Task<IEnumerable<ExerciseDto>> GetAllExercises();

        Task<ExerciseDto> GetExerciseById(int id);

        Task<IEnumerable<ExerciseDto>> GetExercisesByMuscleId(int id);

        Task AddNewExercise(SetExerciseDto newExercise);

        Task RemoveSpecificExercise(int id);


    }
}
