using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Dtos.WriteDto;
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

        //public static Routine ToRoutine(this RoutineDto routineDto)
        //{

        //    return new Routine
        //    {
        //        Id = routineDto.Id,
        //        Name = routineDto.Name
        //    };

        //}

        internal static Routine ToRoutine(this SetRoutineDto dto) =>
             new Routine(dto.name);
        

        


    }
}
