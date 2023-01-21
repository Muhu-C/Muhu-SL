using MCSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSL
{
    public partial class MainPage : UserControl
    {
        public static Color CLR = Color.White;

        public static string Advanced = null;
        public static string MinRAM;
        public static string MaxRAM;
        public static string SERV_Pth;
        public static string SERV_Fle;
        public static string JAVA_Nme;
        public static string JAVA_Pth = "java";
        
        public MainPage()
        {
            MessageBox.Show("打开此程序时请关闭其他Java程序，以防数据丢失");
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            JAVA_Nme = Server.SearchJava(JAVA_Pth);
            JavaverText.Text = JAVA_Nme;
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        #region 查找
        private void SearchJava_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog1 = new OpenFileDialog
            {
                Filter = "Java|java.exe|所有文件|*.*",
                InitialDirectory = @"C:\"
            };
            if (FileDialog1.ShowDialog() == DialogResult.OK) { JAVA_Pth = FileDialog1.FileName; }
            JavaverText.Text = Server.SearchJava(JAVA_Pth);
            ServerConsole.JAVA_Pth = JAVA_Pth;
        }

        
        private void FindServer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SVfolderBrowser = new FolderBrowserDialog
            {
                Description = "请选择带有服务器API的文件夹",
                SelectedPath = @"C:\"
            };
            if (SVfolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK) { SERV_Pth = SVfolderBrowser.SelectedPath; }
            FolderAddress.Text = SERV_Pth;
            ServerConsole.SERV_Pth = SERV_Pth;
            try
            {
                var ServerFileList = Directory.GetFiles(SERV_Pth, "*.jar");
                int Files = ServerFileList.Count();
                if (Files > 1)
                {
                    MessageBox.Show("请规范放置服务器API", "提示");
                }
                else 
                {
                    LbServerAPI.Text = ServerFileList[0];
                    ServerConsole.SERV_Fle = ServerFileList[0];
                    ServerVersion.Text = Server.GetServerName(ServerConsole.SERV_Fle);
                }
            }
            catch (System.IO.DirectoryNotFoundException) { MessageBox.Show("未能找到路径" + "\"" + SERV_Pth + "\"", "错误"); }
        }
        #endregion

        #region 服务器内存
        private void WtbMinRAM_TextChanged(object sender, EventArgs e)
        {
            MinRAM = WtbMinRAM.Text;
            ServerConsole.MinRAM = MinRAM;
        }

        private void WtbMaxRAM_TextChanged(object sender, EventArgs e)
        {
            MaxRAM = WtbMaxRAM.Text;
            ServerConsole.MaxRAM = MaxRAM;
        }
        #endregion

        private void AdvancedSettings_TextChanged(object sender, EventArgs e)
        {
            Advanced = AdvancedSettings.Text;
        }
    }
}
