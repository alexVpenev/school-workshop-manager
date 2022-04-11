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
    public partial class CreateWorkshop : Form
    {
        WorkshopManagement wks;

        public CreateWorkshop(WorkshopManagement wks)
        {
            this.wks = wks;
            InitializeComponent();
            LoadList();
        }

        public void LoadList()
        {
            List<string[]> peopleInfo = wks.GetAllTeachersDisplayInfo();
            TeacherList.Items.Clear();

            foreach (string[] s in peopleInfo)
            {
                // workshopList.Items.Add(s);
                TeacherList.Items.Add(new ListViewItem(s));
            }
        }

        private void CreateWorkshopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TeacherList.SelectedItems.Count > 0)
                {
                    if (WksTypeCbx.SelectedItem.ToString() == "In Building")
                    {
                        wks.CreateInBuildingWorkshop(titleTbx.Text, descriptionTbx.Text, Convert.ToInt32(TeacherList.SelectedItems[0].SubItems[0].Text), Convert.ToInt32(capacityTbx.Text), addressTbx.Text, Convert.ToInt32(roomNrTbx.Text));
                    }
                    else if (WksTypeCbx.SelectedItem.ToString() == "Online")
                    {
                        wks.CreateOnlineWorkshop(titleTbx.Text, descriptionTbx.Text, Convert.ToInt32(TeacherList.SelectedItems[0].SubItems[0].Text));
                    }


                    this.Hide();
                    Form1 app = new Form1(wks);
                    app.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The input marked with * should be a number!");
            }
        }
        

        private void WksTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WksTypeCbx.SelectedItem.ToString() == "In Building")
            {
                capacityTbx.Enabled = true;
                addressTbx.Enabled = true;
                roomNrTbx.Enabled = true;
            }
            else if (WksTypeCbx.SelectedItem.ToString() == "Online")
            {
                capacityTbx.Enabled = false;
                addressTbx.Enabled = false;
                roomNrTbx.Enabled = false;

                capacityTbx.Text = "";
                addressTbx.Text = "";
                roomNrTbx.Text = "";
            }
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 app = new Form1(wks);
            app.ShowDialog();
            this.Close();
        }

    }
}
