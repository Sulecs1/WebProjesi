using System;

namespace BlogProjemFront.Models{

    public class CommentAddModel{
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; }
        public int? ParentCommentId { get; set; }
        public int BlogId { get; set; }
    }
}