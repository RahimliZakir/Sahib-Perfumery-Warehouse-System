using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Areas.Admin.Models.FormModel
{
    public class AddStaffFormModel
    {
        [Required(ErrorMessage = "Xahiş olunur istifadəçi adını daxil edəsiniz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Xahiş olunur şifrəni daxil edəsiniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Xahiş olunur şifrəni daxil edəsiniz!")]
        [Compare("Password", ErrorMessage = "Şifrələr eyni olmalıdır!")]
        public string PasswordConfirm { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string FinCode { get; set; }
        public int SerialNumber { get; set; }
        public int HomeNumber { get; set; }
        public string LivingAddress { get; set; }
        public string RegistrationAddress { get; set; }

        //-------------------------------------------------

        public string Role { get; set; }
    }
}
