namespace Лаб_3._1
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
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            chanToolStripMenuItem = new ToolStripMenuItem();
            redColorText = new ToolStripMenuItem();
            greenColorText = new ToolStripMenuItem();
            blueColorText = new ToolStripMenuItem();
            colorDefault = new ToolStripMenuItem();
            changeTextSizeToolStripMenuItem = new ToolStripMenuItem();
            textSizeplus = new ToolStripMenuItem();
            textSizeminuse = new ToolStripMenuItem();
            textDefault = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(635, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(57, 24);
            loginToolStripMenuItem.Text = "login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(27, 24);
            toolStripMenuItem1.Text = " ";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { chanToolStripMenuItem, changeTextSizeToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(635, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.Visible = false;
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // chanToolStripMenuItem
            // 
            chanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redColorText, greenColorText, blueColorText, colorDefault });
            chanToolStripMenuItem.Name = "chanToolStripMenuItem";
            chanToolStripMenuItem.Size = new Size(111, 24);
            chanToolStripMenuItem.Text = "Change color";
            // 
            // redColorText
            // 
            redColorText.Name = "redColorText";
            redColorText.Size = new Size(224, 26);
            redColorText.Text = "Red";
            redColorText.Click += redColorText_Click;
            // 
            // greenColorText
            // 
            greenColorText.Name = "greenColorText";
            greenColorText.Size = new Size(224, 26);
            greenColorText.Text = "Green";
            greenColorText.Click += greenColorText_Click;
            // 
            // blueColorText
            // 
            blueColorText.Name = "blueColorText";
            blueColorText.Size = new Size(224, 26);
            blueColorText.Text = "Blue";
            blueColorText.Click += blueColorText_Click;
            // 
            // colorDefault
            // 
            colorDefault.Name = "colorDefault";
            colorDefault.Size = new Size(224, 26);
            colorDefault.Text = "Default";
            colorDefault.Click += colorDefault_Click;
            // 
            // changeTextSizeToolStripMenuItem
            // 
            changeTextSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textSizeplus, textSizeminuse, textDefault });
            changeTextSizeToolStripMenuItem.Name = "changeTextSizeToolStripMenuItem";
            changeTextSizeToolStripMenuItem.Size = new Size(131, 24);
            changeTextSizeToolStripMenuItem.Text = "Change text size";
            // 
            // textSizeplus
            // 
            textSizeplus.Name = "textSizeplus";
            textSizeplus.Size = new Size(224, 26);
            textSizeplus.Text = "+1";
            textSizeplus.Click += textSizeplus_Click;
            // 
            // textSizeminuse
            // 
            textSizeminuse.Name = "textSizeminuse";
            textSizeminuse.Size = new Size(224, 26);
            textSizeminuse.Text = "-1";
            textSizeminuse.Click += textSizeminuse_Click;
            // 
            // textDefault
            // 
            textDefault.Name = "textDefault";
            textDefault.Size = new Size(224, 26);
            textDefault.Text = "Default";
            textDefault.Click += textDefault_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 318);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem chanToolStripMenuItem;
        private ToolStripMenuItem changeTextSizeToolStripMenuItem;
        private ToolStripMenuItem redColorText;
        private ToolStripMenuItem greenColorText;
        private ToolStripMenuItem blueColorText;
        private Label label1;
        private ToolStripMenuItem textSizeplus;
        private ToolStripMenuItem textSizeminuse;
        private ToolStripMenuItem colorDefault;
        private ToolStripMenuItem textDefault;
    }
}
