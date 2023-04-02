using PROG6212_Poe_Joseph_20104412.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ClassLibraryForPoe;
using System.Web.Helpers;

namespace PROG6212_Poe_Joseph_20104412.Controllers
{
    public class HomeController : Controller
    {
        //Creating the view for the home page
        public ActionResult Index()
        {
            return View();
        }
        // Creating the view for the signup page
        public ActionResult SignUp()
        {
            return View();
        }

        //adding some features to the signup page
        //[httppost]: created to allow communications between clients and servers. Post is used to send data to a server (w3schools, 2021).
        [HttpPost]
        [ValidateAntiForgeryToken]//[ValidateAntiForgeryToken]: this is known as an action filter (Hasan, 2021)
        public ActionResult SignUp(Student student)
        {
            //if the model state is correct
            //if statements are used to run code based on a condition (w3schools, 2021).
            if (ModelState.IsValid)
            {
                //a new connection will be made to the database
                using (TmDbContext db = new TmDbContext())
                {
                    //student info will be added to the database
                    db.studentsAccount.Add(student);
                    db.SaveChanges();//this allows for data to be stored in the database
                }
                //the model will clear the page of the view
                ModelState.Clear();
                //the signup successfull message will be displayed
                ViewBag.Message = student.Name + " " + student.Surname + ". Successful sign up.";

            }
            return View();//the signup view will be returned
        }

        // View for the ogin page created
        public ActionResult Login()
        {
            return View();//view is returned
        }
        
        //feature are added to the view
        [HttpPost]
        public ActionResult Login(Student student)
        {
            //firstly, a new sql connecttion is created
            using (TmDbContext db = new TmDbContext())
            {
                
                var stu = db.studentsAccount.Single(s => s.Email == student.Email && s.Password == student.Password);
                //if statements are used to run code based on a condition(w3schools, 2021).
                if (stu != null) //if the student exist
                {
                    Session["StudentNr"] = stu.StudentNr.ToString();//provide student number
                    Session["Email"] = stu.Email.ToString();//provide the email
                    return RedirectToAction("DashBoard");//redirect the page to dashboard
                }
                else //otherwise
                {
                    //pprovide the error message
                    ModelState.AddModelError("", "Email or Password is wrong");
                }
            }

            return View();//login view is returned
        }

        //DashBoard view is created 
        public ActionResult DashBoard()
        {
            //if there is a student number available
            //if statements are used to run code based on a condition (w3schools, 2021).
            if (Session["StudentNr"] != null)
            {
                return View();//view is returned
            }
            else
            {
                //otherwise back to login
                return RedirectToAction("Login");
            }
        }

        //view studyHours View is created
        public ActionResult ViewStudyHours()
        {
            return View();
        }

        //some features added to the view
        [HttpPost]
        public ActionResult ViewStudyHours(StudyHours studyHours)
        {

            // To open a connection to the database
            using (ShDbContext1 db = new ShDbContext1())
            {
                // Add data to the particular table
                db.StudyHourData.Add(studyHours);

                // save the changes
               // db.SaveChanges();
            }
            string message = "Created the record successfully";

            // To display the message on the screen
            // after the record is created successfully
            ViewBag.Message = message;

            // write @Viewbag.Message in the created
            // view at the place where you want to
            // display the message
            return View();
        }

