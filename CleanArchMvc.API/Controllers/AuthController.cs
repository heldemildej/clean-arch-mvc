using CleanArchMvc.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO login)
    {
        var token = await _authService.Login(login.Username, login.Password);

        if (token == null)
            return Unauthorized("Invalid credentials");

        return Ok(new { token });
    }
}