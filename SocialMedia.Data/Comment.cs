using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Data
{

    public class Comment
    {
        public int CommentId { get; set; }

        public string Text { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public virtual Comment Comments { get; set; }
    }
}
