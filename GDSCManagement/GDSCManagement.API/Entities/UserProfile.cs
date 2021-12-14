namespace GDSCManagement.API.Entities;

public class UserProfile : Entity
{
    public User User { get; set; }
    public Team Team { get; set; }
    public string FacebookLink { get; set; }
    public string Phone { get; set; }
    public DateOnly Birthday { get; set; }
    
}