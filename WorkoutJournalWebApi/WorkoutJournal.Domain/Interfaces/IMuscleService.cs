using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IMuscleService
    {


        Task<IEnumerable<MuscleDto>> GetAllMuscles();

        Task<MuscleDto> GetMuscleById(int id);

        Task AddNewMuscle(SetMuscleDto newMuscle);

        Task RemoveSpecificMuscle(int id);
    }
}
