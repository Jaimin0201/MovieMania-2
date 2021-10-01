using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class User
    {
        public User()
        {
            this.Movies = new HashSet<Movie>();
            this.Episodes = new HashSet<Episode>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public int UnitNum { get; set; }
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Complement { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PreferredName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }


    }
}