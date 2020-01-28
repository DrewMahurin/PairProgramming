using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedPrograming
{
    public class Student
    {
        //fields

        //properties
        public string FName { get; set; }
        public string LName { get; set; }


        //Constructors
        public Student(string fName, string lName)
        {
            FName = fName;
            LName = lName;

        }

        public override string ToString()
        {
            return $"Student Name: {FName} {LName}";
        }
        //methods

    }
}
