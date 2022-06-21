using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "Must be at least 10-50 chars")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 chars")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Must be at least 300-30000 chars")]
        [MaxLength(30000, ErrorMessage = "Must be at least 300-30000 chars")]
        public string Content{ get; set; }
        public int? PhtotoId { get; set; }
    }
}
