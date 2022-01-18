using LastPractice_B4_Test_allFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastPractice_B4_Test_allFrameworks.Controllers
{
    public class ChefController : Controller
    {
        public static List<Chef> chefList = new List<Chef>()
        {
            new Chef(1,"Nusr","et",1987,300),
            new Chef(2,"Tzug","cheftz",1987,200),
            new Chef(3,"otherChef","zz",1987,159),
            new Chef(4,"someChef","gg",1987,214),
            new Chef(5,"theCHEF","CHEFOO",1987,111),

        };
        // GET: Chef
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ShowChefName()
        {
            ViewBag.chefName = chefList[4].FirstName;
            ViewBag.theMessage = "GOOD MORNING NIGGA";
            return View();
        }
        public ActionResult ChefInfo(int id)
        {
            Chef theChosenChef = chefList.Find(item => item.Id == id);
            return View(theChosenChef);
        }
    }
}