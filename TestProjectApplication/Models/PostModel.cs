using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProjectApplication.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostBy { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public List<CommentModel> CommentList { get; set; }
    }
}