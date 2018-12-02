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
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			home instanceHome = new home();
			instanceHome.Show();
		}
	}
}
