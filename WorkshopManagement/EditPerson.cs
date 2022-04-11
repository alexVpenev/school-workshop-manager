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
    public partial class EditPerson : Form
    {
        WorkshopManagement wks;
        string personPcn;

        public EditPerson(WorkshopManagement wks, string pcn)
        {
            this.wks = wks;
            this.personPcn = pcn;
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            string[] wksInfo = wks.GetPersonInfo(Convert.ToInt32(personPcn));
            PcnTbx.Text = wksInfo[0];
            NameTbx.Text = wksInfo[1];

        }

        private void EditWksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (wks.CheckIfPcnCanBeEdited(Convert.ToInt32(PcnTbx.Text), Convert.ToInt32(personPcn))) 
                {
                    wks.EditPerson(Convert.ToInt32(PcnTbx.Text), NameTbx.Text, Convert.ToInt32(personPcn));
                }
                else
                {
                    MessageBox.Show("A person with that Pcn already exists!");
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
