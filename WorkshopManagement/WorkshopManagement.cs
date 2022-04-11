using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public class WorkshopManagement
    {
        List<Workshop> workshops;
        List<Person> people;
        /*     Initialy wksNextId was a static int in the Workshop class, that part is commented out for you to see the initial solution
         * but due to the Unit tests not able to run in Sync while not failing, because of the static variable. I decided to put the variable in
         * WorkshopManagement. I tried running the tests on separate threads, but it didn't work out.     */
        public int wksNextId;

        public WorkshopManagement()
        {
            workshops = new List<Workshop>();
            people = new List<Person>();
            wksNextId = 1000;
        }

        public void CreateInBuildingWorkshop(string title, string description, int Pcn,  int capacity, string address, int roomNr)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == Pcn)
                {

                    Teacher teacher = (Teacher)p;
                    workshops.Add(new InBuilding(wksNextId, title, description, teacher, capacity, address, roomNr));
                    wksNextId += 10;

                }
            }

        }

        public void CreateOnlineWorkshop(string title, string description, int Pcn)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == Pcn)
                {
                    Teacher teacher = (Teacher)p;
                    workshops.Add(new Online(wksNextId, title, description, teacher));
                    wksNextId += 10;

                }
            }

        }

        public void CreateTeacher(int pcn, string name)
        {
            people.Add(new Teacher(pcn, name));
        }

        public void CreateStudent(int pcn, string name)
        {
            people.Add(new Student(pcn, name));
        }

        public void EnrollStudentInAWks(int wksId, int personId)
        {
            Student student = null;

            foreach(Person p in people)
            {
                if(p.Pcn == personId)
                {
                    student = (Student)p;
                }
            }

            foreach(Workshop w in workshops)
            {
                if(w.Id == wksId)
                {
                    w.EnrollStudent(student);
                }
            }
        }

        public bool CheckIfWksHasEnoughCapacity(int id)
        {
            if(CheckIfWorkshopIsOnline(id))
            {
                return false;
            }
            
            foreach(InBuilding w in workshops)
            {
                if(w.Id == id)
                {
                    if(w.enrolledStudents.Count() >= (w.enrolledStudents.Count() / w.Capacity) * 100)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool CheckIfCapacityCanBeEdited(int id, int cap)
        {
            foreach (InBuilding w in workshops)
            {
                if (w.Id == id)
                {
                    if (w.enrolledStudents.Count() <= cap)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public bool CheckIfWksHasStarted(int id)
        {
            foreach(Workshop w in workshops) 
            {
                if(w.Id == id)
                {
                    return w.Started;
                }
            }
            return false;
        }

        public void StartWorkshop(int id)
        {
            foreach (Workshop w in workshops)
            {
                if (w.Id == id)
                {
                    w.Started = true;
                }
            }
        }

        public List<string[]> GetAllEnrolledStudentsFromAWks(int wksId)
        {
            foreach(Workshop w in workshops)
            {
                if(w.Id == wksId)
                {
                    return w.GetAllEnrolledStudentsInfo();
                }
            }
            return null;
        }

        public void EditInBuildingWorkshop(int id, string title, string description, int capacity, string address, int roomNr)
        {
            foreach (Workshop w in workshops)
            {
                if (w.Id == id)
                {
                    w.EditInfo(title, description, capacity, address, roomNr);
                }
            }

        }

        public void EditOnlineWorkshop(int id, string title, string description)
        {
            foreach (Workshop w in workshops)
            {
                if (w.Id == id)
                {
                    w.EditInfo(title, description);
                }
            }

        }

        public void EditPerson(int pcn, string name, int search)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == search)
                {
                    p.EditInfo(pcn, name);
                }
            }
        }

        public List<string[]> GetAllWorkshops()
        {
            List<string[]> wksTitle = new List<string[]>();

            foreach(Workshop w in workshops)
            {
                wksTitle.Add(w.GetDisplayInfo());
            }

            return wksTitle;
        }

        public string[] GetWorkshopInfoElementsById(int id)
        {
            foreach( Workshop w in workshops)
            {
                if (w.Id == id)
                {
                    return w.GetAllAttributes();
                }
            }

            return new string[] { "none" };
        }

        public string[] GetWorkshopDisplayInfoElementsById(int id)
        {
            foreach (Workshop w in workshops)
            {
                if (w.Id == id)
                {
                    return w.GetDisplayInfo();
                }
            }

            return new string[] { "none" };
        }

        public List<string[]> GetAllPersonsDisplayInfo()
        {
            List<string[]> personInfo = new List<string[]>();

            foreach (Person p in people)
            {
                personInfo.Add(p.GetDisplayInfo());
            }

            return personInfo;
        }

        public List<string[]> GetAllStudentsDisplayInfo()
        {
            List<string[]> personInfo = new List<string[]>();

            foreach (Person p in people)
            {
                if (p is Student) {
                    personInfo.Add(p.GetDisplayInfo());
                }
                
            }

            return personInfo;
        }

        public List<string[]> GetAllTeachersDisplayInfo()
        {
            List<string[]> personInfo = new List<string[]>();

            foreach (Person p in people)
            {
                if (p is Teacher)
                {
                    personInfo.Add(p.GetDisplayInfo());
                }

            }

            return personInfo;
        }

        public string[] GetPersonInfo(int pcn)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == pcn)
                {
                    return p.GetAllAttributes();
                }
            }

            return new string[] { "none" };
        }

        public bool CheckIfWorkshopIsOnline(int id)
        {
            foreach(Workshop w in workshops)
            {
                if(w.Id == id)
                {
                    if (w is Online)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckIfPersonIsAStudent(int pcn)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == pcn)
                {
                    if (p is Student)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckIfPcnExists(int pcn)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == pcn)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckIfPcnCanBeEdited(int pcn, int search)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == pcn && pcn != search)
                {
                    return false;
                }
            }
            return true;
        }

        public List<string[]> GetAllPersonsWorkshops(int pcn)
        {
            List<string[]> returnList = new List<string[]>();
            if (CheckIfPersonIsAStudent(pcn))
            {
                List<string[]> enrolledIn;
                foreach (Workshop w in workshops)
                {
                    enrolledIn = w.GetAllEnrolledStudentsInfo();
                    foreach (string[] s in enrolledIn)
                    {
                        if(Convert.ToInt32(s[0]) == pcn)
                        {
                            returnList.Add(w.GetDisplayInfo());
                        }
                    }
                }
            }
            else
            {
                foreach (Workshop w in workshops)
                {
                    if(w.Teacher.Pcn == pcn)
                    {
                        returnList.Add(w.GetDisplayInfo());
                    }
                }
            } 

            return returnList;
        }

        public bool CheckIfStudentIsAlreadyEnrolled(int wksId, int pcn)
        {
            List<string[]> vs;
            foreach (Workshop w in workshops)
            {
                if (w.Id == wksId)
                {
                    vs = w.GetAllEnrolledStudentsInfo();
                    foreach (string[] s in vs)
                    {
                        if (Convert.ToInt32(s[0]) == pcn)
                        {
                            return false;
                        }
                    }
                }
            }


            return true;
        }

    }



}
