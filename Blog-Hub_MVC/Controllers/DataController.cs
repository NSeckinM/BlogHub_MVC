using Blog_Hub_MVC.Data;
using Blog_Hub_MVC.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog_Hub_MVC.Controllers
{
    //Postlarla ilgili CRUD işlemleri burada yapılacak
    [Authorize]
    public class DataController : Controller
    {
        private readonly ApplicationDbContext db;

        public DataController(ApplicationDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlogPost()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
