using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class LikeListItem
    {
        [Key]
        public int LikeId { get; set; }
        public Guid AuthorId { get; set; }
        public bool isLiked { get; set; }
    }
}
