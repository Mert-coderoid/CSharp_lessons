using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi2.Entities
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int WriterId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}