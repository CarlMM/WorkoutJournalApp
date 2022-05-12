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

        private readonly IExerciseRepository specificExerciseRepository;
        //private readonly IRepository<Exercise> exerciseRepository;


        public ExerciseService(IExerciseRepository specificExerciseRepository)
        {
            //IRepository<Exercise> exerciseRepository, 
            //this.exerciseRepository = exerciseRepository;
            this.specificExerciseRepository = specificExerciseRepository;
        }

        public async Task<IEnumerable<ExerciseDto>> GetAllExercises()
        {
            //var exercises = await exerciseRepository.GetAllExerciseAsync();

            var exercises = await specificExerciseRepository.GetAllItems();

            return exercises.ToList().ToExerciseDtoList();
        }

        public async Task<ExerciseDto> GetExerciseById(int id)
        {
            var specificExercise = await specificExerciseRepository.GetSpecificItem(id);

            return specificExercise.ToExerciseDto();
        }

        public async Task<IEnumerable<ExerciseDto>> GetExercisesByMuscleId(int id)
        {
            var exercisesByMuscleId = await specificExerciseRepository.GetExercisesByMuscleId(id);

            return exercisesByMuscleId.ToList().ToExerciseDtoList();
        }

        public async Task AddNewExercise(SetExerciseDto newExercise)
        {
            Exercise exerciseToAdd = newExercise.ToExercise();
            await specificExerciseRepository.AddNewItem(exerciseToAdd);
            await specificExerciseRepository.SaveChangesAsync();
        }

        public async Task RemoveSpecificExercise(int id)
        {
            var exerciseToDelete = await specificExerciseRepository.GetSpecificItem(id);

            specificExerciseRepository.RemoveSpecificItem(exerciseToDelete);

            await specificExerciseRepository.SaveChangesAsync();

        }
    }
}
