using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2
{
    class Student:Person
    {
        // private field storing student ID
        private int studentID;
        // property for getting and setting student ID
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        // constructor
        // call base constructor and populate student id
        public Student(string pFName, string pLName, string pGender, int pStudentID): base(pFName,pLName,pGender)
        {
            studentID = pStudentID;
        }
        public override string Work()
        {
            return "Study,Drink,Coffee,Party,Sleep,Repeat";
        }
    }
}
