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
    public partial class ViewPerson : Form
    {
        WorkshopManagement wks;
        string personPcn;

        public ViewPerson(WorkshopManagement wks, string pcn)
        {
            this.wks = wks;
            this.personPcn = pcn;
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            string[] wksInfo = wks.GetPersonInfo(Convert.ToInt32(personPcn));

            PcnLbl.Text = wksInfo[0];
            NameLbl.Text = wksInfo[1];

            List<string[]> vs = wks.GetAllPersonsWorkshops(Convert.ToInt32(personPcn));

            foreach(string[] s in vs)
            {
                WorkshopsList.Items.Add(new ListViewItem(s));
            }

            if (wks.CheckIfPersonIsAStudent(Convert.ToInt32(personPcn)))
            {
                RoleLbl.Text = "Student";
                b.Visible = false;
            }
            else 
            {
                RoleLbl.Text = "Teacher";
                a.Visible = false;
            }

        }

        private void EditPersonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPerson app = new EditPerson(wks, personPcn);
            app.ShowDialog();
            this.Close();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 app = new Form1(wks);
            app.ShowDialog();
            this.Close();
        }

        private void ViewWksBtn_Click(object sender, EventArgs e)
        {
            if (WorkshopsList.SelectedItems.Count > 0)
            {
                this.Hide();
                ViewWorkshop app = new ViewWorkshop(wks, WorkshopsList.SelectedItems[0].SubItems[0].Text);
                app.ShowDialog();
                this.Close();
            }
        }
    }
}
