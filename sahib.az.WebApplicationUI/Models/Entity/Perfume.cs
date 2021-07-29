using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.Entity
{
    public class Perfume
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public string Name { get; set; }

        public string Description { get; set; }

        //[DisplayName("Brend")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int ML { get; set; }

        [Required(ErrorMessage = "Növ seçin!")]
        public int TypeId { get; set; }

        public bool IsTester { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int Maya { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int ThreeMonths { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int SixMonths { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int NineMonths { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int TwelveMonths { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int FifteenMonths { get; set; }

        [Required(ErrorMessage = "Xananı doldurun!")]
        public int EighteenMonths { get; set; }

        public string ImagePath { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual PerfumeType Type { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

#nullable enable
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
#nullable disable
    }
}
