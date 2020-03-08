using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IReferenceService
    {
        List<Reference> GetAll();
        void Add(Reference reference);
        void Update(Reference reference);
        void Delete(int referenceId);
        Reference GetById(int referenceId);
    }
}
