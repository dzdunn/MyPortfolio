using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.DAL
{
    public class MyPortfolioInitialiser: System.Data.Entity.DropCreateDatabaseIfModelChanges<MyPortfolioContext>
    {
        protected override void Seed(MyPortfolioContext context)
        {

            var tempProgrammingProject = new ProgrammingProject();
            tempProgrammingProject.ProjectTitle = "TestPP";
            tempProgrammingProject.UploadDate = DateTime.Now;
            context.ProgrammingProjects.Add(tempProgrammingProject);


            var tempDroneProject = new DroneProject();
            tempDroneProject.ProjectTitle = "TestDP";
            tempDroneProject.UploadDate = DateTime.Now;
            context.DroneProjects.Add(tempDroneProject);

            var tempThreeDPrintingProject = new ThreeDPrintingProject();
            tempThreeDPrintingProject.ProjectTitle = "Test3D";
            tempThreeDPrintingProject.UploadDate = DateTime.Now;
            context.ThreeDPrintingProjects.Add(tempThreeDPrintingProject);



            context.SaveChanges();



        }
    }
}