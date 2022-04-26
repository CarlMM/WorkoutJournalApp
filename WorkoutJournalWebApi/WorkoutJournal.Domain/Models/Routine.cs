using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class Routine
    {
        public Routine()
        {
            WorkoutExercises = new HashSet<WorkoutExercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
