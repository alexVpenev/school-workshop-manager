namespace WorkshopManagementApp
{
    partial class ViewPerson
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
            this.PcnLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.EditPersonBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.WorkshopsList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewWksBtn = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PcnLbl
            // 
            this.PcnLbl.AutoSize = true;
            this.PcnLbl.Location = new System.Drawing.Point(86, 85);
            this.PcnLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PcnLbl.Name = "PcnLbl";
            this.PcnLbl.Size = new System.Drawing.Size(46, 18);
            this.PcnLbl.TabIndex = 0;
            this.PcnLbl.Text = "label1";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(86, 132);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(46, 18);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "label2";
            // 
            // EditPersonBtn
            // 
            this.EditPersonBtn.Location = new System.Drawing.Point(382, 272);
            this.EditPersonBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditPersonBtn.Name = "EditPersonBtn";
            this.EditPersonBtn.Size = new System.Drawing.Size(112, 32);
            this.EditPersonBtn.TabIndex = 5;
            this.EditPersonBtn.Text = "Edit";
            this.EditPersonBtn.UseVisualStyleBackColor = true;
            this.EditPersonBtn.Click += new System.EventHandler(this.EditPersonBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(30, 272);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 4;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // WorkshopsList
            // 
            this.WorkshopsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader6});
            this.WorkshopsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkshopsList.FullRowSelect = true;
            this.WorkshopsList.HideSelection = false;
            this.WorkshopsList.Location = new System.Drawing.Point(259, 85);
            this.WorkshopsList.Name = "WorkshopsList";
            this.WorkshopsList.Size = new System.Drawing.Size(235, 140);
            this.WorkshopsList.TabIndex = 6;
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
            this.columnHeader1.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 83;
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Location = new System.Drawing.Point(35, 29);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(46, 18);
            this.RoleLbl.TabIndex = 7;
            this.RoleLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "PCN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // ViewWksBtn
            // 
            this.ViewWksBtn.Location = new System.Drawing.Point(179, 193);
            this.ViewWksBtn.Name = "ViewWksBtn";
            this.ViewWksBtn.Size = new System.Drawing.Size(74, 32);
            this.ViewWksBtn.TabIndex = 26;
            this.ViewWksBtn.Text = "View";
            this.ViewWksBtn.UseVisualStyleBackColor = true;
            this.ViewWksBtn.Click += new System.EventHandler(this.ViewWksBtn_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(256, 55);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(81, 18);
            this.a.TabIndex = 27;
            this.a.Text = "Enrolled in:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(256, 55);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(84, 18);
            this.b.TabIndex = 28;
            this.b.Text = "Lectures in:";
            // 
            // ViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 323);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.ViewWksBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.WorkshopsList);
            this.Controls.Add(this.EditPersonBtn);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PcnLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPerson";
            this.Text = "ViewPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PcnLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button EditPersonBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.ListView WorkshopsList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewWksBtn;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
    }
}