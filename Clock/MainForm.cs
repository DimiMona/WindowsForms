using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			// Получаем размеры рабочей области (без учета панели задач)
			Rectangle screen = Screen.PrimaryScreen.WorkingArea;

			this.Location = new Point(screen.Width - this.Width, 0);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if(checkBoxShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
			if (checkBoxShowWeek.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("dddd")}";
			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			checkBoxShowDate.Visible = false;
			checkBoxShowWeek.Visible = false;
			buttonHideControls.Visible = false;
			this.ShowInTaskbar = false;
		}
	}
}
