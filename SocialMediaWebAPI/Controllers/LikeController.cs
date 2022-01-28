using Microsoft.AspNet.Identity;
using SocialMedia.Models;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialMediaWebAPI.Controllers
{
    public class LikeController : ApiController
    {
        private LikeService CreateLikeService()
        {
            var authorId = Guid.Parse(User.Identity.GetUserId());
            var likeService = new LikeService(authorId);
            return likeService;
        }

        public IHttpActionResult Get()
        {
            LikeService likeService = CreateLikeService();
            var likes = likeService.GetLikes();
            return Ok(likes);
        }

        public IHttpActionResult Get(int id)
        {
            LikeService likeService = CreateLikeService();
            var like = likeService.GetLikeById(id);
            return Ok(like);
        }

        public IHttpActionResult Post(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikeService();

            if (!service.CreateLike(like))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateLikeService();

            if (!service.RemoveLike(id))
                return InternalServerError();

            return Ok();
        }
    }
}
