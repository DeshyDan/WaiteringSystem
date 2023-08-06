using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem;

namespace WaiteringSystem.business
{
    public class Employee : Person
    {
        private string number;
        public Role role;

        public Employee(Role roleValue ):base() {
            var roleType = roleValue.getRole();
            switch (roleType) {

                case RoleType.noRole:
                        role = new Role();
                    break;
                case RoleType.Headwaiter:
                    role = new HeadWaiter();
                    break;
                case RoleType.Waiter:
                    role = new Waiter();
                      break;
                case RoleType.Runner:
                    role = new Runner();
                      break;
                default:
                    throw new Exception("Invalid Role Type was given");

            }

        }
        public string getNumber( )
        {
            return number;
        }

        public Role getRole( )
        {
            return role;
        }

        public void setRole( Role roleValue )
        {
            this.role = roleValue;
        }

       
    }
}
