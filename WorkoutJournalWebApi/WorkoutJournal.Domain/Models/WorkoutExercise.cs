﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class WorkoutExercise
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int WeekdayId { get; set; }
        public int RoutineId { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual Routine Routine { get; set; }
        public virtual Weekday Weekday { get; set; }
    }
}
