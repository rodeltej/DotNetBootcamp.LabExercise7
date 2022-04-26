using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise7.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : this("Invalid Input. Please try again")
        {

        }
        public InvalidInputException(string message) : base(message)
        {

        }
    }
}
