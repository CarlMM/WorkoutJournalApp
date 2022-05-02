using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.RepositoryInterfaces;
using WorkoutJournal.Infrastructure.Context;

namespace WorkoutJournal.Infrastructure.Repository
{
    public class WorkoutExerciseRepository : IWorkoutExerciseRepository
    {
        private readonly IWorkoutDBContext context;


        public WorkoutExerciseRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }


    }
}
