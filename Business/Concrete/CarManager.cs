using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private  ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            Console.WriteLine("Araba ismi minimu 2 karakter ve araba fiyati minimum 0 olmalidir");
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(c=>c.Id==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
