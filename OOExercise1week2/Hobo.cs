using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2
{
    class Hobo:Person
    {
        // call base constructor with same signature
        public Hobo(string pFName, string pLName, string pGender):base(pFName, pLName, pGender) { }
        // call base constructor with same signature
        public Hobo(string pGender) : base(pGender) { }
        public override string Work()
        {
            return "Find a place to sleep";

        }


    }
}
