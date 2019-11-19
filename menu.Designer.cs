namespace ClipboardSaver
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.copyHistory = new System.Windows.Forms.ListBox();
            this.hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyTimer = new System.Windows.Forms.Timer(this.components);
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifiMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.secondCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.fourthCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.fifthCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLast = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wUp = new System.Windows.Forms.CheckBox();
            this.notifiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyHistory
            // 
            this.copyHistory.FormattingEnabled = true;
            this.copyHistory.Location = new System.Drawing.Point(9, 6);
            this.copyHistory.Margin = new System.Windows.Forms.Padding(2);
            this.copyHistory.Name = "copyHistory";
            this.copyHistory.Size = new System.Drawing.Size(314, 329);
            this.copyHistory.TabIndex = 0;
            this.copyHistory.SelectedIndexChanged += new System.EventHandler(this.copyHistory_SelectedIndexChanged);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(329, 303);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(112, 31);
            this.hide.TabIndex = 1;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(327, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click to copy \r\nhistory item.\r\n";
            // 
            // copyTimer
            // 
            this.copyTimer.Tick += new System.EventHandler(this.copyTimer_Tick);
            // 
            // notification
            // 
            this.notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notification.BalloonTipText = "Click Here To See Your History.";
            this.notification.BalloonTipTitle = "You Can See Your Clipboard History Now!";
            this.notification.ContextMenuStrip = this.notifiMenu;
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "Clipboard Saver";
            this.notification.Visible = true;
            this.notification.DoubleClick += new System.EventHandler(this.notification_DoubleClick);
            // 
            // notifiMenu
            // 
            this.notifiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherCopiesToolStripMenuItem,
            this.copyLast,
            this.exitMenu});
            this.notifiMenu.Name = "notifiMenu";
            this.notifiMenu.Size = new System.Drawing.Size(150, 70);
            // 
            // otherCopiesToolStripMenuItem
            // 
            this.otherCopiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstCopy,
            this.secondCopy,
            this.thirdCopy,
            this.fourthCopy,
            this.fifthCopy});
            this.otherCopiesToolStripMenuItem.Name = "otherCopiesToolStripMenuItem";
            this.otherCopiesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.otherCopiesToolStripMenuItem.Text = "Other Copies";
            // 
            // firstCopy
            // 
            this.firstCopy.Name = "firstCopy";
            this.firstCopy.Size = new System.Drawing.Size(164, 22);
            this.firstCopy.Text = "1. [EMPTY DATA]";
            this.firstCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // secondCopy
            // 
            this.secondCopy.Name = "secondCopy";
            this.secondCopy.Size = new System.Drawing.Size(164, 22);
            this.secondCopy.Text = "2. [EMPTY DATA]";
            this.secondCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // thirdCopy
            // 
            this.thirdCopy.Name = "thirdCopy";
            this.thirdCopy.Size = new System.Drawing.Size(164, 22);
            this.thirdCopy.Text = "3. [EMPTY DATA]";
            this.thirdCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // fourthCopy
            // 
            this.fourthCopy.Name = "fourthCopy";
            this.fourthCopy.Size = new System.Drawing.Size(164, 22);
            this.fourthCopy.Text = "4. [EMPTY DATA]";
            this.fourthCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // fifthCopy
            // 
            this.fifthCopy.Name = "fifthCopy";
            this.fifthCopy.Size = new System.Drawing.Size(164, 22);
            this.fifthCopy.Text = "5. [EMPTY DATA]";
            this.fifthCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // copyLast
            // 
            this.copyLast.Name = "copyLast";
            this.copyLast.Size = new System.Drawing.Size(149, 22);
            this.copyLast.Text = "Copy The Last";
            this.copyLast.Click += new System.EventHandler(this.copyLast_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(149, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // wUp
            // 
            this.wUp.AutoSize = true;
            this.wUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wUp.Location = new System.Drawing.Point(329, 49);
            this.wUp.Margin = new System.Windows.Forms.Padding(2);
            this.wUp.Name = "wUp";
            this.wUp.Size = new System.Drawing.Size(108, 17);
            this.wUp.TabIndex = 3;
            this.wUp.Text = "Launch at startup";
            this.wUp.UseVisualStyleBackColor = true;
            this.wUp.CheckedChanged += new System.EventHandler(this.wUp_CheckedChanged);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 344);
            this.Controls.Add(this.wUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.copyHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(467, 383);
            this.MinimumSize = new System.Drawing.Size(467, 383);
            this.Name = "menu";
            this.Text = "Clipboard Saver | History";
            this.Load += new System.EventHandler(this.menu_Load);
            this.notifiMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox copyHistory;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer copyTimer;
        private System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.CheckBox wUp;
        private System.Windows.Forms.ContextMenuStrip notifiMenu;
        private System.Windows.Forms.ToolStripMenuItem copyLast;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem otherCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstCopy;
        private System.Windows.Forms.ToolStripMenuItem secondCopy;
        private System.Windows.Forms.ToolStripMenuItem thirdCopy;
        private System.Windows.Forms.ToolStripMenuItem fourthCopy;
        private System.Windows.Forms.ToolStripMenuItem fifthCopy;
    }
}