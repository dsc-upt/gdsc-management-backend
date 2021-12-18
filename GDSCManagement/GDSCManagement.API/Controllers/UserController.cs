using AutoMapper;
using GDSCManagement.DAL.Interfaces;
using GDSCManagement.Domain.DTOS;
using GDSCManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GDSCManagement.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
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
    public async Task<IActionResult> Add(UserRequest item)
    {
        var user = _mapper.Map<User>(item);
        user.Id = Guid.NewGuid().ToString();
        user.Created = DateTime.UtcNow;
        user.Updated = DateTime.UtcNow;

        if (!_userRepository.CheckEmail(user.Email))
        {
            return BadRequest("Not a valid Email");
        }

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