using Students.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Core.Contract
{
    public interface IStudentService
    {
        void Add(Student Student);

        void Update(Student student);

        void Delete(Student student);

        IEnumerable<Student> GetList(StudentRequest request);

        Student Get(StudentRequest request);
        
    }
}
