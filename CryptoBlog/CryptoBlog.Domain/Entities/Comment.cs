using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoBlog.Domain.Entities
{
    [Table("Comments")]
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
