using System.ComponentModel.DataAnnotations.Schema;
using CryptoBlog.Domain.Enums;

namespace CryptoBlog.Domain.Entities
{
    [Table("Posts")]
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        [Column(TypeName = "tinyint")]
        public PostStatusEnum Status { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
