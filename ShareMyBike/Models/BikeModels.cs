using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace ShareMyBike.Models
{

    [Table("Bike")]
    public class Bike
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BikeId { get; set; }
        public string BikeModel { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }
    }

    public class RegisterBike
    {
        public string BikeModel { get; set; }

    }

}