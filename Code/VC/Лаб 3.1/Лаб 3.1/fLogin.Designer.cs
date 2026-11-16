namespace Лаб_3._1
{
    partial class fLogin
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
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEnter = new Button();
            btnExit = new Button();
            chbViewPassword = new CheckBox();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(126, 34);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(150, 27);
            tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(126, 81);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(150, 27);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 84);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnEnter
            // 
            btnEnter.DialogResult = DialogResult.OK;
            btnEnter.Location = new Point(40, 126);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(236, 29);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Cancel;
            btnExit.Location = new Point(40, 170);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(236, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chbViewPassword
            // 
            chbViewPassword.AutoSize = true;
            chbViewPassword.Location = new Point(282, 83);
            chbViewPassword.Name = "chbViewPassword";
            chbViewPassword.Size = new Size(52, 24);
            chbViewPassword.TabIndex = 6;
            chbViewPassword.Text = "👁";
            chbViewPassword.UseVisualStyleBackColor = true;
            chbViewPassword.CheckedChanged += chbViewPassword_CheckedChanged;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 251);
            Controls.Add(chbViewPassword);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Name = "fLogin";
            Text = "x`";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnEnter;
        private Button btnExit;
        private CheckBox chbViewPassword;
    }
}