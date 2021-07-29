using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.FormModel
{
    public class SignInFormModel
    {
        [Required(ErrorMessage = "Xahiş olunur istifadəçi adınızı və ya emailinizi daxil edin!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Xahiş olunur şifrənizi daxil edin!")]
        public string Password { get; set; }
    }
}
