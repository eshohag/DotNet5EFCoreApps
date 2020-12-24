using CodeFast.Web.Manager.Interface;
using CodeFast.Web.Models;
using CodeFast.Web.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFast.Web.Manager.Implementation
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student Create(Student model)
        {
            var student = _studentRepository.Create(model);
            return student;
        }

        public Student GetStudentById(int studentId)
        {
            return _studentRepository.FirstOrDefault(a => a.Id == studentId);
        }

        public IQueryable<Student> GetStudents()
        {
            return _studentRepository.All();
        }

        public Student Update(Student model)
        {
            if (model == null)
                return null;
            var rowAffect = _studentRepository.Update(model);
            return rowAffect > 0 ? model : null;
        }
    }
}