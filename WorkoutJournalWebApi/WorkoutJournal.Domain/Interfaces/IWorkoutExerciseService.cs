﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IWorkoutExerciseService
    {
        Task<IEnumerable<WorkoutExerciseDto>> GetAllWorkoutExercises();

        Task<IEnumerable<WorkoutExerciseDto>> GetAllWorkoutExercisesByRoutineId(int id);

        Task<WorkoutExerciseDto> GetWorkoutExerciseByIdAsync(int id);

    }
}