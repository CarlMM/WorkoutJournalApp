using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Mapper
{
    internal static class WeekdayMapper
    {

        internal static IEnumerable<WeekdayDto> ToWeekdayDtoList(this List<Weekday> weekdayList) =>
            weekdayList.Select(r => r.ToWeekdayDto()).ToList();



        internal static WeekdayDto ToWeekdayDto(this Weekday weekday) =>
            new WeekdayDto(weekday.Id, weekday.Dayname);
    }
}
