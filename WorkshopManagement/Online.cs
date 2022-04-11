using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public class Online : Workshop
    {
        private string loginCode;
        private string url;

        public Online(int id, string title, string description, Teacher teacher) : base(id, title, description, teacher)
        {
            Random rnd = new Random();
            this.loginCode = "https://lecturegate.com/" + rnd.Next(1000, 9999).ToString() + "/";
            this.url = rnd.Next(10000, 99999).ToString();

        }

        public override string[] GetDisplayInfo()
        {
            if (base.Started) {
                return new string[] { base.Id.ToString(), base.title, "Online", "Started" };
            }
            else
            {
                return new string[] { base.Id.ToString(), base.title, "Online", "Not Started" };
            }
        }

        public override string[] GetAllAttributes()
        {
            return new string[] { base.Id.ToString(), base.title, base.description, this.Teacher.Pcn.ToString(), this.loginCode, this.url };
        }

        public override void EditInfo(string title, string description)
        {
            base.title = title;
            base.description = description;
        }
    }
}
