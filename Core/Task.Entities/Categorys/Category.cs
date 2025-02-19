namespace Task.Entities.Categorys;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Tasks.Task> Tasks { get; set; }
}