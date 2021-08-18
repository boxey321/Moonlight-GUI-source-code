using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Moonlight_GUI.Properties;

namespace Moonlight_GUI
{
	public class Form1 : Form
	{
		private int flag = 1;

		private bool open = false;

		private bool mouseDown;

		private Point offset;

		private IContainer components = null;

		private Button ExitButton;

		private Button MinimizeButton;

		private Panel Sidepannel;

		private Button button3;

		private PictureBox pictureBox1;

		private Label label2;

		private Button button6;

		private Button button5;

		private Button button4;

		private Panel panel2;

		private Panel DashPannel1;

		private Label label5;

		private Label label4;

		private Label label3;

		private Panel DashPannel2;

		private Label label7;

		private Label label6;

		private Panel DashPannel3;

		private Label label12;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Panel inject;

		private Panel inject2;

		private Panel InjectPannel1;

		private Button InjectButton1;

		private Button InjectButton2;

		private TextBox InjectTextBox;

		private Panel Aimbot;

		private Panel Aimbot2;

		private Panel AimbotPannel1;

		private Label label19;

		private Panel AimbotButton4;

		private CheckBox Xmouse;

		private Label label17;

		private Panel AimbotButton3;

		private CheckBox LeftMouse;

		private Label label16;

		private Panel AimbotButton1;

		private CheckBox Shift;

		private Label label15;

		private Panel Settings;

		private PictureBox pictureBox2;

		private Panel Settings2;

		private Panel SettingsPannel2;

		private Label label23;

		private Label label22;

		private Label label21;

		private Panel SettingsPannel1;

		private CheckBox TOP;

		private Label label20;

		private Button button9;

		private Panel ThemePage2;

		private Panel ThemePage;

		private Panel ThemePannel;

		private Button ThemeButton2;

		private Button ThemeButton1;

		private Button ThemeButton3;

		private Button ThemeButton4;

		private Button ThemeButton5;

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		public Form1()
		{
			InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			inject.Hide();
			inject2.Hide();
			Aimbot.Hide();
			Aimbot2.Hide();
			Settings.Hide();
			Settings2.Hide();
			ThemePage.Hide();
			ThemePage2.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - offset.X, point.Y - offset.Y);
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			inject.Show();
			inject2.Show();
			Aimbot.Hide();
			Aimbot2.Hide();
			Settings.Hide();
			Settings2.Hide();
			ThemePage.Hide();
			ThemePage2.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			inject.Hide();
			inject2.Hide();
			Aimbot.Hide();
			Aimbot2.Hide();
			Settings.Hide();
			Settings2.Hide();
			ThemePage.Hide();
			ThemePage2.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Aimbot.Show();
			Aimbot2.Show();
			inject.Hide();
			inject2.Hide();
			Settings.Hide();
			Settings2.Hide();
			ThemePage.Hide();
			ThemePage2.Hide();
		}

