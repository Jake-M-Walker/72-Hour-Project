using System;

namespace SocialMedia.Services
{
    internal class Comment
    {
        public Comment()
        {
        }

        public Guid AuthorId { get; set; }
        public string Text { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public int LikeId { get; set; }
    }
}