using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class Muscle
    {
        public Muscle()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
