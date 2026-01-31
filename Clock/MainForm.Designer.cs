namespace Clock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAutorun = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeek = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Location = new System.Drawing.Point(54, 41);
			this.labelTime.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(261, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator3,
            this.tsmiAlarms,
            this.toolStripSeparator4,
            this.tsmiAutorun,
            this.tsmiExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 248);
			this.contextMenuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// tsmiTopmost
			// 
			this.tsmiTopmost.CheckOnClick = true;
			this.tsmiTopmost.Name = "tsmiTopmost";
			this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
			this.tsmiTopmost.Text = "Topmost";
			this.tsmiTopmost.Click += new System.EventHandler(this.tsmiTopmost_Click);
			// 
			// tsmiShowControls
			// 
			this.tsmiShowControls.CheckOnClick = true;
			this.tsmiShowControls.Name = "tsmiShowControls";
			this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowControls.Text = "Sow controls";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiShowDate
			// 
			this.tsmiShowDate.CheckOnClick = true;
			this.tsmiShowDate.Name = "tsmiShowDate";
			this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowDate.Text = "Show date";
			this.tsmiShowDate.Click += new System.EventHandler(this.tsmiShowDate_Click);
			// 
			// tsmiShowWeekday
			// 
			this.tsmiShowWeekday.CheckOnClick = true;
			this.tsmiShowWeekday.Name = "tsmiShowWeekday";
			this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowWeekday.Text = "Show weekday";
			this.tsmiShowWeekday.Click += new System.EventHandler(this.tsmiShowWeekday_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiFont
			// 
			this.tsmiFont.Name = "tsmiFont";
			this.tsmiFont.Size = new System.Drawing.Size(180, 22);
			this.tsmiFont.Text = "Font";
			// 
			// tsmiColor
			// 
			this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
			this.tsmiColor.Name = "tsmiColor";
			this.tsmiColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiColor.Text = "Color";
			// 
			// tsmiForegroundColor
			// 
			this.tsmiForegroundColor.Name = "tsmiForegroundColor";
			this.tsmiForegroundColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundColor.Text = "Foreground color";
			// 
			// tsmiBackgroundColor
			// 
			this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
			this.tsmiBackgroundColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundColor.Text = "Background color";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAlarms
			// 
			this.tsmiAlarms.Name = "tsmiAlarms";
			this.tsmiAlarms.Size = new System.Drawing.Size(180, 22);
			this.tsmiAlarms.Text = "Alarms";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAutorun
			// 
			this.tsmiAutorun.CheckOnClick = true;
			this.tsmiAutorun.Name = "tsmiAutorun";
			this.tsmiAutorun.Size = new System.Drawing.Size(180, 22);
			this.tsmiAutorun.Text = "Autorun";
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(180, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			//this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(63, 196);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(132, 29);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			// 
			// checkBoxShowWeek
			// 
			this.checkBoxShowWeek.AutoSize = true;
			this.checkBoxShowWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeek.Location = new System.Drawing.Point(63, 231);
			this.checkBoxShowWeek.Name = "checkBoxShowWeek";
			this.checkBoxShowWeek.Size = new System.Drawing.Size(189, 29);
			this.checkBoxShowWeek.TabIndex = 2;
			this.checkBoxShowWeek.Text = "Show Week Day";
			this.checkBoxShowWeek.UseVisualStyleBackColor = true;
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(63, 266);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(252, 77);
			this.buttonHideControls.TabIndex = 3;
			this.buttonHideControls.Text = "Hide Controls";
			this.buttonHideControls.UseVisualStyleBackColor = true;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Clock PV_522";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(372, 389);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeek);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(12);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ClockPV_522";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.CheckBox checkBoxShowWeek;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmiFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiAutorun;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
	}
}

