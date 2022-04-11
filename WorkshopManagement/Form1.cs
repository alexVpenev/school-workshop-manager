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
    public partial class Form1 : Form
    {
        WorkshopManagement wks;

        public Form1(WorkshopManagement wks)
        {
            this.wks = wks;
            InitializeComponent();
            LoadLists();
        }

        private void LoadLists()
        {
            List<string[]> wksTitles = wks.GetAllWorkshops();
            List<string[]> peopleInfo = wks.GetAllPersonsDisplayInfo();
            WorkshopsList.Items.Clear();
            PeopleList.Items.Clear();

            foreach (string[] s in wksTitles)
            {
                // workshopList.Items.Add(s);
                WorkshopsList.Items.Add(new ListViewItem(s));
            }

            foreach (string[] s in peopleInfo)
            {
                // workshopList.Items.Add(s);
                PeopleList.Items.Add(new ListViewItem(s));
            }
        }

        private void CreateWorkshopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateWorkshop app = new CreateWorkshop(wks);
            app.ShowDialog();
            this.Close();
        }

        private void ViewWorkshopBtn_Click(object sender, EventArgs e)
        {
            //workshopList.SelectedItem.ToString();
            if (WorkshopsList.SelectedItems.Count > 0) {
                this.Hide();
                ViewWorkshop app = new ViewWorkshop(wks, WorkshopsList.SelectedItems[0].SubItems[0].Text);
                app.ShowDialog();
                this.Close();
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (WorkshopsList.SelectedItems.Count > 0)
            {
                wks.StartWorkshop(Convert.ToInt32(WorkshopsList.SelectedItems[0].SubItems[0].Text));
                LoadLists();
            }
        }

        private void AddNewPersonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePerson app = new CreatePerson(wks);
            app.ShowDialog();
            this.Close();
        }

        private void ViewPersonInfoBtn_Click(object sender, EventArgs e)
        {
            if (PeopleList.SelectedItems.Count > 0)
            {
                this.Hide();
                ViewPerson app = new ViewPerson(wks, PeopleList.SelectedItems[0].SubItems[0].Text);
                app.ShowDialog();
                this.Close();
            }
        }
    }
}
