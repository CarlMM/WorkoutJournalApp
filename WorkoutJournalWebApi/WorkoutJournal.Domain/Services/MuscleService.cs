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

        //private readonly IMuscleRepository muscleRepository;
        private readonly IRepository<Muscle> muscleRepository;

        public MuscleService(IRepository<Muscle> muscleRepo)
        {
            this.muscleRepository = muscleRepo;
        }


        public async Task<IEnumerable<MuscleDto>> GetAllMuscles()
        {
            //var muscles = await muscleRepository.GetAllMusclesAsync();
            var muscles = await muscleRepository.GetAllItems();

            return muscles.ToList().ToMuscleDtoList();
        }

        public async Task<MuscleDto> GetMuscleById(int id)
        {
            //var specificMuscle = await muscleRepository.GetMuscleByIdAsync(id);
            var specificMuscle = await muscleRepository.GetSpecificItem(id);

            return specificMuscle.ToMuscleDto();

        }

        public async Task AddNewMuscle(SetMuscleDto newMuscle)
        {
            if(newMuscle == null)
            {
                throw new ArgumentNullException();

            }

            Muscle muscleToAdd = newMuscle.ToMuscle();
            //await muscleRepository.AddNewMuscle(muscleToAdd);
            await muscleRepository.AddNewItem(muscleToAdd);
            await muscleRepository.SaveChangesAsync();

        }

        public async Task RemoveSpecificMuscle(int id)
        {
            //var muscleToDelete = await muscleRepository.GetMuscleByIdAsync(id);
            var muscleToDelete = await muscleRepository.GetSpecificItem(id);

            //muscleRepository.RemoveSpecificMuscle(muscleToDelete);
            muscleRepository.RemoveSpecificItem(muscleToDelete);

            await muscleRepository.SaveChangesAsync();
        }

    }
}
