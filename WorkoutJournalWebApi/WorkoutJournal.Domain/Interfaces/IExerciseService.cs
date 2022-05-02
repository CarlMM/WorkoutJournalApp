using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IExerciseService
    {

        Task<IEnumerable<ExerciseDto>> GetAllExercises();

        Task<ExerciseDto> GetExerciseById(int id);

        Task<IEnumerable<ExerciseDto>> GetExercisesByMuscleId(int id);


    }
}
