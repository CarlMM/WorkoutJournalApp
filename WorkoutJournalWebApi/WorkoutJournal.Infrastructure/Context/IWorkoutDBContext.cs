using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Infrastructure.Context
{
    public interface IWorkoutDBContext
    {

        DbSet<Exercise> Exercises { get; }
        DbSet<Muscle> Muscles { get; }
        DbSet<Routine> Routines { get; }
        DbSet<Weekday> Weekdays { get; }
        DbSet<WorkoutExercise> WorkoutExercises { get; }
        DbSet<User> Users { get; }

        Task SaveChangesAsync();


    }
}
