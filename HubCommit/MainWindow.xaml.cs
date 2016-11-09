using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Timers;
using System.Windows.Forms;

namespace HubCommit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process proc = null;
        private ObservableCollection<ViewModel> pendingDic = new ObservableCollection<ViewModel>();
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        private DateTime currentDate = DateTime.Now;
        private int maxLoop = 99;
        private int currLoop = 0;
        public MainWindow()
        {
            InitializeComponent();
            proc = new Process();
            listBox.ItemsSource = pendingDic;
            datepicker.Text = "2016-06-06";
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;    // 1秒 = 1000毫秒
        }

        #region Event
        /// <summary>
        /// Timer的Elapsed事件处理程序
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            changeCurrDateTime();
            //performCommit();
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            aTimer.Start();
        }

        /// <summary>
        /// 暂存列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == System.Windows.Input.Key.Enter && datepicker.SelectedDate!=null)
            {
                DateTime t = DateTime.Now;
                SYSTEMTIME stimt = new SYSTEMTIME();
                stimt.FromDateAndTime(datepicker.SelectedDate.Value, t);
                ViewModel model = new ViewModel();
                model.st = stimt;
                model.text = textBox.Text;
                pendingDic.Add(model);
            }
        }

        #endregion Event

        #region Method
        /// <summary>
        /// smart 的提交快捷键，只要激活就可以提交
        /// </summary>
        public void performCommit()
        {
            //currLoop++;
            //if (maxLoop>currLoop)
            //{
            //    SendKeys.Send("^{K}");
            //    SendKeys.Send("^{V}");
            //    SendKeys.Send("%{C}");
            //}
        }
        /// <summary>
        /// 调用win32API修改系统时间
        /// </summary>
        /// <returns></returns>
        public bool changeCurrDateTime()
        {
            {
                int randomday = 0;
                Random ran = new Random();
                randomday = ran.Next(0,150)*-1;
                DateTime t = currentDate.AddDays(randomday);
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(t.Date, t);
                Win32API.SetLocalTime(ref st);
            }
            return true;
        }

        /// <summary>
        /// 执行CMD语句，经测试win10下不能用，废弃
        /// </summary>
        /// <param name="cmd">要执行的CMD命令</param>
        public void RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            proc.Close();
        }

        /// <summary>
        /// 打开软件并执行命令，经测试win10下不能用，废弃
        /// </summary>
        /// <param name="programName">软件路径加名称（.exe文件）</param>
        /// <param name="cmd">要执行的命令</param>
        public void RunProgram(string programName, string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = programName;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            if (cmd.Length != 0)
            {
                proc.StandardInput.WriteLine(cmd);
            }
            proc.Close();
        }

        /// <summary>
        /// 打开软件，经测试win10下不能用，废弃
        /// </summary>
        /// <param name="programName">软件路径加名称（.exe文件）</param>
        public void RunProgram(string programName)
        {
            this.RunProgram(programName, "");
        }

        #endregion Method

        private void datepicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (datepicker.SelectedDate != null)
            {
                DateTime t = DateTime.Now;
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(datepicker.SelectedDate.Value, t);
                Win32API.SetLocalTime(ref st);
            }
            //RunCmd("date "+ (datepicker.SelectedDate.HasValue?DateTime.Now.ToString("yyyy/MM/dd") :datepicker.SelectedDate.Value.ToString("yyyy/MM/dd")));
        }

        private void datepicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if (datepicker.SelectedDate != null)
            {
                DateTime t = DateTime.Now;
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(datepicker.SelectedDate.Value, t);
                Win32API.SetLocalTime(ref st);
            }
        }
    }

    public class ViewModel
    {
        public SYSTEMTIME st { get; set; }
        public string text { get; set; }
    }
}