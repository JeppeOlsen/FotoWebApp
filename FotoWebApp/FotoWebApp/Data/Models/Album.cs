using Microsoft.AspNetCore.Mvc;
using MudBlazor;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace FotoWebApp.Data.Models
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

        [Label("Project Title")]
        [Required(ErrorMessage = "The project title is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Project title must be between {2} and {1} characters")]
        public string Name { get; set; }

        [Label("Deadline")]
        [Required(ErrorMessage = "The deadline is required")]
        public DateTime? Deadline { get; set; }

        [Label("Album Link Password")]
        public string? LinkPassword { get; set; }

        [Label("Amount of selectable photos by the customer")]
        [HelpKeyword("Amount of selectable photos by the customer")]
        [Range(1, 1000, ErrorMessage = "Amount of photos must be between {1} and {2}")]
        [Required(ErrorMessage = "Amount of selectable photos by the customer is required")]
        public int MaxSelectedImages { get; set; }


        #region Navigation Properties
        public Customer Customer { get; set; } 

        [ForeignKey("Photographer")] 
        public int PhotographerId { get; set; }
        public Photographer Photographer { get; set; }

        public ICollection<Image> Images { get; set; } = new List<Image>();
        #endregion
    }
}
