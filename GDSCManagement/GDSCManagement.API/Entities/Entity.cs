namespace GDSCManagement.API.Entities;

public abstract class Entity
{
    public int ID { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}