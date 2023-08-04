using ToDoApi.Interfaces;
using ToDoApi.Model;

namespace ToDoApi.Services;

public class ToDoService : IToDoService
{
    public Task AddToDoAsync(ToDo toDo)
    {
        return Task.CompletedTask;
    }

    public Task ChangeDoneAsync(int id)
    {
        return Task.CompletedTask;
    }

    public Task ChangeImportantAsync(int id)
    {
        return Task.CompletedTask;
    }

    public Task ChangeStatusAsync(int id)
    {
        return Task.CompletedTask;
    }

    public Task DeleteToDoAsync(int id)
    {
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<ToDo>> GetAccordingToSearchAsync(string search)
    {
        var list = new List<ToDo>();
        return await Task.FromResult(list);
    }

    public async Task<IEnumerable<ToDo>> GetAllAsync()
    {
        var list = new List<ToDo>();
        return await Task.FromResult(list);
    }
}