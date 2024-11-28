using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Models
{
    /// <summary>
    /// This class represents an album entity.
    /// Has a one-to-many relationship with the Image entity, where the album is the principal.
    /// Has a one-to-one relationship with the Customer entity, where the album is the principal.
    /// Has a many-to-one relationship with the Photographer entity, where the album is the dependent.
    /// </summary>
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters")]
        public string Name { get; set; }
        public DateTime? Deadline { get; set; }
        public string AlbumLink { get; set; }
        public int MaxSelectedImages { get; set; }

        #region Navigation Properties
        public Customer Customer { get; set; } 

        [ForeignKey("Photographer")] 
        public int PhotographerId { get; set; }
        public Photographer Photographer { get; set; }

        public ICollection<Image> Images { get; set; }
        #endregion
    }
}
