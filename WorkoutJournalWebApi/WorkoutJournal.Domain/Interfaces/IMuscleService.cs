using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IMuscleService
    {


        Task<IEnumerable<MuscleDto>> GetAllMuscles();

        Task<MuscleDto> GetMuscleById(int id);
    }
}
