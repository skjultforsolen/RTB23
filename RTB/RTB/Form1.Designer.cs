namespace RTB
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            settingsButton = new Button();
            toolTipSettings = new ToolTip(components);
            panelLogin = new Panel();
            labelPassword = new Label();
            labelUsername = new Label();
            labelLogin = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(137, 416);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 0;
            label1.Text = "No Internet Connection!";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(175, 61);
            label2.Name = "label2";
            label2.Size = new Size(153, 54);
            label2.TabIndex = 1;
            label2.Text = "RTB 1.1";
            label2.Click += label2_Click;
            // 
            // settingsButton
            // 
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Image = Properties.Resources.settings_icon2;
            settingsButton.Location = new Point(12, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(45, 45);
            settingsButton.TabIndex = 2;
            toolTipSettings.SetToolTip(settingsButton, "Einstellungen");
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += button1_Click;
            // 
            // toolTipSettings
            // 
            toolTipSettings.Popup += toolTip1_Popup;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.ActiveCaption;
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Controls.Add(labelLogin);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Controls.Add(textBox1);
            panelLogin.Location = new Point(110, 158);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(250, 140);
            panelLogin.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(9, 90);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password:";
            labelPassword.Click += label3_Click_2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(9, 54);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(78, 20);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Username:";
            labelUsername.Click += label3_Click_1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(94, 12);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Login";
            labelLogin.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panelLogin);
            Controls.Add(settingsButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Remote Telefonbuch";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button settingsButton;
        private ToolTip toolTipSettings;
        private Panel panelLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelLogin;
        private Label labelUsername;
        private Label labelPassword;
    }
}
