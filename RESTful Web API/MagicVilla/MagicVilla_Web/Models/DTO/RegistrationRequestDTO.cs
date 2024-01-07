namespace MagicVilla_Web.Models.DTO
{
    public class RegistrationRequestDTO
    {
        public string UserName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
