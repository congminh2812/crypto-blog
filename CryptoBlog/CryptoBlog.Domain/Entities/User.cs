using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoBlog.Domain.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
