using System.ComponentModel.DataAnnotations;

namespace AR.Presentetion.Resources
{
    public class AuthUserResource
    {
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
