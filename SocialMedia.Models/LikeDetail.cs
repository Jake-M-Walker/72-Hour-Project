using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class LikeDetail
    {

        public int Id { get; set; }

        public Guid OwnerId { get; set; }

        [Display(Name ="Liked at"]
        public DateTimeOffset CreatedUtc { get; set; }

        public bool isLiked { get; set; }

        public int PostId { get; set; }
    }
}
