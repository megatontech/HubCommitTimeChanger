using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoKey
{
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
        }
        string txtTitle1 = "指定按键";
        string txtTitle2 = "时间间隔";
        //
        //操作1
        //
        //获得焦点
        private void txtKey1_Enter(object sender, EventArgs e)
        {
            if (txtKey1.Text.Trim() == txtTitle1)
                txtKey1.Text = "";
        }
        //失去焦点
        private void txtKey1_Leave(object sender, EventArgs e)
        {
            if (txtKey1.Text.Trim() == "")
                txtKey1.Text = txtTitle1;

        }

        private void txtTime1_Enter(object sender, EventArgs e)
        {
            //txtTime1.SelectAll();
            if (txtTime1.Text.Trim() == txtTitle2)
                txtTime1.Text = "1.0";

        }

        private void txtTime1_Leave(object sender, EventArgs e)
        {
            if (txtTime1.Text.Trim() == "")
                txtTime1.Text = txtTitle2;
        }
        //
        //操作2
        //
        //获得焦点
        private void txtKey2_Enter(object sender, EventArgs e)
        {
            if (txtKey2.Text.Trim() == txtTitle1)
                txtKey2.Text = "";
        }
        //失去焦点
        private void txtKey2_Leave(object sender, EventArgs e)
        {
            if (txtKey2.Text.Trim() == "")
                txtKey2.Text = txtTitle1;

        }
       
        private void txtTime2_Enter(object sender, EventArgs e)
        {

            if (txtTime2.Text.Trim() == txtTitle2)
                txtTime2.Text = "1.0";

        }

        private void txtTime2_Leave(object sender, EventArgs e)
        {
            if (txtTime2.Text.Trim() == "")
                txtTime2.Text = txtTitle2;
        }
        //
        //操作3
        //
        //获得焦点
        private void txtKey3_Enter(object sender, EventArgs e)
        {
            if (txtKey3.Text.Trim() == txtTitle1)
                txtKey3.Text = "";
        }
        //失去焦点
        private void txtKey3_Leave(object sender, EventArgs e)
        {
            if (txtKey3.Text.Trim() == "")
                txtKey3.Text = txtTitle1;

        }

        private void txtTime3_Enter(object sender, EventArgs e)
        {

            if (txtTime3.Text.Trim() == txtTitle2)
                txtTime3.Text = "1.0";

        }

        private void txtTime3_Leave(object sender, EventArgs e)
        {
            if (txtTime3.Text.Trim() == "")
                txtTime3.Text = txtTitle2;
        }
        //
        //操作4
        //
        //获得焦点
        private void txtKey4_Enter(object sender, EventArgs e)
        {
            if (txtKey4.Text.Trim() == txtTitle1)
                txtKey4.Text = "";
        }
        //失去焦点
        private void txtKey4_Leave(object sender, EventArgs e)
        {
            if (txtKey4.Text.Trim() == "")
                txtKey4.Text = txtTitle1;

        }

        private void txtTime4_Enter(object sender, EventArgs e)
        {

            if (txtTime4.Text.Trim() == txtTitle2)
                txtTime4.Text = "1.0";

        }

        private void txtTime4_Leave(object sender, EventArgs e)
        {
            if (txtTime4.Text.Trim() == "")
                txtTime4.Text = txtTitle2;
        }
        //
        //操作5
        //
        //获得焦点
        private void txtKey5_Enter(object sender, EventArgs e)
        {
            if (txtKey5.Text.Trim() == txtTitle1)
                txtKey5.Text = "";
        }
        //失去焦点
        private void txtKey5_Leave(object sender, EventArgs e)
        {
            if (txtKey5.Text.Trim() == "")
                txtKey5.Text = txtTitle1;

        }

        private void txtTime5_Enter(object sender, EventArgs e)
        {

            if (txtTime5.Text.Trim() == txtTitle2)
                txtTime5.Text = "1.0";

        }

        private void txtTime5_Leave(object sender, EventArgs e)
        {
            if (txtTime5.Text.Trim() == "")
                txtTime5.Text = txtTitle2;
        }
        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //执行按钮
        private void button1_Click(object sender, EventArgs e)
        {
            CmdStart();
        }

        /// <summary>
        /// 执行的方法
        /// </summary>
        private void CmdStart()
        {
            try
            {
                if (button1.Text.Trim() == "执行<F10>")
                {

                    if (MainControl())
                    {
                        this.Activate();
                        MessageBox.Show("笨蛋，设置错误,或者没有激活对象！", "啊洁哥哥说");
                        return;
                    }
                    button1.Text = "取消";
                    this.Text = "执行按键中...";
                    groupBox1.Enabled = false;
                    tsbtnClear.Enabled = false;
                    tsbtnEsc.Enabled = false;
                }
                else
                {
                    CloseTime();
                    button1.Text = "执行<F10>";
                    this.Text = "按键精灵";
                    groupBox1.Enabled = true;
                    tsbtnClear.Enabled = true;
                    tsbtnEsc.Enabled = true;
                }
            }
            catch
            {
                CloseTime();
                MessageBox.Show("间隔的时间只能是有效的数字，单位是秒！", "啊洁哥哥说");
            }
        }
        /// <summary>
        /// 关闭所有定时器
        /// </summary>
        private void CloseTime()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }
        /// <summary>
        /// 控制方法
        /// </summary>
        private bool MainControl()
        {
            //foreach (Control cbxx in this.Controls )//遍历控件
            //{
            //    if (cbxx is CheckBox)//如果是多选按钮
            //    {
            //        if (cbxx.ch)
            //        {

            //        }
            //    }
            //}
            bool temp = true;
            //time1
            if (cbx1.Checked)
            {
                if (txtKey1.Text.Trim() == "" || txtKey1.Text.Trim() == txtTitle1 || txtTime1.Text.Trim() == "" || txtTime1.Text.Trim() == txtTitle2)
                {
                    CloseTime();
                    return true;
                }
                else
                {
                    timer1.Interval = (int)(double.Parse(txtTime1.Text.Trim()) * 1000);
                    timer1.Enabled = true;
                    temp = false;
                }
            }
            //time2
            if (cbx2.Checked)
            {
                if (txtKey2.Text.Trim() == "" || txtKey2.Text.Trim() == txtTitle1 || txtTime2.Text.Trim() == "" || txtTime2.Text.Trim() == txtTitle2)
                {
                    CloseTime();
                    return true;
                }
                else
                {
                    timer2.Interval = (int)(double.Parse(txtTime2.Text.Trim()) * 1000);
                    timer2.Enabled = true;
                    temp = false;
                }
            }
            //time3
            if (cbx3.Checked)
            {
                if (txtKey3.Text.Trim() == "" || txtKey3.Text.Trim() == txtTitle1 || txtTime3.Text.Trim() == "" || txtTime3.Text.Trim() == txtTitle2)
                {
                    CloseTime();
                    return true;
                }
                else
                {
                    timer3.Interval = (int)(double.Parse(txtTime3.Text.Trim()) * 1000);
                    timer3.Enabled = true;
                    temp = false;
                }
            }
            //time4
            if (cbx4.Checked)
            {
                if (txtKey4.Text.Trim() == "" || txtKey4.Text.Trim() == txtTitle1 || txtTime4.Text.Trim() == "" || txtTime4.Text.Trim() == txtTitle2)
                {
                    CloseTime();
                    return true;
                }
                else
                {
                    timer4.Interval = (int)(double.Parse(txtTime4.Text.Trim()) * 1000);
                    timer4.Enabled = true;
                    temp = false;
                }
            }
            //time5
            if (cbx5.Checked)
            {
                if (txtKey5.Text.Trim() == "" || txtKey5.Text.Trim() == txtTitle1 || txtTime5.Text.Trim() == "" || txtTime5.Text.Trim() == txtTitle2)
                {
                    CloseTime();
                    return true;
                }
                else
                {
                    timer5.Interval = (int)(double.Parse(txtTime5.Text.Trim()) * 1000);
                    timer5.Enabled = true;
                    temp = false;
                }
            }
            return temp;
        }
        //定时器1
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey1.Text);
        }
        //定时器2
        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey2.Text);
        }
        //定时器3
        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey3.Text);
        }
        //定时器4
        private void timer4_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey4.Text);
        }
        //定时器5
        private void timer5_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey5.Text);
        }
        //窗体加载
        private void KeyForm_Load(object sender, EventArgs e)
        {
            //
            //注册热键
            //
            WinKey.RegisterHotKey(Handle, 100, WinKey.KeyModifiers.None, Keys.F10);//100是热键ID可以任意设置但不能重复
            WinKey.RegisterHotKey(Handle, 101, WinKey.KeyModifiers.None, Keys.F11);
        }
        //窗口关闭
        private void KeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            //注销热键
            //
            WinKey.UnregisterHotKey(Handle, 100);
            WinKey.UnregisterHotKey(Handle, 101);
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.WParam.ToInt32())
            {
                case 100://f10
                    CmdStart();
                    break;
                case 101://f11
                    //最小化和普通模式
                    if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
                    {
                        this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                        this.Activate();
                    }
                    else
                    {
                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        //帮助
        private void tsbtnHelp_Click(object sender, EventArgs e)
        {
            string helptxt = "按键精灵2.2版本是用C#编写，比1.0更加稳定计时更加准确，加入全新系统热键，运行全屏程序时按快捷键就可以启动模拟按键！\n可同时模拟５个按键，同样时间间隔是按从下望上执行(比如操作123都被激活，且时间间隔相同，程序先执行操作3然后操作2最后操作1)。\n后２个带*号不限制文字输入可以模拟文本输入,当输入'~'时回自动换行输出。【F10】执行，取消模拟按键【F11】最小化，还原窗口!";
            MessageBox.Show(helptxt, "啊洁哥哥说：");
        }
        //初始化
        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            txtKey1.Text = txtTitle1;
            txtKey2.Text = txtTitle1;
            txtKey3.Text = txtTitle1;
            txtKey4.Text = txtTitle1;
            txtKey5.Text = txtTitle1;
            txtTime1.Text = txtTitle2;
            txtTime2.Text = txtTitle2;
            txtTime3.Text = txtTitle2;
            txtTime4.Text = txtTitle2;
            txtTime5.Text = txtTitle2;
            cbx1.Checked = false;
            cbx2.Checked = false;
            cbx3.Checked = false;
            cbx4.Checked = false;
            cbx5.Checked = false;
        }
        //退出
        private void tsbtnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}