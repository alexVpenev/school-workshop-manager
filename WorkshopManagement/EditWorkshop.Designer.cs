namespace WorkshopManagementApp
{
    partial class EditWorkshop
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
            this.roomNrTbx = new System.Windows.Forms.TextBox();
            this.addressTbx = new System.Windows.Forms.TextBox();
            this.capacityTbx = new System.Windows.Forms.TextBox();
            this.descriptionTbx = new System.Windows.Forms.TextBox();
            this.titleTbx = new System.Windows.Forms.TextBox();
            this.EditWksBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomNrTbx
            // 
            this.roomNrTbx.Location = new System.Drawing.Point(201, 151);
            this.roomNrTbx.Margin = new System.Windows.Forms.Padding(4);
            this.roomNrTbx.Name = "roomNrTbx";
            this.roomNrTbx.Size = new System.Drawing.Size(148, 24);
            this.roomNrTbx.TabIndex = 11;
            // 
            // addressTbx
            // 
            this.addressTbx.Location = new System.Drawing.Point(201, 121);
            this.addressTbx.Margin = new System.Windows.Forms.Padding(4);
            this.addressTbx.Name = "addressTbx";
            this.addressTbx.Size = new System.Drawing.Size(148, 24);
            this.addressTbx.TabIndex = 10;
            // 
            // capacityTbx
            // 
            this.capacityTbx.Location = new System.Drawing.Point(201, 89);
            this.capacityTbx.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTbx.Name = "capacityTbx";
            this.capacityTbx.Size = new System.Drawing.Size(148, 24);
            this.capacityTbx.TabIndex = 9;
            // 
            // descriptionTbx
            // 
            this.descriptionTbx.Location = new System.Drawing.Point(201, 55);
            this.descriptionTbx.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTbx.Name = "descriptionTbx";
            this.descriptionTbx.Size = new System.Drawing.Size(148, 24);
            this.descriptionTbx.TabIndex = 8;
            // 
            // titleTbx
            // 
            this.titleTbx.Location = new System.Drawing.Point(201, 23);
            this.titleTbx.Margin = new System.Windows.Forms.Padding(4);
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.Size = new System.Drawing.Size(148, 24);
            this.titleTbx.TabIndex = 7;
            // 
            // EditWksBtn
            // 
            this.EditWksBtn.Location = new System.Drawing.Point(201, 207);
            this.EditWksBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditWksBtn.Name = "EditWksBtn";
            this.EditWksBtn.Size = new System.Drawing.Size(112, 32);
            this.EditWksBtn.TabIndex = 13;
            this.EditWksBtn.Text = "Save Changes";
            this.EditWksBtn.UseVisualStyleBackColor = true;
            this.EditWksBtn.Click += new System.EventHandler(this.EditWksBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(40, 207);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 14;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Change Desription:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Change Title:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(27, 124);
            this.b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(121, 18);
            this.b.TabIndex = 17;
            this.b.Text = "Change Address:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(27, 154);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(172, 18);
            this.c.TabIndex = 18;
            this.c.Text = "*Change Room Number:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(27, 92);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(130, 18);
            this.a.TabIndex = 19;
            this.a.Text = "*Change Capacity:";
            // 
            // EditWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 254);
            this.Controls.Add(this.a);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.EditWksBtn);
            this.Controls.Add(this.roomNrTbx);
            this.Controls.Add(this.addressTbx);
            this.Controls.Add(this.capacityTbx);
            this.Controls.Add(this.descriptionTbx);
            this.Controls.Add(this.titleTbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditWorkshop";
            this.Text = "EditWorkshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomNrTbx;
        private System.Windows.Forms.TextBox addressTbx;
        private System.Windows.Forms.TextBox capacityTbx;
        private System.Windows.Forms.TextBox descriptionTbx;
        private System.Windows.Forms.TextBox titleTbx;
        private System.Windows.Forms.Button EditWksBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label a;
    }
}