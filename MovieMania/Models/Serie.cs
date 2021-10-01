using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMania.Models
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string SerieTitle { get; set; }
        public string SerieDescription { get; set; }
        public Genre Genre { get; set; }

        [DisplayName("Upload File")]
        [NotMapped]
        public HttpPostedFileBase Cover { get; set; }
        public string FilePath { get; set; }
        public int SeasonsNumber { get; set; }

    }
}