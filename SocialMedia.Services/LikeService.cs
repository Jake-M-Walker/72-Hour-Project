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
                    IsLiked = model.IsLiked,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                
            }
        }
    }
}
