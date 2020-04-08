using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackITmvc.Models.StackItViewModels
{
    public class AssignedUserData
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public bool Assigned { get; set; }

        public string UserLevel { get; set; }
    }
}
