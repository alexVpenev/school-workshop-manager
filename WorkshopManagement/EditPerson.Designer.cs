namespace WorkshopManagementApp
{
    partial class EditPerson
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
            this.EditWksBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PcnTbx
            // 
            this.PcnTbx.Location = new System.Drawing.Point(141, 36);
            this.PcnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.PcnTbx.Name = "PcnTbx";
            this.PcnTbx.Size = new System.Drawing.Size(148, 24);
            this.PcnTbx.TabIndex = 0;
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(141, 87);
            this.NameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(148, 24);
            this.NameTbx.TabIndex = 1;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(29, 142);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 16;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // EditWksBtn
            // 
            this.EditWksBtn.Location = new System.Drawing.Point(177, 142);
            this.EditWksBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditWksBtn.Name = "EditWksBtn";
            this.EditWksBtn.Size = new System.Drawing.Size(112, 32);
            this.EditWksBtn.TabIndex = 15;
            this.EditWksBtn.Text = "Save Changes";
            this.EditWksBtn.UseVisualStyleBackColor = true;
            this.EditWksBtn.Click += new System.EventHandler(this.EditWksBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Change Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Change PCN:";
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.EditWksBtn);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.PcnTbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditPerson";
            this.Text = "EditPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PcnTbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button EditWksBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}