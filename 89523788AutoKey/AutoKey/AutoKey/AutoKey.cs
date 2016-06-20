using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
	public partial class AutoKey : Form
	{
		public AutoKey()
		{
			InitializeComponent();
		}

		private const int RUN_WAIT = 100;
		private int StartIndex = 3;
		private void timer2_Tick(object sender, EventArgs e)
		{
			StartIndex--;
			lblInfo.Text = StartIndex.ToString() + "秒后开始！";
			if (StartIndex == 0)
			{
				timer2.Stop();
				timer1.Interval = RUN_WAIT;
				timer1.Start();
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (linkHelp.Text == "关闭")
			{
				txtCode.Text = oldText;
				linkHelp.Text = "帮助";
			}
			if (btnGo.Text == "停 止")
			{
				timer2.Stop();
				timer1.Stop();
				lblInfo.Text = "";
				btnGo.Text = "开 始";
			}
			else
			{
				if (txtCode.Text == "")
				{
					return;
				}
				codeList = new List<string>();
				codeIndex = 0;
				foreach (string r in txtCode.Text.Split('\r'))
				{
					if (r.Trim() != "")
					{
						codeList.Add(r.Trim());
					}
				}
				StartIndex = 3;
				btnGo.Text = "停 止";
				lblInfo.Text = StartIndex.ToString() + "秒后开始！";
				timer2.Start();
			}
		}

		//自动执行
		private IList<string> codeList = null;
		private int codeIndex = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			timer1.Interval = RUN_WAIT;
			lblInfo.Text = string.Format("{0}/{1} {2}", codeIndex + 1, codeList.Count, codeList[codeIndex]);
			string code = codeList[codeIndex];
			int split = code.IndexOf(':');
			string codeType = "";
			string codeContent = "";
			if (split > 0)
			{
				codeType = code.Substring(0, split);
				codeContent = code.Substring(split + 1);
			}
			else
			{
				codeType = code;
			}
			codeType = codeType.Trim().ToUpper();
			if (Enum.IsDefined(typeof(CmdType),codeType))
			{
				try
				{
					CmdType cmdType = (CmdType)Enum.Parse(typeof(CmdType), codeType);
					switch (cmdType)
					{
						case CmdType.INPUT:
							cmdInput(codeContent);
							break;
						case CmdType.RUN:
							cmdRun(codeContent);
							break;
						case CmdType.KEY:
							cmdKey(codeContent);
							break;
						case CmdType.SLEEP:
							cmdSleep(codeContent);
							break;
						case CmdType.MOUSE_MOVE:
							cmdMouseMove(codeContent);
							break;
						case CmdType.MOUSE_CLICK:
							cmdMouseClick();
							break;
						case CmdType.MOUSE_DBCLICK:
							cmdMouseDBClick();
							break;
						case CmdType.SCREEN:
							cmdScreen();
							break;
						case CmdType.ALL_SCREEN:
							cmdAllScreen();
							break;
						default:
							break;
					}
				}
				catch(Exception ex)
				{
					btnGo.PerformClick();
					MessageBox.Show("运行[" + code + "]时失败！\r\n\r\n错误原因：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			codeIndex++;
			if (codeIndex == codeList.Count)
			{
				btnGo.PerformClick();
			}
			else
			{
				timer1.Start();
			}
		}

		#region 命令类型
		/// <summary>
		/// 命令类型
		/// </summary>
		private enum CmdType
		{
			/// <summary>
			/// 输入
			/// </summary>
			INPUT,

			/// <summary>
			/// 运行
			/// </summary>
			RUN,

			/// <summary>
			/// 按键
			/// </summary>
			KEY,

			/// <summary>
			/// 暂停
			/// </summary>
			SLEEP,

			/// <summary>
			/// 鼠标移动
			/// </summary>
			MOUSE_MOVE,

			/// <summary>
			/// 鼠标单击
			/// </summary>
			MOUSE_CLICK,

			/// <summary>
			/// 鼠标双击
			/// </summary>
			MOUSE_DBCLICK,

			/// <summary>
			/// 窗口截屏
			/// </summary>
			SCREEN,

			/// <summary>
			/// 全屏截屏
			/// </summary>
			ALL_SCREEN
		}
		#endregion

		#region 命令
		private void cmdInput(string str)
		{
			Clipboard.Clear();
			Clipboard.SetText(str);
			SendKeys.SendWait("^v");
		}
		private void cmdRun(string str)
		{
			Process.Start(str);
		}
		private void cmdKey(string str)
		{
			SendKeys.SendWait(str);
		}
		private void cmdSleep(string str)
		{
			int t = 0;
			if (int.TryParse(str, out t))
			{
				if (t > RUN_WAIT)
				{
					timer1.Interval = t;
				}
			}
		}
		private void cmdScreen()
		{
			Clipboard.Clear();
			SendKeys.SendWait("{PRTSC}");
			if (Clipboard.ContainsImage())
			{
				Image img = Clipboard.GetImage();
				savePic(img);
				img.Dispose();
				Clipboard.Clear();
			}
		}
		private void cmdAllScreen()
		{
			Rectangle rect = Screen.PrimaryScreen.Bounds;
			using (Bitmap bmp = new Bitmap(rect.Width, rect.Height))
			{
				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.CopyFromScreen(0, 0, 0, 0, new Size(rect.Width, rect.Height));
				}
				savePic(bmp);
			}
		}
		private void savePic(Image img)
		{
			string strScreenPath = Application.StartupPath + "\\SCREEN\\";
			if (!System.IO.Directory.Exists(strScreenPath))
			{
				System.IO.Directory.CreateDirectory(strScreenPath);
			}
			img.Save(strScreenPath + Guid.NewGuid().ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
		}

		[Flags]
		enum MouseEventFlag : uint
		{
			Move = 0x0001,
			LeftDown = 0x0002,
			LeftUp = 0x0004,
			RightDown = 0x0008,
			RightUp = 0x0010,
			MiddleDown = 0x0020,
			MiddleUp = 0x0040,
			XDown = 0x0080,
			XUp = 0x0100,
			Wheel = 0x0800,
			VirtualDesk = 0x4000,
			Absolute = 0x8000,
		}

		[DllImport("user32.dll")]
		static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr ext);

		private void cmdMouseMove(string str)
		{
			string[] strs = str.Split(',');
			if (strs.Length == 2)
			{
				int x = int.Parse(strs[0]);
				int y = int.Parse(strs[1]);
				Cursor.Position = new Point(x, y);
			}
		}
		private void cmdMouseClick()
		{
			mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
			mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
		}
		private void cmdMouseDBClick()
		{
			cmdMouseClick();
			cmdMouseClick();
		}
		#endregion

		private string oldText = "";
		private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (linkHelp.Text == "帮助")
			{
				oldText = txtCode.Text;
				linkHelp.Text = "关闭";
				txtCode.Text = @"========================
按键工具 AutoKey v1.0 
========================
作者：http://www.cnblogs.com/zjfree
日期：2012-01-31

输入格式为：命令:内容 每行一条命令

INPUT         输入文本
RUN           运行程序
KEY           模拟按键
SLEEP         暂停
MOUSE_MOVE    鼠标移动
MOUSE_CLICK   鼠标单击
MOUSE_DBCLICK 鼠标双击
SCREEN        窗口截屏
ALL_SCREEN    全屏截屏

KEY 辅助说明 按照C# SendKeys.Send 函数要求

字母或数字 a-z A-Z 0-9
Alt    %
Ctrl   ^
Shift  +
向上键 {UP} 
向下键 {DOWN}  
向左键 {LEFT}  
向右键 {RIGHT}  
Enter  {ENTER} 或 ~  
Backspace {BACKSPACE}、{BS} 或 {BKSP}  
Break     {BREAK}  
Caps Lock {CAPSLOCK}  
Scroll Lock   {SCROLLLOCK}  
Print Screen  {PRTSC}（保留供将来使用）  
Del 或 Delete {DELETE} 或 {DEL}  
End   {END}  
Esc   {ESC}  
Help  {HELP}  
Home  {HOME}  
Ins 或 Insert  {INSERT} 或 {INS}  
Num Lock   {NUMLOCK}  
Page Down  {PGDN}  
Page Up    {PGUP}  
Tab        {TAB}  
F1-F16     {F1-F16} 
数字键盘加号 {ADD}  
数字键盘减号 {SUBTRACT} 
数字键盘乘号 {MULTIPLY}  
数字键盘除号 {DIVIDE} 
特殊键 {{} {%}
重复键 {h 10}
组合键 ^(AC)
";
			}
			else
			{
				txtCode.Text = oldText;
				linkHelp.Text = "帮助";
				txtCode.Focus();
			}
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			timer3.Stop();
			int x = Control.MousePosition.X;
			int y = Control.MousePosition.Y;
			lblPosition.Text = string.Format("鼠标坐标: {0},{1}", x, y);
			
			Rectangle rect = Screen.PrimaryScreen.Bounds;
			using (Bitmap bmp = new Bitmap(1, 1))
			{
				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
				}
				lblColor.BackColor = bmp.GetPixel(0, 0);
			}

			timer3.Start();
		}

		private void AutoKey_Load(object sender, EventArgs e)
		{
			timer3.Start();
		}
	}
}