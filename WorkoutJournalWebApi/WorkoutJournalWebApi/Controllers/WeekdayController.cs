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
    public class WeekdayController : ControllerBase
    {


        private readonly IWeekdayService weekdayService;

        public WeekdayController(IWeekdayService weekdayService)
        {
            this.weekdayService = weekdayService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWeekdays()
        {
            var result = await weekdayService.GetAllWeekdays();

            return Ok(result);
        }


    }
}
