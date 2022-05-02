using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Mapper
{
    internal static class ExerciseMapper
    {
        internal static IEnumerable<ExerciseDto> ToExerciseDtoList(this List<Exercise> exerciseList) =>
            exerciseList.Select(e => e.ToExerciseDto()).ToList();

        internal static ExerciseDto ToExerciseDto(this Exercise exercise) =>
            new ExerciseDto(exercise.Id, exercise.Name, exercise.MuscleId);

        internal static Exercise ToExercise(this SetExerciseDto dto) =>
            new Exercise(dto.name, dto.muscleId);



    }
}
