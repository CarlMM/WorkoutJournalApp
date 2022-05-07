using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;

namespace WorkoutJournalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutExerciseController : ControllerBase
    {
        private readonly IWorkoutExerciseService workoutExerciseService;


        public WorkoutExerciseController(IWorkoutExerciseService workoutExerciseService)
        {
            this.workoutExerciseService = workoutExerciseService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllWorkoutExercises()
        {
            var result = await workoutExerciseService.GetAllWorkoutExercises();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetSpecificWorkoutExercise(int id)
        {
            var result = await workoutExerciseService.GetWorkoutExerciseByIdAsync(id);

            return Ok(result);
        }

        [HttpGet]
        [Route("workoutExerciseRoutineId/{workoutExerciseRoutineId}")]
        public async Task<IActionResult> GetWorkoutExercisesByRoutineId(int workoutExerciseRoutineId)
        {
            var result = await workoutExerciseService.GetAllWorkoutExercisesByRoutineId(workoutExerciseRoutineId);

            return Ok(result);
        }
    }
}
