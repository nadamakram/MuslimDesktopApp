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
	public partial class Page2Quraan : Form
	{
		public Page2Quraan()
		{
			InitializeComponent();
		}

		private void Page2Quraan_Load(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			Page3Quraan pageThreeTowInstance = new Page3Quraan();
			pageThreeTowInstance.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Page1Quraan pageOneTwoInstance = new Page1Quraan();
			pageOneTwoInstance.Show();
		}
	}
}
