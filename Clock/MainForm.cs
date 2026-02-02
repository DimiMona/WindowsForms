using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		ColorDialog backgroundDialog;
		ColorDialog foregroundDialog;
		PrivateFontCollection fontCollection = new PrivateFontCollection();
		Font customFont;
		Font defaultFont;
		Point lastPoint;

		private Point dragStartPoint;//запоминает точку, где нажали мышку
		private bool canDragWindow = false;//флаг (true/false), можно ли сейчас двигать окно
		public MainForm()
		{
			InitializeComponent();
			// Получаем размеры рабочей области (без учета панели задач)
			Rectangle screen = Screen.PrimaryScreen.WorkingArea;

			this.Location = new Point(screen.Width - this.Width, 0);
			tsmiShowControls.Checked = true;
			backgroundDialog = new ColorDialog();
			foregroundDialog = new ColorDialog();
			fontCollection.AddFontFile(@"D:\Учеба по РПО\Source\repos\WindowsForms\Clock\Fonts\prodes-stencil.regular.ttf");
			customFont = new Font(fontCollection.Families[0], 32);
			defaultFont = labelTime.Font;

			// Подключаем события мыши к labelTime
			labelTime.MouseDown += labelTime_MouseDown;
			labelTime.MouseMove += labelTime_MouseMove;
			labelTime.MouseUp += labelTime_MouseUp;
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
			tsmiShowControls.Checked = false;
		}
		private void labelTime_DoubleClick(object sender, EventArgs e) =>
			tsmiShowControls.Checked = true;


		private void tsmiTopmost_CheckedChanged(object sender, EventArgs e)
		{
			//this.TopMost = tsmiTopmost.Checked;
			this.TopMost = (sender as ToolStripMenuItem).Checked;
		}

		private void tsmiShowControls_CheckStateChanged(object sender, EventArgs e)
		{
			SetVisibility(tsmiShowControls.Checked);
		}

		private void tsmiExit_Click(object sender, EventArgs e) => this.Close();

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) => tsmiShowDate.Checked = (sender as CheckBox).Checked;

		private void checkBoxShowWeek_CheckedChanged(object sender, EventArgs e) => tsmiShowWeekday.Checked = (sender as CheckBox).Checked;

		private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => checkBoxShowDate.Checked = (sender as ToolStripMenuItem).Checked;

		private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) => checkBoxShowWeek.Checked = (sender as ToolStripMenuItem).Checked;

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			DialogResult result = backgroundDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				labelTime.BackColor = backgroundDialog.Color;
			}
		}

		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{
			if (foregroundDialog.ShowDialog() == DialogResult.OK)
				labelTime.ForeColor = foregroundDialog.Color;
		}

		private void tsmiFont_CheckedChanged_1(object sender, EventArgs e)
		{
			if (labelTime.Font.Name != fontCollection.Families[0].Name)
			{
				labelTime.Font = customFont;

			}
			else
			{
				labelTime.Font = defaultFont;
			}
		}

		private void tsmiAutorun_CheckedChanged(object sender, EventArgs e)
		{

			// Устанавливаем или удаляем из автозагрузки
			if (tsmiAutorun.Checked)
			{
				RegistryKey runKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

				if (runKey != null)
				{
					runKey.SetValue("MyClock", Application.ExecutablePath);
					runKey.Close();
				}
			}
			else
			{
				RegistryKey runKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

				if (runKey != null)
				{
					runKey.DeleteValue("MyClock", false);
					runKey.Close();
				}
			}

			// Сохраняем настройку			
			Properties.Settings.Default.Save();
		}
		// 1. Когда нажимаем кнопку мыши на тексте времени
		private void labelTime_MouseDown(object sender, MouseEventArgs e)
		{
			// Проверяем: если нажата ЛЕВАЯ кнопка мыши И контролы скрыты
			if (e.Button == MouseButtons.Left && !tsmiShowControls.Checked)
			{
				// Запоминаем точку клика
				dragStartPoint = new Point(e.X, e.Y);
				// Разрешаем перемещение
				canDragWindow = true;
				// Меняем курсор на "руку"
				labelTime.Cursor = Cursors.SizeAll;
			}
		}

		// 2. Когда двигаем мышку
		private void labelTime_MouseMove(object sender, MouseEventArgs e)
		{
			// Если можно двигать И кнопка мыши нажата
			if (canDragWindow && e.Button == MouseButtons.Left)
			{
				// Вычисляем новую позицию окна
				Point newLocation = this.Location;
				newLocation.X += e.X - dragStartPoint.X;
				newLocation.Y += e.Y - dragStartPoint.Y;

				// Перемещаем окно
				this.Location = newLocation;
			}
		}

		// 3. Когда отпускаем кнопку мыши
		private void labelTime_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// Запрещаем дальнейшее перемещение
				canDragWindow = false;
				// Возвращаем обычный курсор
				labelTime.Cursor = Cursors.Default;
			}
		}

		
		

	}
}
