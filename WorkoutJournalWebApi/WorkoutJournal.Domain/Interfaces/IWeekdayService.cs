using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Services;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IWeekdayService
    {

        Task<IEnumerable<WeekdayDto>> GetAllWeekdays();

    }
}
