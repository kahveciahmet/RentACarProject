using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        //Relational properties

        [ForeignKey("ColorId")]
        public Color Color { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }


}
