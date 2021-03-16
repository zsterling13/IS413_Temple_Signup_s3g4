using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models
{
    public class tourGroupList
    {
        private static List<tourGroup> listedGroups = new List<tourGroup>();

        public static IEnumerable<tourGroup> enumerateListedGroups => listedGroups;

        public static void AddTourGroup(tourGroup newGroup)
        {
            listedGroups.Add(newGroup);
        }
    }
}
