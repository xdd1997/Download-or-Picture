namespace JiShiQi
{
    partial class Timer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeShow = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "计时：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTimeShow
            // 
            this.txtTimeShow.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTimeShow.Location = new System.Drawing.Point(117, 29);
            this.txtTimeShow.Name = "txtTimeShow";
            this.txtTimeShow.Size = new System.Drawing.Size(145, 34);
            this.txtTimeShow.TabIndex = 1;
            this.txtTimeShow.TextChanged += new System.EventHandler(this.txtTimeShow_TextChanged);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnstart.Location = new System.Drawing.Point(12, 95);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(62, 35);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "开始";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(158, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "清清";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnstop.Location = new System.Drawing.Point(83, 95);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(62, 35);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "结束";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(225, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "倒计时";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtTimeShow);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.Text = "研究生啦";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeShow;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Button button2;
    }
}

