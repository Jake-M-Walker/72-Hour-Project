using SocialMedia.Data;
using SocialMedia.Models;
using SocialMediaWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class LikeService
    {
        private readonly Guid _authorId;

        public LikeService(Guid authorId)
        {
            _authorId = authorId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    AuthorId = _authorId,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LikeListItem> GetLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Likes
                        .Where(e => e.AuthorId == _authorId)
                        .Select(
                                e =>
                                new LikeListItem
                                {
                                    LikeId = e.LikeId,
                                    CreatedUtc = e.CreatedUtc
                                }
                                    );
                return query.ToArray();
            }
        }
    }
}
