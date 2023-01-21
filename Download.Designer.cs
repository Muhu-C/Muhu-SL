namespace MuhuSL
{
    partial class Download
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
            this.ComboBoxA = new System.Windows.Forms.ComboBox();
            this.ComboBoxB = new System.Windows.Forms.ComboBox();
            this.TextFor下载类型 = new System.Windows.Forms.Label();
            this.TextFor下载项目 = new System.Windows.Forms.Label();
            this.DownloadBotton = new System.Windows.Forms.Button();
            this.TextForXZZT = new System.Windows.Forms.Label();
            this.DownloadInfo = new System.Windows.Forms.Label();
            this.PBForDownloadInfo = new System.Windows.Forms.ProgressBar();
            this.LbDownloadInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.Transparent;
            this.H1.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.H1.Location = new System.Drawing.Point(0, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(1150, 115);
            this.H1.TabIndex = 0;
            this.H1.Text = "Muhu SL 下载";
            this.H1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ComboBoxA
            // 
            this.ComboBoxA.DropDownWidth = 876;
            this.ComboBoxA.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxA.FormattingEnabled = true;
            this.ComboBoxA.Location = new System.Drawing.Point(199, 227);
            this.ComboBoxA.MaxDropDownItems = 4;
            this.ComboBoxA.Name = "ComboBoxA";
            this.ComboBoxA.Size = new System.Drawing.Size(876, 41);
            this.ComboBoxA.TabIndex = 1;
            this.ComboBoxA.SelectedIndexChanged += new System.EventHandler(this.ConboBoxA_SelectedIndexChanged);
            // 
            // ComboBoxB
            // 
            this.ComboBoxB.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBoxB.FormattingEnabled = true;
            this.ComboBoxB.Location = new System.Drawing.Point(199, 358);
            this.ComboBoxB.MaxDropDownItems = 4;
            this.ComboBoxB.Name = "ComboBoxB";
            this.ComboBoxB.Size = new System.Drawing.Size(876, 41);
            this.ComboBoxB.TabIndex = 2;
            this.ComboBoxB.SelectedIndexChanged += new System.EventHandler(this.ComboBoxB_SelectedIndexChanged);
            // 
            // TextFor下载类型
            // 
            this.TextFor下载类型.AutoSize = true;
            this.TextFor下载类型.BackColor = System.Drawing.Color.Transparent;
            this.TextFor下载类型.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.TextFor下载类型.Location = new System.Drawing.Point(56, 227);
            this.TextFor下载类型.Name = "TextFor下载类型";
            this.TextFor下载类型.Size = new System.Drawing.Size(137, 40);
            this.TextFor下载类型.TabIndex = 3;
            this.TextFor下载类型.Text = "下载类型";
            // 
            // TextFor下载项目
            // 
            this.TextFor下载项目.AutoSize = true;
            this.TextFor下载项目.BackColor = System.Drawing.Color.Transparent;
            this.TextFor下载项目.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.TextFor下载项目.Location = new System.Drawing.Point(56, 359);
            this.TextFor下载项目.Name = "TextFor下载项目";
            this.TextFor下载项目.Size = new System.Drawing.Size(137, 40);
            this.TextFor下载项目.TabIndex = 4;
            this.TextFor下载项目.Text = "下载项目";
            // 
            // DownloadBotton
            // 
            this.DownloadBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBotton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.DownloadBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBotton.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownloadBotton.Location = new System.Drawing.Point(775, 481);
            this.DownloadBotton.Name = "DownloadBotton";
            this.DownloadBotton.Size = new System.Drawing.Size(300, 143);
            this.DownloadBotton.TabIndex = 5;
            this.DownloadBotton.Text = "下载";
            this.DownloadBotton.UseVisualStyleBackColor = false;
            this.DownloadBotton.Click += new System.EventHandler(this.DownloadBotton_Click);
            // 
            // TextForXZZT
            // 
            this.TextForXZZT.AutoSize = true;
            this.TextForXZZT.BackColor = System.Drawing.Color.Transparent;
            this.TextForXZZT.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.TextForXZZT.Location = new System.Drawing.Point(56, 500);
            this.TextForXZZT.Name = "TextForXZZT";
            this.TextForXZZT.Size = new System.Drawing.Size(137, 40);
            this.TextForXZZT.TabIndex = 6;
            this.TextForXZZT.Text = "下载状态";
            // 
            // DownloadInfo
            // 
            this.DownloadInfo.AutoSize = true;
            this.DownloadInfo.BackColor = System.Drawing.Color.Transparent;
            this.DownloadInfo.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.DownloadInfo.Location = new System.Drawing.Point(199, 500);
            this.DownloadInfo.Name = "DownloadInfo";
            this.DownloadInfo.Size = new System.Drawing.Size(107, 39);
            this.DownloadInfo.TabIndex = 7;
            this.DownloadInfo.Text = "未下载";
            // 
            // PBForDownloadInfo
            // 
            this.PBForDownloadInfo.Location = new System.Drawing.Point(63, 557);
            this.PBForDownloadInfo.Name = "PBForDownloadInfo";
            this.PBForDownloadInfo.Size = new System.Drawing.Size(271, 35);
            this.PBForDownloadInfo.TabIndex = 8;
            // 
            // LbDownloadInfo
            // 
            this.LbDownloadInfo.AutoSize = true;
            this.LbDownloadInfo.BackColor = System.Drawing.Color.Transparent;
            this.LbDownloadInfo.Font = new System.Drawing.Font("宋体", 11F);
            this.LbDownloadInfo.Location = new System.Drawing.Point(340, 557);
            this.LbDownloadInfo.Name = "LbDownloadInfo";
            this.LbDownloadInfo.Size = new System.Drawing.Size(103, 30);
            this.LbDownloadInfo.TabIndex = 9;
            this.LbDownloadInfo.Text = "--.--%";
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MuhuSL.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LbDownloadInfo);
            this.Controls.Add(this.PBForDownloadInfo);
            this.Controls.Add(this.DownloadInfo);
            this.Controls.Add(this.TextForXZZT);
            this.Controls.Add(this.DownloadBotton);
            this.Controls.Add(this.TextFor下载项目);
            this.Controls.Add(this.TextFor下载类型);
            this.Controls.Add(this.ComboBoxB);
            this.Controls.Add(this.ComboBoxA);
            this.Controls.Add(this.H1);
            this.Name = "Download";
            this.Size = new System.Drawing.Size(1150, 666);
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.ComboBox ComboBoxA;
        private System.Windows.Forms.ComboBox ComboBoxB;
        private System.Windows.Forms.Label TextFor下载类型;
        private System.Windows.Forms.Label TextFor下载项目;
        private System.Windows.Forms.Button DownloadBotton;
        private System.Windows.Forms.Label TextForXZZT;
        private System.Windows.Forms.Label DownloadInfo;
        private System.Windows.Forms.ProgressBar PBForDownloadInfo;
        private System.Windows.Forms.Label LbDownloadInfo;
    }
}
