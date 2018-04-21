using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class ProgrammingProject : IProject
    {
        public int ID { get; set; }
        public string ProjectTitle { get; set; }
        
        public ICollection<Image> Images { get; set; }
        public ICollection<Video> Videos { get; set; }
        public DateTime UploadDate { get; set; }

        public enum Language { Java, Python, CPlusPLus, CSharp, JavaScript, JQuery, HTML, CSS, Bootstrap  };

        public List<string> ProjectLanguages { get; set; }

        public void setLanguage (Language language)
        {
            string projectLanguage = language.ToString();
            this.ProjectLanguages.Add(projectLanguage);
        }

        public void removeLanguage(Language language)
        {
            string projectLanguage = language.ToString();
            this.ProjectLanguages.Remove(projectLanguage);
        }
    }
}