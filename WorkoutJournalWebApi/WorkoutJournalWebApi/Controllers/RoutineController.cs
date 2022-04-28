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

        private readonly IRoutineService service;


        public RoutineController(IRoutineService service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllRoutines()
        {
            var result = await service.GetAllRoutinesAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewRoutine(SetRoutineDto routineDto)
        {
            await service.AddNewRoutine(routineDto);

            return Ok();
        }


    }
}
