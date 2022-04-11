namespace WorkshopManagementApp
{
    partial class CreateWorkshop
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
            this.titleTbx = new System.Windows.Forms.TextBox();
            this.descriptionTbx = new System.Windows.Forms.TextBox();
            this.capacityTbx = new System.Windows.Forms.TextBox();
            this.addressTbx = new System.Windows.Forms.TextBox();
            this.roomNrTbx = new System.Windows.Forms.TextBox();
            this.CreateWorkshopBtn = new System.Windows.Forms.Button();
            this.TeacherList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WksTypeCbx = new System.Windows.Forms.ComboBox();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTbx
            // 
            this.titleTbx.Location = new System.Drawing.Point(135, 93);
            this.titleTbx.Margin = new System.Windows.Forms.Padding(4);
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.Size = new System.Drawing.Size(180, 24);
            this.titleTbx.TabIndex = 1;
            // 
            // descriptionTbx
            // 
            this.descriptionTbx.Location = new System.Drawing.Point(135, 129);
            this.descriptionTbx.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTbx.Multiline = true;
            this.descriptionTbx.Name = "descriptionTbx";
            this.descriptionTbx.Size = new System.Drawing.Size(180, 64);
            this.descriptionTbx.TabIndex = 2;
            // 
            // capacityTbx
            // 
            this.capacityTbx.Location = new System.Drawing.Point(135, 201);
            this.capacityTbx.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTbx.Name = "capacityTbx";
            this.capacityTbx.Size = new System.Drawing.Size(44, 24);
            this.capacityTbx.TabIndex = 3;
            // 
            // addressTbx
            // 
            this.addressTbx.Location = new System.Drawing.Point(135, 233);
            this.addressTbx.Margin = new System.Windows.Forms.Padding(4);
            this.addressTbx.Name = "addressTbx";
            this.addressTbx.Size = new System.Drawing.Size(180, 24);
            this.addressTbx.TabIndex = 4;
            // 
            // roomNrTbx
            // 
            this.roomNrTbx.Location = new System.Drawing.Point(167, 265);
            this.roomNrTbx.Margin = new System.Windows.Forms.Padding(4);
            this.roomNrTbx.Name = "roomNrTbx";
            this.roomNrTbx.Size = new System.Drawing.Size(148, 24);
            this.roomNrTbx.TabIndex = 5;
            // 
            // CreateWorkshopBtn
            // 
            this.CreateWorkshopBtn.Location = new System.Drawing.Point(279, 509);
            this.CreateWorkshopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateWorkshopBtn.Name = "CreateWorkshopBtn";
            this.CreateWorkshopBtn.Size = new System.Drawing.Size(112, 32);
            this.CreateWorkshopBtn.TabIndex = 6;
            this.CreateWorkshopBtn.Text = "Create";
            this.CreateWorkshopBtn.UseVisualStyleBackColor = true;
            this.CreateWorkshopBtn.Click += new System.EventHandler(this.CreateWorkshopBtn_Click);
            // 
            // TeacherList
            // 
            this.TeacherList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.TeacherList.FullRowSelect = true;
            this.TeacherList.HideSelection = false;
            this.TeacherList.Location = new System.Drawing.Point(13, 336);
            this.TeacherList.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(378, 149);
            this.TeacherList.TabIndex = 7;
            this.TeacherList.UseCompatibleStateImageBehavior = false;
            this.TeacherList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PCN";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 242;
            // 
            // WksTypeCbx
            // 
            this.WksTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WksTypeCbx.FormattingEnabled = true;
            this.WksTypeCbx.Items.AddRange(new object[] {
            "In Building",
            "Online"});
            this.WksTypeCbx.Location = new System.Drawing.Point(52, 59);
            this.WksTypeCbx.Margin = new System.Windows.Forms.Padding(4);
            this.WksTypeCbx.Name = "WksTypeCbx";
            this.WksTypeCbx.Size = new System.Drawing.Size(263, 26);
            this.WksTypeCbx.TabIndex = 8;
            this.WksTypeCbx.SelectedIndexChanged += new System.EventHandler(this.WksTypeCbx_SelectedIndexChanged);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(13, 509);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 9;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desription:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(49, 204);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 18);
            this.a.TabIndex = 14;
            this.a.Text = "*Capacity:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(49, 236);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(66, 18);
            this.b.TabIndex = 15;
            this.b.Text = "Address:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(49, 268);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(117, 18);
            this.c.TabIndex = 16;
            this.c.Text = "*Room Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Choose a Type of Workshop";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Choose a Lecturer:";
            // 
            // CreateWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.WksTypeCbx);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.CreateWorkshopBtn);
            this.Controls.Add(this.roomNrTbx);
            this.Controls.Add(this.addressTbx);
            this.Controls.Add(this.capacityTbx);
            this.Controls.Add(this.descriptionTbx);
            this.Controls.Add(this.titleTbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateWorkshop";
            this.Text = "CreateWorkshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleTbx;
        private System.Windows.Forms.TextBox descriptionTbx;
        private System.Windows.Forms.TextBox capacityTbx;
        private System.Windows.Forms.TextBox addressTbx;
        private System.Windows.Forms.TextBox roomNrTbx;
        private System.Windows.Forms.Button CreateWorkshopBtn;
        private System.Windows.Forms.ListView TeacherList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox WksTypeCbx;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}