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
    public partial class CreatePerson : Form
    {
        WorkshopManagement wks;
        public CreatePerson(WorkshopManagement wks)
        {
            this.wks = wks;
            InitializeComponent();
            PersonTypeCbx.SelectedItem = "Teacher";
        }

        private void CreatePersonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!wks.CheckIfPcnExists(Convert.ToInt32(PcnTbx.Text)))
                {
                    if (PersonTypeCbx.SelectedItem.ToString() == "Teacher")
                    {
                        wks.CreateTeacher(Convert.ToInt32(PcnTbx.Text), NameTbx.Text);
                    }
                    else if (PersonTypeCbx.SelectedItem.ToString() == "Student")
                    {
                        wks.CreateStudent(Convert.ToInt32(PcnTbx.Text), NameTbx.Text);
                    }
                }
                else
                {
                    MessageBox.Show("A person with that PCN already exists.");
                }



                this.Hide();
                Form1 app = new Form1(wks);
                app.ShowDialog();
                this.Close();
            }
            catch(Exception)
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
