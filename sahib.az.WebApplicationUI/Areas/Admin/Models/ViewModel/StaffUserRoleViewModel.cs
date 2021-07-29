using sahib.az.WebApplicationUI.Models.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Areas.Admin.Models.ViewModel
{
    public class StaffUserRoleViewModel
    {
        public IEnumerable<AppUser> Users { get; set; }

        public AppUser User { get; set; }

        public IEnumerable<AppRole> Roles { get; set; }

        public AppRole Role { get; set; }

        //-----------------------------------------------------

        public int Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string FinCode { get; set; }
        public string SerialNumber { get; set; }
        public int HomeNumber { get; set; }
        public string LivingAddress { get; set; }
        public string RegistrationAddress { get; set; }
    }
}
