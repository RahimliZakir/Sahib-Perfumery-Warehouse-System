using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.Entity
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Xahiş olunur brendin adını qeyd edin!")]
        public string Name { get; set; }

        public virtual ICollection<Perfume> Perfumes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

#nullable enable
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
#nullable disable
    }
}
