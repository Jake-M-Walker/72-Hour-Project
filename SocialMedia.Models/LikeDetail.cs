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

        public int LikeId { get; set; }

        public Guid AuthorId { get; set; }

        [Display(Name ="Liked at")]
        public DateTimeOffset CreatedUtc { get; set; }
        public int PostId { get; set; }
    }
}
