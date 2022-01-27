using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SocialMedia.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(1, ErrorMessage ="Please enter at least 1 character.")]
        public string Title { get; set; }
        public string Text { get; set; }
        
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Comments")]
        public virtual List<Comment> Comment { get; set; }

        [Display(Name = "Likes")]
         public virtual List<Like> Like { get; set; }
    }
}
