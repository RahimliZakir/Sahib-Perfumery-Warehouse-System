using sahib.az.WebApplicationUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Areas.Admin.Models.ViewModel
{
    public class AnswerIndexCreateViewModel
    {
        public IEnumerable<Perfume> Perfumes { get; set; }

        public Perfume Perfume { get; set; }

        public string SearchError { get; set; }
    }
}
