namespace WorkshopManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Workshops = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkshopsList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewWorkshopBtn = new System.Windows.Forms.Button();
            this.CreateWorkshopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.People = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.PeopleList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewPersonInfoBtn = new System.Windows.Forms.Button();
            this.addNewPersonBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Workshops.SuspendLayout();
            this.People.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Workshops);
            this.tabControl.Controls.Add(this.People);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(590, 415);
            this.tabControl.TabIndex = 0;
            // 
            // Workshops
            // 
            this.Workshops.Controls.Add(this.label2);
            this.Workshops.Controls.Add(this.WorkshopsList);
            this.Workshops.Controls.Add(this.ViewWorkshopBtn);
            this.Workshops.Controls.Add(this.CreateWorkshopBtn);
            this.Workshops.Controls.Add(this.StartBtn);
            this.Workshops.Location = new System.Drawing.Point(4, 27);
            this.Workshops.Name = "Workshops";
            this.Workshops.Padding = new System.Windows.Forms.Padding(3);
            this.Workshops.Size = new System.Drawing.Size(582, 384);
            this.Workshops.TabIndex = 0;
            this.Workshops.Text = "Workshops";
            this.Workshops.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Workshops:";
            // 
            // WorkshopsList
            // 
            this.WorkshopsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7});
            this.WorkshopsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkshopsList.FullRowSelect = true;
            this.WorkshopsList.HideSelection = false;
            this.WorkshopsList.Location = new System.Drawing.Point(6, 39);
            this.WorkshopsList.Name = "WorkshopsList";
            this.WorkshopsList.Size = new System.Drawing.Size(428, 339);
            this.WorkshopsList.TabIndex = 4;
            this.WorkshopsList.UseCompatibleStateImageBehavior = false;
            this.WorkshopsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#id";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Progress";
            this.columnHeader7.Width = 99;
            // 
            // ViewWorkshopBtn
            // 
            this.ViewWorkshopBtn.Location = new System.Drawing.Point(440, 329);
            this.ViewWorkshopBtn.Name = "ViewWorkshopBtn";
            this.ViewWorkshopBtn.Size = new System.Drawing.Size(135, 49);
            this.ViewWorkshopBtn.TabIndex = 3;
            this.ViewWorkshopBtn.Text = "View";
            this.ViewWorkshopBtn.UseVisualStyleBackColor = true;
            this.ViewWorkshopBtn.Click += new System.EventHandler(this.ViewWorkshopBtn_Click);
            // 
            // CreateWorkshopBtn
            // 
            this.CreateWorkshopBtn.Location = new System.Drawing.Point(440, 274);
            this.CreateWorkshopBtn.Name = "CreateWorkshopBtn";
            this.CreateWorkshopBtn.Size = new System.Drawing.Size(135, 49);
            this.CreateWorkshopBtn.TabIndex = 2;
            this.CreateWorkshopBtn.Text = "Create Workshop";
            this.CreateWorkshopBtn.UseVisualStyleBackColor = true;
            this.CreateWorkshopBtn.Click += new System.EventHandler(this.CreateWorkshopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(440, 219);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(135, 49);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // People
            // 
            this.People.Controls.Add(this.label1);
            this.People.Controls.Add(this.PeopleList);
            this.People.Controls.Add(this.viewPersonInfoBtn);
            this.People.Controls.Add(this.addNewPersonBtn);
            this.People.Location = new System.Drawing.Point(4, 27);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(582, 384);
            this.People.TabIndex = 1;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Students and Teachers:";
            // 
            // PeopleList
            // 
            this.PeopleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.PeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleList.FullRowSelect = true;
            this.PeopleList.HideSelection = false;
            this.PeopleList.Location = new System.Drawing.Point(6, 42);
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.Size = new System.Drawing.Size(430, 336);
            this.PeopleList.TabIndex = 5;
            this.PeopleList.UseCompatibleStateImageBehavior = false;
            this.PeopleList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PCN";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 222;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 110;
            // 
            // viewPersonInfoBtn
            // 
            this.viewPersonInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.viewPersonInfoBtn.Location = new System.Drawing.Point(441, 329);
            this.viewPersonInfoBtn.Name = "viewPersonInfoBtn";
            this.viewPersonInfoBtn.Size = new System.Drawing.Size(135, 49);
            this.viewPersonInfoBtn.TabIndex = 1;
            this.viewPersonInfoBtn.Text = "View";
            this.viewPersonInfoBtn.UseVisualStyleBackColor = true;
            this.viewPersonInfoBtn.Click += new System.EventHandler(this.ViewPersonInfoBtn_Click);
            // 
            // addNewPersonBtn
            // 
            this.addNewPersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPersonBtn.Location = new System.Drawing.Point(441, 274);
            this.addNewPersonBtn.Name = "addNewPersonBtn";
            this.addNewPersonBtn.Size = new System.Drawing.Size(134, 49);
            this.addNewPersonBtn.TabIndex = 0;
            this.addNewPersonBtn.Text = "Add new Person";
            this.addNewPersonBtn.UseVisualStyleBackColor = true;
            this.addNewPersonBtn.Click += new System.EventHandler(this.AddNewPersonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 435);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Workshops.ResumeLayout(false);
            this.Workshops.PerformLayout();
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Workshops;
        private System.Windows.Forms.Button ViewWorkshopBtn;
        private System.Windows.Forms.Button CreateWorkshopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.Button viewPersonInfoBtn;
        private System.Windows.Forms.Button addNewPersonBtn;
        private System.Windows.Forms.ListView WorkshopsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView PeopleList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

