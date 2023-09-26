using EFWD2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWD2
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void btn_signin_Click(object sender, EventArgs e)
		{
			string enteredUsername = txt_username.Text;
			string enteredPassword = txt_pass.Text;

			using (var context = new ITIContext())
			{
				var author = context.Authers
					.FirstOrDefault(a => a.userName == enteredUsername && a.Password == enteredPassword);

				if (author != null)
				{
					Form3 thirdForm = new Form3(author.id); // Pass the author's ID
					thirdForm.Show();
				}
				else
				{
					MessageBox.Show("Invalid username or password. Please try again.");
					txt_pass.Clear();
					txt_username.Clear();
				}
			}

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
