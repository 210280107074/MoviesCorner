using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace moviecorner.Domain.Models
{
    public class MovieActor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid ActorId { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual Actor? Actor { get; set; }
    }
}