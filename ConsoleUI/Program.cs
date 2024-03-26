using Business;
using DataAccess;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
