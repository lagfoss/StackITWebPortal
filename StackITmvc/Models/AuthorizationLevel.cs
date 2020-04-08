using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackITmvc.Models
{
    // Working with enum instead of strings
    public enum AuthorizationLevel
    {
        StackIt = 0,
        K_Admin = 1,
        K_Operator = 2,
        Api = 3
    }
}
