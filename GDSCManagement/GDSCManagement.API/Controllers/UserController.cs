using GDSCManagement.DAL.Interfaces;
using GDSCManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GDSCManagement.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await _userRepository.GetAsync();
        if (response.Count == 0)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var response = await _userRepository.GetAsync(id);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Add(User item)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            Email = item.Email,
            FirstName = item.FirstName,
            LastName = item.LastName
        };

        var response = await _userRepository.AddAsync(user);
        return Ok(response);

    }

    [HttpDelete]
    public async Task<IActionResult> Delete(User user)
    {
        await _userRepository.DeleteAsync(user);
        return Ok();
    }
}