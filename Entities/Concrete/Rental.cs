using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        //Relational properties

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
