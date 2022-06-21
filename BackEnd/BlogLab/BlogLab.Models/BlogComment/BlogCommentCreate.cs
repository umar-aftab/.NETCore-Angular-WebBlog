﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? PraentBlogCommentId { get; set; }
        public int BlogId { get;set; }


        [Required(ErrorMessage = "Content is required")]
        [MinLength(10, ErrorMessage = "Must be at least 10-300 chars")]
        [MaxLength(300, ErrorMessage = "Must be at least 10-300 chars")]
        public string Content { get; set; }

    }
}