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
    public class ExerciseService : IExerciseService
    {

        private readonly IExerciseRepository exerciseRepository;


        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            this.exerciseRepository = exerciseRepository;
        }

        public async Task<IEnumerable<ExerciseDto>> GetAllExercises()
        {
            var exercises = await exerciseRepository.GetAllExerciseAsync();

            return exercises.ToList().ToExerciseDtoList();
        }

        public async Task<ExerciseDto> GetExerciseById(int id)
        {
            var specificExercise = await exerciseRepository.GetExerciseByIdAsync(id);

            return specificExercise.ToExerciseDto();
        }

        public async Task<IEnumerable<ExerciseDto>> GetExercisesByMuscleId(int id)
        {
            var exercisesByMuscleId = await exerciseRepository.GetExercisesByMuscleId(id);

            return exercisesByMuscleId.ToList().ToExerciseDtoList();
        }

        public async Task AddNewExercise(SetExerciseDto newExercise)
        {
            Exercise exerciseToAdd = newExercise.ToExercise();
            await exerciseRepository.AddNewExercise(exerciseToAdd);
            await exerciseRepository.SaveChangesAsync();
        }

        public async Task RemoveSpecificExercise(int id)
        {
            var exerciseToDelete = await exerciseRepository.GetExerciseByIdAsync(id);

            exerciseRepository.RemoveSpecificExercise(exerciseToDelete);

            await exerciseRepository.SaveChangesAsync();

        }
    }
}
