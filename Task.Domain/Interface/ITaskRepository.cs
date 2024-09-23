using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Entities;

namespace TaskApp.Domain.Interface
{
    public interface ITaskRepository
    {
        Task<IEnumerable<UserTask>> GetAllAsync();
        Task AddAsync(UserTask task);
        Task<UserTask> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(UserTask task);
    }
}
