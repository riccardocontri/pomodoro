namespace Pomodoro
{
    partial class MainForm
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
            this.Time = new System.Windows.Forms.Label();
            this.TimeBar = new System.Windows.Forms.ProgressBar();
            this.Commands = new System.Windows.Forms.Panel();
            this.Span = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.DTPSpan = new System.Windows.Forms.DateTimePicker();
            this.Start15 = new System.Windows.Forms.Button();
            this.Start2 = new System.Windows.Forms.Button();
            this.Start5 = new System.Windows.Forms.Button();
            this.Start25 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TickMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlarmMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChiudiTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RipristinaTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Start25TrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start15TrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start5TrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start2TrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Commands.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.Font = new System.Drawing.Font("Forte", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(12, 32);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(318, 94);
            this.Time.TabIndex = 0;
            this.Time.Text = "- 59:59";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimeBar
            // 
            this.TimeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeBar.ForeColor = System.Drawing.Color.Red;
            this.TimeBar.Location = new System.Drawing.Point(12, 129);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(318, 16);
            this.TimeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeBar.TabIndex = 1;
            // 
            // Commands
            // 
            this.Commands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Commands.Controls.Add(this.Span);
            this.Commands.Controls.Add(this.Stop);
            this.Commands.Controls.Add(this.Start);
            this.Commands.Controls.Add(this.DTPSpan);
            this.Commands.Controls.Add(this.Start15);
            this.Commands.Controls.Add(this.Start2);
            this.Commands.Controls.Add(this.Start5);
            this.Commands.Controls.Add(this.Start25);
            this.Commands.Location = new System.Drawing.Point(12, 151);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(318, 54);
            this.Commands.TabIndex = 12;
            // 
            // Span
            // 
            this.Span.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Span.Location = new System.Drawing.Point(81, 1);
            this.Span.Name = "Span";
            this.Span.Size = new System.Drawing.Size(75, 20);
            this.Span.TabIndex = 19;
            this.Span.Text = "30";
            this.Span.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Span.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Span_KeyPress);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Stop.Location = new System.Drawing.Point(243, 0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 18;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start.Location = new System.Drawing.Point(0, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 17;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // DTPSpan
            // 
            this.DTPSpan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DTPSpan.Checked = false;
            this.DTPSpan.CustomFormat = "H:mm:ss";
            this.DTPSpan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPSpan.Location = new System.Drawing.Point(162, 1);
            this.DTPSpan.Name = "DTPSpan";
            this.DTPSpan.ShowUpDown = true;
            this.DTPSpan.Size = new System.Drawing.Size(75, 20);
            this.DTPSpan.TabIndex = 16;
            this.DTPSpan.Value = new System.DateTime(2008, 1, 14, 0, 0, 10, 0);
            this.DTPSpan.Visible = false;
            // 
            // Start15
            // 
            this.Start15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start15.Location = new System.Drawing.Point(81, 29);
            this.Start15.Name = "Start15";
            this.Start15.Size = new System.Drawing.Size(75, 23);
            this.Start15.TabIndex = 15;
            this.Start15.Text = "15 min";
            this.Start15.UseVisualStyleBackColor = true;
            this.Start15.Click += new System.EventHandler(this.Start15_Click);
            // 
            // Start2
            // 
            this.Start2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start2.Location = new System.Drawing.Point(243, 29);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(75, 23);
            this.Start2.TabIndex = 14;
            this.Start2.Text = "2 min";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // Start5
            // 
            this.Start5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start5.Location = new System.Drawing.Point(162, 29);
            this.Start5.Name = "Start5";
            this.Start5.Size = new System.Drawing.Size(75, 23);
            this.Start5.TabIndex = 13;
            this.Start5.Text = "5 min";
            this.Start5.UseVisualStyleBackColor = true;
            this.Start5.Click += new System.EventHandler(this.Start5_Click);
            // 
            // Start25
            // 
            this.Start25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start25.Location = new System.Drawing.Point(0, 29);
            this.Start25.Name = "Start25";
            this.Start25.Size = new System.Drawing.Size(75, 23);
            this.Start25.TabIndex = 12;
            this.Start25.Text = "25 min";
            this.Start25.UseVisualStyleBackColor = true;
            this.Start25.Click += new System.EventHandler(this.Start25_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(342, 24);
            this.MainMenu.TabIndex = 13;
            this.MainMenu.Text = "MainMenu";
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TickMenuItem,
            this.AlarmMenuItem});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(54, 20);
            this.OptionsMenuItem.Text = "Opzioni";
            // 
            // TickMenuItem
            // 
            this.TickMenuItem.Checked = true;
            this.TickMenuItem.CheckOnClick = true;
            this.TickMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TickMenuItem.Name = "TickMenuItem";
            this.TickMenuItem.Size = new System.Drawing.Size(131, 22);
            this.TickMenuItem.Text = "Ticchettio";
            // 
            // AlarmMenuItem
            // 
            this.AlarmMenuItem.Checked = true;
            this.AlarmMenuItem.CheckOnClick = true;
            this.AlarmMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlarmMenuItem.Name = "AlarmMenuItem";
            this.AlarmMenuItem.Size = new System.Drawing.Size(131, 22);
            this.AlarmMenuItem.Text = "Suoneria";
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Text = "#Pomodoro";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RipristinaTrayMenuItem,
            this.TrayMenuSeparator1,
            this.StartTrayMenuItem,
            this.Start25TrayMenuItem,
            this.Start15TrayMenuItem,
            this.Start5TrayMenuItem,
            this.Start2TrayMenuItem,
            this.StopTrayMenuItem,
            this.TrayMenuSeparator2,
            this.ChiudiTrayMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(153, 214);
            // 
            // ChiudiTrayMenuItem
            // 
            this.ChiudiTrayMenuItem.Name = "ChiudiTrayMenuItem";
            this.ChiudiTrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChiudiTrayMenuItem.Text = "Chiudi";
            this.ChiudiTrayMenuItem.Click += new System.EventHandler(this.ChiudiTrayMenuItem_Click);
            // 
            // StartTrayMenuItem
            // 
            this.StartTrayMenuItem.Name = "StartTrayMenuItem";
            this.StartTrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartTrayMenuItem.Text = "#Start";
            this.StartTrayMenuItem.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopTrayMenuItem
            // 
            this.StopTrayMenuItem.Name = "StopTrayMenuItem";
            this.StopTrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StopTrayMenuItem.Text = "#Stop";
            this.StopTrayMenuItem.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TrayMenuSeparator2
            // 
            this.TrayMenuSeparator2.Name = "TrayMenuSeparator2";
            this.TrayMenuSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // RipristinaTrayMenuItem
            // 
            this.RipristinaTrayMenuItem.Name = "RipristinaTrayMenuItem";
            this.RipristinaTrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RipristinaTrayMenuItem.Text = "Ripristina";
            this.RipristinaTrayMenuItem.Click += new System.EventHandler(this.RipristinaTrayMenuItem_Click);
            // 
            // TrayMenuSeparator1
            // 
            this.TrayMenuSeparator1.Name = "TrayMenuSeparator1";
            this.TrayMenuSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Start25TrayMenuItem
            // 
            this.Start25TrayMenuItem.Name = "Start25TrayMenuItem";
            this.Start25TrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Start25TrayMenuItem.Text = "#25 min";
            this.Start25TrayMenuItem.Click += new System.EventHandler(this.Start25_Click);
            // 
            // Start15TrayMenuItem
            // 
            this.Start15TrayMenuItem.Name = "Start15TrayMenuItem";
            this.Start15TrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Start15TrayMenuItem.Text = "#15 min";
            this.Start15TrayMenuItem.Click += new System.EventHandler(this.Start15_Click);
            // 
            // Start5TrayMenuItem
            // 
            this.Start5TrayMenuItem.Name = "Start5TrayMenuItem";
            this.Start5TrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Start5TrayMenuItem.Text = "#5 min";
            this.Start5TrayMenuItem.Click += new System.EventHandler(this.Start5_Click);
            // 
            // Start2TrayMenuItem
            // 
            this.Start2TrayMenuItem.Name = "Start2TrayMenuItem";
            this.Start2TrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Start2TrayMenuItem.Text = "#2 min";
            this.Start2TrayMenuItem.Click += new System.EventHandler(this.Start2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 217);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.MainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Pomodoro Virtuale";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Commands.ResumeLayout(false);
            this.Commands.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ProgressBar TimeBar;
        private System.Windows.Forms.Panel Commands;
        private System.Windows.Forms.TextBox Span;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.DateTimePicker DTPSpan;
        private System.Windows.Forms.Button Start15;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.Button Start5;
        private System.Windows.Forms.Button Start25;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TickMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlarmMenuItem;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem ChiudiTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator TrayMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem RipristinaTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator TrayMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Start25TrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Start15TrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Start5TrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Start2TrayMenuItem;
    }
}

