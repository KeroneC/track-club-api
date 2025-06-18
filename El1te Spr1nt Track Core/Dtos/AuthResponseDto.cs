namespace El1te_Spr1nt_Track_Core.Dtos
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string FullName { get; set; } = null!;
    }
}
