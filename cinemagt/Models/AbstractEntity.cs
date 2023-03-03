using System.ComponentModel.DataAnnotations;

namespace cinemagt.Models
{
    public abstract class AbstractEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
