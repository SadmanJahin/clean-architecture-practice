using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.Contracts;
using TaskApp.Domain.Entities;
using TaskApp.Domain.Interface;

namespace TaskApp.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskDto> GetTaskByIdAsync(Guid id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            return task != null ? new TaskDto { /* mapping */ } : null;
        }

        public async Task UpdateTaskAsync(Guid id, UpdateTaskDto updateTaskDto)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            if (task != null)
            {
                await _taskRepository.UpdateAsync(task);
            }
        }

        public async Task DeleteTaskAsync(Guid id)
        {
            await _taskRepository.DeleteAsync(id);
        }

        public async Task<bool> TaskExistsAsync(Guid id)
        {
            return (await _taskRepository.GetByIdAsync(id)) != null;
        }

        public Task<IEnumerable<TaskDto>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateTaskAsync(CreateTaskDto createTaskDto)
        {
            throw new NotImplementedException();
        }
    }
}
