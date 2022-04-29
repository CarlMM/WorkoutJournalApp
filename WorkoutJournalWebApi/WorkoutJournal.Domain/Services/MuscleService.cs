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
    public class MuscleService : IMuscleService
    {

        private readonly IMuscleRepository muscleRepository;

       public MuscleService(IMuscleRepository muscleRepo)
        {
            this.muscleRepository = muscleRepo;
        }


        public async Task<IEnumerable<MuscleDto>> GetAllMuscles()
        {
            var muscles = await muscleRepository.GetAllMusclesAsync();

            return muscles.ToList().ToMuscleDtoList();
        }

    }
}
