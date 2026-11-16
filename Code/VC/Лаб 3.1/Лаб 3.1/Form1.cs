using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лаб_3._1
{
    public partial class Form1 : Form
    {
        private Label tekstLabel;
        private int fontSize = 14;
        public Form1()
        {
            InitializeComponent();

            tekstLabel = new Label();
            tekstLabel.AutoSize = false; // дозволяє задавати власний розмір
            tekstLabel.Size = new Size(500, 400);
            tekstLabel.Location = new Point(20, 20);
            tekstLabel.Font = new Font("Times New Roman", fontSize);
            tekstLabel.ForeColor = Color.Black; // колір тексту
            tekstLabel.TextAlign = ContentAlignment.TopLeft;

            // текст українською
            tekstLabel.Text =
@"
Без надії таки сподіваюсь!
Буду жити! Геть думи сумні!
Я на вбогім сумнім перелозі
Буду сіять барвисті квітки,

Буду сіять квітки на морозі,
Буду лить на них сльози гіркі,
І від сліз тих гарячих розтане
Та кора льодовая, міцна,

Може, квіти зійдуть — і настане
Ще й для мене весела весна.";

            // додаємо лейбл на форму
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Hello, " + f.UserName);
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
                this.Controls.Add(tekstLabel);
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            tekstLabel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redColorText_Click(object sender, EventArgs e)
        {
            tekstLabel.ForeColor = Color.DarkRed;
        }

        private void defoltToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greenColorText_Click(object sender, EventArgs e)
        {
            tekstLabel.ForeColor = Color.DarkGreen;
        }

        private void blueColorText_Click(object sender, EventArgs e)
        {
            tekstLabel.ForeColor = Color.DarkBlue;
        }

        private void colorDefault_Click(object sender, EventArgs e)
        {
            tekstLabel.ForeColor = Color.Black;
        }

        private void textSizeplus_Click(object sender, EventArgs e)
        {
            fontSize += 1;
            tekstLabel.Font = new Font("Times New Roman", fontSize);
        }

        private void textSizeminuse_Click(object sender, EventArgs e)
        {
            fontSize -= 1;
            tekstLabel.Font = new Font("Times New Roman", fontSize);
        }

        private void textDefault_Click(object sender, EventArgs e)
        {
            fontSize = 14;
            tekstLabel.Font = new Font("Times New Roman", fontSize);
        }
    }
}
