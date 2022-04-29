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


        public async Task<IEnumerable<RoutineDto>> GetAllRoutinesAsync()
        {
            var routines = await routineRepository.GetAllRoutinesAsync();


            return routines.ToList().ToRoutineDtoList();
        }

        public async Task<RoutineDto> GetRoutineById(int id)
        {
            var specificRoutine = await routineRepository.GetRoutineByIdAsync(id);

            return specificRoutine.ToRoutineDto();
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

        public async Task UpdateRoutineAsync(int id, SetRoutineDto routineDto)
        {
            var routineToUpdate = await routineRepository.GetRoutineByIdAsync(id);


            routineToUpdate.Name = routineDto.name;


            routineRepository.UpdateRoutineAsync(routineToUpdate);
            await routineRepository.SaveChangesAsync();
        }

        public async Task RemoveSpecificRoutine(int id)
        {
            var routineToDelete = await routineRepository.GetRoutineByIdAsync(id);


            routineRepository.RemoveSpecificRoutine(routineToDelete);

            await routineRepository.SaveChangesAsync();
        }

    }
}
