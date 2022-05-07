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
    internal static class WorkoutExerciseMapper
    {

        internal static IEnumerable<WorkoutExerciseDto> ToWorkoutExerciseDtoList(this List<WorkoutExercise> wEList) =>
            wEList.Select(w => w.ToWorkoutExerciseDto()).ToList();


        internal static WorkoutExerciseDto ToWorkoutExerciseDto(this WorkoutExercise wE) =>
            new WorkoutExerciseDto(wE.Id, wE.Exercise.Name, wE.Reps, wE.Sets, wE.Routine.Name, wE.Weekday.Dayname);


        internal static WorkoutExercise ToWorkoutExercise(this SetWorkoutExerciseDto dto) =>
            new WorkoutExercise(dto.exerciseId, dto.reps, dto.sets, dto.weekdayId, dto.routineId);




    }
}
