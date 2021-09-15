using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Hub_MVC.Models
{
    public class AddBlogPostViewModel
    {
        [Required(ErrorMessage ="This area is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This area is required")]
        public string Content { get; set; }

        [Display(Name = "Article Picture")]
        public IFormFile BlogPostPicture { get; set; }

    }
}
