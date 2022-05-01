using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos.ReadDto;
using WorkoutJournal.Domain.Dtos.WriteDto;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Mapper;
using WorkoutJournal.Domain.Models;
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

        public async Task<MuscleDto> GetMuscleById(int id)
        {
            var specificMuscle = await muscleRepository.GetMuscleByIdAsync(id);

            return specificMuscle.ToMuscleDto();

        }

        public async Task AddNewMuscle(SetMuscleDto newMuscle)
        {
            if(newMuscle == null)
            {
                throw new ArgumentNullException();

            }

            Muscle muscleToAdd = newMuscle.ToMuscle();
            await muscleRepository.AddNewMuscle(muscleToAdd);
            await muscleRepository.SaveChangesAsync();

        }

        public async Task RemoveSpecificMuscle(int id)
        {
            var muscleToDelete = await muscleRepository.GetMuscleByIdAsync(id);

            muscleRepository.RemoveSpecificMuscle(muscleToDelete);

            await muscleRepository.SaveChangesAsync();
        }

    }
}
