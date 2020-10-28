using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegist
{
    public class Student
    {
        private string FN, MN, LN;
        private int A;
        private string Add;

        public Student(string fN, string mN, string lN, int a, string add)
        {
            FN = fN;
            MN = mN;
            LN = lN;
            A = a;
            Add = add;
        }

        public string FN1 { get => FN; set => FN = value; }
        public string MN1 { get => MN; set => MN = value; }
        public string LN1 { get => LN; set => LN = value; }
        public int A1 { get => A; set => A = value; }
        public string Add1 { get => Add; set => Add = value; }
    }
}
