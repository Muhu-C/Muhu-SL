using MCSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSL
{
    public partial class ServerConsole : UserControl
    {
        public static string SERV_Pth = null;
        public static string SERV_Fle = null;
        public static string JAVA_Pth = "java";
        public static string MaxRAM = "128";
        public static string MinRAM = "2048";

        public System.Threading.Thread Server;
        public StreamWriter writer = null;
        public Process p = null;
        public bool RESET;
        public bool SvInfo;
        public string WriteC;
        public ServerConsole()
        {
            InitializeComponent();
        }

        private void ServerConsole_Load(object sender, EventArgs e)
        {

        }

        public void StartBotton_Click(object sender, EventArgs e)
        {
            if (SERV_Fle != null & MaxRAM != null & MinRAM != null)
            {
                if (SvInfo == false | RESET == true)
                {
                    TbOutput.Clear();
                    Server = new Thread(STS)
                    {
                        IsBackground = true
                    };
                    Server.Start();
                    SvInfo = true;
                }
                else { MessageBox.Show("服务器未关闭！", "提示"); }
                SvInfo = true;
            }
            else
            {
                MessageBox.Show("请填写服务器内存和服务器API位置", "错误");
            }
        }

        private void StopBotton_Click(object sender, EventArgs e)
        {
            WriteC = "stop";
            if (writer == null)
            {
                MessageBox.Show("服务器未开启", "提示");
                SvInfo = false;
            }
            else
            {
                try
                {
                    writer.WriteLine(WriteC);
                    SvInfo = false;
                }
                catch (System.ObjectDisposedException)
                {
                    MessageBox.Show("已设为关闭状态", "提示");
                    SvInfo = false;
                }
            }
        }

        private void KillJavaButton_Click(object sender, EventArgs e)
        {
            KillJava();
            TbOutput.AppendText("-------------------Java进程关闭成功-------------------\r\n");
            SvInfo = false;
        }




        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@函数区@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        #region 开启服务器
        public void STS()
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe")
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            p = Process.Start(start);
            writer = p.StandardInput;

            writer.WriteLine("cd " + SERV_Pth + "&" + SERV_Pth[0] + SERV_Pth[1]);
            if (SERV_Fle != null & MaxRAM != null & MinRAM != null) { writer.WriteLine(JAVA_Pth + " -jar " + SERV_Fle + " nogui Xms" + MinRAM + "M Xmx" + MaxRAM + "M" + MainPage.Advanced); }
            else
            {
                MessageBox.Show("请填写服务器内存和服务器API位置", "错误");
                WriteC = "exit";
                writer.WriteLine(WriteC);
            }

            p.OutputDataReceived += new DataReceivedEventHandler(Serveroutput);
            p.BeginOutputReadLine();
            p.WaitForExit();
            p.Close();
            writer.Close();
        }
        #endregion

        #region 服务器重定向输出
        void Serveroutput(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                ShowText(TbOutput, e.Data);
            }
        }
        #endregion

        private delegate void showTextDelegate(TextBox tb, string line);

        #region 判断服务器输出
        private async void ShowText(TextBox tb, string line)
        {
            if (tb.InvokeRequired)
            {
                showTextDelegate d = ShowText;
                object[] a = { tb, line };
                try { tb.Invoke(d, a); }
                catch { Console.WriteLine("A"); }
            }
            else
            {
                

                if (line.Length <= 20)
                {
                    if (line == SERV_Pth + ">exit")
                    { SvInfo = false; }
                    else { tb.AppendText(line + "\r\n"); }
                }
                if (line.Length > 20)
                {
                    if (line.Substring(line.Length - 13, 13) == "Timings Reset")
                    {
                        tb.AppendText("--------------------服务器开启成功--------------------\r\n");
                    }
                    try { tb.AppendText(line + "\r\n"); }
                    catch (System.ObjectDisposedException) { Console.WriteLine(""); }
                }

                if (line.Length > 32)
                {
                    if (line.Substring(line.Length - 19, 19) == "Closing Thread Pool")
                    {
                        await PutTaskDelay(500);
                        SvInfo = false;
                        WriteC = "exit";
                        writer.WriteLine(WriteC);
                        try
                        {
                            tb.AppendText("--------------------服务器关闭成功--------------------\r\n");
                        }
                        catch (System.ObjectDisposedException) { Console.WriteLine(""); }
                    }
                    if (line.Substring(line.Length - 23, 23) == "FAILED TO BIND TO PORT!")
                    {
                        try
                        {
                            tb.AppendText("--------------------服务器端口被占用！--------------------\r\n");
                        }
                        catch (System.ObjectDisposedException) { Console.WriteLine(""); }
                    }
                    if (line == "java.io.IOException: 另一个程序已锁定文件的一部分，进程无法访问。")
                    {
                        await PutTaskDelay(500);
                        SvInfo = false;
                        WriteC = "exit";
                        writer.WriteLine(WriteC);
                    }
                }
                if (line.Length > 48) 
                {
                    if (line.Substring(line.Length - 29, 29) == "Go to eula.txt for more info.")
                    {

                        WriteC = "exit";
                        writer.WriteLine(WriteC);
                        Server.Abort();
                        Process.Start("https://www.minecraft.net/en-us/eula");
                        if (MessageBox.Show("是否同意协议？", "设置", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            StreamWriter sw = new StreamWriter(SERV_Pth + "\\eula.txt");
                            sw.Write("eula=true");
                            sw.Flush();
                            sw.Close();
                            RESET = true;
                            StartBotton_Click(null, null);
                        }
                        else
                        {
                            Console.WriteLine("N");
                            writer.WriteLine("exit");
                            SvInfo = false;
                        }
                    }
                }
            }
        }
        #endregion

        async Task PutTaskDelay(int msec)
        {
            await Task.Delay(msec);
        }

        private void KillJava()
        {
            System.Diagnostics.Process[] myProgress;
            myProgress = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process p in myProgress)
            {
                if (p.ProcessName == "java")
                {
                    p.Kill();
                }
            }
        }


    }
}
