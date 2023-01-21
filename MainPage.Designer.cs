using System.Drawing;

namespace MMSL
{
    partial class MainPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.H1 = new System.Windows.Forms.Label();
            this.H2 = new System.Windows.Forms.Label();
            this.TextforServerFolderAddress = new System.Windows.Forms.Label();
            this.ServerInfoPanel = new System.Windows.Forms.Panel();
            this.ServerVersion = new System.Windows.Forms.Label();
            this.TextForServerVersion = new System.Windows.Forms.Label();
            this.LbServerAPI = new System.Windows.Forms.Label();
            this.TextForServerAPIAddress = new System.Windows.Forms.Label();
            this.JavaverText = new System.Windows.Forms.Label();
            this.TextForJavaVersion = new System.Windows.Forms.Label();
            this.FolderAddress = new System.Windows.Forms.Label();
            this.FindServer = new System.Windows.Forms.Button();
            this.SearchJava = new System.Windows.Forms.Button();
            this.TextForServerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdvancedSettings = new System.Windows.Forms.TextBox();
            this.WtbMaxRAM = new MMSL.WaterTextbox();
            this.WtbMinRAM = new MMSL.WaterTextbox();
            this.ServerInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.Transparent;
            this.H1.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.H1.Location = new System.Drawing.Point(0, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(1150, 107);
            this.H1.TabIndex = 0;
            this.H1.Text = "Muhu SL 主页";
            this.H1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.H1.Click += new System.EventHandler(this.H1_Click);
            // 
            // H2
            // 
            this.H2.AutoSize = true;
            this.H2.BackColor = System.Drawing.Color.Transparent;
            this.H2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.H2.Location = new System.Drawing.Point(24, 12);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(150, 35);
            this.H2.TabIndex = 1;
            this.H2.Text = "服务器信息";
            // 
            // TextforServerFolderAddress
            // 
            this.TextforServerFolderAddress.AutoSize = true;
            this.TextforServerFolderAddress.BackColor = System.Drawing.Color.Transparent;
            this.TextforServerFolderAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextforServerFolderAddress.Location = new System.Drawing.Point(65, 57);
            this.TextforServerFolderAddress.Name = "TextforServerFolderAddress";
            this.TextforServerFolderAddress.Size = new System.Drawing.Size(135, 24);
            this.TextforServerFolderAddress.TabIndex = 2;
            this.TextforServerFolderAddress.Text = "服务器位置";
            // 
            // ServerInfoPanel
            // 
            this.ServerInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ServerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerInfoPanel.Controls.Add(this.ServerVersion);
            this.ServerInfoPanel.Controls.Add(this.TextForServerVersion);
            this.ServerInfoPanel.Controls.Add(this.LbServerAPI);
            this.ServerInfoPanel.Controls.Add(this.TextForServerAPIAddress);
            this.ServerInfoPanel.Controls.Add(this.JavaverText);
            this.ServerInfoPanel.Controls.Add(this.TextForJavaVersion);
            this.ServerInfoPanel.Controls.Add(this.FolderAddress);
            this.ServerInfoPanel.Controls.Add(this.H2);
            this.ServerInfoPanel.Controls.Add(this.TextforServerFolderAddress);
            this.ServerInfoPanel.Location = new System.Drawing.Point(0, 130);
            this.ServerInfoPanel.Name = "ServerInfoPanel";
            this.ServerInfoPanel.Size = new System.Drawing.Size(1150, 220);
            this.ServerInfoPanel.TabIndex = 3;
            this.ServerInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerInfoPanel_Paint);
            // 
            // ServerVersion
            // 
            this.ServerVersion.AutoSize = true;
            this.ServerVersion.BackColor = System.Drawing.Color.Transparent;
            this.ServerVersion.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerVersion.Location = new System.Drawing.Point(361, 173);
            this.ServerVersion.Name = "ServerVersion";
            this.ServerVersion.Size = new System.Drawing.Size(62, 24);
            this.ServerVersion.TabIndex = 9;
            this.ServerVersion.Text = "NONE";
            // 
            // TextForServerVersion
            // 
            this.TextForServerVersion.AutoSize = true;
            this.TextForServerVersion.BackColor = System.Drawing.Color.Transparent;
            this.TextForServerVersion.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForServerVersion.Location = new System.Drawing.Point(65, 173);
            this.TextForServerVersion.Name = "TextForServerVersion";
            this.TextForServerVersion.Size = new System.Drawing.Size(135, 24);
            this.TextForServerVersion.TabIndex = 8;
            this.TextForServerVersion.Text = "服务器版本";
            // 
            // LbServerAPI
            // 
            this.LbServerAPI.AutoSize = true;
            this.LbServerAPI.BackColor = System.Drawing.Color.Transparent;
            this.LbServerAPI.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbServerAPI.Location = new System.Drawing.Point(361, 134);
            this.LbServerAPI.Name = "LbServerAPI";
            this.LbServerAPI.Size = new System.Drawing.Size(62, 24);
            this.LbServerAPI.TabIndex = 7;
            this.LbServerAPI.Text = "NONE";
            // 
            // TextForServerAPIAddress
            // 
            this.TextForServerAPIAddress.AutoSize = true;
            this.TextForServerAPIAddress.BackColor = System.Drawing.Color.Transparent;
            this.TextForServerAPIAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForServerAPIAddress.Location = new System.Drawing.Point(65, 134);
            this.TextForServerAPIAddress.Name = "TextForServerAPIAddress";
            this.TextForServerAPIAddress.Size = new System.Drawing.Size(174, 24);
            this.TextForServerAPIAddress.TabIndex = 6;
            this.TextForServerAPIAddress.Text = "服务器API位置";
            // 
            // JavaverText
            // 
            this.JavaverText.AutoSize = true;
            this.JavaverText.BackColor = System.Drawing.Color.Transparent;
            this.JavaverText.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JavaverText.Location = new System.Drawing.Point(361, 96);
            this.JavaverText.Name = "JavaverText";
            this.JavaverText.Size = new System.Drawing.Size(153, 24);
            this.JavaverText.TabIndex = 5;
            this.JavaverText.Text = "JavaVersion";
            // 
            // TextForJavaVersion
            // 
            this.TextForJavaVersion.AutoSize = true;
            this.TextForJavaVersion.BackColor = System.Drawing.Color.Transparent;
            this.TextForJavaVersion.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForJavaVersion.Location = new System.Drawing.Point(65, 96);
            this.TextForJavaVersion.Name = "TextForJavaVersion";
            this.TextForJavaVersion.Size = new System.Drawing.Size(112, 24);
            this.TextForJavaVersion.TabIndex = 4;
            this.TextForJavaVersion.Text = "Java版本";
            // 
            // FolderAddress
            // 
            this.FolderAddress.AutoSize = true;
            this.FolderAddress.BackColor = System.Drawing.Color.Transparent;
            this.FolderAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderAddress.Location = new System.Drawing.Point(361, 57);
            this.FolderAddress.Name = "FolderAddress";
            this.FolderAddress.Size = new System.Drawing.Size(62, 24);
            this.FolderAddress.TabIndex = 3;
            this.FolderAddress.Text = "NONE";
            // 
            // FindServer
            // 
            this.FindServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FindServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindServer.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindServer.Location = new System.Drawing.Point(862, 369);
            this.FindServer.Name = "FindServer";
            this.FindServer.Size = new System.Drawing.Size(252, 129);
            this.FindServer.TabIndex = 4;
            this.FindServer.Text = "查找服务器";
            this.FindServer.UseVisualStyleBackColor = false;
            this.FindServer.Click += new System.EventHandler(this.FindServer_Click);
            // 
            // SearchJava
            // 
            this.SearchJava.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchJava.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchJava.Location = new System.Drawing.Point(862, 517);
            this.SearchJava.Name = "SearchJava";
            this.SearchJava.Size = new System.Drawing.Size(252, 129);
            this.SearchJava.TabIndex = 5;
            this.SearchJava.Text = "更换Java";
            this.SearchJava.UseVisualStyleBackColor = false;
            this.SearchJava.Click += new System.EventHandler(this.SearchJava_Click);
            // 
            // TextForServerInfo
            // 
            this.TextForServerInfo.AutoSize = true;
            this.TextForServerInfo.BackColor = System.Drawing.Color.Transparent;
            this.TextForServerInfo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold);
            this.TextForServerInfo.Location = new System.Drawing.Point(25, 385);
            this.TextForServerInfo.Name = "TextForServerInfo";
            this.TextForServerInfo.Size = new System.Drawing.Size(180, 33);
            this.TextForServerInfo.TabIndex = 6;
            this.TextForServerInfo.Text = "服务器属性";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "服务器最小内存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "服务器最大内存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "高级设置";
            // 
            // AdvancedSettings
            // 
            this.AdvancedSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdvancedSettings.Font = new System.Drawing.Font("宋体", 11F);
            this.AdvancedSettings.Location = new System.Drawing.Point(76, 596);
            this.AdvancedSettings.Name = "AdvancedSettings";
            this.AdvancedSettings.Size = new System.Drawing.Size(665, 41);
            this.AdvancedSettings.TabIndex = 12;
            this.AdvancedSettings.TextChanged += new System.EventHandler(this.AdvancedSettings_TextChanged);
            // 
            // WtbMaxRAM
            // 
            this.WtbMaxRAM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WtbMaxRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WtbMaxRAM.Font = new System.Drawing.Font("宋体", 10F);
            this.WtbMaxRAM.Location = new System.Drawing.Point(290, 485);
            this.WtbMaxRAM.Name = "WtbMaxRAM";
            this.WtbMaxRAM.Size = new System.Drawing.Size(109, 38);
            this.WtbMaxRAM.TabIndex = 10;
            this.WtbMaxRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WtbMaxRAM.WatermarkText = "MB";
            this.WtbMaxRAM.TextChanged += new System.EventHandler(this.WtbMaxRAM_TextChanged);
            // 
            // WtbMinRAM
            // 
            this.WtbMinRAM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WtbMinRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WtbMinRAM.Font = new System.Drawing.Font("宋体", 10F);
            this.WtbMinRAM.Location = new System.Drawing.Point(290, 438);
            this.WtbMinRAM.Name = "WtbMinRAM";
            this.WtbMinRAM.Size = new System.Drawing.Size(109, 38);
            this.WtbMinRAM.TabIndex = 9;
            this.WtbMinRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WtbMinRAM.WatermarkText = "MB";
            this.WtbMinRAM.TextChanged += new System.EventHandler(this.WtbMinRAM_TextChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::MuhuSL.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AdvancedSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WtbMaxRAM);
            this.Controls.Add(this.WtbMinRAM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextForServerInfo);
            this.Controls.Add(this.SearchJava);
            this.Controls.Add(this.FindServer);
            this.Controls.Add(this.ServerInfoPanel);
            this.Controls.Add(this.H1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1150, 666);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ServerInfoPanel.ResumeLayout(false);
            this.ServerInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label H2;
        private System.Windows.Forms.Label TextforServerFolderAddress;
        private System.Windows.Forms.Label FolderAddress;
        private System.Windows.Forms.Label JavaverText;
        private System.Windows.Forms.Label TextForJavaVersion;
        private System.Windows.Forms.Button FindServer;
        private System.Windows.Forms.Button SearchJava;
        private System.Windows.Forms.Label TextForServerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WaterTextbox WtbMinRAM;
        private WaterTextbox WtbMaxRAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdvancedSettings;
        private System.Windows.Forms.Label LbServerAPI;
        private System.Windows.Forms.Label TextForServerAPIAddress;
        private System.Windows.Forms.Label ServerVersion;
        private System.Windows.Forms.Label TextForServerVersion;
        public System.Windows.Forms.Panel ServerInfoPanel;
    }
}
