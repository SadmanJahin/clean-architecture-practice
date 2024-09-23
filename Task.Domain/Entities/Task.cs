using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public class UserTask
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public bool IsCompleted { get; private set; }
    }

    public class CreateTaskDto
    {
        public string Title { get; set; }
    }

    public class TaskDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class UpdateTaskDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool? IsCompleted { get; set; } 
    }
}
