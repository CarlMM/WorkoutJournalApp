using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Dtos;

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
        public async Task<IActionResult> AddNewRoutine()
        {
            var result = await service.AddNewRoutine(RoutineDto newRoutine);

            return Ok(result);
        }


    }
}
