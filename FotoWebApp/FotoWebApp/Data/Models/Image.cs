using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Data.Models
{
    /// <summary>
    /// This class represents an image entity.
    /// Has a many-to-one relationship with the Album entity, 
    /// where the image is the dependent entity in the relationship.
    /// </summary>
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public string PhotoUrl { get; set; }
        public string FileName { get; set; }
        public bool Selected { get; set; } = false;

        #region Navigation Properties
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        #endregion


    }
}
