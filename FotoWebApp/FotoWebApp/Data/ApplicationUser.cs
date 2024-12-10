using FotoWebApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Data
{
    /// <summary>
    /// This class represents an application user entity.
    /// Has a one-to-one relationship with the Photographer entity, where the application user is the principal.
    /// Inherits from IdentityUser, which is a class provided by the Identity framework. 
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        // Add profile data for application users by adding properties to the ApplicationUser class


        #region Navigation Properties
        // Add a foreign key to the Photographer entity
        //[ForeignKey("Photographer")]
        //public int? PhotographerId { get; set; }
        public Photographer? Photographer { get; set; }
        #endregion
    }

}
