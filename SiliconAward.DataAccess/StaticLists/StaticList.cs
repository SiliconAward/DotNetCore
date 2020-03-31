using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconAward.DataAccess.StaticLists
{
    public static class UserRoles
    {
        public static string Admin => "Admin";
        public static string Referee => "Referee";
        public static string Participant => "Participant";


        public static Dictionary<int, string> Roles => new Dictionary<int, string>
            {
                {1, Admin},
                {2, Referee},
                {3, Participant}
            };
        public static Dictionary<string, int> RoleIds => new Dictionary<string, int>
             {
                 {"6de51ace-e1e8-4e8b-af61-07bcc46c6af0",1},
                 {"9da85e75-f0e5-488d-8d3d-e6e7247f7a80",2},
                 {"19d1e3a1-b4eb-485b-9a20-1d65f296ffd2",3}
             };

    }
}
