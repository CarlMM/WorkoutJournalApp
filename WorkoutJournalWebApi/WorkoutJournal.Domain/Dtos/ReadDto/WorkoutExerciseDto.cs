using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutJournal.Domain.Dtos.ReadDto
{
    public record WorkoutExerciseDto(int id, string exercise, int reps, int sets, string routineName, string weekdayName)
    {    
    }
}
