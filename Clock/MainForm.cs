using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
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


			// Инициализируем начальные состояния
			tsmiShowDate.Checked = false;


			tsmiShowDate.MouseUp += tsmiShowDate_Click;

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
			if (checkBoxShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
			if (checkBoxShowWeek.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("dddd")}";
			}
			notifyIcon.Text = labelTime.Text;
		}

		void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible; //Делает невидимым
			checkBoxShowWeek.Visible = visible; //Делает невидимым
			buttonHideControls.Visible = visible; //Делает кнопку невидимым
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None; //убираем границу окна
			this.ShowInTaskbar = visible;// скрываем кнопку приложения в панели задач
			this.TransparencyKey = visible ? Color.Empty : this.BackColor; //Делаем окно прозрачным
																		   //для того чтобы сделать окно 
		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(false);
		}


		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			SetVisibility(true);
		}

		private void tsmiTopmost_Click(object sender, EventArgs e)
		{

			if (tsmiTopmost.Checked)
			{
				this.TopMost = true;
			}
			else
			{
				this.TopMost = false;
			}
		}

		private void tsmiShowDate_Click(object sender, EventArgs e)
		{

			if (tsmiShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.TopMost = true;
			labelTime.Text = DateTime.Now.ToString
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if (checkBoxShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
			if (checkBoxShowWeek.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("dddd")}";
			}
			notifyIcon.Text = labelTime.Text;
		}

		private void notifyI(object sender, MouseEventArgs e)
		{

		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsmiShowWeekday_Click(object sender, EventArgs e)
		{
			if (tsmiShowWeekday.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("dddd")}";
			}
		}
	}
}
