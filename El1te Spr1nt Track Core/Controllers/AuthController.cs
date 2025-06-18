using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using El1te_Spr1nt_Track_Core.Dtos;
using El1te_Spr1nt_Track_Core.Services;

namespace El1te_Spr1nt_Track_Core.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResponseDto>> Register(UserRegisterDto dto)
        {
            try
            {
                var response = await _authService.RegisterUserAsync(dto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponseDto>> Login(UserLoginDto dto)
        {
            try
            {
                var response = await _authService.LoginUserAsync(dto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }
    }
}
