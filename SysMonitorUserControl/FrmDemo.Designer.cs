namespace SysMonitorUserControl
{
    partial class FrmDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemo));
            this.uccpu1 = new SysMonitorUserControl.UCCPU();
            this.ucMemory1 = new SysMonitorUserControl.UCMemory();
            this.ucMicrophone1 = new SysMonitorUserControl.UCMicrophone();
            this.ucSpeaker1 = new WindowsFormsApp3.UCSpeaker();
            this.SuspendLayout();
            // 
            // uccpu1
            // 
            this.uccpu1.BackColor = System.Drawing.Color.Black;
            this.uccpu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uccpu1.ForeColor = System.Drawing.Color.LawnGreen;
            this.uccpu1.Location = new System.Drawing.Point(25, 24);
            this.uccpu1.Name = "uccpu1";
            this.uccpu1.Size = new System.Drawing.Size(25, 25);
            this.uccpu1.TabIndex = 0;
            this.uccpu1.UsageColor = System.Drawing.Color.DarkRed;
            // 
            // ucMemory1
            // 
            this.ucMemory1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMemory1.BackgroundImage")));
            this.ucMemory1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMemory1.Location = new System.Drawing.Point(57, 24);
            this.ucMemory1.Name = "ucMemory1";
            this.ucMemory1.Size = new System.Drawing.Size(54, 25);
            this.ucMemory1.TabIndex = 1;
            this.ucMemory1.UsageColor = System.Drawing.Color.DarkRed;
            // 
            // ucMicrophone1
            // 
            this.ucMicrophone1.BackColor = System.Drawing.Color.Black;
            this.ucMicrophone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMicrophone1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMicrophone1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ucMicrophone1.Location = new System.Drawing.Point(118, 24);
            this.ucMicrophone1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ucMicrophone1.Name = "ucMicrophone1";
            this.ucMicrophone1.Size = new System.Drawing.Size(40, 25);
            this.ucMicrophone1.TabIndex = 2;
            this.ucMicrophone1.UsageColor = System.Drawing.Color.DarkRed;
            // 
            // ucSpeaker1
            // 
            this.ucSpeaker1.BackColor = System.Drawing.Color.Black;
            this.ucSpeaker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSpeaker1.Location = new System.Drawing.Point(164, 24);
            this.ucSpeaker1.Name = "ucSpeaker1";
            this.ucSpeaker1.Size = new System.Drawing.Size(40, 25);
            this.ucSpeaker1.TabIndex = 3;
            this.ucSpeaker1.UsageColor = System.Drawing.Color.DarkRed;
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucSpeaker1);
            this.Controls.Add(this.ucMicrophone1);
            this.Controls.Add(this.ucMemory1);
            this.Controls.Add(this.uccpu1);
            this.Name = "FrmDemo";
            this.Text = "User Control Demo";
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCCPU uccpu1;
        private UCMemory ucMemory1;
        private UCMicrophone ucMicrophone1;
        private WindowsFormsApp3.UCSpeaker ucSpeaker1;
    }
}

