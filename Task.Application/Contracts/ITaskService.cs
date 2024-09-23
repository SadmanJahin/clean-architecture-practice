using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Entities;

namespace TaskApp.Application.Contracts
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetTasksAsync();
        Task<TaskDto> GetTaskByIdAsync(Guid id);
        Task CreateTaskAsync(CreateTaskDto createTaskDto);
        Task UpdateTaskAsync(Guid id, UpdateTaskDto updateTaskDto);
        Task DeleteTaskAsync(Guid id);
        Task<bool> TaskExistsAsync(Guid id);
    }
}
