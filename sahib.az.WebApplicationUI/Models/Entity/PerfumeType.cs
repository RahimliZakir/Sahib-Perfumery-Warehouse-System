using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.Entity
{
    public class PerfumeType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Növ əlavə edin!")]
        public string Name { get; set; }

        public virtual ICollection<Perfume> Perfumes { get; set; }

        public DateTime CreatedDate { get; set; }

#nullable enable
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
#nullable disable
    }
}
