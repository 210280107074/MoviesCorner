using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace moviecorner.Domain.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, MaxLength(250)]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Column("timestamp without time zone")]
        public DateTime ReleaseDate { get; set; }
        public int DurationMinutes { get; set; }
        public string PosterUrl { get; set; } = string.Empty;
        public string? TrailerUrl { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}