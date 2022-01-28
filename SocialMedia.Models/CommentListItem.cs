using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentListItem
    {
        [Key]
        public int CommentId { get; set; }
        public string Text { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public Guid AuthorId { get; set; }

        public int PostId { get; set; }
    }
}
