using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Image
    {
        public int ID { get; set; }

        public string ImageTitle { get; set; }

        public string Directory { get; set; }

        public int ProjectID { get; set; }

        public IProject Project { get; set; }


    }
}