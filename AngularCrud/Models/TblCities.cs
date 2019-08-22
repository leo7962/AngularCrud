using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularCrud.Models
{
    public partial class TblCities
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }
    }
}
