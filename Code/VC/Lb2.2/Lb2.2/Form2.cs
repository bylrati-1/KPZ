using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2._2
{
    public partial class Form2 : Form
    {
        private string filePath;


        public Form2()
        {
            InitializeComponent();
            InitFilePath();
        }

        public Form2(int number)
        {
            InitializeComponent();
            Text = "Document" + number.ToString();
            InitFilePath();
        }
        private void InitFilePath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (string.IsNullOrEmpty(appData))
            {
                appData = Application.StartupPath;
            }

            filePath = Path.Combine(appData, "savedText.txt");

            if (File.Exists(filePath))
            {
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(filePath, richTextBox1.Text);
                MessageBox.Show("Текст сохранён!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении:\n" + ex.Message);
            }
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            File.WriteAllText(filePath, string.Empty);
        }
    }
}
