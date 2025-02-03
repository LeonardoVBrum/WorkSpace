using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Cards
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        public string? Description{ get; set; }
        public DateTime? CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeadLine { get; set; }
        public ListCard? List { get; set; }
        public StatusCardEnum Status { get; set; }
    }
}
