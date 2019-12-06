/*  
    [Version 1.6]
    Project link: www.github.com/aemirdnr/clipboardsaver
    Author: www.github.com/aemirdnr
*/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClipboardSaver
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        string copyh;
        int indexMenuItem = 0;

        void TakeCopy()
        {            
            copyh = Clipboard.GetText();
            if (string.IsNullOrEmpty(copyh))
                return;

            //If list already have data, don't save it.
            if (!copyHistory.Items.Contains(copyh))
            {
                /*
                DateTime now = DateTime.Now;
                dataHistoryView.Items.Add(Convert.ToString(now.Hour) + ":" + Convert.ToString(now.Minute) + ":" + Convert.ToString(now.Second));
                */
                copyHistory.Items.Add(copyh);

                ToolStripMenuItem[] menuItem = { firstCopy, secondCopy, thirdCopy, fourthCopy, fifthCopy };

                if (indexMenuItem == 5)
                    indexMenuItem = 0;

                menuItem[indexMenuItem++].Text = string.Concat(indexMenuItem, ". " , copyh); 
            }
        }
        
        private void menu_Load(object sender, EventArgs e)
        {
            wUp.Checked = Properties.Settings.Default.cbox;
            copyTimer.Start();

            //Last History Tab Settings
            string data = Properties.Settings.Default.lasthstry;
            string[] sData = data.Split('*');
            foreach (var item in sData)
            {
                if (!historyBox.Items.Contains(item))
                {
                    historyBox.Items.Add(item);
                }            
            }
        }
        private void copyTimer_Tick(object sender, EventArgs e)
        {
            TakeCopy();
        }
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Add data to settings
            foreach (var data in copyHistory.Items)
            {
                Properties.Settings.Default.lasthstry += data + "*";
            }
            Properties.Settings.Default.Save();
        }

        #region ListBox Settings

        private void DeleteItem(object sender, EventArgs e)
        {
            ListBox selectedLb = (ListBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            if (selectedLb.SelectedItem != null)
            {
                if (selectedLb.Items.Count > 1)
                {
                    selectedLb.Items.Remove(selectedLb.SelectedItem);
                }
                else
                {
                    Clipboard.Clear();
                    selectedLb.Items.Remove(selectedLb.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("You must select item.", "Clipboard Saver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                         
        }
        private void CopyItem(object sender, EventArgs e)
        {
            ListBox selectedLb = (ListBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            if (selectedLb.SelectedItem != null)
            {
                Clipboard.SetText(selectedLb.SelectedItem.ToString());
            }             
            else
            { 
                MessageBox.Show("You must select item.", "Clipboard Saver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("Clipboard Saver", "\"" + Application.ExecutablePath + "\"");
            }
        }
        public static void RemoveApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("Clipboard Saver", false);
            }
        }


        #endregion

        #region Notification Settings
        private void notification_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        //Notification Context Menu Events 
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        private void copyClick(object sender, EventArgs e)
        {
            Clipboard.SetText(sender.ToString());
        }
        private void copyLast_Click(object sender, EventArgs e)
        {
            int count = copyHistory.Items.Count - 2;
            string lastcopy = copyHistory.Items[count].ToString();
            Clipboard.SetText(lastcopy);
        }
        #endregion

        #region CheckBox Settings
        private void wUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cbox = wUp.Checked;
            Properties.Settings.Default.Save();

            if (wUp.Checked)
            {
                AddApplicationToStartup();
            }
            else
            {
                RemoveApplicationFromStartup();
            }
        }
        #endregion

        #region Button Settings
        private void ClearLastButton_Click(object sender, EventArgs e)
        {
            historyBox.Items.Clear();
            Properties.Settings.Default.lasthstry = "";       
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            copyHistory.Items.Clear();
        }
        private void hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            if (stopButton.Text != "STOP")
            {
                copyTimer.Start();
                stopButton.Text = "STOP";
                onOfLabel.Text = "STATUS: ON";
                onOfLabel.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                copyTimer.Stop();
                stopButton.Text = "START";
                onOfLabel.Text = "STATUS: OFF";
                onOfLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        #endregion
    }
}
