using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Mapper;
using WorkoutJournal.Domain.Models;
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

        public async Task<IEnumerable<WorkoutExerciseDto>> GetAllWorkoutExercisesByRoutineId(int id)
        {
            var listByRoutineId = await workoutExerciseRepository.GetAllWorkoutExercisesByRoutineId(id);

            return listByRoutineId.ToList().ToWorkoutExerciseDtoList();
        }

        public async Task<WorkoutExerciseDto> GetWorkoutExerciseByIdAsync(int id)
        {
            var specificWorkoutExercise = await workoutExerciseRepository.GetWorkoutExerciseByIdAsync(id);

            return specificWorkoutExercise.ToWorkoutExerciseDto();
        }

        public async Task AddWorkoutExercise(SetWorkoutExerciseDto newWorkoutExercise)
        {
            WorkoutExercise workoutExerciseToAdd = newWorkoutExercise.ToWorkoutExercise();

            await workoutExerciseRepository.AddWorkoutExercise(workoutExerciseToAdd);
            await workoutExerciseRepository.SaveChangesAsync();


        }

    }
}
