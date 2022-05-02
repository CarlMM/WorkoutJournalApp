using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class Exercise
    {
        public Exercise()
        {
            WorkoutExercises = new HashSet<WorkoutExercise>();
        }

        public Exercise(string name, int muscleId)
        {
            Name = name;
            MuscleId = muscleId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MuscleId { get; set; }

        public virtual Muscle Muscle { get; set; }
        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
