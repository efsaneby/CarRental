using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public void Add(Rental entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
             }
        }

        public void Delete(Rental entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Rental>().ToList();
            }
        }

        public Rental GetById(Expression<Func<Rental, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Rental>().SingleOrDefault(filter);
            }
        }

        public List<Rental> GetCarsByBrandId(Expression<Func<Rental, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Rental>().Where(filter).ToList();
            }
        }

        public List<Rental> GetCarsByColorId(Expression<Func<Rental, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Rental>().Where(filter).ToList();
            }
        }

        public void Update(Rental entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
