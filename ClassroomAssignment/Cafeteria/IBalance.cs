using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public interface IBalance
    {
        double WalletBalance {get;}
        public double WalletRecharge(double amount);
        public double DeductAmount(double amount);
    }
}