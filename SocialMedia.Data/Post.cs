using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }

        //public int CommentID { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        // public virtual List<Comments> Comment  { get; set; }

        //public virtual Like List<Likes> { get; set; }

        public Guid AuthorId { get; set; }



    }
}
