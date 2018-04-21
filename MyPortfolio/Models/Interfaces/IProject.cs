using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public interface IProject
    {
        int ID { get; set; }

        string ProjectTitle { get; set; }
    
        ICollection<Image> Images { get; set; }

        ICollection<Video> Videos { get; set; }

        DateTime UploadDate { get; set; }
    }
}