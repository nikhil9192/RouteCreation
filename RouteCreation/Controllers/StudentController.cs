using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteCreation.Models;

namespace RouteCreation.Controllers
{
    public class StudentController : Controller
    {

       private List<Student>  StudentL(){
            return new List<Student>()
            {
           new Student(){
                id=1,
                name="Nikhil Singh",
                classes=12,
                address=new Address()
                {
                    Homenumber=12,
                    address="this is my house",
                    city="pune"
                }

            },
            new Student()
            {
                id=2,
                name="Suresh Singh",
                classes=12,
                address=new Address()
                {
                    Homenumber=15,
                    address="this is my house",
                    city="Mumbai"
                }

            }
       };
            }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getallStudent()
        {
            var student = StudentL();
            return View(student);
        }
        public ActionResult getStudent(int id)
        {
            var student = StudentL().FirstOrDefault(x => x.id==id);
            return View();
        }
        public ActionResult getStudentaddress(int id)
        {
            var studentaddress = StudentL().Where(x=> x.id==id).Select(x=>x.address);
            return View(studentaddress);
        }
    }
}