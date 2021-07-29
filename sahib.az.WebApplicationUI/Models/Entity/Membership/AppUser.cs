using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.Entity.Membership
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string FinCode { get; set; }
        public string SerialNumber { get; set; }
        public int HomeNumber { get; set; }
        public string LivingAddress { get; set; }
        public string RegistrationAddress { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(4);

#nullable enable
        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }
#nullable disable
    }
}
