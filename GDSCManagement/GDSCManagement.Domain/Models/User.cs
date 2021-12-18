using System.ComponentModel.DataAnnotations;
using GDSCManagement.Domain.Abstractions;

namespace GDSCManagement.Domain.Models;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
}