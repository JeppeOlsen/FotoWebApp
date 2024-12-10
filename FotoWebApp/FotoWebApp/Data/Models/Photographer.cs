using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Data.Models
{
    /// <summary>
    /// This class represents a photographer entity.
    /// Has a one-to-many relationship with the Album entity, 
    /// where the photographer is the principal entity in the relationship.
    /// Has a one-to-one relationship with the ApplicationUser entity, 
    /// where the photographer is the dependent entity in the relationship.
    /// </summary>
    public class Photographer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotographerId { get; set; }

        public string Name { get; set; }

        #region Navigation Properties
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<Album> Albums { get; set; }
        #endregion
    }
}
