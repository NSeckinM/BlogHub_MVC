using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Hub_MVC.Data
{
    public class Blogpost
    {

        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Required, MinLength(100)]
        public string Content { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        //Nav prop  

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }


    }
}
