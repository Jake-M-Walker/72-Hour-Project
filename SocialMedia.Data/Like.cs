using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
    }
}
