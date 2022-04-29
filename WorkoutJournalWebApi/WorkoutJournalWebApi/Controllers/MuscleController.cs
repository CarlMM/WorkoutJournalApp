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


    }
}
