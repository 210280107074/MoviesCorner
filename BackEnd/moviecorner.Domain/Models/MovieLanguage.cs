using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviecorner.Domain.Models
{
    public class MovieLanguage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        [ForeignKey("Language")]
        public Guid LanguageId { get; set; }
        public virtual Movie? Movie { get; set; } 
        public virtual Language? Language { get; set; }
    }
}