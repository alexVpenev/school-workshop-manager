using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public class InBuilding : Workshop
    {
        private string address;
        private int roomNr;
        public int Capacity { get; set; }

        public override string[] GetDisplayInfo()
        {
            if (base.Started)
            {
                return new string[] { base.Id.ToString(), base.title, "In Building", "Started" };
            }
            else
            {
                return new string[] { base.Id.ToString(), base.title, "In Building", "Not Started" };
            }
        }

        public override string[] GetAllAttributes()
        {
            return new string[] { base.Id.ToString(), base.title, base.description, base.enrolledStudents.Count + " / " + this.Capacity.ToString(), this.address, this.roomNr.ToString(), this.Teacher.Pcn.ToString()  };
        }

        public override void EditInfo(string title, string description, int capacity, string address, int roomNr)
        {
            base.title = title;
            base.description = description;
            this.Capacity = capacity;
            this.address = address;
            this.roomNr = roomNr;
        }

        public InBuilding(int id, string title, string description, Teacher teacher, int capacity, string address, int roomNr) : base(id, title, description, teacher)
        {
            this.Capacity = capacity;
            this.address = address;
            this.roomNr = roomNr;
        }
    }
}
