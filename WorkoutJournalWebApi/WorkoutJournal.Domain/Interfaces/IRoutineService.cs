using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IRoutineService
    {

        Task<IEnumerable<RoutineDto>> GetAllRoutinesAsync();

        Task<RoutineDto> GetRoutineById(int id);

        Task AddNewRoutine(SetRoutineDto newRoutine);

        Task UpdateRoutineAsync(int id, SetRoutineDto routineDto);

        Task RemoveSpecificRoutine(int id);

    }
}
