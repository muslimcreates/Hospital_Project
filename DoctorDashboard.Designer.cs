namespace Hospital_Project
{
    partial class DoctorDashboard
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
            btnViewInfo = new Button();
            btnViewAppointments = new Button();
            listBoxAppointments = new ListBox();
            SuspendLayout();
            // 
            // btnViewInfo
            // 
            btnViewInfo.Location = new Point(138, 41);
            btnViewInfo.Name = "btnViewInfo";
            btnViewInfo.Size = new Size(164, 63);
            btnViewInfo.TabIndex = 0;
            btnViewInfo.Text = "View my Info";
            btnViewInfo.UseVisualStyleBackColor = true;
            btnViewInfo.Click += btnViewInfo_Click;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Location = new Point(129, 187);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(182, 58);
            btnViewAppointments.TabIndex = 1;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            // 
            // listBoxAppointments
            // 
            listBoxAppointments.FormattingEnabled = true;
            listBoxAppointments.ItemHeight = 25;
            listBoxAppointments.Location = new Point(373, 41);
            listBoxAppointments.Name = "listBoxAppointments";
            listBoxAppointments.Size = new Size(377, 204);
            listBoxAppointments.TabIndex = 2;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxAppointments);
            Controls.Add(btnViewAppointments);
            Controls.Add(btnViewInfo);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewInfo;
        private Button btnViewAppointments;
        private ListBox listBoxAppointments;
    }
}