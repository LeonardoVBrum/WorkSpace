

using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Workspace
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        [Required]
        [StringLength(50)]
        public User? User { get; set; }
        public ICollection<ListCard>? List { get; set; }
        public SatatusItemEnum Satus { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
