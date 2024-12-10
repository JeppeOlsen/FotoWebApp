using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Data.Models
{
    /// <summary>
    /// This class represents a customer entity. 
    /// Has a one-to-one relationship with the Album entity, 
    /// where the customer is the dependent entity in the relationship.
    /// </summary>
    public class Customer
    {
        [Key] // This attribute specifies that the property is a primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database will generate the primary key value.
        public int CustomerId { get; set; }

        [Required] // This attribute specifies that the property is required.
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters")] // This attribute specifies the maximum and minimum length of the property.
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Email must be between 1 and 50 characters")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 8 and 20 characters")]
        public string Phone { get; set; }


        #region Navigation Properties
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        #endregion
    }
}
