using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.business
{
    #region Roletype enum
    public enum RoleType
         {
        noRole=0 ,
        Headwaiter=1,
        Waiter=2,
        Runner=3
          }
#endregion
    public class Role
    {
        #region Data Members
        private string description;
        private RoleType role;
        #endregion
        #region Contructors
        public Role()
        {
            role = RoleType.noRole;
            description = "No Role";
        }

        public Role(string desciption, RoleType role)
        {
            this.description = desciption;
            this.role = role;
        }

        #endregion
        #region Properties

        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description) { 

            this.description = description;
        }
        public RoleType getRole()
        {
            return role;
        }
        public void setRole(RoleType role) {
            this.role = role; }

        public virtual int payment()
        {
            return 0;
        }

        public virtual int payment(int amount)
        {
            return 0;
        }
        #endregion

    }
}
