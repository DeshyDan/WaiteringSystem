using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    public class Waiter:Role
    {
        private int tips;
        private int rate;
        private int noOfShifts;
        public Waiter(int tips, int rate, int noOfShifts)
        {
            this.tips = tips;
            this.rate = rate;
            this.noOfShifts = noOfShifts;
        }
        public override int payment(int tips)
        {
            return rate * noOfShifts + tips;
        }

    }
}
