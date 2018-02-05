using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

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
        private static DateTime currentDate = DateTime.Now;
        private string sourcePath = "";
        private string destPath = "";
        private string repoPath = @"D:\Github\FreeIOT";

        public MainWindow()
        {
            InitializeComponent();
            Label3.Content = currentDate.ToString("yyyy-MM-dd hh:mm:ss");
            proc = new Process();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 2000;    // 1秒 = 1000毫秒
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
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            aTimer.Stop();
        }

        /// <summary>
        /// push
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            aTimer.Stop();
        }

        /// <summary>
        /// 源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = openFileDialog.FileName;
                sourcePath = filePath.Remove(openFileDialog.FileName.LastIndexOf(@"\"), (openFileDialog.FileName.Length - openFileDialog.FileName.LastIndexOf(@"\")));
                Label1.Content = sourcePath;
            }
        }

        /// <summary>
        /// 目标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = openFileDialog.FileName;
                destPath = filePath.Remove(openFileDialog.FileName.LastIndexOf(@"\"), (openFileDialog.FileName.Length - openFileDialog.FileName.LastIndexOf(@"\")));
                Label2.Content = destPath;
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
            {
                int randomday = 0;
                Random ran = new Random();
                randomday = ran.Next(0, 365) * 1;
                randomday = randomday * (randomday % 2 == 1 ? -1 : 1);
                DateTime t = currentDate.AddDays(randomday);
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(t.Date, t);
                Win32API.SetLocalTime(ref st);
                gitOperation();
            }
            return true;
        }

        public void gitOperation()
        {
            string randomid = Guid.NewGuid().ToString();
            string str = Console.ReadLine();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序
            p.StandardInput.WriteLine(@"move /Y " + GetFirstFileStr(sourcePath) + " " + destPath + " ");//向cmd窗口发送输入信息
            p.StandardInput.WriteLine(@"cd " + destPath + "");//向cmd窗口发送输入信息
            p.StandardInput.WriteLine(@"git add .");//向cmd窗口发送输入信息
            p.StandardInput.WriteLine(@"git commit -m " + randomid + "");//向cmd窗口发送输入信息
            p.StandardInput.AutoFlush = true;
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            Console.WriteLine(output);
        }

        public string GetFirstFileStr(string path)
        {
            string filePath = "";
            DirectoryInfo TheFolder = new DirectoryInfo(path);
            filePath = TheFolder.GetFiles().FirstOrDefault().FullName;
            
            return filePath;
        }

        #endregion Method

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

    public class ViewModel
    {
        public SYSTEMTIME st { get; set; }
        public string text { get; set; }
    }
}