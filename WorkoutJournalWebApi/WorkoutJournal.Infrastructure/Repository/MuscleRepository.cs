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
    public class MuscleRepository : IRepository<Muscle>
    {
        private readonly IWorkoutDBContext context;


        public MuscleRepository(IWorkoutDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Muscle>> GetAllItems()
        {
            return await context.Muscles.ToListAsync();
        }

        public async Task<Muscle> GetSpecificItem(int id)
        {
            return await context.Muscles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Muscle> AddNewItem(Muscle muscleToAdd)
        {
            await context.Muscles.AddAsync(muscleToAdd);

            return muscleToAdd;
        }

        public Muscle RemoveSpecificItem(Muscle muscleToDelete)
        {
            return context.Muscles.Remove(muscleToDelete).Entity;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
