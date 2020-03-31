using Microsoft.AspNetCore.Identity;


namespace SiliconAward.DataAccess.Entities.Identities
{
    public class AspNetUsers : IdentityUser
    {
        private readonly string fullName;

        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //public string FullName { get{ return FirstName + " " + LastName;   } }
        //public int LocationId { get; set; }
        //public int Skills { get; set; }



        public string WebSite { get; set; }
    }
}
