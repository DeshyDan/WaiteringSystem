using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    public class Runner:Role
    {
        #region instance varsd
        private int tips;
        private int rate;
        private int noOfShifts;
        #endregion

        #region constructors
        public Runner() : base("Runner", RoleType.Runner)
        {
           this.tips                = 0;
            this.rate = 0;
            this.noOfShifts = 0;
        }
        #endregion

        #region properties
        public override int payment()
        {
            return rate * noOfShifts;
        }


        public override int payment(int tips)
        {
            return rate * noOfShifts + tips;
        }
        public int getTips()
        {
            return tips;
        }
        public void setTips(int tips)
        {
            this.tips= tips;
        }
        public int getRate()
        {
            return rate;
        }
        public int getNoOfShifts()
        {
            return noOfShifts;
        }
        #endregion


    }
}
