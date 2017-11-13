using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Timers;
using System.Runtime.InteropServices;
using HubCommit;

namespace HubCommitWinform
{
    public partial class Form1 : Form
    {
        private Process proc = null;
        private ObservableCollection<ViewModel> pendingDic = new ObservableCollection<ViewModel>();
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        private DateTime currentDate = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;    // 1秒 = 1000毫秒
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aTimer.Start();
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            changeCurrDateTime();
        }
        public bool changeCurrDateTime()
        {
            {
                int randomday = 0;
                Random ran = new Random();
                randomday = ran.Next(0, 365) * 1;
                DateTime t = currentDate.AddDays(randomday);
                SYSTEMTIME st = new SYSTEMTIME();
                st.FromDateAndTime(t.Date, t);
                Win32API.SetLocalTime(ref st);
            }
            return true;
        }
    }
    public class ViewModel
    {
        public SYSTEMTIME st { get; set; }
        public string text { get; set; }
    }
}
