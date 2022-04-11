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
    public partial class EditWorkshop : Form
    {
        WorkshopManagement wks;
        string workshopID;

        public EditWorkshop(WorkshopManagement wks, string id)
        {
            this.wks = wks;
            this.workshopID = id;
            InitializeComponent();
            LoadElements();
        }

        private void LoadElements()
        {
            string[] wksInfo = wks.GetWorkshopInfoElementsById(Convert.ToInt32(workshopID));
            if (wks.CheckIfWorkshopIsOnline(Convert.ToInt32(workshopID)))
            {
                titleTbx.Text = wksInfo[1];
                descriptionTbx.Text = wksInfo[2];
                capacityTbx.Enabled = false;
                addressTbx.Enabled = false;
                roomNrTbx.Enabled = false;
            }
            else
            {
                titleTbx.Text = wksInfo[1];
                descriptionTbx.Text = wksInfo[2];


                capacityTbx.Text = wksInfo[3].Substring(wksInfo[3].LastIndexOf('/') + 1);
                addressTbx.Text = wksInfo[4];
                roomNrTbx.Text = wksInfo[5];
            }
        }


        private void EditWksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (wks.CheckIfWorkshopIsOnline(Convert.ToInt32(workshopID)))
                {
                    wks.EditOnlineWorkshop(Convert.ToInt32(workshopID), titleTbx.Text, descriptionTbx.Text);
                }
                else
                {
                    if (wks.CheckIfCapacityCanBeEdited(Convert.ToInt32(workshopID), Convert.ToInt32(capacityTbx.Text)))
                    {
                        wks.EditInBuildingWorkshop(Convert.ToInt32(workshopID), titleTbx.Text, descriptionTbx.Text, Convert.ToInt32(capacityTbx.Text), addressTbx.Text, Convert.ToInt32(roomNrTbx.Text));
                    }
                    else
                    {
                        MessageBox.Show("Chosen Capacity is less than the number already enrolled in that Workshop");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The input marked with * should be a number!");
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
