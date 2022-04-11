using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public abstract class Person
    {
        protected string name;

        public int Pcn { get; set; }

        public Person(int pcn, string name)
        {
            this.Pcn = pcn;
            this.name = name;
        }

        public string[] GetAllAttributes()
        {
            return new string[] { this.Pcn.ToString(), this.name };
        }

        public virtual string[] GetDisplayInfo()
        {
            return new string[] { "not found", "id" };
        }

        public void EditInfo(int pcn, string name)
        {
            this.Pcn = pcn;
            this.name = name;
        }
    }
}
