namespace Lb2._2
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            textToolStripMenuItem = new ToolStripMenuItem();
            saveTextToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            clearTextToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { textToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveTextToolStripMenuItem, clearTextToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(50, 24);
            textToolStripMenuItem.Text = "Text";
            // 
            // saveTextToolStripMenuItem
            // 
            saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            saveTextToolStripMenuItem.Size = new Size(224, 26);
            saveTextToolStripMenuItem.Text = "Save text";
            saveTextToolStripMenuItem.Click += saveTextToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 422);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // clearTextToolStripMenuItem
            // 
            clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            clearTextToolStripMenuItem.Size = new Size(224, 26);
            clearTextToolStripMenuItem.Text = "Clear text";
            clearTextToolStripMenuItem.Click += clearTextToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem textToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem saveTextToolStripMenuItem;
        private ToolStripMenuItem clearTextToolStripMenuItem;
    }
}