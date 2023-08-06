using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem
{
    public abstract class Person
    {
        #region Data Members
        private string ID;
        private string name;
        private string phone;
        #endregion
        #region Constructor
        public Person(string ID, string name, string phone)
        {

            this.ID = ID;
            this.name = name;
            this.phone = phone;
        }
        #endregion

        #region Property Methods
        public string getID()
        {
            return this.ID;
        }
        public void setID(string ID)
        {
            this.ID = ID;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPhone()
        {
            return this.phone;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        #endregion


    }
}
