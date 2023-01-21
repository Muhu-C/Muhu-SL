using System;
using MCSLib;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhuSL
{
    public partial class Download : UserControl
    {
        public static string[] DownloadClass =
        {
            "Java - JRE",
            "PaperAPI - 服务器API",
            "SpigotAPI - 服务器API"
        };
        public static string[] JreDownload =
        {
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-JREDownloads/releases/download/MuhuSL-Java-Downloads/OpenJDK18U-jre_x64_windows_hotspot_18.0.2.1_1.msi",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-JREDownloads/releases/download/MuhuSL-Java-Downloads/OpenJDK17U-jre_x64_windows_hotspot_17.0.5_8.msi",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-JREDownloads/releases/download/MuhuSL-Java-Downloads/OpenJDK11U-jre_x64_windows_hotspot_2023-01-13-05-36.msi",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-JREDownloads/releases/download/MuhuSL-Java-Downloads/OpenJDK8U-jre_x64_windows_hotspot_8u352b08.msi",
        };
        public static string[] PaperAPIDownload =
        {
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.19.3-381.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.18.2-388.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.17.1-411.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.16.5-794.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.15.2-393.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.14.4-245.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.13.2-657.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.12.2-1620.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.11.2-1106.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.10.2-918.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.9.4-775.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/MuhuSL-PaperDownloads/releases/download/MuhuSL-Paper/paper-1.8.8-445.jar",
        };
        public static string[] SpigotAPIDownload =
        {
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.19.3.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.18.2.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.17.1.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.16.5.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.15.2.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.14.4.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.13.2.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.12.2.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.11,2.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.10.2-R0.1-SNAPSHOT-latest.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.9.4-R0.1-SNAPSHOT-latest.jar",
            "https://ghdl.feizhuqwq.cf/https://github.com/Muhu-C/Spigot-Downloads/releases/download/MuhuSL-Spigot/spigot-1.8.8-R0.1-SNAPSHOT-latest.jar",
        };
        public static string[] Jre =
        {
            "Jre 18 - Java",
            "Jre 17 - Java",
            "Jre 11 - Java",
            "Jre 8 - Java",
        };
        public static string[] Paper =
        {
            "Paper 1.19.3 Latest",
            "Paper 1.18.2 Latest",
            "Paper 1.17.1 Latest",
            "Paper 1.16.5 Latest",
            "Paper 1.15.2 Latest",
            "Paper 1.14.4 Latest",
            "Paper 1.13.2 Latest",
            "Paper 1.12.2 Latest",
            "Paper 1.11.2 Latest",
            "Paper 1.10.2 Latest",
            "Paper 1.9.4 Latest",
            "Paper 1.8.8 Latest"
        };
        public static string[] Spigot =
        {
            "Spigot 1.19.3 Latest",
            "Spigot 1.18.2 Latest",
            "Spigot 1.17.1 Latest",
            "Spigot 1.16.5 Latest",
            "Spigot 1.15.2 Latest",
            "Spigot 1.14.4 Latest",
            "Spigot 1.13.2 Latest",
            "Spigot 1.12.2 Latest",
            "Spigot 1.11.2 Latest",
            "Spigot 1.10.2 Latest",
            "Spigot 1.9.4 Latest",
            "Spigot 1.8.8 Latest"
        };

        public static int DownloadItems = -1;
        public static int DownloadIndex = -1;

        public Download()
        {
            InitializeComponent();
        }

        private void Download_Load(object sender, EventArgs e)
        {
            ComboBoxA.Items.AddRange(DownloadClass);
        }

        private void ConboBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxB.Items.Clear();
            if (ComboBoxA.SelectedIndex == 0)
            {
                ComboBoxB.Items.AddRange(Jre);
                DownloadItems = 0; 
            }
            else if (ComboBoxA.SelectedIndex == 1) 
            {
                ComboBoxB.Items.AddRange(Paper);
                DownloadItems = 1;
            }
            else if (ComboBoxA.SelectedIndex == 2) 
            {
                ComboBoxB.Items.AddRange(Spigot);
                DownloadItems = 2;
            }
        }

        private void ComboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DownloadIndex = ComboBoxB.SelectedIndex;
        }

        private void DownloadBotton_Click(object sender, EventArgs e)
        {
            if (DownloadItems != -1)
            {
                string[][] TOTALINDEX = { JreDownload, PaperAPIDownload, SpigotAPIDownload };//总索引
                string[] TOTALDOWNLOADITEMS = TOTALINDEX[DownloadItems];//选择区域索引
                string TOTALDOWNLOADFILE = TOTALDOWNLOADITEMS[DownloadIndex];//要下载的文件

                if (DownloadItems == 0)
                {
                    SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Title = "保存文件的位置",
                        Filter = "安装包文件(*.msi)|*.msi",
                    };
                    if(saveFile.ShowDialog() == DialogResult.OK)
                    {
                        DownloadInfo.Text = "下载中 ??.??%";
                        DownloadInfo.ForeColor = Color.Red;
                        FileProcess.DownloadFile(TOTALDOWNLOADFILE, saveFile.FileName, PBForDownloadInfo, DownloadInfo);
                        DownloadInfo.Text = "下载完成";
                        DownloadInfo.ForeColor = Color.Green;
                    }
                }
                else if (DownloadItems == 1 | DownloadItems == 2)
                {
                    MessageBox.Show(TOTALDOWNLOADFILE);
                    SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Title = "保存文件的位置",
                        Filter = "Minecraft服务器API文件(*.jar)|*.jar",
                    };
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(saveFile.FileName);
                        DownloadInfo.Text = "下载中 ??.??%";
                        DownloadInfo.ForeColor = Color.Red;
                        FileProcess.DownloadFile(TOTALDOWNLOADFILE, saveFile.FileName, PBForDownloadInfo, DownloadInfo);
                        DownloadInfo.Text = "下载完成";
                        DownloadInfo.ForeColor = Color.Green;
                    }
                }
            }
        }
    }
}
