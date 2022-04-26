using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise7.Model;

namespace CSharp.LabExercise7.Service
{
    public class DBService
    {
        StudentDb StudentDb;
        public DBService()
        {
            StudentDb = new StudentDb();
        }
        public void AddStudentToDb(Student student)
        {
            StudentDb.Students.Add(student);
        }
        public int GetStudentCount()
        {
            return StudentDb.Students.Count;
        }
        public List<Student> GetStudents()
        {
            return StudentDb.Students;
        }
        public void RemoveStudentByIndex(int index)
        {
            StudentDb.Students.RemoveAt(index);
        }
    }
}
