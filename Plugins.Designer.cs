namespace MuhuSL
{
    partial class Plugins
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
            this.ChoosePlugin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbPluginFolderAddress = new System.Windows.Forms.Label();
            this.LbPluginAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextForPluginAddress = new System.Windows.Forms.Label();
            this.LbPluginVersion = new System.Windows.Forms.Label();
            this.TextForPluginVersion = new System.Windows.Forms.Label();
            this.LbPluginName = new System.Windows.Forms.Label();
            this.TextForPluginName = new System.Windows.Forms.Label();
            this.H2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeletePlugin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.Transparent;
            this.H1.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.H1.Location = new System.Drawing.Point(0, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(1150, 166);
            this.H1.TabIndex = 0;
            this.H1.Text = "Muhu SL 插件";
            this.H1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoosePlugin
            // 
            this.ChoosePlugin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChoosePlugin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ChoosePlugin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ChoosePlugin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChoosePlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePlugin.Font = new System.Drawing.Font("幼圆", 15F);
            this.ChoosePlugin.Location = new System.Drawing.Point(456, 474);
            this.ChoosePlugin.Name = "ChoosePlugin";
            this.ChoosePlugin.Size = new System.Drawing.Size(238, 138);
            this.ChoosePlugin.TabIndex = 1;
            this.ChoosePlugin.Text = "选择插件";
            this.ChoosePlugin.UseVisualStyleBackColor = false;
            this.ChoosePlugin.Click += new System.EventHandler(this.ChoosePlugin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LbPluginFolderAddress);
            this.panel1.Controls.Add(this.LbPluginAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextForPluginAddress);
            this.panel1.Controls.Add(this.LbPluginVersion);
            this.panel1.Controls.Add(this.TextForPluginVersion);
            this.panel1.Controls.Add(this.LbPluginName);
            this.panel1.Controls.Add(this.TextForPluginName);
            this.panel1.Controls.Add(this.H2);
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 237);
            this.panel1.TabIndex = 2;
            // 
            // LbPluginFolderAddress
            // 
            this.LbPluginFolderAddress.AutoSize = true;
            this.LbPluginFolderAddress.BackColor = System.Drawing.Color.Transparent;
            this.LbPluginFolderAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPluginFolderAddress.Location = new System.Drawing.Point(379, 184);
            this.LbPluginFolderAddress.Name = "LbPluginFolderAddress";
            this.LbPluginFolderAddress.Size = new System.Drawing.Size(82, 24);
            this.LbPluginFolderAddress.TabIndex = 8;
            this.LbPluginFolderAddress.Text = "未选择";
            // 
            // LbPluginAddress
            // 
            this.LbPluginAddress.AutoSize = true;
            this.LbPluginAddress.BackColor = System.Drawing.Color.Transparent;
            this.LbPluginAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPluginAddress.Location = new System.Drawing.Point(379, 143);
            this.LbPluginAddress.Name = "LbPluginAddress";
            this.LbPluginAddress.Size = new System.Drawing.Size(82, 24);
            this.LbPluginAddress.TabIndex = 7;
            this.LbPluginAddress.Text = "未选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "插件文件夹绝对地址";
            // 
            // TextForPluginAddress
            // 
            this.TextForPluginAddress.AutoSize = true;
            this.TextForPluginAddress.BackColor = System.Drawing.Color.Transparent;
            this.TextForPluginAddress.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForPluginAddress.Location = new System.Drawing.Point(68, 143);
            this.TextForPluginAddress.Name = "TextForPluginAddress";
            this.TextForPluginAddress.Size = new System.Drawing.Size(154, 24);
            this.TextForPluginAddress.TabIndex = 5;
            this.TextForPluginAddress.Text = "插件绝对地址";
            // 
            // LbPluginVersion
            // 
            this.LbPluginVersion.AutoSize = true;
            this.LbPluginVersion.BackColor = System.Drawing.Color.Transparent;
            this.LbPluginVersion.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPluginVersion.Location = new System.Drawing.Point(379, 103);
            this.LbPluginVersion.Name = "LbPluginVersion";
            this.LbPluginVersion.Size = new System.Drawing.Size(82, 24);
            this.LbPluginVersion.TabIndex = 4;
            this.LbPluginVersion.Text = "未选择";
            // 
            // TextForPluginVersion
            // 
            this.TextForPluginVersion.AutoSize = true;
            this.TextForPluginVersion.BackColor = System.Drawing.Color.Transparent;
            this.TextForPluginVersion.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForPluginVersion.Location = new System.Drawing.Point(68, 103);
            this.TextForPluginVersion.Name = "TextForPluginVersion";
            this.TextForPluginVersion.Size = new System.Drawing.Size(106, 24);
            this.TextForPluginVersion.TabIndex = 3;
            this.TextForPluginVersion.Text = "插件版本";
            // 
            // LbPluginName
            // 
            this.LbPluginName.AutoSize = true;
            this.LbPluginName.BackColor = System.Drawing.Color.Transparent;
            this.LbPluginName.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPluginName.Location = new System.Drawing.Point(379, 61);
            this.LbPluginName.Name = "LbPluginName";
            this.LbPluginName.Size = new System.Drawing.Size(82, 24);
            this.LbPluginName.TabIndex = 2;
            this.LbPluginName.Text = "未选择";
            // 
            // TextForPluginName
            // 
            this.TextForPluginName.AutoSize = true;
            this.TextForPluginName.BackColor = System.Drawing.Color.Transparent;
            this.TextForPluginName.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextForPluginName.Location = new System.Drawing.Point(68, 61);
            this.TextForPluginName.Name = "TextForPluginName";
            this.TextForPluginName.Size = new System.Drawing.Size(82, 24);
            this.TextForPluginName.TabIndex = 1;
            this.TextForPluginName.Text = "插件名";
            // 
            // H2
            // 
            this.H2.AutoSize = true;
            this.H2.BackColor = System.Drawing.Color.Transparent;
            this.H2.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Bold);
            this.H2.Location = new System.Drawing.Point(22, 13);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(128, 27);
            this.H2.TabIndex = 0;
            this.H2.Text = "插件信息";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("幼圆", 15F);
            this.button1.Location = new System.Drawing.Point(72, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 138);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加插件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddPlugin_Click);
            // 
            // DeletePlugin
            // 
            this.DeletePlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeletePlugin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeletePlugin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeletePlugin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeletePlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlugin.Font = new System.Drawing.Font("幼圆", 15F);
            this.DeletePlugin.Location = new System.Drawing.Point(842, 474);
            this.DeletePlugin.Name = "DeletePlugin";
            this.DeletePlugin.Size = new System.Drawing.Size(238, 138);
            this.DeletePlugin.TabIndex = 4;
            this.DeletePlugin.Text = "删除\r\n已选插件";
            this.DeletePlugin.UseVisualStyleBackColor = false;
            this.DeletePlugin.Click += new System.EventHandler(this.DeletePlugin_Click);
            // 
            // Plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::MuhuSL.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DeletePlugin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChoosePlugin);
            this.Controls.Add(this.H1);
            this.Name = "Plugins";
            this.Size = new System.Drawing.Size(1150, 666);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Button ChoosePlugin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbPluginName;
        private System.Windows.Forms.Label TextForPluginName;
        private System.Windows.Forms.Label H2;
        private System.Windows.Forms.Label LbPluginVersion;
        private System.Windows.Forms.Label TextForPluginVersion;
        private System.Windows.Forms.Label LbPluginFolderAddress;
        private System.Windows.Forms.Label LbPluginAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextForPluginAddress;
        private System.Windows.Forms.Button DeletePlugin;
    }
}
