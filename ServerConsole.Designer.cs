namespace MMSL
{
    partial class ServerConsole
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
            this.TbOutput = new System.Windows.Forms.TextBox();
            this.StartBotton = new System.Windows.Forms.Button();
            this.StopBotton = new System.Windows.Forms.Button();
            this.KillJavaButton = new System.Windows.Forms.Button();
            this.TbInput = new MMSL.WaterTextbox();
            this.SuspendLayout();
            // 
            // TbOutput
            // 
            this.TbOutput.BackColor = System.Drawing.SystemColors.Desktop;
            this.TbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TbOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbOutput.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.TbOutput.Location = new System.Drawing.Point(0, 0);
            this.TbOutput.Multiline = true;
            this.TbOutput.Name = "TbOutput";
            this.TbOutput.Size = new System.Drawing.Size(1150, 629);
            this.TbOutput.TabIndex = 0;
            // 
            // StartBotton
            // 
            this.StartBotton.BackColor = System.Drawing.Color.Lime;
            this.StartBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBotton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.StartBotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartBotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBotton.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartBotton.Location = new System.Drawing.Point(14, 0);
            this.StartBotton.Name = "StartBotton";
            this.StartBotton.Size = new System.Drawing.Size(145, 50);
            this.StartBotton.TabIndex = 1;
            this.StartBotton.Text = "开启";
            this.StartBotton.UseVisualStyleBackColor = false;
            this.StartBotton.Click += new System.EventHandler(this.StartBotton_Click);
            // 
            // StopBotton
            // 
            this.StopBotton.BackColor = System.Drawing.Color.Red;
            this.StopBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBotton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.StopBotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopBotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StopBotton.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopBotton.Location = new System.Drawing.Point(160, 0);
            this.StopBotton.Name = "StopBotton";
            this.StopBotton.Size = new System.Drawing.Size(145, 50);
            this.StopBotton.TabIndex = 2;
            this.StopBotton.Text = "关闭";
            this.StopBotton.UseVisualStyleBackColor = false;
            this.StopBotton.Click += new System.EventHandler(this.StopBotton_Click);
            // 
            // KillJavaButton
            // 
            this.KillJavaButton.BackColor = System.Drawing.Color.Red;
            this.KillJavaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillJavaButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.KillJavaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KillJavaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KillJavaButton.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KillJavaButton.Location = new System.Drawing.Point(840, 0);
            this.KillJavaButton.Name = "KillJavaButton";
            this.KillJavaButton.Size = new System.Drawing.Size(290, 50);
            this.KillJavaButton.TabIndex = 3;
            this.KillJavaButton.Text = "强行关闭Java进程";
            this.KillJavaButton.UseVisualStyleBackColor = false;
            this.KillJavaButton.Click += new System.EventHandler(this.KillJavaButton_Click);
            // 
            // TbInput
            // 
            this.TbInput.BackColor = System.Drawing.SystemColors.Desktop;
            this.TbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbInput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TbInput.Location = new System.Drawing.Point(0, 631);
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(1150, 35);
            this.TbInput.TabIndex = 4;
            this.TbInput.WatermarkText = "输入指令";
            // 
            // ServerConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.TbInput);
            this.Controls.Add(this.KillJavaButton);
            this.Controls.Add(this.StopBotton);
            this.Controls.Add(this.StartBotton);
            this.Controls.Add(this.TbOutput);
            this.Name = "ServerConsole";
            this.Size = new System.Drawing.Size(1150, 666);
            this.Load += new System.EventHandler(this.ServerConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbOutput;
        private System.Windows.Forms.Button StartBotton;
        private System.Windows.Forms.Button StopBotton;
        private System.Windows.Forms.Button KillJavaButton;
        private WaterTextbox TbInput;
    }
}
