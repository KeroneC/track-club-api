using El1te_Spr1nt_Track_Core.Dtos;

namespace El1te_Spr1nt_Track_Core.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto> RegisterUserAsync(UserRegisterDto dto);
        Task<AuthResponseDto> LoginUserAsync(UserLoginDto dto);
    }
}
