namespace Task.Entities.Tasks;

public class Task
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool DoIt { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
}