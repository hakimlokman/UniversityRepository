using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRepository.DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> listCustomer = new List<Student>()
        {
            new Student(1, "Lokman", "C#"),
            new Student(2, "Hasib", "PHP"),
            new Student(3, "Yasin", "JAVA"),
            new Student(4, "Kamran", "DDD")
        };
        public List<Student> Get()
        {
            return listCustomer.OrderBy(x => x.Name).ToList();
        }

        public Student Get(int roll)
        {
            Student University = listCustomer.Where(x => x.Roll == roll).FirstOrDefault();
            return University;
        }

        public bool Add(Student model)
        {
            listCustomer.Add(model);
            return true;
        }

        public bool Update(Student model)
        {
            bool isExecuted = false;
            Student University = listCustomer.Where(x => x.Roll == model.Roll).FirstOrDefault();
            if (University != null)
            {
                listCustomer.Remove(University);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int roll)
        {
            bool isExecuted = false;
            Student University = listCustomer.Where(x => x.Roll == roll).FirstOrDefault();
            if (University != null)
            {
                listCustomer.Remove(University);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
