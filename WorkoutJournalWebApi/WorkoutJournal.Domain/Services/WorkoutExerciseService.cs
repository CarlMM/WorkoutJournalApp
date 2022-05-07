using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Mapper;
using WorkoutJournal.Domain.RepositoryInterfaces;

namespace WorkoutJournal.Domain.Services
{
    public class WorkoutExerciseService : IWorkoutExerciseService
    {

        private readonly IWorkoutExerciseRepository workoutExerciseRepository;

        public WorkoutExerciseService(IWorkoutExerciseRepository workoutExerciseRepository)
        {
            this.workoutExerciseRepository = workoutExerciseRepository;
        }


        public async Task<IEnumerable<WorkoutExerciseDto>> GetAllWorkoutExercises()
        {
           var workoutExercises = await workoutExerciseRepository.GetAllWorkoutExercises();

            return workoutExercises.ToList().ToWorkoutExerciseDtoList();
        }

    }
}
