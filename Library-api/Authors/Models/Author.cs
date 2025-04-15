using Library_api.Books.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_api.Authors.Models
{
    [Table("author")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("AuthorName")]
        public string AuthorName { get; set; }

        public virtual List<Book> Books { get; set; } = new();

    }
}
