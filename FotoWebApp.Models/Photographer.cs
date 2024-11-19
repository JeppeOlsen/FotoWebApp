using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Models
{
    /// <summary>
    /// This class represents a photographer entity.
    /// Has a one-to-many relationship with the Album entity, 
    /// where the photographer is the principal entity in the relationship.
    /// </summary>
    public class Photographer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotographerId { get; set; }

        public string Name { get; set; }

        #region Navigation Properties
        public ICollection<Album> Albums { get; set; }
        #endregion
    }
}
