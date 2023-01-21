namespace MMSL
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutOK = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutOK
            // 
            this.AboutOK.Location = new System.Drawing.Point(569, 351);
            this.AboutOK.Name = "AboutOK";
            this.AboutOK.Size = new System.Drawing.Size(206, 69);
            this.AboutOK.TabIndex = 1;
            this.AboutOK.Text = "确定";
            this.AboutOK.UseVisualStyleBackColor = true;
            this.AboutOK.Click += new System.EventHandler(this.AboutOK_Click);
            // 
            // Picture
            // 
            this.Picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture.BackgroundImage")));
            this.Picture.Location = new System.Drawing.Point(37, 49);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(258, 255);
            this.Picture.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(367, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 273);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muhu SL v2.3.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "制作者： Muhu_C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "MCSLib制作者： Muhu_C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "使用C# .NET\r\nWindows窗体应用制作\r\nbilibili:Muhu_C";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(109, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(574, 24);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "bilibili: https://space.bilibili.com/1469137723";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(33, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "问题反馈：452044217@qq.com & QQ452044217";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.AboutOK);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.Text = "关于";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AboutOK;
        private System.Windows.Forms.Panel Picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}