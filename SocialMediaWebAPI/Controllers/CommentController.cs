using Microsoft.AspNet.Identity;
using SocialMedia.Models;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SocialMediaWebAPI.Controllers
{
    public class CommentController
    {
        [Authorize]
        public class PostController : ApiController
        {

            public IHttpActionResult Get()
            {
                CommentService CommentService = CreateCommentService();
                var comments = CommentService.GetComments();
                return Ok(comments);
            }


            public IHttpActionResult Comment(CommentCreate post)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateCommentService();

                if (!service.CreateComment(Comment))
                    return InternalServerError();

                return Ok();
            }

            private CommentService CreateCommentService()
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var CommentService = new CommentService(userId);
                return CommentService;
            }

            public IHttpActionResult Put(CommentEdit comment)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateCommentService();

                if (!service.UpdateComment(comment))
                    return InternalServerError();

                return Ok();

            }

            public IHttpActionResult Delete(int id)
            {
                var service = CreateCommentService();

                if (!service.DeleteComment(id))
                    return InternalServerError();

                return Ok();
            }
        }
    }
}