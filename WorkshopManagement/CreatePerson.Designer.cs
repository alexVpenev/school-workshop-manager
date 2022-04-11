namespace WorkshopManagementApp
{
    partial class CreatePerson
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
            this.PcnTbx = new System.Windows.Forms.TextBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.CreatePersonBtn = new System.Windows.Forms.Button();
            this.PersonTypeCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PcnTbx
            // 
            this.PcnTbx.Location = new System.Drawing.Point(91, 106);
            this.PcnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.PcnTbx.Name = "PcnTbx";
            this.PcnTbx.Size = new System.Drawing.Size(148, 24);
            this.PcnTbx.TabIndex = 0;
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(91, 153);
            this.NameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(148, 24);
            this.NameTbx.TabIndex = 1;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(13, 207);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 2;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // CreatePersonBtn
            // 
            this.CreatePersonBtn.Location = new System.Drawing.Point(133, 207);
            this.CreatePersonBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePersonBtn.Name = "CreatePersonBtn";
            this.CreatePersonBtn.Size = new System.Drawing.Size(112, 32);
            this.CreatePersonBtn.TabIndex = 3;
            this.CreatePersonBtn.Text = "Create";
            this.CreatePersonBtn.UseVisualStyleBackColor = true;
            this.CreatePersonBtn.Click += new System.EventHandler(this.CreatePersonBtn_Click);
            // 
            // PersonTypeCbx
            // 
            this.PersonTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonTypeCbx.FormattingEnabled = true;
            this.PersonTypeCbx.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.PersonTypeCbx.Location = new System.Drawing.Point(59, 57);
            this.PersonTypeCbx.Margin = new System.Windows.Forms.Padding(4);
            this.PersonTypeCbx.Name = "PersonTypeCbx";
            this.PersonTypeCbx.Size = new System.Drawing.Size(180, 26);
            this.PersonTypeCbx.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Choose a Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "*PCN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name:";
            // 
            // CreatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PersonTypeCbx);
            this.Controls.Add(this.CreatePersonBtn);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.PcnTbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatePerson";
            this.Text = "CreatePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PcnTbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button CreatePersonBtn;
        private System.Windows.Forms.ComboBox PersonTypeCbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}