using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutJournal.Domain.Dtos.WriteDto
{
    public record SetWorkoutExerciseDto(int exerciseId, int reps, int sets, int weekdayId, int routineId, string routineName)
    {
    }
}
