using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace moviecorner.Domain.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string LastName { get; set; } = string.Empty;
        
        [Required, MaxLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required,MaxLength(100)]
        public string Password { get; set; } = string.Empty;
        [ForeignKey(nameof(Role))]
        public Guid RoleId { get; set; }
        [ForeignKey(nameof(City))]
        public Guid CityId { get; set; }
        [ForeignKey(nameof(State))]
        public Guid StateId { get; set; }
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        [Column(TypeName = "timestamp without Time Zone")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "timestamp without Time Zone")]
        public DateTime? UpdatedAt { get; set; } 
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public virtual Role? Role { get; set; }
        public virtual City? City { get; set; }
        public virtual State? State { get; set; }
        public virtual Country? Country { get; set; }
    }
}