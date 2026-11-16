using System.Windows.Forms;

namespace Lb2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number = 1;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(number);
            number++;
            f.MdiParent = this;
            f.Show();
        }

        private void gascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                this.ActiveMdiChild.Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* for(int i=0; i<this.MdiChildren.Count(); i++)
                 this.MdiChildren[i].Close();*/
            foreach (Form f in MdiChildren)
              f.Close();
        }
    }
}
