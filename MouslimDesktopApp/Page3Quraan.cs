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
	public partial class Page3Quraan : Form
	{
		public Page3Quraan()
		{
			InitializeComponent();
		}

		private void Page3Quraan_Load(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Page1Quraan pageOneThree = new Page1Quraan();
			pageOneThree.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Page2Quraan pageTwoThreeInstance = new Page2Quraan();
			pageTwoThreeInstance.Show();
		}
	}
}
