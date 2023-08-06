using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    public class HeadWaiter : Role
    {
        private int salary;
        public HeadWaiter() : base("HeadWaiter", RoleType.Headwaiter)
        {
            this.salary = 0;
        }
        public override int payment(int amount)
        {
            return salary;
        }
      
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;   
        }
    }
}
