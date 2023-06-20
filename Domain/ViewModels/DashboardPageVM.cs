using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class DashboardPageVM
    {
        public RegistrationRequestsVM? RegistrationsRequests { get; set; }
        public AdviceRequestsVM? AdvicesRequests { get; set; }
        public int AllUsers { get; set; }
        public int BlockedUsers { get; set; }
        public int Advices { get; set; }
        public int Diseases { get; set; }
        public int TypeOfDiseases { get; set; }
        public int Specializations { get; set; }
        public int Contacts { get; set; }
        public int LungTransplants { get; set; }
    }
}
