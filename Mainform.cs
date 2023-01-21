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

        #region 优化
        public Mainform()
        {
            MessageBox.Show("打开此程序时请关闭其他Java程序，以防数据丢失");
            InitializeComponent();
        }
        
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }
        #endregion


        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            PageA.Visible = true;
            PageB.Visible = false;
            PageC.Visible = false;
            PageD.Visible = false;
        }

        private void ConsolePage_Click(object sender, EventArgs e)
        {
            PageB.Visible = true;
            PageA.Visible = false;
            PageC.Visible = false;
            PageD.Visible = false;
        }

        private void PluginsPage_Click(object sender, EventArgs e)
        {
            PageC.Visible = true;
            PageA.Visible = false;
            PageB.Visible = false;
            PageD.Visible = false;
        }

        private void DownloadPage_Click(object sender, EventArgs e)
        {
            PageD.Visible = true;
            PageA.Visible = false;
            PageB.Visible = false;
            PageC.Visible = false;
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
