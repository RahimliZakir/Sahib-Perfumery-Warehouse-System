using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.Entity
{
    public class Logo
    {
        [Key]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

#nullable enable
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
#nullable disable

        [NotMapped]
        public string Temp { get; set; }
    }
}
