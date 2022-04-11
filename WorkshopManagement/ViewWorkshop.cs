using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagementApp
{
    public partial class ViewWorkshop : Form
    {
        WorkshopManagement wks;
        string workshopID;

        public ViewWorkshop(WorkshopManagement wks, string id)
        {
            this.wks = wks;
            this.workshopID = id;
            InitializeComponent();
            LoadElements();
        }

        private void LoadElements()
        {
            string[] wksInfo = wks.GetWorkshopInfoElementsById(Convert.ToInt32(workshopID));
            string[] teacherInfo;
            List<string[]> enrolledStudents = wks.GetAllEnrolledStudentsFromAWks(Convert.ToInt32(workshopID));
            if (wks.CheckIfWorkshopIsOnline(Convert.ToInt32(workshopID))) {
                TitleLbl.Text = wksInfo[1];
                DescriptionLbl.Text = wksInfo[2];
                IdLbl.Text = wksInfo[0];
                teacherInfo = wks.GetPersonInfo(Convert.ToInt32(wksInfo[3]));
                UrlLbl.Text = wksInfo[4];
                LoginLbl.Text = wksInfo[5];
                TypeLbl.Text = "Online";

                a.Visible = false;
                b.Visible = false;
                c.Visible = false;
                CapacityLbl.Visible = false;
                AddressLbl.Visible = false;
                RoomNrLbl.Visible = false;
            }
            else
            {
                TitleLbl.Text = wksInfo[1];
                IdLbl.Text = wksInfo[0];
                DescriptionLbl.Text = wksInfo[2];
                CapacityLbl.Text = wksInfo[3];
                AddressLbl.Text = wksInfo[4];
                RoomNrLbl.Text = wksInfo[5];
                teacherInfo = wks.GetPersonInfo(Convert.ToInt32(wksInfo[6]));
                TypeLbl.Text = "In Building";
                label9.Visible = false;
                label10.Visible = false;
                UrlLbl.Visible = false;
                LoginLbl.Visible = false;
            }

            foreach(string[] enrolledStudent in enrolledStudents)
            {
                EnrolledStudentsList.Items.Add(new ListViewItem(enrolledStudent));
            }

            TeacherList.Items.Add(new ListViewItem(teacherInfo));
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 app = new Form1(wks);
            app.ShowDialog();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(wks.CheckIfWksHasStarted(Convert.ToInt32(workshopID)))
            {
                MessageBox.Show("The workshop has already started!");    
            }
            else
            {
                this.Hide();
                EditWorkshop app = new EditWorkshop(wks, workshopID);
                app.ShowDialog();
                this.Close();
            }



            
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            if (!wks.CheckIfWksHasStarted(Convert.ToInt32(workshopID))) {
                if (!wks.CheckIfWksHasEnoughCapacity(Convert.ToInt32(workshopID))) {
                    this.Hide();
                    EnrollStudent app = new EnrollStudent(wks, workshopID);
                    app.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Workshop is at full capacity");
                }
            }
            else
            {
                MessageBox.Show("The workshop has already started!");
            }
        }

        private void ViewTeacherBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPerson app = new ViewPerson(wks, TeacherList.Items[0].SubItems[0].Text);
            app.ShowDialog();
            this.Close();
        }

        private void VewStudentBtn_Click(object sender, EventArgs e)
        {
            if (EnrolledStudentsList.SelectedItems.Count > 0)
            {
                this.Hide();
                ViewPerson app = new ViewPerson(wks, EnrolledStudentsList.SelectedItems[0].SubItems[0].Text);
                app.ShowDialog();
                this.Close();
            }
        }
    }
}
