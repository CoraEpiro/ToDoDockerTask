namespace ToDoApi.Model;

public class ToDo
{
    public int Id { get; set; }
    public string Context { get; set; }
    public Status Status { get; set; }
    public bool IsImportant { get; set; }
 }