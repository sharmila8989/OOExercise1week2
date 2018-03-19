using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2
{
    class SecondaryTeacher:Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }

        public SecondaryTeacher(string pFName, string pLName, string pGender, int pStaffID): base(pFName, pLName, pGender, pStaffID) { }

    }
}
