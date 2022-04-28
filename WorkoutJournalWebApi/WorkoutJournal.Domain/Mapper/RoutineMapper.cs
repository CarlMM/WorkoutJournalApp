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

        internal static IEnumerable<RoutineDto> ToRoutineDtoList(this List<Routine> routineList) =>
            routineList.Select(r => r.ToRoutineDto()).ToList();



        internal static RoutineDto ToRoutineDto(this Routine routine) =>
            new RoutineDto(routine.Id, routine.Name);
       

        internal static Routine ToRoutine(this SetRoutineDto dto) =>
             new Routine(dto.name);
        

        


    }
}
