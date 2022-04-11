using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public abstract class Workshop
    {
        //private static int nextId = 1000;
        protected string title;
        protected string description;
        public List<Student> enrolledStudents;

        public int Id { get; set; }
        public bool Started { get; set; }
        public Teacher Teacher { get; set; }

        public Workshop(int id, string title, string description, Teacher teacher)
        {
            this.Id = id;//nextId;
            this.title = title;
            this.description = description;
            this.Started = false;
            this.Teacher = teacher;
            enrolledStudents = new List<Student>();
            //nextId+=10;
        }

        public virtual string[] GetDisplayInfo()
        {
            return new string[] { "not found", "id" };
        }

        public void EnrollStudent(Student s)
        {
                enrolledStudents.Add(s);
        }

        public List<string[]> GetAllEnrolledStudentsInfo()
        {
            List<string[]> array = new List<string[]>();

            foreach (Student p in enrolledStudents)
            {
                array.Add(p.GetDisplayInfo());
            }

            return array;
        }

        public virtual string[] GetAllAttributes()
        {
            return new string[] { "not found" };
        }

        public virtual void EditInfo(string title, string description, int capacity, string address, int roomNr) { }

        public virtual void EditInfo(string title, string description) { }
    }
}
