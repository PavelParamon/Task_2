using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class MobilePhone
    {
        protected string mark;
        protected string model;
        protected int price;
        protected int memory;

        public MobilePhone(string mark, string model, int price, int memory)
        {
            this.mark = mark;
            this.model = model;
            this.price = price;
            this.memory = memory;
        }

        public string Mark
        {
            get
            {
                return mark;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
        }

        public int Memory
        {
            get
            {
                return memory;
            }
        }

        public virtual double Quality()
        {
            double quality = (double)memory / price;
            return quality;
        }
    }
}
