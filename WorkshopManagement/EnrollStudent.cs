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
    public partial class EnrollStudent : Form
    {
        WorkshopManagement wks;
        string workshopId;

        public EnrollStudent(WorkshopManagement wks, string id)
        {
            this.wks = wks;
            this.workshopId = id;
            InitializeComponent();
            LoadList();
        }

        public void LoadList()
        {
            List<string[]> peopleInfo = wks.GetAllStudentsDisplayInfo();
            EnrolledStudentsList.Items.Clear();

            foreach (string[] s in peopleInfo)
            {
                // workshopList.Items.Add(s);
                EnrolledStudentsList.Items.Add(new ListViewItem(s));
            }
        }

        

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewWorkshop app = new ViewWorkshop(wks, workshopId);
            app.ShowDialog();
            this.Close();
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            if (EnrolledStudentsList.SelectedItems.Count > 0)
            {
                if (wks.CheckIfStudentIsAlreadyEnrolled(Convert.ToInt32(workshopId), Convert.ToInt32(EnrolledStudentsList.SelectedItems[0].SubItems[0].Text))) {
                    wks.EnrollStudentInAWks(Convert.ToInt32(workshopId), Convert.ToInt32(EnrolledStudentsList.SelectedItems[0].SubItems[0].Text));

                    this.Hide();
                    ViewWorkshop app = new ViewWorkshop(wks, workshopId);
                    app.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That Student is already Enrolled in that course.");
                }
            }
        }
    }
}
