using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoBlog.Domain.Entities
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }
    }
}
