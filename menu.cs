using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ClipboardSaver
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        /*  
           
           [Version 1.5]
          
            Project link: www.github.com/aemirdnr/clipboardsaver

            Author: www.github.com/aemirdnr

        */

        string copyh;
        int indexMenuItem = 0;

        void TakeCopy()
        {            
            copyh = Clipboard.GetText();

            //If list already have data, don't save it.
            if (!copyHistory.Items.Contains(copyh))
            {              
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
                historyBox.Items.Add(item);
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


            Application.Exit();
        }

        #region ListBox Settings

        private void copyHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (copyHistory.SelectedItem != null)
                Clipboard.SetText(copyHistory.SelectedItem.ToString());
        }

        private void historyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyBox.SelectedItem != null)
                Clipboard.SetText(historyBox.SelectedItem.ToString());
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
        #endregion
    }
}
