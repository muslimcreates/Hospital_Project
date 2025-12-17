namespace Hospital_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comborole = new ComboBox();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // comborole
            // 
            comborole.DropDownStyle = ComboBoxStyle.DropDownList;
            comborole.FormattingEnabled = true;
            comborole.Items.AddRange(new object[] { "Admin", "Doctor", "Patient" });
            comborole.Location = new Point(267, 42);
            comborole.Name = "comborole";
            comborole.Size = new Size(182, 33);
            comborole.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 1;
            label1.Text = "Role";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(267, 123);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(182, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 126);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 208);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(267, 205);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(182, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(268, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(comborole);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comborole;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private Button btnLogin;
    }
}
