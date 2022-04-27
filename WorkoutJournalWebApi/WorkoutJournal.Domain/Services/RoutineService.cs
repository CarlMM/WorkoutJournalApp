using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Services
{
    class RoutineService : IRoutineRepository
    {
        private readonly IRoutineRepository routineRepository;

        public RoutineService(IRoutineRepository repo)
        {
            this.routineRepository = repo;
        }


        public async Task<IEnumerable<Routine>> GetAllRoutinesAsync()
        {
            return await routineRepository.GetAllRoutinesAsync();
        }

    }
}
