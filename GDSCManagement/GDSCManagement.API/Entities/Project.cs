namespace GDSCManagement.API.Entities;

public class Project: Entity
{
    public string Name { get; set; }
    public User Manager { get; set; }
    public ICollection<Team> Teams { get; set; }
}