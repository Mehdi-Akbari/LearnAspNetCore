using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearnASPNetCore.Models;

namespace LearnASPNetCore.Controllers
{
    public class HomeController : Controller
    {

        #region session 1 to 4
        //public IActionResult Index()
        //{
        //    var content = "<p> Hello! </P>";

        //    return new ContentResult()
        //    {
        //        Content = content,
        //        ContentType = "text/html"
        //    };
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //private IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "Hello World!";
        //}


        //public ErrorViewModel index()
        //{
        //    return new ErrorViewModel();
        //}

        //public IActionResult Index()
        //{
        //    return View("Index2");
        //}




        //public IActionResult Index()
        //{
        //    //return View("MyView");
        //    return View("MYvIEw");
        //}

        //public ViewResult Index2() // Create a New View
        //{
        //    return View();
        //}

        //public ViewResult TestViewBag()
        //{
        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

        //    //pass second value
        //    ViewBag.Name = "Mehdi";

        //    ///*dynamic vs var*/
        //    //dynamic myDynamic = "test";
        //    //myDynamic = 10;
        //    //myDynamic.Item1 = 15;
        //    //myDynamic.Item2 = "test";

        //    //var x = "test";
        //    //x = 10; // compile time error : cannot implicitly convert type 'int' to 'string'

        //    return View();
        //}

        #endregion


        IPersonRepository repository;
        public HomeController(IPersonRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            Repository.AddPerson(new Person() { Name = "Ali", LastName = "Alavi", Married = true });
            Repository.AddPerson(new Person() { Name = "Mahdi", LastName = "Mahdavi", Married = false });
            Repository.AddPerson(new Person() { Name = "Ahmad", LastName = "Ahmadi"});
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Person person)
        {
            if (ModelState.IsValid)
            {
                Repository.AddPerson(person);
                return View("Thanks", person);
            }
            else
            {
                return View();
            }
        }

        public IActionResult AllPeople()
        {
            return View(repository.People);

           // return View(Repository.People);
        }

        public IActionResult Married()
        {
            return View("AllPeople",Repository.People.Where(per => per.Married == true));
        }

        public IActionResult Single()
        {
            return View("AllPeople", Repository.People.Where(per => per.Married == false));
        }
    }
}
