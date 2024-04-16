using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRepository.DataAccessLayer
{
    public interface IStudentRepository
    {

        List<Student> Get();
        Student Get(int roll);
        bool Add(Student model);
        bool Update(Student model);
        bool Delete(int roll);
    }
}
