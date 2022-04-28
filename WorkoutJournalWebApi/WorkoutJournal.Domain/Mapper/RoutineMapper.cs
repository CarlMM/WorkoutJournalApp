using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Mapper
{
    internal static class RoutineMapper
    {

        public static RoutineDto ToDto(this Routine routine)
        {
            return new RoutineDto
            {
                Id = routine.Id,
                Name = routine.Name
            };
        }

        public static Routine ToRoutine(this RoutineDto routineDto)
        {

            return new Routine
            {
                Id = routineDto.Id,
                Name = routineDto.Name
            };

        }

        public static IEnumerable<RoutineDto> ToDoCollection(this IEnumerable<Routine> routines)
        {
            if(routines is null)
            {
                return Enumerable.Empty<RoutineDto>();
            }
            return routines.Select(routines => routines.ToDto()).ToList();
        }


    }
}
