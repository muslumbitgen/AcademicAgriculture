using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class ReferenceManager : IReferenceService
    {
        private IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void Add(Reference reference)
        {
            _referenceDal.Add(reference);
        }

        public void Delete(int referenceId)
        {
            _referenceDal.Delete(new Reference { Id = referenceId });
        }

        public List<Reference> GetAll()
        {
            return _referenceDal.GetList();
        }

        public Reference GetById(int referenceId)
        {
            return _referenceDal.Get(p => p.Id == referenceId);
        }

        public void Update(Reference reference)
        {
            _referenceDal.Update(reference);
        }
    }
}
