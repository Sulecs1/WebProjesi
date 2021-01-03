using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProjem.DTO.DTOs.CommentDtos
{
    public class CommentAddDto
    {
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; }
        public int? ParentCommentId { get; set; }
        public int BlogId { get; set; }
    }
}
