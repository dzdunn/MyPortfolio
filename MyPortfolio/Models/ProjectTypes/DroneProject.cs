using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class DroneProject: IProject
    {
        public int ID { get; set; }
        public string ProjectTitle { get; set; }
      
        public ICollection<Image> Images { get; set; }
        public ICollection<Video> Videos { get; set; }
        public DateTime UploadDate { get; set; }
    }
}