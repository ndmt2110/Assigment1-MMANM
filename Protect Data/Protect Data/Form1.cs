using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ProtectFiles.Properties;
using DevExpress;

namespace Protect_Data
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		private bool mouseIsDown = false;
		private Point firstPoint;

		public Form1()
		{
			InitializeComponent();
			xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[0];
			txtInputFile.ReadOnly = true;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			firstPoint = e.Location;
			mouseIsDown = true;
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseIsDown = false;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if(mouseIsDown)
			{
				//get position different between two points
				int xDiff = firstPoint.X - e.Location.X;
				int yDiff = firstPoint.Y - e.Location.Y;

				//set new points
				int x = this.Location.X - xDiff;
				int y = this.Location.Y - yDiff;
				this.Location = new Point(x, y);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.xtraTabControl1.Focus();
		}

		private void btnInputFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog f = new OpenFileDialog();
			f.Filter = "All File | *.*";
			if(f.ShowDialog() == DialogResult.OK)
			{
				txtInputFile.Text = f.FileName;
			}
		}
	}
}
