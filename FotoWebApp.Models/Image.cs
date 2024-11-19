﻿using System.ComponentModel.DataAnnotations; // Enables data annotations, which are used to configure the database schema and validation rules etc.
using System.ComponentModel.DataAnnotations.Schema;

namespace FotoWebApp.Models
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

        // More properties to be added here

        #region Navigation Properties
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        #endregion
    }
}
