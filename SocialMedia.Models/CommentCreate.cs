using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 character.")]
        public string Text { get; set; }

        [Display(Name = "Date Created")]

        public Guid AuthorId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Likes")]
        public int LikeId { get; set; }
        public string Like { get; set; }
        public int PostId { get; set; }
        public object CommentId { get; set; }
    }
}
