namespace WindowsApplication1
{
	partial class AutoKey
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
			this.btnGo = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblInfo = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.linkHelp = new System.Windows.Forms.LinkLabel();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGo.Location = new System.Drawing.Point(12, 255);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 31);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "开 始";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtCode
			// 
			this.txtCode.AcceptsReturn = true;
			this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCode.Location = new System.Drawing.Point(12, 29);
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCode.Size = new System.Drawing.Size(290, 220);
			this.txtCode.TabIndex = 3;
			this.txtCode.Text = "run:notepad\r\ninput:hello 哈哈\r\nkey:{@ 10}\r\nscreen\r\nsleep:1000\r\nkey:%{F4}\r\nsleep:100" +
				"0\r\nkey:n\r\nmouse_move:3,3\r\nmouse_click";
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(93, 264);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(0, 12);
			this.lblInfo.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// linkHelp
			// 
			this.linkHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkHelp.AutoSize = true;
			this.linkHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkHelp.Location = new System.Drawing.Point(273, 9);
			this.linkHelp.Name = "linkHelp";
			this.linkHelp.Size = new System.Drawing.Size(29, 12);
			this.linkHelp.TabIndex = 2;
			this.linkHelp.TabStop = true;
			this.linkHelp.Text = "帮助";
			this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(28, 9);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(53, 12);
			this.lblPosition.TabIndex = 1;
			this.lblPosition.Text = "鼠标位置";
			// 
			// lblColor
			// 
			this.lblColor.AutoSize = true;
			this.lblColor.BackColor = System.Drawing.Color.White;
			this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblColor.Location = new System.Drawing.Point(12, 7);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(13, 14);
			this.lblColor.TabIndex = 0;
			this.lblColor.Text = " ";
			// 
			// AutoKey
			// 
			this.AcceptButton = this.btnGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 294);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.linkHelp);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.btnGo);
			this.MaximizeBox = false;
			this.Name = "AutoKey";
			this.Text = "AutoKey";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AutoKey_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.LinkLabel linkHelp;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblColor;
	}
}