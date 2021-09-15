using Blog_Hub_MVC.Data;
using Blog_Hub_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Hub_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("IndexPublic");
            }

            List<BlogPostViewModel> blogPostsList = db.BlogPosts
                .Select(x => new BlogPostViewModel() { Id = x.Id, Title = x.Title, Content = x.Content, Author = (x.Author.FirstName +" "+ x.Author.LastName), CreationTime = x.CreationTime })
                .Take(20)
                .OrderByDescending(x => x.CreationTime)
                .ToList();

            return View(blogPostsList);
        }

        [HttpGet]
        public IActionResult AddBlogPost()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
