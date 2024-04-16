using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityRepository.DataAccessLayer;

namespace UniversityRepository.BusinessLayer
{
    public class University
    {
        IStudentRepository _repository;

        public University(IStudentRepository repository)
        {
            _repository = repository;
        }
        public List<Student> Get()
        {
            return _repository.Get();
        }

        public Student Get(int roll)
        {
            return _repository.Get(roll);
        }

        public bool Add(Student model)
        {
            return _repository.Add(model);
        }

        public bool Update(Student model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int roll)
        {
            return _repository.Delete(roll);
        }
    }
}
