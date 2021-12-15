using GDSCManagement.Domain.Abstractions;

namespace GDSCManagement.Domain.Models;

public class Team : Entity
{
    public string Name;
    public string GitHubLink { get; set; }
}