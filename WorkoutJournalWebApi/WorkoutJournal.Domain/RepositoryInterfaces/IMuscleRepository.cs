using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.RepositoryInterfaces
{
    public interface IMuscleRepository
    {

        Task<IEnumerable<Muscle>> GetAllMusclesAsync();

        Task<Muscle> GetMuscleByIdAsync(int id);

    }
}
