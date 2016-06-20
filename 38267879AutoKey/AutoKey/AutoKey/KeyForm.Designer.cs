namespace AutoKey
{
    partial class KeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey3 = new System.Windows.Forms.TextBox();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKey4 = new System.Windows.Forms.TextBox();
            this.txtTime4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKey5 = new System.Windows.Forms.TextBox();
            this.txtTime5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEsc = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作1";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(74, 28);
            this.txtKey1.MaxLength = 1;
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(54, 21);
            this.txtKey1.TabIndex = 1;
            this.txtKey1.TabStop = false;
            this.txtKey1.Text = "指定按键";
            this.txtKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey1.Enter += new System.EventHandler(this.txtKey1_Enter);
            this.txtKey1.Leave += new System.EventHandler(this.txtKey1_Leave);
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(138, 28);
            this.txtTime1.MaxLength = 5;
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(67, 21);
            this.txtTime1.TabIndex = 2;
            this.txtTime1.TabStop = false;
            this.txtTime1.Text = "时间间隔";
            this.txtTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime1.Enter += new System.EventHandler(this.txtTime1_Enter);
            this.txtTime1.Leave += new System.EventHandler(this.txtTime1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "秒";
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(234, 30);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(48, 16);
            this.cbx1.TabIndex = 1;
            this.cbx1.TabStop = false;
            this.cbx1.Text = "激活";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作2";
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(74, 61);
            this.txtKey2.MaxLength = 1;
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(54, 21);
            this.txtKey2.TabIndex = 1;
            this.txtKey2.TabStop = false;
            this.txtKey2.Text = "指定按键";
            this.txtKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey2.Enter += new System.EventHandler(this.txtKey2_Enter);
            this.txtKey2.Leave += new System.EventHandler(this.txtKey2_Leave);
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(138, 61);
            this.txtTime2.MaxLength = 5;
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(67, 21);
            this.txtTime2.TabIndex = 2;
            this.txtTime2.TabStop = false;
            this.txtTime2.Text = "时间间隔";
            this.txtTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime2.Enter += new System.EventHandler(this.txtTime2_Enter);
            this.txtTime2.Leave += new System.EventHandler(this.txtTime2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "秒";
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(234, 63);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(48, 16);
            this.cbx2.TabIndex = 1;
            this.cbx2.TabStop = false;
            this.cbx2.Text = "激活";
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "操作3";
            // 
            // txtKey3
            // 
            this.txtKey3.Location = new System.Drawing.Point(74, 94);
            this.txtKey3.MaxLength = 1;
            this.txtKey3.Name = "txtKey3";
            this.txtKey3.Size = new System.Drawing.Size(54, 21);
            this.txtKey3.TabIndex = 1;
            this.txtKey3.TabStop = false;
            this.txtKey3.Text = "指定按键";
            this.txtKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey3.Enter += new System.EventHandler(this.txtKey3_Enter);
            this.txtKey3.Leave += new System.EventHandler(this.txtKey3_Leave);
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(138, 94);
            this.txtTime3.MaxLength = 5;
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.Size = new System.Drawing.Size(67, 21);
            this.txtTime3.TabIndex = 2;
            this.txtTime3.TabStop = false;
            this.txtTime3.Text = "时间间隔";
            this.txtTime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime3.Enter += new System.EventHandler(this.txtTime3_Enter);
            this.txtTime3.Leave += new System.EventHandler(this.txtTime3_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "秒";
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(234, 96);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(48, 16);
            this.cbx3.TabIndex = 1;
            this.cbx3.TabStop = false;
            this.cbx3.Text = "激活";
            this.cbx3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "*操作4";
            // 
            // txtKey4
            // 
            this.txtKey4.Location = new System.Drawing.Point(74, 127);
            this.txtKey4.MaxLength = 1000;
            this.txtKey4.Name = "txtKey4";
            this.txtKey4.Size = new System.Drawing.Size(54, 21);
            this.txtKey4.TabIndex = 1000;
            this.txtKey4.TabStop = false;
            this.txtKey4.Text = "指定按键";
            this.txtKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey4.Enter += new System.EventHandler(this.txtKey4_Enter);
            this.txtKey4.Leave += new System.EventHandler(this.txtKey4_Leave);
            // 
            // txtTime4
            // 
            this.txtTime4.Location = new System.Drawing.Point(138, 127);
            this.txtTime4.MaxLength = 5;
            this.txtTime4.Name = "txtTime4";
            this.txtTime4.Size = new System.Drawing.Size(67, 21);
            this.txtTime4.TabIndex = 2;
            this.txtTime4.TabStop = false;
            this.txtTime4.Text = "时间间隔";
            this.txtTime4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime4.Enter += new System.EventHandler(this.txtTime4_Enter);
            this.txtTime4.Leave += new System.EventHandler(this.txtTime4_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "秒";
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.Location = new System.Drawing.Point(234, 129);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(48, 16);
            this.cbx4.TabIndex = 1;
            this.cbx4.TabStop = false;
            this.cbx4.Text = "激活";
            this.cbx4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "*操作5";
            // 
            // txtKey5
            // 
            this.txtKey5.Location = new System.Drawing.Point(74, 158);
            this.txtKey5.MaxLength = 1000;
            this.txtKey5.Name = "txtKey5";
            this.txtKey5.Size = new System.Drawing.Size(54, 21);
            this.txtKey5.TabIndex = 1;
            this.txtKey5.TabStop = false;
            this.txtKey5.Text = "指定按键";
            this.txtKey5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey5.Enter += new System.EventHandler(this.txtKey5_Enter);
            this.txtKey5.Leave += new System.EventHandler(this.txtKey5_Leave);
            // 
            // txtTime5
            // 
            this.txtTime5.Location = new System.Drawing.Point(138, 158);
            this.txtTime5.MaxLength = 5;
            this.txtTime5.Name = "txtTime5";
            this.txtTime5.Size = new System.Drawing.Size(67, 21);
            this.txtTime5.TabIndex = 2;
            this.txtTime5.TabStop = false;
            this.txtTime5.Text = "时间间隔";
            this.txtTime5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime5.Enter += new System.EventHandler(this.txtTime5_Enter);
            this.txtTime5.Leave += new System.EventHandler(this.txtTime5_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "秒";
            // 
            // cbx5
            // 
            this.cbx5.AutoSize = true;
            this.cbx5.Location = new System.Drawing.Point(234, 160);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(48, 16);
            this.cbx5.TabIndex = 1;
            this.cbx5.TabStop = false;
            this.cbx5.Text = "激活";
            this.cbx5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "执行<F10>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbx4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbx3);
            this.groupBox1.Controls.Add(this.txtKey1);
            this.groupBox1.Controls.Add(this.cbx2);
            this.groupBox1.Controls.Add(this.txtKey2);
            this.groupBox1.Controls.Add(this.cbx1);
            this.groupBox1.Controls.Add(this.txtKey3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKey4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtKey5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTime1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTime2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTime3);
            this.groupBox1.Controls.Add(this.txtTime5);
            this.groupBox1.Controls.Add(this.txtTime4);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClear,
            this.tsbtnEsc,
            this.tsbtnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(320, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(69, 22);
            this.tsbtnClear.Text = "初始化窗口";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // tsbtnEsc
            // 
            this.tsbtnEsc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEsc.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEsc.Image")));
            this.tsbtnEsc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEsc.Name = "tsbtnEsc";
            this.tsbtnEsc.Size = new System.Drawing.Size(33, 22);
            this.tsbtnEsc.Text = "退出";
            this.tsbtnEsc.Click += new System.EventHandler(this.tsbtnEsc_Click);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHelp.Image")));
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(33, 22);
            this.tsbtnHelp.Text = "帮助";
            this.tsbtnHelp.Click += new System.EventHandler(this.tsbtnHelp_Click);
            // 
            // KeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 295);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按键精灵";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyForm_FormClosing);
            this.Load += new System.EventHandler(this.KeyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey3;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKey4;
        private System.Windows.Forms.TextBox txtTime4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbx4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKey5;
        private System.Windows.Forms.TextBox txtTime5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbx5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnEsc;
    }
}

