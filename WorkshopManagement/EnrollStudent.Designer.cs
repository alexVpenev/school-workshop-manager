namespace WorkshopManagementApp
{
    partial class EnrollStudent
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
            this.EnrolledStudentsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnrollStudentBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnrolledStudentsList
            // 
            this.EnrolledStudentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.EnrolledStudentsList.FullRowSelect = true;
            this.EnrolledStudentsList.HideSelection = false;
            this.EnrolledStudentsList.Location = new System.Drawing.Point(13, 32);
            this.EnrolledStudentsList.Margin = new System.Windows.Forms.Padding(4);
            this.EnrolledStudentsList.Name = "EnrolledStudentsList";
            this.EnrolledStudentsList.Size = new System.Drawing.Size(474, 241);
            this.EnrolledStudentsList.TabIndex = 10;
            this.EnrolledStudentsList.UseCompatibleStateImageBehavior = false;
            this.EnrolledStudentsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PCN";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 307;
            // 
            // EnrollStudentBtn
            // 
            this.EnrollStudentBtn.Location = new System.Drawing.Point(495, 206);
            this.EnrollStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EnrollStudentBtn.Name = "EnrollStudentBtn";
            this.EnrollStudentBtn.Size = new System.Drawing.Size(112, 32);
            this.EnrollStudentBtn.TabIndex = 11;
            this.EnrollStudentBtn.Text = "Enroll";
            this.EnrollStudentBtn.UseVisualStyleBackColor = true;
            this.EnrollStudentBtn.Click += new System.EventHandler(this.EnrollStudentBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(495, 246);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(112, 32);
            this.GoBackBtn.TabIndex = 12;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select a Student to Enroll:";
            // 
            // EnrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.EnrollStudentBtn);
            this.Controls.Add(this.EnrolledStudentsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnrollStudent";
            this.Text = "EnrollStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EnrolledStudentsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button EnrollStudentBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Label label1;
    }
}