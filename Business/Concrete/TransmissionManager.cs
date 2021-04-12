using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TransmissionManager: ITransmissionService
    {
        ITransmissionDal _transmissionDal;
        public TransmissionManager(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }

        public IResult Add(Transmission transmission)
        {
            _transmissionDal.Add(transmission);
            return new SuccessResult();
        }

        public IResult Delete(Transmission transmission)
        {
            _transmissionDal.Delete(transmission);
            return new SuccessResult();
        }

        public IDataResult<List<Transmission>> GetAll()
        {
            return new SuccessDataResult<List<Transmission>>(_transmissionDal.GetAll());
        }

        public IDataResult<Transmission> GetById(int id)
        {
            return new SuccessDataResult<Transmission>(_transmissionDal.Get(c => c.Id == id));
        }

        public IResult Update(Transmission transmission)
        {
            _transmissionDal.Update(transmission);
            return new SuccessResult();
        }
    }
}
