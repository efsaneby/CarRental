using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);


            _carDal.Add(car);
            return new SuccesResult(Messages.ProductAdded);
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult();
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }
        public IDataResult<Car> GetById(int id)
        {
            return new SuccesDataResult<Car>(_carDal.GetById(c => c.Id == id), Messages.ProductListed);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult();

        }
    }
}
