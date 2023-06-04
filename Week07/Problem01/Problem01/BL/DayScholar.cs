using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class DayScholar : Student
    {
        private int BusNo;
        private bool IsBusCard;
        private string PickPoint;
        private int PickDistance;

        public DayScholar(int BusNo, bool IsBusCard, string PickPoint, int PickDistance, string Name, int Session, bool IsDayScholar, int Ecat, int Inter) :base(Name,Session, IsDayScholar,Ecat,Inter)
        {
            this.BusNo = BusNo;
            this.IsBusCard = IsBusCard;
            this.PickPoint = PickPoint;
            this.PickDistance = PickDistance;
        }
        public float GetBusFee()
        {
            float fee = 0;
            return fee;
        }
    }
}
