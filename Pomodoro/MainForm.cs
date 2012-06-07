using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;

namespace Pomodoro
{
    public partial class MainForm : Form
    {
        //private const string TickFile = @"Sounds\Blip.wav";
        //private const string TickFile = @"Sounds\Utopia - Chiusura.wav";
        //private const string TickFile = @"Sounds\Utopia predefinito.wav";
        //private const string TickFile = @"Sounds\thin.bell.wav";
        private const string TickFile = @"Sounds\tick.wav";

        //private const string RingFile = @"Sounds\ringin.wav";
        //private const string RingFile = @"Sounds\tiptoe.thru.the.tulips.wav";
        private const string RingFile = @"Sounds\ring.wav";

        private DateTime StopTime;
        private AutoResetEvent StopCount = new AutoResetEvent(false);
        private ManualResetEvent CountStopped = new ManualResetEvent(true);

        private SoundManager TickPlayer = new SoundManager(TickFile);
        private SoundManager RingPlayer = new SoundManager(RingFile);

        public MainForm()
        {
            InitializeComponent();
            SecondsLeft = 0;

            InitsFromAppSettings();

            InitTrayIcon();

            DTPSpan.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            DTPSpan.Text = TimeSpan.Zero.ToString();
        }

        private void InitsFromAppSettings()
        {
            bool Res;
            bool Value;

            Res = bool.TryParse(ConfigurationManager.AppSettings["EnableTick"], out Value);
            if (Res) { TickMenuItem.Checked = Value; } //else già a default

            Res = bool.TryParse(ConfigurationManager.AppSettings["EnableAlarm"], out Value);
            if (Res) { AlarmMenuItem.Checked = Value; } //else già a default
        }

        private void InitTrayIcon()
        {
            TrayIcon.Text = this.Text + ": 0";
            TrayIcon.Icon = this.Icon;
            StartTrayMenuItem.Text = Start.Text;
            Start25TrayMenuItem.Text = Start25.Text;
            Start15TrayMenuItem.Text = Start15.Text;
            Start5TrayMenuItem.Text = Start5.Text;
            Start2TrayMenuItem.Text = Start2.Text;
            StopTrayMenuItem.Text = Stop.Text;
        }

        private delegate void WriteDelegate(int seconds);
        private void UpdateTime(int seconds)
        {
            TimeSpan ts = new TimeSpan(0, 0, seconds).Duration();
            StringBuilder sb = new StringBuilder();

            if (seconds < 0) { sb.Append("-"); }
            if (ts.Hours != 0) { sb.AppendFormat("{0}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds); }
            else if (ts.Minutes != 0) { sb.AppendFormat("{0}:{1:D2}", ts.Minutes, ts.Seconds); }
            else { sb.Append(ts.Seconds); }

            Time.Text = sb.ToString();
            sb.Insert(0, this.Text + ": ");
            TrayIcon.Text = sb.ToString();
            
            if (seconds <= 0) { TimeBar.Value = -seconds; }
        }
        public int SecondsLeft
        {
            set
            {
                if (Time.InvokeRequired)
                {
                    BeginInvoke(new WriteDelegate(UpdateTime), value);
                }
                else
                {
                    UpdateTime(value);
                }
            }
        }

        private void StartCount(int timeout)//TODO Creare classe specifica per esecuzione
        {
            StopCount.Set();
            if (!CountStopped.WaitOne(1000, false)) { return; }
            StopCount.Reset();

            StopTime = DateTime.Now.AddSeconds(timeout);
            TimeBar.Maximum = timeout;

            ThreadPool.QueueUserWorkItem(new WaitCallback(Count), this);//Count();

            //ThreadPool.QueueUserWorkItem(new WaitCallback(
            //    delegate(object o) { ((Form1)o).Count; }),
            //    this);

            Thread.Sleep(0);
        }

        private void Count(object o)
        {
            MainForm form = (MainForm)o;
            TimeSpan ts;
            bool Active = true;

            try
            {
                CountStopped.Reset();

                if (TickMenuItem.Checked) { TickPlayer.Start(); }
                ts = DateTime.Now.Subtract(form.StopTime);
                form.SecondsLeft = (int)ts.TotalSeconds;
                while (!form.StopCount.WaitOne(1000, false))
                {
                    ts = DateTime.Now.Subtract(form.StopTime);
                    form.SecondsLeft = (int)ts.TotalSeconds;

                    if (Active)
                    {
                        if (ts.TotalSeconds >= 0)
                        {
                            Active = false;
                            form.Ripristina();
                            TickPlayer.Stop();
                            if (AlarmMenuItem.Checked) { RingPlayer.Start(); }
                            //TODO Registrazione pomodoro ("Conserva")
                        }
                    }
                    if (ts.TotalSeconds >= 5)
                    {
                        RingPlayer.Stop();
                    }
                }
            }
            finally
            {
                TickPlayer.Stop();
                RingPlayer.Stop();
                SecondsLeft = 0;

                CountStopped.Set();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CustomStart();
        }

        private void CustomStart()
        {
            //StartCount((int)Span.Value.TimeOfDay.TotalSeconds);
            double secs;

            if (double.TryParse(Span.Text, out secs) && secs > 0)
            {
                StartCount((int)TimeSpan.FromSeconds(secs).TotalSeconds);
            }
            else
            {
                MessageBox.Show("Scrivi un intervallo positivo espresso in secondi.");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            StopCount.Set();
        }

        private void Start25_Click(object sender, EventArgs e)
        {
            StartCount(25 * 60);
        }

        private void Start15_Click(object sender, EventArgs e)
        {
            StartCount(15 * 60);
        }

        private void Start5_Click(object sender, EventArgs e)
        {
            StartCount(5 * 60);
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            StartCount(2 * 60);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["EnableTick"].Value = TickMenuItem.Checked.ToString();
            config.AppSettings.Settings["EnableAlarm"].Value = AlarmMenuItem.Checked.ToString();
            config.Save(ConfigurationSaveMode.Full); //Attenzione: dall'ambiente non funziona
        }

        private void Span_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CustomStart();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { Hide(); }
        }

        private void ChiudiTrayMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Ripristina();
                    break;
                case MouseButtons.Right:
                    TrayMenu.Show();
                    break;
            }
        }

        private void RipristinaTrayMenuItem_Click(object sender, EventArgs e)
        {
            Ripristina();
        }

        private delegate void RestoreDelegate();
        private void Restore()
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }
        private void Ripristina()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new RestoreDelegate(Restore));
            }
            else
            {
                Restore();
            }
        }
    }
}