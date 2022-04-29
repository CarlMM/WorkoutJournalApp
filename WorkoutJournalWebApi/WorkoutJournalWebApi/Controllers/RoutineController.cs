using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Dtos.WriteDto;

namespace WorkoutJournalWebApi.Controllers
{
    


    [Route("api/[controller]")]
    [ApiController]
    public class RoutineController : ControllerBase
    {

        private readonly IRoutineService routineService;


        public RoutineController(IRoutineService routineService)
        {
            this.routineService = routineService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllRoutines()
        {
            var result = await routineService.GetAllRoutinesAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewRoutine(SetRoutineDto routineDto)
        {
            await routineService.AddNewRoutine(routineDto);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoutine(int id, SetRoutineDto routineToUpdate)
        {
            try
            {
                await routineService.UpdateRoutineAsync(id, routineToUpdate);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }


    }
}
