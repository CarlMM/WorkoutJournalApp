using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Mapper;
using WorkoutJournal.Domain.RepositoryInterfaces;

namespace WorkoutJournal.Domain.Services
{
    public class WeekdayService : IWeekdayService
    {

        private readonly IWeekdayRepository weekdayRepository;


        public WeekdayService(IWeekdayRepository weekdayRepo)
        {
            this.weekdayRepository = weekdayRepo;
        }


        public async Task<IEnumerable<WeekdayDto>> GetAllWeekdays()
        {
            var weekdays = await weekdayRepository.GetAllWeekdaysAsync();


            return weekdays.ToList().ToWeekdayDtoList();
        }

    }
}
