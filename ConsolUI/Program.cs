using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("******************** Cars ********************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId :{0} --BranId :{1} --ColorId :{2} --ModelYear :{3} --DailyPrice :{4} --Type :{5}", car.CarId,car.BrandId,car.ColorId,car.DailyPrice,car.ModelYear,car.Description);
            }
            Console.WriteLine("________________________________________________________________________________________");

            Console.WriteLine("******************** Car Brand ********************");

            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine("CarId :{0} --BrandId :{1} --Type :{2}", car.CarId, car.BrandId, car.Description);
            }
            Console.WriteLine("_______________________________________________________________________________________");

            Console.WriteLine("******************** Car Color ********************");
            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine("CarId :{0} --ColorId :{1} --Type :{2}", car.CarId, car.ColorId, car.Description);
            }
        }
    }
}