        [HttpGet] // Set the attribute to Read
        //Read
        //StudyHours view created
        public ActionResult StudyHours(Modules modules, int id)
        {
            using (ModuleContext2 db = new ModuleContext2())
            {
                var data = db.moduleData.FirstOrDefault(x => x.Module_Code == id);
                using (ShDbContext1 db1 = new ShDbContext1())
                {
                    
                    var data1 = db1.StudyHourData.FirstOrDefault(s => s.SH_ID == id);
                    // Checking if any such record exist 
                    //if statements are used to run code based on a condition (w3schools, 2021).
                    if (data != null)
                    {
                        
                        data.Nr_of_Weeks = modules.Nr_of_Weeks;
                        data.Credits = modules.Credits;
                        data.Class_Hours_per_week = modules.Class_Hours_per_week;

                        int credits = Convert.ToInt32(data.Credits);
                        int classhours = Convert.ToInt32(data.Class_Hours_per_week);
                        int nr_of_Weeks = data.Nr_of_Weeks;
                        int studyhours = Convert.ToInt32(data1.study_hours_required);
                        int remaining = Convert.ToInt32(data1.RemainingStudyHours);

                        studyhours = (credits * 10 / nr_of_Weeks) - classhours;
                        remaining = studyhours - data1.hoursStudied;

                        db.SaveChanges();
                        db1.SaveChanges();

                        // It will redirect to 
                        // the Read method
                        return RedirectToAction("StudyHours");
                    }
                    else
                        return View();
                }
            }
        }

        public ActionResult AddModules()
        {

            return View();
        }

        [HttpPost]
        //Create
        public ActionResult AddModules(Modules modules)
        {

            // To open a connection to the database
            using (ModuleContext2 db = new ModuleContext2())
            {
                // Add data to the particular table
                db.moduleData.Add(modules);

                // save the changes
                db.SaveChanges();
            }
            string message = "Created the record successfully";

            // To display the message on the screen
            // after the record is created successfully
            ViewBag.Message = message;

            // write @Viewbag.Message in the created
            // view at the place where you want to
            // display the message
            return View();
        }

        [HttpGet] // Set the attribute to Read
        //Read
        //[httpget]: created to allow communications between clients and servers. get is used to ask for data from a resource (w3schools, 2021).
        public ActionResult MyModules()
        {
            using (ModuleContext2 db = new ModuleContext2())
            {

                // Return the list of data from the database
                var data = db.moduleData.ToList();
                return View(data);
            }
        }

        //Update
        public ActionResult Update(int id)
        {
            using (ModuleContext2 db = new ModuleContext2())
            {
                var data = db.moduleData.Where(x => x.Module_Code == id).SingleOrDefault();
                return View(data);
            }
        }

        // To specify that this will be 
        // invoked when post method is called
        [HttpPost]
        [ValidateAntiForgeryToken]//[ValidateAntiForgeryToken]: this is known as an action filter (Hasan, 2021)
        public ActionResult Update(int id, Modules modules)
        {
            using (ModuleContext2 db = new ModuleContext2())
            {

                // Use of lambda expression to access
                // particular record from a database
                var data = db.moduleData.FirstOrDefault(x => x.Module_Code == id);

                // Checking if any such record exist
                //if statements are used to run code based on a condition(w3schools, 2021).
                if (data != null)
                {
                    data.ModuleName = modules.ModuleName;
                    data.Credits = modules.Credits;
                    data.Class_Hours_per_week = modules.Class_Hours_per_week;
                    data.Semester_Start_Date = modules.Semester_Start_Date;
                    db.SaveChanges();

                    // It will redirect to 
                    // the Read method
                    return RedirectToAction("MyModules");
                }
                else
                    return View();
            }
        }

        //Delete
        public ActionResult Delete()
        {
            return View();
        }

        //some features added to the delete view
        [HttpPost]
        [ValidateAntiForgeryToken]//[ValidateAntiForgeryToken]: this is known as an action filter (Hasan, 2021)
        public ActionResult
        Delete(int id)
        {
            //new sql connection created
            using (ModuleContext2 db = new ModuleContext2())
            {
                var data = db.moduleData.FirstOrDefault(x => x.Module_Code == id);
                if (data != null)// if the module data exists
                {
                    db.moduleData.Remove(data);//remove it
                    db.SaveChanges();//and save the changes
                    return RedirectToAction("MyModules");//then go back to the list to check if it worked
                }
                else
                    return View();//view is returned
            }
        }
    }
}