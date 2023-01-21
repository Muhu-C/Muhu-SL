using MMSL;
using System;
using MCSLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhuSL
{
    public partial class Plugins : UserControl
    {
        public static string Plugin;
        public static string PluginFullName;
        public static string PluginVersion;
        public static bool PluginChooseState = false;
        public Plugins()
        {
            InitializeComponent();
        }

        private void ChoosePlugin_Click(object sender, EventArgs e)
        {

            OpenFileDialog FileDialog1 = new OpenFileDialog
            {
                Filter = "Java文件|*.jar",
                InitialDirectory = ServerConsole.SERV_Pth
            };
            if (FileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Plugin = @FileDialog1.FileName; ;
                    PluginFullName = Server.GetPluginName(Plugin);
                    PluginVersion = Server.GetPluginVersion(Plugin);
                    LbPluginName.Text = PluginFullName;
                    LbPluginVersion.Text = PluginVersion;
                    LbPluginAddress.Text = Plugin;
                    LbPluginFolderAddress.Text = ServerConsole.SERV_Pth + "\\plugins\\" + PluginFullName + "\\";
                }
                catch(System.IO.FileNotFoundException)
                {
                    MessageBox.Show("你选择的不是插件", "错误");
                }
            }
            PluginChooseState = true;
        }

        private void AddPlugin_Click(object sender, EventArgs e)
        {
            string Plugin;
            string PluginName;
            OpenFileDialog FileDialog1 = new OpenFileDialog
            {
                Filter = "Java文件|*.jar",
                InitialDirectory = @"C:\"
            };
            if (FileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                @Plugin = FileDialog1.FileName;
                PluginName = Path.GetFileName(Plugin);
                
                try
                {
                    File.Copy(Plugin, ServerConsole.SERV_Pth + "\\plugins\\" + PluginName);
                    MessageBox.Show("添加成功，源文件未删除", "提示");
                }
                catch (System.IO.IOException) { MessageBox.Show("已有的文件或未选择服务器文件夹", "错误"); }
            }
        }

        private void DeletePlugin_Click(object sender, EventArgs e)
        {
            if(PluginChooseState)
            {
                if (MessageBox.Show("是否删除此插件？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(Plugin);
                    if (ServerConsole.SERV_Pth != null)
                    {
                        try
                        {
                            FileProcess.DeleteFolder(ServerConsole.SERV_Pth + "\\plugins\\" + PluginFullName);
                            MessageBox.Show("删除成功", "提示");
                        }
                        catch (System.IO.DirectoryNotFoundException) { MessageBox.Show("删除成功", "提示"); }
                    }
                    else
                    {
                        MessageBox.Show("请选择服务器位置！", "错误");
                    }
                }
            }
        }
    }
}
