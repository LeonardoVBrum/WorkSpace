

using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class ListCard
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        public StatusCardEnum Status { get; set; }
        public  DateTime CreateAt { get; set; }

        public Workspace? Workspace { get; set; }
        public ICollection<Cards>? Cards { get; set; }

    }
}
