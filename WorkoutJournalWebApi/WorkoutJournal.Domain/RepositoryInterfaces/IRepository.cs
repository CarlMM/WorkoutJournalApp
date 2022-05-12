using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.RepositoryInterfaces
{

    //Generic interface, for testing
    public interface IRepository<T>
    {
        Task <IEnumerable<T>> GetAllItems();

        Task<T> GetSpecificItem(int id);

        Task<T> AddNewItem(T itemToAdd);

        T RemoveSpecificItem(T itemToRemove);

        Task SaveChangesAsync();

    }
}
