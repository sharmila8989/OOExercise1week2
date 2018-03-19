using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2
{
    public abstract class Person
    {
        // backing store
        private string fName;
        private string gender;
        private string lName;
        // property to get and set private field fName
        public string FName {
            get { return fName; }
            set { fName = value; }
        }
        // Property to get and set private field lName
        public string LName {
            get { return lName; }
            set { lName = value; }
        }

        public string GetGender()
        {
            return gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }
        public Person(string pFName, string pLName, string pGender)
        {
            fName = pFName;
            lName = pLName;
            gender = pGender;

            if (gender != "M" || gender != "F")
                throw new Exception("Invalid Gender passed to Person Constructor !");
        }
        public Person(string pGender)
        {
            if (pGender == "M")
            {
                fName = "John";
                lName = "Doe";
                gender = pGender;
            }
            else if (pGender == "F")
            {
                fName = "Jane";
                lName = "Doe";
                gender = pGender;

            }
            else throw new Exception("Invalid gender passed to  person constructor !");

        }
        public abstract string Work();
      
    }
}
