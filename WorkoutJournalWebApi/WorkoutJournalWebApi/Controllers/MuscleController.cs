using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;

namespace WorkoutJournalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuscleController : ControllerBase
    {
        private readonly IMuscleService muscleService;

        public MuscleController(IMuscleService muscleService)
        {
            this.muscleService = muscleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMuscles()
        {
            var result = await muscleService.GetAllMuscles();

            return Ok(result);
        }
        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetMuscleById(int id)
        {
            var result = await muscleService.GetMuscleById(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewMuscle(SetMuscleDto newMuscle)
        {
            await muscleService.AddNewMuscle(newMuscle);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSpecificMuscle(int id)
        {
            await muscleService.RemoveSpecificMuscle(id);

            return Ok();
        }
    }
}
