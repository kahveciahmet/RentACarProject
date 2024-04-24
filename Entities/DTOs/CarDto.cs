using Core.Entities;

namespace Entities
{
    public class CarDto : IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
