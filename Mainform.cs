using System;
using MCSLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhuSL;

namespace MMSL
{
    public partial class Mainform : Form
    {
        public About AboutForm = new About();
        public static Color Backcolor = Color.Azure;
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            PageA.Visible = true;
            PageB.Visible = false;
            PageC.Visible = false;
        }

        private void ConsolePage_Click(object sender, EventArgs e)
        {
            PageB.Visible = true;
            PageA.Visible = false;
            PageC.Visible = false;
        }

        private void PluginsPage_Click(object sender, EventArgs e)
        {
            PageC.Visible = true;
            PageA.Visible = false;
            PageB.Visible = false;
        }

        private void 重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void 关于ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try { AboutForm.Show(); }
            catch (System.ObjectDisposedException)
            {
                AboutForm = new About();
                AboutForm.Show();
            }
        }

    }
}
