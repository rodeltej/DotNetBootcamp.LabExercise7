using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise7.Model
{
    public class StudentDb
    {
        public List<Student> Students { get; set; }

        public StudentDb()
        {
            Students = new List<Student>();
        }
    }
}
