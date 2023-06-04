using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Hostelite : Student
    {
        private int RoomNo;
        private bool IsFridge;
        private bool IsInternet;
        public Hostelite(int RoomNo,bool IsFridge,bool IsInternet, string Name, int Session, bool IsDayScholar, int Ecat, int Inter) : base(Name, Session, IsDayScholar, Ecat, Inter)
        {
            this.RoomNo = RoomNo;
            this.IsFridge = IsFridge;
            this.IsInternet = IsInternet;
        }
        public float GetHostelFee()
        {
            float fee = 0;
            return fee;
        }
    }
}
