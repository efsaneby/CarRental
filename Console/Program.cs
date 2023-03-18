using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var c in carManager.GetAll().Data)
{
    Console.WriteLine(c.Name);
}




