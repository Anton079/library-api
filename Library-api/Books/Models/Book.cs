using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Library_api.Authors.Models;

namespace Library_api.Books.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("author")]
        public string Author { get; set; }

        [Required]
        [Column("publishedYear")]
        public int PublishedYear { get; set; }

        public int AuthorId { get; set; }

        public virtual Author author { get; set; }
    }

}
