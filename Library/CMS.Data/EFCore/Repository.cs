using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.EFCore
{
    public class Repository : IRepository
    {
        private readonly SchoolContext _context;
        public Repository()
        {
            _context = new SchoolContext();
        }

        public Repository(SchoolContext context)
        {
            _context = context;
        }

        public void Delete(int idStudent)
        {
            Student student = _context.Students.Find(idStudent);
            _context.Students.Remove(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int idStudent)
        {
            return _context.Students.Find(idStudent);
        }

        public void Insert(Student student)
        {
            _context.Students.Add(student);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            // var _student = _context.Students.Find(student.Id);
            // _student = student;
            _context.Entry(student).State = EntityState.Modified;
        }
    }
}