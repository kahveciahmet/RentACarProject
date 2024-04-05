using Business;
using DataAccess;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Name + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }
    }
}
