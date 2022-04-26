using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise7.Model;

namespace CSharp.LabExercise7.Service
{
    public class SearchService
    {
        public int GetIndexByStudentID(List<Student> students, string studentID)
        {
            for (int index = 0; index < students.Count; index++)
            {
                if (studentID == students[index].StudentID)
                {
                    return index;
                }
            }
            return -1; // throw something
        }
    }
}
