using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? CompanyName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        //Relational properties

        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
    }
}
