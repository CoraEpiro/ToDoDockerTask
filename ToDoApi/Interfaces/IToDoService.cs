using ToDoApi.Model;

namespace ToDoApi.Interfaces;

public interface IToDoService
{
    //Task<ToDo> GetToDoAsync(string id);
    Task<IEnumerable<ToDo>> GetAllAsync();
    Task<IEnumerable<ToDo>> GetAccordingToSearchAsync(string search);
    Task AddToDoAsync(ToDo toDo);
    Task DeleteToDoAsync(int id);
    Task ChangeDoneAsync(int id);
    Task ChangeImportantAsync(int id);
    Task ChangeStatusAsync(int id);
}