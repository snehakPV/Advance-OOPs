using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public abstract class Dress
    {
        protected string dressType;
        protected string dressName;
        protected decimal price;
        protected decimal totalPrice;
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();
    }
}