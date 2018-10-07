using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class PhoneModify : MobilePhone
    {
        protected int countSIM;

        public PhoneModify(string mark, string model, int price, int memory, int countSIM) : base(mark, model, price, memory)
        {
            this.countSIM = countSIM;
        }

        public int CountSIM
        {
            get
            {
                return countSIM;
            }
        }

        public override double Quality()
        {
            double quality = base.Quality() * countSIM;
            return quality;
        }
    }
}
