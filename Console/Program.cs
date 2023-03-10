using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());


foreach (var c in carManager.GetAll())
{
    Console.WriteLine(c.Name);
}



//var cars = carManager.GetAll();

//foreach (var car in cars)
//{
//    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);
//}

//Car car1 = new Car() { Id=6,BrandId=3, ColorId=4, DailyPrice=30000, ModelYear=2023, Description="BMW"};

//carManager.Add(car1);

//foreach (var car in cars)
//{
//    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);
//}

//Console.WriteLine(carManager.GetById(5).Description);

