using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMania.Models
{
    public class Episode
    {
        public Episode()
        {
            this.Users = new HashSet<User>();
        }

        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public string SerieName { get; set; }
        public Serie Serie { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public int DurationHours { get; set; }
        public int DurationMin { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}