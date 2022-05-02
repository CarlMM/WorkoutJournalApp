﻿using System;
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
    }
}