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
            this.delOrCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.delOrCopy2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.clearButton = new System.Windows.Forms.Button();
            this.ClearLastButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.onOfLabel = new System.Windows.Forms.Label();
            this.delOrCopy.SuspendLayout();
            this.notifiMenu.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.delOrCopy2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyHistory
            // 
            this.copyHistory.ContextMenuStrip = this.delOrCopy;
            this.copyHistory.FormattingEnabled = true;
            this.copyHistory.Location = new System.Drawing.Point(0, 1);
            this.copyHistory.Margin = new System.Windows.Forms.Padding(2);
            this.copyHistory.Name = "copyHistory";
            this.copyHistory.Size = new System.Drawing.Size(304, 303);
            this.copyHistory.TabIndex = 0;
            // 
            // delOrCopy
            // 
            this.delOrCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.delOrCopy.Name = "delOrCopy";
            this.delOrCopy.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(330, 281);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(112, 24);
            this.hide.TabIndex = 1;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click to history\r\nitem for copy or delete.";
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
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Location = new System.Drawing.Point(10, 7);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(312, 327);
            this.tab1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.copyHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.historyBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Last History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // historyBox
            // 
            this.historyBox.ContextMenuStrip = this.delOrCopy2;
            this.historyBox.FormattingEnabled = true;
            this.historyBox.Location = new System.Drawing.Point(0, 0);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(304, 303);
            this.historyBox.TabIndex = 1;
            // 
            // delOrCopy2
            // 
            this.delOrCopy2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.copyToolStripMenuItem1});
            this.delOrCopy2.Name = "delOrCopy2";
            this.delOrCopy2.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(304, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(40, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(229, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.github.com/aemirdnr";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(330, 222);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 24);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear History";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ClearLastButton
            // 
            this.ClearLastButton.Location = new System.Drawing.Point(330, 252);
            this.ClearLastButton.Name = "ClearLastButton";
            this.ClearLastButton.Size = new System.Drawing.Size(112, 24);
            this.ClearLastButton.TabIndex = 7;
            this.ClearLastButton.Text = "Clear Last History";
            this.ClearLastButton.UseVisualStyleBackColor = true;
            this.ClearLastButton.Click += new System.EventHandler(this.ClearLastButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(330, 310);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 24);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // onOfLabel
            // 
            this.onOfLabel.AutoSize = true;
            this.onOfLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.onOfLabel.Location = new System.Drawing.Point(350, 197);
            this.onOfLabel.Name = "onOfLabel";
            this.onOfLabel.Size = new System.Drawing.Size(72, 13);
            this.onOfLabel.TabIndex = 9;
            this.onOfLabel.Text = "STATUS: ON";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 344);
            this.Controls.Add(this.onOfLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.ClearLastButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.wUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(467, 383);
            this.MinimumSize = new System.Drawing.Size(467, 383);
            this.Name = "menu";
            this.Text = "Clipboard Saver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.delOrCopy.ResumeLayout(false);
            this.notifiMenu.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.delOrCopy2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ClearLastButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip delOrCopy;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip delOrCopy2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label onOfLabel;
    }
}