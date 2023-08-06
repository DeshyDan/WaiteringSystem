using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    public class Waiter:Role
    {
        #region instance vars
        private int tips; 
        private int rate;
        private int noOfShifts;
        #endregion
        #region Constructor
        public Waiter( ):base("Waite", RoleType.Waiter)
        {
            this.tips = 0;
            this.rate = 0;
            this.noOfShifts = 0;
        }
        #endregion
        #region Properties

        public int getRate() { return rate; }
        public void setRate(int rate) { this.rate = rate; }
        public int getTips() { return tips; }
        public void setTips(int tips) {  this.tips = tips; }
        public int getNoOfShifts()
        {
            return noOfShifts;
        }
        public void setNoOfShifts(int noOfShift)
        {
            noOfShifts=noOfShift;
        }
        public override int payment(int tips)
        {
            return rate * noOfShifts + tips;
        }
        #endregion

    }
}
