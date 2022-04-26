using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class Weekday
    {
        public Weekday()
        {
            WorkoutExercises = new HashSet<WorkoutExercise>();
        }

        public int Id { get; set; }
        public string Dayname { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
