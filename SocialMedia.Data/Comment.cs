using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    class Comment
    {
        public int CommentId { get; set; }

        public string Text { get; set; }

        public int CommentID { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        public Guid AuthorId { get; set; }
       
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public virtual Comment Comments { get; set; }
    }
}

