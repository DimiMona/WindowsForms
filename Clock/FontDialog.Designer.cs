namespace Clock
{
	partial class FontDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontDialog));
			this.comboBoxFonts = new System.Windows.Forms.ComboBox();
			this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFonts
			// 
			this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFonts.FormattingEnabled = true;
			this.comboBoxFonts.Location = new System.Drawing.Point(13, 13);
			this.comboBoxFonts.Name = "comboBoxFonts";
			this.comboBoxFonts.Size = new System.Drawing.Size(344, 21);
			this.comboBoxFonts.TabIndex = 0;
			// 
			// numericUpDownFontSize
			// 
			this.numericUpDownFontSize.Location = new System.Drawing.Point(385, 12);
			this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            58,
            0,
            0,
            0});
			this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numericUpDownFontSize.Name = "numericUpDownFontSize";
			this.numericUpDownFontSize.Size = new System.Drawing.Size(74, 20);
			this.numericUpDownFontSize.TabIndex = 1;
			this.numericUpDownFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(13, 52);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(191, 51);
			this.labelExample.TabIndex = 2;
			this.labelExample.Text = "Example";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(282, 127);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(384, 127);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 172);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.numericUpDownFontSize);
			this.Controls.Add(this.comboBoxFonts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FontDialog";
			this.ShowInTaskbar = false;
			this.Text = "FontDialog";
			this.Load += new System.EventHandler(this.FontDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFonts;
		private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}