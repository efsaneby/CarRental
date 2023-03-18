using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car() {Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=18000,Description="Mercedes"},
                new Car() {Id=2,BrandId=2,ColorId=1,ModelYear=2015,DailyPrice=15000,Description="Toyota"},
                new Car() {Id=3,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=17500,Description="Fiat"},
                new Car() {Id=4,BrandId=4,ColorId=2,ModelYear=2012,DailyPrice=22500,Description="Renault"},
                new Car() {Id=5,BrandId=5,ColorId=3,ModelYear=2022,DailyPrice=19000,Description="Nissan"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _car.SingleOrDefault(c=>c.Id== car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _car.SingleOrDefault(c=>c.Id== id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _car.SingleOrDefault(c=>c.Id== car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
