using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        //Relational properties

        //[ForeignKey("ColorId")]
        //public Color Color { get; set; }

        //[ForeignKey("BrandId")]
        //public Brand Brand { get; set; }
    }


}
