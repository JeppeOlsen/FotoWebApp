using MudBlazor;
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

        [Label("Customer Name")] // This attribute specifies the label of the property.
        [Required(ErrorMessage = "The customer name is required")] // This attribute specifies that the property is required.
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Customer Name must be between {2} and {1} characters")] // This attribute specifies the maximum and minimum length of the property.
        public string Name { get; set; }

        [Label("Customer Email Address")]
        [Required(ErrorMessage = "The customer email address is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Label("Customer Phone Number")]
        [Required(ErrorMessage = "The customer phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }


        #region Navigation Properties
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        #endregion
    }
}
