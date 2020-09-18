using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProjectApplication.Models
{
    public class CommentModel
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public string UserName { get; set; }
        public int? UserId { get; set; }
        public DateTime? CommentDate { get; set; }
        public DateTime? Createdate { get; set; }
        public int? PostId { get; set; }
        public int? CommentLike { get; set; }
        public int? CommentDislike { get; set; }
    }
}