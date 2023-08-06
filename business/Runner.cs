using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    public class Runner:Role
    {

        private int tips;
        private int rate;
        private int noOfShifts;
        public Runner(int tips, int rate, int noOfShifts) : base("Runner", RoleType.Runner)
        {
            this.tips = tips;
            this.rate = rate;
            this.noOfShifts = noOfShifts;
        }




        public override int payment()
        {
            return rate * noOfShifts;
        }

        public override int payment(int tips)
        {
            return rate * noOfShifts + tips;
        }


    }
}
