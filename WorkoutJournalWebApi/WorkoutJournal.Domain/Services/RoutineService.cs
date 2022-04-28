using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Mapper;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Infrastructure.Interfaces;

namespace WorkoutJournal.Domain.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IRoutineRepository routineRepository;

        public RoutineService(IRoutineRepository routineRepo)
        {
            this.routineRepository = routineRepo;
        }


        public async Task<IEnumerable<Routine>> GetAllRoutinesAsync()
        {
            return await routineRepository.GetAllRoutinesAsync();
        }


        public async Task AddNewRoutine(SetRoutineDto newRoutine)
        {
            if(newRoutine == null)
            {
                throw new ArgumentNullException();
            }

            Routine routineToAdd = newRoutine.ToRoutine();
            await routineRepository.AddNewRoutine(routineToAdd);
            await routineRepository.SaveChangesAsync();


        }

    }
}
