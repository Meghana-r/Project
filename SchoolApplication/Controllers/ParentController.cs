using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolApplication.Models;
namespace SchoolApplication.Controllers
{
    public class ParentController : Controller
    {
        ProjectDBEntities5 db = new ProjectDBEntities5();

        // GET: User
        [HttpGet]
        public ActionResult register()
        {
           var data = new SelectList(db.Branches, "branch_id", "location");
           Session["rsdata"] = data;
           
            
            return View();
        }
        [HttpPost]
        public ActionResult register(ApplicationForm af,ProcessedForm ps) 
        {
            af.name = Request.Form["txtcdname"].ToString();
            
            af.address = Request.Form["txtaddr"].ToString();
            af.branch_id =int.Parse( Request.Form["ddlbranch"]);
           
            af.classid = int.Parse(Request.Form["ddlclass"]);
          
            af.age = int.Parse(Request.Form["txtage"]);
           
            af.dob = DateTime.Parse(Request.Form["txtdob"]);
            ps.comments = "Submitted";
            af.category = "Not Processed";
            db.ApplicationForms.Add(af);
            db.ProcessedForms.Add(ps);
            var r = db.SaveChanges();
            if (r > 0)
            {
               
                ModelState.AddModelError("", "Application Id is:" + af.Id);

            }
            return View();
           
        }
        [HttpGet]
        public ActionResult Check()
        {
            return View();

        }
         [HttpGet]
        public ActionResult CheckStatus()
         {
             var data = new SelectList(db.ProcessedForms, "Application_id", "Application_id");
             Session["rsdata"] = data;
             return View();

         }
        [HttpPost]
        public ActionResult CheckStatus(int id = 0)
        {
            id = int.Parse(Request.Form["txtcheck"].ToString());
            var data = db.ApplicationForms.Where(x => x.Id == id).SingleOrDefault();

            if (data.category == "Not Processed")
            {
                Response.Write("Application not processed,checklater");
            }
            else
            {
                var dat = db.ProcessedForms.Where(x => x.Application_id == id).Select(x => new { resolved = x.resolved_By });
                Response.Write("your Aplication is processed by :" + dat);


            }
            return View();

        }

    }
}