		private void label23_Click(object sender, EventArgs e)
		{
			Process.Start("https://cdn.discordapp.com/attachments/861526883724165143/864882883003809852/files.rar");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			InjectTextBox.Text = "Injecting moonlight";
			InjectTextBox.Update();
			Thread.Sleep(2000);
			InjectTextBox.Text = "";
			InjectTextBox.Update();
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			if (processesByName.Length != 0)
			{
				open = true;
			}
			else
			{
				open = false;
				InjectTextBox.Text = "Fivem Not Found, Join a server before injecting!";
				InjectTextBox.Update();
			}
			if (Shift.Checked && open)
			{
				Process.Start("utils\\MoonlBetav3Shift.exe");
				InjectTextBox.Text = "Succesfully Injected Moonlight";
				InjectTextBox.Update();
			}
			if (Xmouse.Checked && open)
			{
				Process.Start("utils\\MoonlBetav3Xmouse.exe");
				InjectTextBox.Text = "Succesfully Injected Moonlight";
				InjectTextBox.Update();
			}
			if (LeftMouse.Checked && open)
			{
				Process.Start("utils\\MoonlBetav3Left.exe");
				InjectTextBox.Text = "Succesfully Injected Moonlight";
				InjectTextBox.Update();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			InjectTextBox.Text = "Injecting moonlight";
			InjectTextBox.Update();
			Thread.Sleep(2000);
			InjectTextBox.Text = "";
			InjectTextBox.Update();
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			if (processesByName.Length != 0)
			{
				Process.Start("utils\\MoonlBetav3Modmenu.exe");
				InjectTextBox.Text = "Succesfully Injected Moonlight";
				InjectTextBox.Update();
			}
			else
			{
				open = false;
				InjectTextBox.Text = "Fivem Not Found, Join a server before injecting!";
				InjectTextBox.Update();
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/b7VPsDSHZ7");
		}

		private void TOP_CheckedChanged(object sender, EventArgs e)
		{
			if (TOP.Checked)
			{
				base.TopMost = true;
			}
			else
			{
				base.TopMost = false;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Settings.Show();
			Settings2.Show();
			Aimbot.Hide();
			Aimbot2.Hide();
			inject.Hide();
			inject2.Hide();
			ThemePage.Hide();
			ThemePage2.Hide();
		}

		private void Settings2_MouseDown(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void Settings2_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - offset.X, point.Y - offset.Y);
			}
		}

		private void Settings2_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void Aimbot_MouseDown(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void Aimbot_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - offset.X, point.Y - offset.Y);
			}
		}

		private void Aimbot_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void inject_MouseDown(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void inject_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - offset.X, point.Y - offset.Y);
			}
		}

		private void inject_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ThemePage.Show();
			ThemePage2.Show();
			Settings.Hide();
			Settings2.Hide();
			Aimbot.Hide();
			Aimbot2.Hide();
			inject.Hide();
			inject2.Hide();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			BackColor = Color.FromArgb(240, 54, 65);
			BackgroundImage = null;
			Sidepannel.BackColor = Color.FromArgb(199, 9, 20);
			ExitButton.BackColor = Color.FromArgb(199, 9, 20);
			MinimizeButton.BackColor = Color.FromArgb(199, 9, 20);
			ThemePage.BackColor = Color.FromArgb(240, 54, 65);
			ThemePage2.BackColor = Color.FromArgb(240, 54, 65);
			ThemeButton1.BackColor = Color.FromArgb(199, 9, 20);
			ThemeButton2.BackColor = Color.FromArgb(199, 9, 20);
			ThemeButton3.BackColor = Color.FromArgb(199, 9, 20);
			ThemeButton4.BackColor = Color.FromArgb(199, 9, 20);
			ThemePannel.BackColor = Color.FromArgb(220, 34, 46);
			Settings.BackColor = Color.FromArgb(240, 54, 65);
			Settings2.BackColor = Color.FromArgb(240, 54, 65);
			SettingsPannel1.BackColor = Color.FromArgb(199, 9, 20);
			SettingsPannel2.BackColor = Color.FromArgb(199, 9, 20);
			Aimbot.BackColor = Color.FromArgb(240, 54, 65);
			Aimbot2.BackColor = Color.FromArgb(240, 54, 65);
			AimbotButton1.BackColor = Color.FromArgb(199, 9, 20);
			AimbotButton3.BackColor = Color.FromArgb(199, 9, 20);
			AimbotButton4.BackColor = Color.FromArgb(199, 9, 20);
			AimbotPannel1.BackColor = Color.FromArgb(199, 9, 20);
			inject.BackColor = Color.FromArgb(240, 54, 65);
			inject2.BackColor = Color.FromArgb(240, 54, 65);
			InjectTextBox.BackColor = Color.FromArgb(220, 34, 46);
			InjectPannel1.BackColor = Color.FromArgb(220, 34, 46);
			InjectButton1.BackColor = Color.FromArgb(199, 9, 20);
			InjectButton2.BackColor = Color.FromArgb(199, 9, 20);
			DashPannel1.BackColor = Color.FromArgb(199, 9, 20);
			DashPannel2.BackColor = Color.FromArgb(199, 9, 20);
			DashPannel3.BackColor = Color.FromArgb(199, 9, 20);
			Update();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			BackColor = Color.FromArgb(46, 51, 73);
			BackgroundImage = null;
			Sidepannel.BackColor = Color.FromArgb(24, 30, 54);
			ExitButton.BackColor = Color.FromArgb(20, 30, 54);
			MinimizeButton.BackColor = Color.FromArgb(20, 30, 54);
			ThemePage.BackColor = Color.FromArgb(46, 51, 73);
			ThemePage2.BackColor = Color.FromArgb(46, 51, 73);
			ThemeButton1.BackColor = Color.FromArgb(24, 30, 54);
			ThemeButton2.BackColor = Color.FromArgb(24, 30, 54);
			ThemeButton3.BackColor = Color.FromArgb(24, 30, 54);
			ThemeButton4.BackColor = Color.FromArgb(24, 30, 54);
			ThemeButton5.BackColor = Color.FromArgb(24, 30, 54);
			ThemePannel.BackColor = Color.FromArgb(37, 42, 64);
			Settings.BackColor = Color.FromArgb(46, 51, 73);
			Settings2.BackColor = Color.FromArgb(46, 51, 73);
			SettingsPannel1.BackColor = Color.FromArgb(37, 42, 64);
			SettingsPannel2.BackColor = Color.FromArgb(37, 42, 64);
			Aimbot.BackColor = Color.FromArgb(46, 51, 73);
			Aimbot2.BackColor = Color.FromArgb(46, 51, 73);
			AimbotButton1.BackColor = Color.FromArgb(37, 42, 64);
			AimbotButton3.BackColor = Color.FromArgb(37, 42, 64);
			AimbotButton4.BackColor = Color.FromArgb(37, 42, 64);
			AimbotPannel1.BackColor = Color.FromArgb(37, 42, 64);
			inject.BackColor = Color.FromArgb(46, 51, 73);
			inject2.BackColor = Color.FromArgb(46, 51, 73);
			InjectTextBox.BackColor = Color.FromArgb(37, 42, 64);
			InjectPannel1.BackColor = Color.FromArgb(37, 42, 64);
			InjectButton1.BackColor = Color.FromArgb(24, 30, 54);
			InjectButton2.BackColor = Color.FromArgb(24, 30, 54);
			DashPannel1.BackColor = Color.FromArgb(37, 42, 64);
			DashPannel2.BackColor = Color.FromArgb(37, 42, 64);
			DashPannel3.BackColor = Color.FromArgb(37, 42, 64);
			Update();
		}

		private void ThemePage2_MouseDown(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void ThemePage2_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - offset.X, point.Y - offset.Y);
			}
		}

		private void ThemePage2_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			BackColor = Color.FromArgb(156, 75, 217);
			BackgroundImage = null;
			Sidepannel.BackColor = Color.FromArgb(109, 31, 168);
			ExitButton.BackColor = Color.FromArgb(109, 31, 168);
			MinimizeButton.BackColor = Color.FromArgb(109, 31, 168);
			ThemePage.BackColor = Color.FromArgb(156, 75, 217);
			ThemePage2.BackColor = Color.FromArgb(156, 75, 217);
			ThemeButton1.BackColor = Color.FromArgb(109, 31, 168);
			ThemeButton2.BackColor = Color.FromArgb(109, 31, 168);
			ThemeButton3.BackColor = Color.FromArgb(109, 31, 168);
			ThemeButton4.BackColor = Color.FromArgb(109, 31, 168);
			ThemeButton5.BackColor = Color.FromArgb(109, 31, 168);
			ThemePannel.BackColor = Color.FromArgb(134, 28, 213);
			Settings.BackColor = Color.FromArgb(156, 75, 217);
			Settings2.BackColor = Color.FromArgb(156, 75, 217);
			SettingsPannel1.BackColor = Color.FromArgb(199, 9, 20);
			SettingsPannel2.BackColor = Color.FromArgb(199, 9, 20);
			Aimbot.BackColor = Color.FromArgb(156, 75, 217);
			Aimbot2.BackColor = Color.FromArgb(156, 75, 217);
			AimbotButton1.BackColor = Color.FromArgb(109, 31, 168);
			AimbotButton3.BackColor = Color.FromArgb(109, 31, 168);
			AimbotButton4.BackColor = Color.FromArgb(109, 31, 168);
			AimbotPannel1.BackColor = Color.FromArgb(109, 31, 168);
			inject.BackColor = Color.FromArgb(156, 75, 217);
			inject2.BackColor = Color.FromArgb(156, 75, 217);
			InjectTextBox.BackColor = Color.FromArgb(134, 28, 213);
			InjectPannel1.BackColor = Color.FromArgb(134, 28, 213);
			InjectButton1.BackColor = Color.FromArgb(109, 31, 168);
			InjectButton2.BackColor = Color.FromArgb(109, 31, 168);
			DashPannel1.BackColor = Color.FromArgb(109, 31, 168);
			DashPannel2.BackColor = Color.FromArgb(109, 31, 168);
			DashPannel3.BackColor = Color.FromArgb(109, 31, 168);
			Update();
		}

		private void ThemeButton4_Click(object sender, EventArgs e)
		{
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void ThemeButton4_Click_1(object sender, EventArgs e)
		{
			flag *= -1;
			if (flag == -1)
			{
				Bitmap bitmap = (Bitmap)(BackgroundImage = new Bitmap("Themes\\Supreme.png"));
				Sidepannel.BackColor = Color.FromArgb(199, 9, 20);
				ExitButton.BackColor = Color.FromArgb(199, 9, 20);
				MinimizeButton.BackColor = Color.FromArgb(199, 9, 20);
				ThemePage.BackColor = Color.Transparent;
				ThemePage2.BackColor = Color.Transparent;
				ThemeButton1.BackColor = Color.FromArgb(227, 76, 76);
				ThemeButton2.BackColor = Color.FromArgb(227, 76, 76);
				ThemeButton3.BackColor = Color.FromArgb(227, 76, 76);
				ThemeButton4.BackColor = Color.FromArgb(227, 76, 76);
				ThemeButton5.BackColor = Color.FromArgb(227, 76, 76);
				ThemePannel.BackColor = Color.FromArgb(199, 9, 20);
				Settings.BackColor = Color.Transparent;
				Settings2.BackColor = Color.Transparent;
				SettingsPannel1.BackColor = Color.FromArgb(199, 9, 20);
				SettingsPannel2.BackColor = Color.FromArgb(199, 9, 20);
				Aimbot.BackColor = Color.Transparent;
				Aimbot2.BackColor = Color.Transparent;
				AimbotButton1.BackColor = Color.FromArgb(227, 76, 76);
				AimbotButton3.BackColor = Color.FromArgb(227, 76, 76);
				AimbotButton4.BackColor = Color.FromArgb(227, 76, 76);
				AimbotPannel1.BackColor = Color.FromArgb(227, 76, 76);
				inject.BackColor = Color.Transparent;
				inject2.BackColor = Color.Transparent;
				InjectTextBox.BackColor = Color.FromArgb(199, 9, 20);
				InjectPannel1.BackColor = Color.FromArgb(199, 9, 20);
				InjectButton1.BackColor = Color.FromArgb(227, 76, 76);
				InjectButton2.BackColor = Color.FromArgb(227, 76, 76);
				DashPannel1.BackColor = Color.FromArgb(199, 9, 20);
				DashPannel2.BackColor = Color.FromArgb(199, 9, 20);
				DashPannel3.BackColor = Color.FromArgb(199, 9, 20);
				Update();
			}
		}

		private void ThemePannel_Paint(object sender, PaintEventArgs e)
		{
		}

		private void ThemeButton5_Click(object sender, EventArgs e)
		{
			flag *= -1;
			if (flag == -1)
			{
				Bitmap bitmap = (Bitmap)(BackgroundImage = new Bitmap("Themes\\Offwhite.png"));
				Sidepannel.BackColor = Color.FromArgb(110, 106, 106);
				ExitButton.BackColor = Color.FromArgb(110, 106, 106);
				MinimizeButton.BackColor = Color.FromArgb(110, 106, 106);
				ThemePage.BackColor = Color.Transparent;
				ThemePage2.BackColor = Color.Transparent;
				ThemeButton1.BackColor = Color.FromArgb(73, 73, 73);
				ThemeButton2.BackColor = Color.FromArgb(73, 73, 73);
				ThemeButton3.BackColor = Color.FromArgb(73, 73, 73);
				ThemeButton4.BackColor = Color.FromArgb(73, 73, 73);
				ThemeButton5.BackColor = Color.FromArgb(73, 73, 73);
				ThemePannel.BackColor = Color.FromArgb(110, 106, 106);
				Settings.BackColor = Color.Transparent;
				Settings2.BackColor = Color.Transparent;
				SettingsPannel1.BackColor = Color.FromArgb(110, 106, 106);
				SettingsPannel2.BackColor = Color.FromArgb(110, 106, 106);
				Aimbot.BackColor = Color.Transparent;
				Aimbot2.BackColor = Color.Transparent;
				AimbotButton1.BackColor = Color.FromArgb(73, 73, 73);
				AimbotButton3.BackColor = Color.FromArgb(73, 73, 73);
				AimbotButton4.BackColor = Color.FromArgb(73, 73, 73);
				AimbotPannel1.BackColor = Color.FromArgb(73, 73, 73);
				inject.BackColor = Color.Transparent;
				inject2.BackColor = Color.Transparent;
				InjectTextBox.BackColor = Color.FromArgb(144, 144, 144);
				InjectPannel1.BackColor = Color.FromArgb(110, 106, 106);
				InjectButton1.BackColor = Color.FromArgb(73, 73, 73);
				InjectButton2.BackColor = Color.FromArgb(73, 73, 73);
				DashPannel1.BackColor = Color.FromArgb(110, 106, 106);
				DashPannel2.BackColor = Color.FromArgb(110, 106, 106);
				DashPannel3.BackColor = Color.FromArgb(110, 106, 106);
				Update();
			}
		}

		private void ThemePage_Paint(object sender, PaintEventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moonlight_GUI.Form1));
			ExitButton = new System.Windows.Forms.Button();
			MinimizeButton = new System.Windows.Forms.Button();
			Sidepannel = new System.Windows.Forms.Panel();
			button9 = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			button6 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			DashPannel1 = new System.Windows.Forms.Panel();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			DashPannel2 = new System.Windows.Forms.Panel();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			DashPannel3 = new System.Windows.Forms.Panel();
			label12 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			inject = new System.Windows.Forms.Panel();
			InjectPannel1 = new System.Windows.Forms.Panel();
			InjectButton1 = new System.Windows.Forms.Button();
			InjectButton2 = new System.Windows.Forms.Button();
			InjectTextBox = new System.Windows.Forms.TextBox();
			inject2 = new System.Windows.Forms.Panel();
			Aimbot = new System.Windows.Forms.Panel();
			AimbotPannel1 = new System.Windows.Forms.Panel();
			label19 = new System.Windows.Forms.Label();
			AimbotButton4 = new System.Windows.Forms.Panel();
			Xmouse = new System.Windows.Forms.CheckBox();
			label17 = new System.Windows.Forms.Label();
			AimbotButton3 = new System.Windows.Forms.Panel();
			LeftMouse = new System.Windows.Forms.CheckBox();
			label16 = new System.Windows.Forms.Label();
			AimbotButton1 = new System.Windows.Forms.Panel();
			Shift = new System.Windows.Forms.CheckBox();
			label15 = new System.Windows.Forms.Label();
			Aimbot2 = new System.Windows.Forms.Panel();
			ThemePage2 = new System.Windows.Forms.Panel();
			Settings = new System.Windows.Forms.Panel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			Settings2 = new System.Windows.Forms.Panel();
			SettingsPannel2 = new System.Windows.Forms.Panel();
			label23 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			SettingsPannel1 = new System.Windows.Forms.Panel();
			TOP = new System.Windows.Forms.CheckBox();
			label20 = new System.Windows.Forms.Label();
			ThemePage = new System.Windows.Forms.Panel();
			ThemePannel = new System.Windows.Forms.Panel();
			ThemeButton5 = new System.Windows.Forms.Button();
			ThemeButton4 = new System.Windows.Forms.Button();
			ThemeButton3 = new System.Windows.Forms.Button();
			ThemeButton2 = new System.Windows.Forms.Button();
			ThemeButton1 = new System.Windows.Forms.Button();
			Sidepannel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			DashPannel1.SuspendLayout();
			DashPannel2.SuspendLayout();
			DashPannel3.SuspendLayout();
			inject.SuspendLayout();
			InjectPannel1.SuspendLayout();
			Aimbot.SuspendLayout();
			AimbotPannel1.SuspendLayout();
			AimbotButton4.SuspendLayout();
			AimbotButton3.SuspendLayout();
			AimbotButton1.SuspendLayout();
			Aimbot2.SuspendLayout();
			Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			Settings2.SuspendLayout();
			SettingsPannel2.SuspendLayout();
			SettingsPannel1.SuspendLayout();
			ThemePage.SuspendLayout();
			ThemePannel.SuspendLayout();
			SuspendLayout();
			ExitButton.BackColor = System.Drawing.Color.FromArgb(20, 30, 54);
			ExitButton.FlatAppearance.BorderSize = 0;
			ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ExitButton.Font = new System.Drawing.Font("Nirmala UI", 9f, System.Drawing.FontStyle.Bold);
			ExitButton.ForeColor = System.Drawing.Color.White;
			ExitButton.Location = new System.Drawing.Point(618, 11);
			ExitButton.Name = "ExitButton";
			ExitButton.Size = new System.Drawing.Size(29, 33);
			ExitButton.TabIndex = 0;
			ExitButton.Text = "X";
			ExitButton.UseVisualStyleBackColor = false;
			ExitButton.Click += new System.EventHandler(button1_Click);
			MinimizeButton.BackColor = System.Drawing.Color.FromArgb(20, 30, 54);
			MinimizeButton.FlatAppearance.BorderSize = 0;
			MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			MinimizeButton.Font = new System.Drawing.Font("Nirmala UI", 9f, System.Drawing.FontStyle.Bold);
			MinimizeButton.ForeColor = System.Drawing.Color.White;
			MinimizeButton.Location = new System.Drawing.Point(583, 11);
			MinimizeButton.Name = "MinimizeButton";
			MinimizeButton.Size = new System.Drawing.Size(29, 33);
			MinimizeButton.TabIndex = 1;
			MinimizeButton.Text = "-";
			MinimizeButton.UseVisualStyleBackColor = false;
			MinimizeButton.Click += new System.EventHandler(button2_Click);
			Sidepannel.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			Sidepannel.Controls.Add(button9);
			Sidepannel.Controls.Add(panel2);
			Sidepannel.Controls.Add(label2);
			Sidepannel.Controls.Add(button6);
			Sidepannel.Controls.Add(button5);
			Sidepannel.Controls.Add(button4);
			Sidepannel.Controls.Add(button3);
			Sidepannel.Controls.Add(pictureBox1);
			Sidepannel.Location = new System.Drawing.Point(0, 0);
			Sidepannel.Name = "Sidepannel";
			Sidepannel.Size = new System.Drawing.Size(187, 443);
			Sidepannel.TabIndex = 2;
			button9.FlatAppearance.BorderSize = 0;
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			button9.ForeColor = System.Drawing.Color.White;
			button9.Image = (System.Drawing.Image)resources.GetObject("button9.Image");
			button9.Location = new System.Drawing.Point(0, 323);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(187, 56);
			button9.TabIndex = 6;
			button9.Text = "Themes";
			button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			button9.UseVisualStyleBackColor = true;
			button9.Click += new System.EventHandler(button9_Click);
			panel2.Location = new System.Drawing.Point(201, 68);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(448, 349);
			panel2.TabIndex = 4;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(50, 112);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(90, 20);
			label2.TabIndex = 5;
			label2.Text = "Moonlight";
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			button6.ForeColor = System.Drawing.Color.White;
			button6.Image = (System.Drawing.Image)resources.GetObject("button6.Image");
			button6.Location = new System.Drawing.Point(0, 387);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(187, 56);
			button6.TabIndex = 4;
			button6.Text = "Settings";
			button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			button6.UseVisualStyleBackColor = true;
			button6.Click += new System.EventHandler(button6_Click);
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			button5.ForeColor = System.Drawing.Color.White;
			button5.Image = (System.Drawing.Image)resources.GetObject("button5.Image");
			button5.Location = new System.Drawing.Point(0, 259);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(187, 56);
			button5.TabIndex = 3;
			button5.Text = "Aimbot";
			button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			button5.UseVisualStyleBackColor = true;
			button5.Click += new System.EventHandler(button5_Click);
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			button4.ForeColor = System.Drawing.Color.White;
			button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
			button4.Location = new System.Drawing.Point(0, 203);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(187, 56);
			button4.TabIndex = 2;
			button4.Text = "Inject";
			button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(button4_Click);
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			button3.ForeColor = System.Drawing.Color.White;
			button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
			button3.Location = new System.Drawing.Point(0, 147);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(187, 56);
			button3.TabIndex = 1;
			button3.Text = "Dashboard";
			button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			pictureBox1.Image = Moonlight_GUI.Properties.Resources.moonlightjitter;
			pictureBox1.Location = new System.Drawing.Point(57, 17);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(78, 75);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			DashPannel1.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			DashPannel1.Controls.Add(label5);
			DashPannel1.Controls.Add(label4);
			DashPannel1.Controls.Add(label3);
			DashPannel1.Location = new System.Drawing.Point(204, 94);
			DashPannel1.Name = "DashPannel1";
			DashPannel1.Size = new System.Drawing.Size(229, 133);
			DashPannel1.TabIndex = 4;
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Nirmala UI", 9.75f);
			label5.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label5.Location = new System.Drawing.Point(20, 91);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(95, 23);
			label5.TabIndex = 2;
			label5.Text = "Up To Date";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21f, System.Drawing.FontStyle.Bold);
			label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
			label4.Location = new System.Drawing.Point(13, 44);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(204, 39);
			label4.TabIndex = 1;
			label4.Text = "Undetected";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(14, 8);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(79, 32);
			label3.TabIndex = 0;
			label3.Text = "Status";
			DashPannel2.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			DashPannel2.Controls.Add(label7);
			DashPannel2.Controls.Add(label6);
			DashPannel2.Location = new System.Drawing.Point(444, 94);
			DashPannel2.Name = "DashPannel2";
			DashPannel2.Size = new System.Drawing.Size(205, 133);
			DashPannel2.TabIndex = 5;
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold);
			label7.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label7.Location = new System.Drawing.Point(12, 69);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(180, 24);
			label7.TabIndex = 4;
			label7.Text = "Moonlight V3 Beta";
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label6.ForeColor = System.Drawing.Color.White;
			label6.Location = new System.Drawing.Point(17, 6);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(93, 32);
			label6.TabIndex = 3;
			label6.Text = "Version";
			DashPannel3.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			DashPannel3.Controls.Add(label12);
			DashPannel3.Controls.Add(label11);
			DashPannel3.Controls.Add(label10);
			DashPannel3.Controls.Add(label9);
			DashPannel3.Controls.Add(label8);
			DashPannel3.Location = new System.Drawing.Point(199, 271);
			DashPannel3.Name = "DashPannel3";
			DashPannel3.Size = new System.Drawing.Size(448, 133);
			DashPannel3.TabIndex = 6;
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Nirmala UI", 9.75f);
			label12.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label12.Location = new System.Drawing.Point(107, 93);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(146, 23);
			label12.TabIndex = 5;
			label12.Text = "jetjames007#4592";
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			label11.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label11.Location = new System.Drawing.Point(18, 93);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(87, 23);
			label11.TabIndex = 4;
			label11.Text = "Designer:";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Nirmala UI", 9.75f);
			label10.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label10.Location = new System.Drawing.Point(107, 59);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(118, 23);
			label10.TabIndex = 3;
			label10.Text = "Reece ✟#0999";
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			label9.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label9.Location = new System.Drawing.Point(18, 59);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(98, 23);
			label9.TabIndex = 2;
			label9.Text = "Developer:";
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(18, 13);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(79, 32);
			label8.TabIndex = 1;
			label8.Text = "Status";
			inject.Controls.Add(InjectPannel1);
			inject.Controls.Add(InjectTextBox);
			inject.Location = new System.Drawing.Point(196, 80);
			inject.Name = "inject";
			inject.Size = new System.Drawing.Size(461, 360);
			inject.TabIndex = 6;
			inject.MouseDown += new System.Windows.Forms.MouseEventHandler(inject_MouseDown);
			inject.MouseMove += new System.Windows.Forms.MouseEventHandler(inject_MouseMove);
			inject.MouseUp += new System.Windows.Forms.MouseEventHandler(inject_MouseUp);
			InjectPannel1.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			InjectPannel1.Controls.Add(InjectButton1);
			InjectPannel1.Controls.Add(InjectButton2);
			InjectPannel1.Location = new System.Drawing.Point(8, 232);
			InjectPannel1.Name = "InjectPannel1";
			InjectPannel1.Size = new System.Drawing.Size(446, 85);
			InjectPannel1.TabIndex = 2;
			InjectButton1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			InjectButton1.FlatAppearance.BorderSize = 0;
			InjectButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			InjectButton1.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			InjectButton1.ForeColor = System.Drawing.Color.White;
			InjectButton1.Location = new System.Drawing.Point(14, 14);
			InjectButton1.Name = "InjectButton1";
			InjectButton1.Size = new System.Drawing.Size(135, 53);
			InjectButton1.TabIndex = 2;
			InjectButton1.Text = "Inject Aimbot";
			InjectButton1.UseVisualStyleBackColor = false;
			InjectButton1.Click += new System.EventHandler(button8_Click);
			InjectButton2.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			InjectButton2.FlatAppearance.BorderSize = 0;
			InjectButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			InjectButton2.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			InjectButton2.ForeColor = System.Drawing.Color.White;
			InjectButton2.Location = new System.Drawing.Point(278, 14);
			InjectButton2.Name = "InjectButton2";
			InjectButton2.Size = new System.Drawing.Size(158, 53);
			InjectButton2.TabIndex = 1;
			InjectButton2.Text = "Inject Mod Menu";
			InjectButton2.UseVisualStyleBackColor = false;
			InjectButton2.Click += new System.EventHandler(button7_Click);
			InjectTextBox.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			InjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			InjectTextBox.Font = new System.Drawing.Font("Segoe UI", 9f);
			InjectTextBox.ForeColor = System.Drawing.Color.White;
			InjectTextBox.Location = new System.Drawing.Point(10, 67);
			InjectTextBox.Multiline = true;
			InjectTextBox.Name = "InjectTextBox";
			InjectTextBox.Size = new System.Drawing.Size(442, 143);
			InjectTextBox.TabIndex = 0;
			inject2.Location = new System.Drawing.Point(193, 2);
			inject2.Name = "inject2";
			inject2.Size = new System.Drawing.Size(228, 60);
			inject2.TabIndex = 7;
			Aimbot.Controls.Add(AimbotPannel1);
			Aimbot.Controls.Add(AimbotButton4);
			Aimbot.Controls.Add(AimbotButton3);
			Aimbot.Controls.Add(AimbotButton1);
			Aimbot.Location = new System.Drawing.Point(196, 77);
			Aimbot.Name = "Aimbot";
			Aimbot.Size = new System.Drawing.Size(461, 360);
			Aimbot.TabIndex = 8;
			Aimbot.MouseDown += new System.Windows.Forms.MouseEventHandler(Aimbot_MouseDown);
			Aimbot.MouseMove += new System.Windows.Forms.MouseEventHandler(Aimbot_MouseMove);
			Aimbot.MouseUp += new System.Windows.Forms.MouseEventHandler(Aimbot_MouseUp);
			AimbotPannel1.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			AimbotPannel1.Controls.Add(label19);
			AimbotPannel1.Location = new System.Drawing.Point(4, 259);
			AimbotPannel1.Name = "AimbotPannel1";
			AimbotPannel1.Size = new System.Drawing.Size(453, 63);
			AimbotPannel1.TabIndex = 5;
			label19.AutoSize = true;
			label19.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label19.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label19.Location = new System.Drawing.Point(12, 13);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(432, 32);
			label19.TabIndex = 2;
			label19.Text = "Make sure you only have one selected.";
			AimbotButton4.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			AimbotButton4.Controls.Add(Xmouse);
			AimbotButton4.Controls.Add(label17);
			AimbotButton4.Location = new System.Drawing.Point(283, 163);
			AimbotButton4.Name = "AimbotButton4";
			AimbotButton4.Size = new System.Drawing.Size(147, 63);
			AimbotButton4.TabIndex = 4;
			Xmouse.AutoSize = true;
			Xmouse.Checked = true;
			Xmouse.CheckState = System.Windows.Forms.CheckState.Checked;
			Xmouse.Location = new System.Drawing.Point(118, 24);
			Xmouse.Name = "Xmouse";
			Xmouse.Size = new System.Drawing.Size(18, 17);
			Xmouse.TabIndex = 1;
			Xmouse.UseVisualStyleBackColor = true;
			label17.AutoSize = true;
			label17.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label17.ForeColor = System.Drawing.Color.White;
			label17.Location = new System.Drawing.Point(14, 13);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(101, 32);
			label17.TabIndex = 2;
			label17.Text = "Xmouse";
			AimbotButton3.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			AimbotButton3.Controls.Add(LeftMouse);
			AimbotButton3.Controls.Add(label16);
			AimbotButton3.Location = new System.Drawing.Point(22, 162);
			AimbotButton3.Name = "AimbotButton3";
			AimbotButton3.Size = new System.Drawing.Size(147, 63);
			AimbotButton3.TabIndex = 3;
			LeftMouse.AutoSize = true;
			LeftMouse.Location = new System.Drawing.Point(118, 24);
			LeftMouse.Name = "LeftMouse";
			LeftMouse.Size = new System.Drawing.Size(18, 17);
			LeftMouse.TabIndex = 1;
			LeftMouse.UseVisualStyleBackColor = true;
			label16.AutoSize = true;
			label16.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label16.ForeColor = System.Drawing.Color.White;
			label16.Location = new System.Drawing.Point(7, 15);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(112, 32);
			label16.TabIndex = 2;
			label16.Text = "Left Click";
			AimbotButton1.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			AimbotButton1.Controls.Add(Shift);
			AimbotButton1.Controls.Add(label15);
			AimbotButton1.Location = new System.Drawing.Point(22, 67);
			AimbotButton1.Name = "AimbotButton1";
			AimbotButton1.Size = new System.Drawing.Size(115, 63);
			AimbotButton1.TabIndex = 0;
			Shift.AutoSize = true;
			Shift.Location = new System.Drawing.Point(83, 24);
			Shift.Name = "Shift";
			Shift.Size = new System.Drawing.Size(18, 17);
			Shift.TabIndex = 1;
			Shift.UseVisualStyleBackColor = true;
			label15.AutoSize = true;
			label15.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label15.ForeColor = System.Drawing.Color.White;
			label15.Location = new System.Drawing.Point(12, 15);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(64, 32);
			label15.TabIndex = 2;
			label15.Text = "Shift";
			Aimbot2.Controls.Add(ThemePage2);
			Aimbot2.Location = new System.Drawing.Point(191, 0);
			Aimbot2.Name = "Aimbot2";
			Aimbot2.Size = new System.Drawing.Size(373, 60);
			Aimbot2.TabIndex = 9;
			ThemePage2.Location = new System.Drawing.Point(0, 0);
			ThemePage2.Name = "ThemePage2";
			ThemePage2.Size = new System.Drawing.Size(379, 56);
			ThemePage2.TabIndex = 13;
			ThemePage2.MouseDown += new System.Windows.Forms.MouseEventHandler(ThemePage2_MouseDown);
			ThemePage2.MouseMove += new System.Windows.Forms.MouseEventHandler(ThemePage2_MouseMove);
			ThemePage2.MouseUp += new System.Windows.Forms.MouseEventHandler(ThemePage2_MouseUp);
			Settings.Controls.Add(pictureBox2);
			Settings.Location = new System.Drawing.Point(191, 2);
			Settings.Name = "Settings";
			Settings.Size = new System.Drawing.Size(387, 65);
			Settings.TabIndex = 10;
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(331, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(33, 32);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			Settings2.Controls.Add(SettingsPannel2);
			Settings2.Controls.Add(SettingsPannel1);
			Settings2.Location = new System.Drawing.Point(193, 74);
			Settings2.Name = "Settings2";
			Settings2.Size = new System.Drawing.Size(458, 360);
			Settings2.TabIndex = 11;
			Settings2.MouseDown += new System.Windows.Forms.MouseEventHandler(Settings2_MouseDown);
			Settings2.MouseMove += new System.Windows.Forms.MouseEventHandler(Settings2_MouseMove);
			Settings2.MouseUp += new System.Windows.Forms.MouseEventHandler(Settings2_MouseUp);
			SettingsPannel2.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			SettingsPannel2.Controls.Add(label23);
			SettingsPannel2.Controls.Add(label22);
			SettingsPannel2.Controls.Add(label21);
			SettingsPannel2.Location = new System.Drawing.Point(16, 189);
			SettingsPannel2.Name = "SettingsPannel2";
			SettingsPannel2.Size = new System.Drawing.Size(428, 156);
			SettingsPannel2.TabIndex = 1;
			label23.AutoSize = true;
			label23.Font = new System.Drawing.Font("Nirmala UI", 9.75f);
			label23.ForeColor = System.Drawing.Color.MediumSeaGreen;
			label23.Location = new System.Drawing.Point(15, 107);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(197, 23);
			label23.TabIndex = 3;
			label23.Text = "Click here for the dll files";
			label23.Click += new System.EventHandler(label23_Click);
			label22.AutoSize = true;
			label22.Font = new System.Drawing.Font("Nirmala UI", 9.75f);
			label22.ForeColor = System.Drawing.Color.FromArgb(159, 151, 176);
			label22.Location = new System.Drawing.Point(15, 62);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(388, 23);
			label22.TabIndex = 2;
			label22.Text = "Install the file and move all .dll files into System32";
			label21.AutoSize = true;
			label21.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label21.ForeColor = System.Drawing.Color.White;
			label21.Location = new System.Drawing.Point(13, 8);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(169, 32);
			label21.TabIndex = 1;
			label21.Text = "Missing Dll Fix";
			SettingsPannel1.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			SettingsPannel1.Controls.Add(TOP);
			SettingsPannel1.Controls.Add(label20);
			SettingsPannel1.Location = new System.Drawing.Point(16, 54);
			SettingsPannel1.Name = "SettingsPannel1";
			SettingsPannel1.Size = new System.Drawing.Size(153, 63);
			SettingsPannel1.TabIndex = 0;
			TOP.AutoSize = true;
			TOP.Location = new System.Drawing.Point(120, 26);
			TOP.Name = "TOP";
			TOP.Size = new System.Drawing.Size(18, 17);
			TOP.TabIndex = 1;
			TOP.UseVisualStyleBackColor = true;
			TOP.CheckedChanged += new System.EventHandler(TOP_CheckedChanged);
			label20.AutoSize = true;
			label20.Font = new System.Drawing.Font("Nirmala UI", 14.25f);
			label20.ForeColor = System.Drawing.Color.White;
			label20.Location = new System.Drawing.Point(8, 15);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(108, 32);
			label20.TabIndex = 0;
			label20.Text = "TopMost";
			ThemePage.Controls.Add(ThemePannel);
			ThemePage.Location = new System.Drawing.Point(190, 71);
			ThemePage.Name = "ThemePage";
			ThemePage.Size = new System.Drawing.Size(458, 360);
			ThemePage.TabIndex = 12;
			ThemePage.Paint += new System.Windows.Forms.PaintEventHandler(ThemePage_Paint);
			ThemePannel.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			ThemePannel.Controls.Add(ThemeButton5);
			ThemePannel.Controls.Add(ThemeButton4);
			ThemePannel.Controls.Add(ThemeButton3);
			ThemePannel.Controls.Add(ThemeButton2);
			ThemePannel.Controls.Add(ThemeButton1);
			ThemePannel.Location = new System.Drawing.Point(14, 20);
			ThemePannel.Name = "ThemePannel";
			ThemePannel.Size = new System.Drawing.Size(428, 326);
			ThemePannel.TabIndex = 2;
			ThemePannel.Paint += new System.Windows.Forms.PaintEventHandler(ThemePannel_Paint);
			ThemeButton5.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			ThemeButton5.FlatAppearance.BorderSize = 0;
			ThemeButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ThemeButton5.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			ThemeButton5.ForeColor = System.Drawing.Color.White;
			ThemeButton5.Location = new System.Drawing.Point(280, 70);
			ThemeButton5.Name = "ThemeButton5";
			ThemeButton5.Size = new System.Drawing.Size(135, 53);
			ThemeButton5.TabIndex = 7;
			ThemeButton5.Text = "Off White";
			ThemeButton5.UseVisualStyleBackColor = false;
			ThemeButton5.Click += new System.EventHandler(ThemeButton5_Click);
			ThemeButton4.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			ThemeButton4.FlatAppearance.BorderSize = 0;
			ThemeButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ThemeButton4.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			ThemeButton4.ForeColor = System.Drawing.Color.White;
			ThemeButton4.Location = new System.Drawing.Point(280, 9);
			ThemeButton4.Name = "ThemeButton4";
			ThemeButton4.Size = new System.Drawing.Size(135, 53);
			ThemeButton4.TabIndex = 6;
			ThemeButton4.Text = "Supreme";
			ThemeButton4.UseVisualStyleBackColor = false;
			ThemeButton4.Click += new System.EventHandler(ThemeButton4_Click_1);
			ThemeButton3.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			ThemeButton3.FlatAppearance.BorderSize = 0;
			ThemeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ThemeButton3.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			ThemeButton3.ForeColor = System.Drawing.Color.White;
			ThemeButton3.Location = new System.Drawing.Point(10, 129);
			ThemeButton3.Name = "ThemeButton3";
			ThemeButton3.Size = new System.Drawing.Size(135, 53);
			ThemeButton3.TabIndex = 5;
			ThemeButton3.Text = "Pink Purple";
			ThemeButton3.UseVisualStyleBackColor = false;
			ThemeButton3.Click += new System.EventHandler(button1_Click_1);
			ThemeButton2.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			ThemeButton2.FlatAppearance.BorderSize = 0;
			ThemeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ThemeButton2.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			ThemeButton2.ForeColor = System.Drawing.Color.White;
			ThemeButton2.Location = new System.Drawing.Point(10, 70);
			ThemeButton2.Name = "ThemeButton2";
			ThemeButton2.Size = new System.Drawing.Size(135, 53);
			ThemeButton2.TabIndex = 4;
			ThemeButton2.Text = "Red";
			ThemeButton2.UseVisualStyleBackColor = false;
			ThemeButton2.Click += new System.EventHandler(button11_Click);
			ThemeButton1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			ThemeButton1.FlatAppearance.BorderSize = 0;
			ThemeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ThemeButton1.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			ThemeButton1.ForeColor = System.Drawing.Color.White;
			ThemeButton1.Location = new System.Drawing.Point(10, 10);
			ThemeButton1.Name = "ThemeButton1";
			ThemeButton1.Size = new System.Drawing.Size(135, 53);
			ThemeButton1.TabIndex = 3;
			ThemeButton1.Text = "Blue";
			ThemeButton1.UseVisualStyleBackColor = false;
			ThemeButton1.Click += new System.EventHandler(button10_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			base.ClientSize = new System.Drawing.Size(656, 443);
			base.Controls.Add(Settings);
			base.Controls.Add(Aimbot2);
			base.Controls.Add(inject2);
			base.Controls.Add(ThemePage);
			base.Controls.Add(Settings2);
			base.Controls.Add(Aimbot);
			base.Controls.Add(inject);
			base.Controls.Add(DashPannel3);
			base.Controls.Add(DashPannel2);
			base.Controls.Add(DashPannel1);
			base.Controls.Add(Sidepannel);
			base.Controls.Add(MinimizeButton);
			base.Controls.Add(ExitButton);
			ForeColor = System.Drawing.Color.White;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			Text = "Form1";
			base.Load += new System.EventHandler(Form1_Load);
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(Form1_MouseDown);
			base.MouseMove += new System.Windows.Forms.MouseEventHandler(Form1_MouseMove);
			base.MouseUp += new System.Windows.Forms.MouseEventHandler(Form1_MouseUp);
			Sidepannel.ResumeLayout(false);
			Sidepannel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			DashPannel1.ResumeLayout(false);
			DashPannel1.PerformLayout();
			DashPannel2.ResumeLayout(false);
			DashPannel2.PerformLayout();
			DashPannel3.ResumeLayout(false);
			DashPannel3.PerformLayout();
			inject.ResumeLayout(false);
			inject.PerformLayout();
			InjectPannel1.ResumeLayout(false);
			Aimbot.ResumeLayout(false);
			AimbotPannel1.ResumeLayout(false);
			AimbotPannel1.PerformLayout();
			AimbotButton4.ResumeLayout(false);
			AimbotButton4.PerformLayout();
			AimbotButton3.ResumeLayout(false);
			AimbotButton3.PerformLayout();
			AimbotButton1.ResumeLayout(false);
			AimbotButton1.PerformLayout();
			Aimbot2.ResumeLayout(false);
			Settings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			Settings2.ResumeLayout(false);
			SettingsPannel2.ResumeLayout(false);
			SettingsPannel2.PerformLayout();
			SettingsPannel1.ResumeLayout(false);
			SettingsPannel1.PerformLayout();
			ThemePage.ResumeLayout(false);
			ThemePannel.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
