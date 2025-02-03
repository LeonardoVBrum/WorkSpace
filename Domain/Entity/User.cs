

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("us_Name")]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        [Column("us_Sname")]
        public string? Surname { get; set; }
        [EmailAddress]
        [StringLength(100)]
        [Column("us_Email")]
        public string? Email { get; set; }
        [Required]
        [Column("us_Password")]
        public string? PasswordHash { get; set; }
        [Required]
        [Column("us_UserName")]
        public string? Username { get; set; }
        [Column("us_Wk")]
        public ICollection<Workspace>? Workspaces { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpirationTime { get; set; }
    }
}
