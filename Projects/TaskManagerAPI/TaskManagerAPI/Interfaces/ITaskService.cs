using TaskManagerAPI.Models;
using TaskManagerAPI.Models.DTOs;

namespace TaskManagerAPI.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetAll(string userId);
        TaskItem? GetById(int id, string userId);
        TaskItem Create(TaskCreateDto dto, string userId);
        bool Update(int id, TaskCreateDto dto, string userId);
        bool Delete(int id, string userId);
    }
}
