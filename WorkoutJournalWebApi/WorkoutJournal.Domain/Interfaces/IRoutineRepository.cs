using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IRoutineRepository
    {

        Task<IEnumerable<Routine>> GetAllRoutinesAsync();


    }
}
