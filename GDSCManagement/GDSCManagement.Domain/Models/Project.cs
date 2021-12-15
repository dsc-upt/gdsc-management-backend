using GDSCManagement.Domain.Abstractions;

namespace GDSCManagement.Domain.Models;

public class Project : Entity
{
    public string Name { get; set; }
    public User Manager { get; set; }
    public ICollection<Team> Teams { get; set; }
}