using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouslimDesktopApp
{
	public partial class LogIn : Form
	{
		public LogIn()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			home instanceLogIn = new home();
			instanceLogIn.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Page1Quraan instanceIndex = new Page1Quraan();
			instanceIndex.Show();
		}
	}
}
