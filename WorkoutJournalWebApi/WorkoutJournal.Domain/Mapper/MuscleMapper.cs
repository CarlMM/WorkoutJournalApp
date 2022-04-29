using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Mapper
{
    internal static class MuscleMapper
    {
        internal static IEnumerable<MuscleDto> ToMuscleDtoList(this List<Muscle> muscleList) =>
            muscleList.Select(m => m.ToMuscleDto()).ToList();

        internal static MuscleDto ToMuscleDto(this Muscle muscle) =>
            new MuscleDto(muscle.Id, muscle.Name);

        internal static Muscle ToMuscle(this SetMuscleDto dto) =>
            new Muscle(dto.name);

    }
}
