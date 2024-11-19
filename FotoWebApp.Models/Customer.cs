using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Models
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

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        #region Navigation Properties
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        #endregion
    }
}
