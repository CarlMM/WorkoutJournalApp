using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Domain.RepositoryInterfaces;
using WorkoutJournal.Infrastructure.Context;

namespace WorkoutJournal.Infrastructure.Repository
{
    public class MuscleRepository : IMuscleRepository
    {
        private readonly IWorkoutDBContext context;


        public MuscleRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Muscle>> GetAllMusclesAsync()
        {
            return await context.Muscles.ToListAsync();
        }

        public async Task<Muscle> GetMuscleByIdAsync(int id)
        {
            return await context.Muscles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Muscle> AddNewMuscle(Muscle muscleToAdd)
        {
            await context.Muscles.AddAsync(muscleToAdd);

            return muscleToAdd;
        }

        public Muscle RemoveSpecificMuscle(Muscle muscleToDelete)
        {
            return context.Muscles.Remove(muscleToDelete).Entity;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
