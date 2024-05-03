using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? Date { get; set; }

        //Relational properties

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
