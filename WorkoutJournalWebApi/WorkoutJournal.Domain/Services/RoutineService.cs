using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Infrastructure.Interfaces;

namespace WorkoutJournal.Domain.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IRoutineRepository routineService;

        public RoutineService(IRoutineRepository repo)
        {
            this.routineService = repo;
        }


        public async Task<IEnumerable<Routine>> GetAllRoutinesAsync()
        {
            return await routineService.GetAllRoutinesAsync();
        }

    }
}
