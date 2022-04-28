using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutJournal.Domain.Dtos
{
    public record RoutineDto
    {
        public int Id { get; init; }
        public string Name { get; init; }

    }
}
