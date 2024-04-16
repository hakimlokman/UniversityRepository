using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRepository.DataAccessLayer
{
    public class Student
    {

        public int Roll;
        public string Name;
        public string Subject;
        public Student()
        {

        }
        public Student(int roll, string name, string subject)
        {
            Roll = roll;
            Name = name;
            Subject = subject;
        }
    }
}
