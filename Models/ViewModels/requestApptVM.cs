using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models.ViewModels
{
    public class requestApptVM
    {
        //Creates a tourGroup model/object for views to be accessed
        public tourGroup tourGroup { get; set; }

        //Creates a timeSlot model/object for views to be accessed
        public timeSlot timeSlot { get; set; }
    }
}
