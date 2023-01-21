namespace MMSL
{
    partial class Mainform
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.MenuA = new System.Windows.Forms.StatusStrip();
            this.DropDownBotton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SettingsPage = new System.Windows.Forms.Button();
            this.DownloadPage = new System.Windows.Forms.Button();
            this.PluginsPage = new System.Windows.Forms.Button();
            this.ConsolePage = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Button();
            this.PageA = new MMSL.MainPage();
            this.PageB = new MMSL.ServerConsole();
            this.PageC = new MuhuSL.Plugins();
            this.PageD = new MuhuSL.Download();
            this.MenuA.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuA
            // 
            this.MenuA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuA.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuA.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.MenuA.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownBotton1,
            this.关于ToolStripMenuItem});
            this.MenuA.Location = new System.Drawing.Point(0, 0);
            this.MenuA.Name = "MenuA";
            this.MenuA.Size = new System.Drawing.Size(1150, 43);
            this.MenuA.TabIndex = 1;
            this.MenuA.Text = "菜单";
            // 
            // DropDownBotton1
            // 
            this.DropDownBotton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDownBotton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序ToolStripMenuItem});
            this.DropDownBotton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownBotton1.Name = "DropDownBotton1";
            this.DropDownBotton1.Size = new System.Drawing.Size(91, 39);
            this.DropDownBotton1.Text = "文件";
            // 
            // 程序ToolStripMenuItem
            // 
            this.程序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem,
            this.重启ToolStripMenuItem});
            this.程序ToolStripMenuItem.Name = "程序ToolStripMenuItem";
            this.程序ToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.程序ToolStripMenuItem.Text = "程序";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 重启ToolStripMenuItem
            // 
            this.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem";
            this.重启ToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.重启ToolStripMenuItem.Text = "重启";
            this.重启ToolStripMenuItem.Click += new System.EventHandler(this.重启ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.关于ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(91, 39);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click_1);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.Controls.Add(this.SettingsPage);
            this.Panel1.Controls.Add(this.DownloadPage);
            this.Panel1.Controls.Add(this.PluginsPage);
            this.Panel1.Controls.Add(this.ConsolePage);
            this.Panel1.Controls.Add(this.MainPage);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 709);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1150, 50);
            this.Panel1.TabIndex = 2;
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.SystemColors.Menu;
            this.SettingsPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.SettingsPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingsPage.Location = new System.Drawing.Point(920, 0);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(230, 50);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "设置";
            this.SettingsPage.UseVisualStyleBackColor = false;
            // 
            // DownloadPage
            // 
            this.DownloadPage.BackColor = System.Drawing.SystemColors.Menu;
            this.DownloadPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.DownloadPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownloadPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.DownloadPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.DownloadPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownloadPage.Location = new System.Drawing.Point(690, 0);
            this.DownloadPage.Name = "DownloadPage";
            this.DownloadPage.Size = new System.Drawing.Size(230, 50);
            this.DownloadPage.TabIndex = 4;
            this.DownloadPage.Text = "下载";
            this.DownloadPage.UseVisualStyleBackColor = false;
            this.DownloadPage.Click += new System.EventHandler(this.DownloadPage_Click);
            // 
            // PluginsPage
            // 
            this.PluginsPage.BackColor = System.Drawing.SystemColors.Menu;
            this.PluginsPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PluginsPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.PluginsPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.PluginsPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.PluginsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PluginsPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PluginsPage.Location = new System.Drawing.Point(460, 0);
            this.PluginsPage.Name = "PluginsPage";
            this.PluginsPage.Size = new System.Drawing.Size(230, 50);
            this.PluginsPage.TabIndex = 2;
            this.PluginsPage.Text = "插件管理";
            this.PluginsPage.UseVisualStyleBackColor = false;
            this.PluginsPage.Click += new System.EventHandler(this.PluginsPage_Click);
            // 
            // ConsolePage
            // 
            this.ConsolePage.BackColor = System.Drawing.SystemColors.Menu;
            this.ConsolePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConsolePage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsolePage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ConsolePage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.ConsolePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsolePage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConsolePage.Location = new System.Drawing.Point(230, 0);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Size = new System.Drawing.Size(230, 50);
            this.ConsolePage.TabIndex = 1;
            this.ConsolePage.Text = "控制台";
            this.ConsolePage.UseVisualStyleBackColor = false;
            this.ConsolePage.Click += new System.EventHandler(this.ConsolePage_Click);
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.SystemColors.Menu;
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.MainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(230, 50);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "主页";
            this.MainPage.UseVisualStyleBackColor = false;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // PageA
            // 
            this.PageA.BackColor = System.Drawing.Color.White;
            this.PageA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageA.BackgroundImage")));
            this.PageA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageA.Location = new System.Drawing.Point(0, 43);
            this.PageA.Name = "PageA";
            this.PageA.Size = new System.Drawing.Size(1150, 666);
            this.PageA.TabIndex = 5;
            // 
            // PageB
            // 
            this.PageB.BackColor = System.Drawing.Color.MintCream;
            this.PageB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageB.Location = new System.Drawing.Point(0, 43);
            this.PageB.Name = "PageB";
            this.PageB.Size = new System.Drawing.Size(1150, 666);
            this.PageB.TabIndex = 4;
            // 
            // PageC
            // 
            this.PageC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageC.BackgroundImage")));
            this.PageC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageC.Location = new System.Drawing.Point(0, 43);
            this.PageC.Name = "PageC";
            this.PageC.Size = new System.Drawing.Size(1150, 666);
            this.PageC.TabIndex = 6;
            // 
            // PageD
            // 
            this.PageD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageD.BackgroundImage")));
            this.PageD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageD.Location = new System.Drawing.Point(0, 43);
            this.PageD.Name = "PageD";
            this.PageD.Size = new System.Drawing.Size(1150, 666);
            this.PageD.TabIndex = 7;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 759);
            this.Controls.Add(this.PageA);
            this.Controls.Add(this.PageB);
            this.Controls.Add(this.PageC);
            this.Controls.Add(this.PageD);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Muhu Server-Launcher";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.MenuA.ResumeLayout(false);
            this.MenuA.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton DropDownBotton1;
        private System.Windows.Forms.ToolStripMenuItem 程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.Button ConsolePage;
        private System.Windows.Forms.Button PluginsPage;
        private System.Windows.Forms.Button SettingsPage;
        private ServerConsole PageB;
        private System.Windows.Forms.ToolStripMenuItem 重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton 关于ToolStripMenuItem;
        public MainPage PageA;
        public System.Windows.Forms.StatusStrip MenuA;
        private System.Windows.Forms.Button DownloadPage;
        private MuhuSL.Plugins PageC;
        private MuhuSL.Download PageD;
    }
}

