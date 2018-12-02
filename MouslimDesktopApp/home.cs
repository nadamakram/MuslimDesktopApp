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
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void home_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SignUp instanceSignUp = new SignUp();
			instanceSignUp.Show();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			LogIn instanceLogInHome = new LogIn();
			instanceLogInHome.Show();
		}
	}
}
