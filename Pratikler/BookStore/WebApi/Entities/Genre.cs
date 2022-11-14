using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // this for auto increment
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}