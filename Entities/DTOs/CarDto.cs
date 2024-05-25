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
        public string TransmissionType { get; set; }
        public int DailyKmLimit { get; set; }
        public int SeatingCapacity { get; set; }
        public int LicenseAge { get; set; }
        public int RenterAge { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
