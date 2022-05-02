using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutJournal.Domain.Dtos.ReadDto
{
    public record ExerciseDto(int id, string name, int muscleId)
    {
    }
}
