using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;

namespace CMS.Data.EFCore
{
    public interface IRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int idStudent);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int idStudent);
        void Save();

    }
}