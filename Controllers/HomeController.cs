using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayerProject;
using ModelProject;
using DataLayerProject;
using System.Data;

namespace SmartHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Smart Center for Healthcare and Sanitation Division";

            return View();
        }

        public ActionResult CenterInfo()
        {
            ViewBag.Message = "This page contains information about the center and the various services provided as part of the SmartHub initiative.";

            return View();
        }

        public ActionResult PatientDetails()
        {
            ViewBag.Message = "This page contains grid view of patient details.";

            var PatientDetails = BusinessLayerClass.GetPatientDetailsList();

            return View(PatientDetails);
        }
    }
}