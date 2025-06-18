using El1teSpr1ntTrack.Core.DTOs;

namespace El1teSpr1ntTrack.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDto> RegisterUserAsync(UserRegisterDto dto);
        Task<AuthResponseDto> LoginUserAsync(UserLoginDto dto);
    }
}
