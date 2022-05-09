using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.CustomExceptions;

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

        [HttpPost]
        public async Task<IActionResult> AddNewWorkoutExercise(SetWorkoutExerciseDto newWorkoutExercise)
        {

            try
            {
                await workoutExerciseService.AddWorkoutExercise(newWorkoutExercise);
                return Ok(newWorkoutExercise);

            }
            catch (NotFoundException)
            {
                return StatusCode(204);
            }
        }
    }
}
