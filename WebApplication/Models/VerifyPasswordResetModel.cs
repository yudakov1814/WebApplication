using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class VerifyPasswordResetModel
    {
        [Required]
        public string Code { get; set; }
    }
}
