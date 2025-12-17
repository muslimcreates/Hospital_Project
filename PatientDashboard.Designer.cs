namespace Hospital_Project
{
    partial class PatientDashboard
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
            btnMakeAppointment = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBoxDoctors = new ComboBox();
            label1 = new Label();
            btnViewInfo = new Button();
            SuspendLayout();
            // 
            // btnMakeAppointment
            // 
            btnMakeAppointment.Location = new Point(178, 267);
            btnMakeAppointment.Name = "btnMakeAppointment";
            btnMakeAppointment.Size = new Size(283, 49);
            btnMakeAppointment.TabIndex = 11;
            btnMakeAppointment.Text = "Make Appointment";
            btnMakeAppointment.UseVisualStyleBackColor = true;
            btnMakeAppointment.Click += btnMakeAppointment_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(261, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 128);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 9;
            label2.Text = "Appointment Date/Time";
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(387, 55);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(182, 33);
            comboBoxDoctors.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 58);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 7;
            label1.Text = "Select Doctor";
            // 
            // btnViewInfo
            // 
            btnViewInfo.Location = new Point(54, 46);
            btnViewInfo.Name = "btnViewInfo";
            btnViewInfo.Size = new Size(166, 49);
            btnViewInfo.TabIndex = 6;
            btnViewInfo.Text = "View Info";
            btnViewInfo.UseVisualStyleBackColor = true;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMakeAppointment);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(comboBoxDoctors);
            Controls.Add(label1);
            Controls.Add(btnViewInfo);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMakeAppointment;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBoxDoctors;
        private Label label1;
        private Button btnViewInfo;
    }
}