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
	public partial class Page1Quraan : Form
	{
		public Page1Quraan()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Page2Quraan pageTwoInstance = new Page2Quraan();
			pageTwoInstance.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Page3Quraan pageThreeOneInstance = new Page3Quraan();
			pageThreeOneInstance.Show();
		}
	}
}
