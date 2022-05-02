using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;

namespace WorkoutJournalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {

        private readonly IExerciseService exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            this.exerciseService = exerciseService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAlLExercises()
        {
            var result = await exerciseService.GetAllExercises();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExerciseById(int id)
        {
            var result = await exerciseService.GetExerciseById(id);

            return Ok(result);
        }

        [HttpGet("/{muscleId}")]
        public async Task<IActionResult> GetExerciseByMuscleId(int muscleId)
        {
            var result = await exerciseService.GetExercisesByMuscleId(muscleId);

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddNewExercise(SetExerciseDto newExercise)
        {
            await exerciseService.AddNewExercise(newExercise);

            return Ok(newExercise);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSpecificExercise(int id)
        {
            await exerciseService.RemoveSpecificExercise(id);

            return Ok();
        }

    }
}
