using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Update.BL
{
    public class Subject
    {
        public Subject(int code, string type, int creditHours, float fees)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.fees = fees;
        }

        public int code;
        public string type;
        public int creditHours;
        public float fees;

        public int GetCreditHours()
        {
            return creditHours;
        }
    }
}
