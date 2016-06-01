using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace HubCommit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process proc = null;
        private ObservableCollection<ViewModel> pendingDic = new ObservableCollection<ViewModel>();

        public MainWindow()
        {
            InitializeComponent();
            proc = new Process();
            listBox.ItemsSource = pendingDic;
        }

        #region Event

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            changeCurrDateTime();
        }

        /// <summary>
        /// 暂存列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
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
        /// 调用win32API修改系统时间
        /// </summary>
        /// <returns></returns>
        public bool changeCurrDateTime()
        {
            DateTime t = DateTime.Now;
            SYSTEMTIME st = new SYSTEMTIME();
            st.FromDateAndTime(datepicker.SelectedDate.Value, t);
            Win32API.SetLocalTime(ref st);
            //RunCmd("date "+ (datepicker.SelectedDate.HasValue?DateTime.Now.ToString("yyyy/MM/dd") :datepicker.SelectedDate.Value.ToString("yyyy/MM/dd")));
            return true;
        }

        ///// <summary>
        ///// 执行CMD语句，经测试win10下不能用，废弃
        ///// </summary>
        ///// <param name="cmd">要执行的CMD命令</param>
        //public void RunCmd(string cmd)
        //{
        //    proc.StartInfo.CreateNoWindow = true;
        //    proc.StartInfo.FileName = "cmd.exe";
        //    proc.StartInfo.UseShellExecute = false;
        //    proc.StartInfo.RedirectStandardError = true;
        //    proc.StartInfo.RedirectStandardInput = true;
        //    proc.StartInfo.RedirectStandardOutput = true;
        //    proc.Start();
        //    proc.StandardInput.WriteLine(cmd);
        //    string output = proc.StandardOutput.ReadToEnd();
        //    proc.WaitForExit();
        //    proc.Close();
        //}

        ///// <summary>
        ///// 打开软件并执行命令，经测试win10下不能用，废弃
        ///// </summary>
        ///// <param name="programName">软件路径加名称（.exe文件）</param>
        ///// <param name="cmd">要执行的命令</param>
        //public void RunProgram(string programName, string cmd)
        //{
        //    Process proc = new Process();
        //    proc.StartInfo.CreateNoWindow = true;
        //    proc.StartInfo.FileName = programName;
        //    proc.StartInfo.UseShellExecute = false;
        //    proc.StartInfo.RedirectStandardError = true;
        //    proc.StartInfo.RedirectStandardInput = true;
        //    proc.StartInfo.RedirectStandardOutput = true;
        //    proc.Start();
        //    if (cmd.Length != 0)
        //    {
        //        proc.StandardInput.WriteLine(cmd);
        //    }
        //    proc.Close();
        //}

        ///// <summary>
        ///// 打开软件，经测试win10下不能用，废弃
        ///// </summary>
        ///// <param name="programName">软件路径加名称（.exe文件）</param>
        //public void RunProgram(string programName)
        //{
        //    this.RunProgram(programName, "");
        //}

        #endregion Method
    }

    public class ViewModel
    {
        public SYSTEMTIME st { get; set; }
        public string text { get; set; }
    }
}