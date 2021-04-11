using System.ComponentModel.DataAnnotations;

namespace API.DTOS
{
    public class RegisterDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string Password{ get; set; }
    }
}