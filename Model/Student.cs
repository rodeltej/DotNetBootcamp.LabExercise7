using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise7.Model
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeLevel { get; set; }
        public int Section { get; set; }

        public override string ToString()
        {
            return $"{StudentID} \t\t {FirstName} \t\t {LastName} \t\t {GradeLevel} \t\t {Section}";
        }
    }
}
