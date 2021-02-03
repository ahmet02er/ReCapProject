using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=100,Description="Station Wagon"},
                new Car{CarId=2,BrandId=3,ColorId=2,ModelYear=2019,DailyPrice=350,Description="Cabrio"},
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=450,Description="Sport"},
                new Car{CarId=4,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=800,Description="SUV"},
                new Car{CarId=5,BrandId=3,ColorId=4,ModelYear=2018,DailyPrice=300,Description="Pick Up"},
                new Car{CarId=6,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=250,Description="Hatchback"},
                new Car{CarId=7,BrandId=1,ColorId=3,ModelYear=2021,DailyPrice=550,Description="Sedan"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }
    }
}
