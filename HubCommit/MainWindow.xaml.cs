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
            datepicker.Text = DateTime.Now.ToShortDateString();
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
        /// 调用win32API修改系统时间
        /// </summary>
        /// <returns></returns>
        public bool changeCurrDateTime()
        {
            {
                int randomday = 0;
                Random ran = new Random();
                randomday = ran.Next(0,80)*-1;
                DateTime t = currentDate.AddDays(randomday);
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(t.Date, t);
                Win32API.SetLocalTime(ref st);
            }
            return true;
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