using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2
{
    class PaveTeacher:Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
        public PaveTeacher(string pFName, string pLName, string pGender, int pStaffID): base(pFName, pLName, pGender, pStaffID) { }
    }
}
