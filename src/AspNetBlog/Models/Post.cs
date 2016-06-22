using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetBlog.Models
{
    public class Post
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Blog Post Title")]
        [StringLength (100,MinimumLength =5,ErrorMessage ="Title must be between 5 and 100 carecters long")]
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
        public string Author { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(5,ErrorMessage = "Blog postr must be 5 carecters long")]
        public string Body { get; set; }
    }
}
