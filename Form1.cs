using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Windows.Forms;

namespace subte.cc
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        private string stringBuilder()
        {
            String domainString = "";
            foreach(Control domainsBox in tabPage1.Controls)
            {
                if (domainsBox.GetType() == typeof(TextBox))
                {
                    if(domainsBox.Text != "")
                    {
                        domainString = domainString + domainsBox.Text + ",";
                    }
                }
            }
            return domainString;
        }
        private async void refreshIPs()
        {
            string url = "https://subte.cc/up?domains=" + stringBuilder();
            client.DefaultRequestHeaders.Add("X-Api-Key", tokenBox.Text);
            try
            {
               string response = await client.GetStringAsync(url);
                if (response == "OK" && Properties.Settings.Default.notifications) notifyIcon1.ShowBalloonTip(5000, "Success", "Domains have updated successfully", ToolTipIcon.Info);
            }
            catch (HttpRequestException ex)
            {
                if(Properties.Settings.Default.notifications) notifyIcon1.ShowBalloonTip(5000, "An error ocurred", ex.ToString(), ToolTipIcon.Warning);
            }

        }

        private void updateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (updateBox.Checked)
            {
                autoupdateLabel.Enabled = true;
                timeLabel.Enabled = true;
                updateInterval.Enabled = true;
                timer1.Enabled = true;
            }
            else
            {
                autoupdateLabel.Enabled = false;
                timeLabel.Enabled = false;
                updateInterval.Enabled = false;
                timer1.Enabled = false;
            }
            Properties.Settings.Default.autoUpdate = updateBox.Checked;
            Properties.Settings.Default.Save();
        }


        private void autostartBox_CheckedChanged(object sender, EventArgs e)
        {
            // The registry key for current user startup programs
            string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            string appName = "subte.cc";
            string appPath = Assembly.GetExecutingAssembly().Location;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
            {
                if (autostartBox.Checked)
                    key.SetValue(appName, appPath);
                else
                    key.DeleteValue(appName, false);
            }
            Properties.Settings.Default.autoStart = autostartBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && updateBox.Checked)
            { 
                if(Properties.Settings.Default.notifications) notifyIcon1.ShowBalloonTip(3000);
                this.Hide();
            }
            else
            {
                this.Show();
            }
            
        }

        private void updateInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)updateInterval.Value * 60000;
            Properties.Settings.Default.updateInterval = updateInterval.Value;
            Properties.Settings.Default.Save();
        }

        private void tokenBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.token = tokenBox.Text;
            Properties.Settings.Default.Save();
        }
        private void settingsLoader()
        {
            autostartBox.Checked = Properties.Settings.Default.autoStart;
            updateBox.Checked = Properties.Settings.Default.autoUpdate;
            notificationsBox.Checked = Properties.Settings.Default.notifications;
            tokenBox.Text = Properties.Settings.Default.token;
            updateInterval.Value = Properties.Settings.Default.updateInterval;
            domain1.Text = Properties.Settings.Default.domain1;
            domain2.Text = Properties.Settings.Default.domain2;
            domain3.Text = Properties.Settings.Default.domain3;
            domain4.Text = Properties.Settings.Default.domain4;
            domain5.Text = Properties.Settings.Default.domain5;
        }
        private void domains_TextChanged(object sender, EventArgs e)
        {
            // If you know a better way of doing this let me know
            Properties.Settings.Default.domain1 = domain1.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.domain2 = domain2.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.domain3 = domain3.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.domain4 = domain4.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.domain5 = domain5.Text;
            Properties.Settings.Default.Save();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            settingsLoader();
            if(Properties.Settings.Default.autoStart) this.WindowState = FormWindowState.Minimized; ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refreshIPs();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshIPs();
        }

        private void notificationsBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.notifications = notificationsBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://codeberg.org/subte-cc/subteccwindows");
        }
    }
}
