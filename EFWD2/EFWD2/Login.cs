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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel2_Click(object sender, EventArgs e)
		{
			var SignUp = new SignUp();
			SignUp.TopMost = true;
			SignUp.Show();

		}

		private void loginbtn_Click(object sender, EventArgs e)
		{
			string enteredUsername = txt_email.Text;
			string enteredPassword = txt_pass.Text;

			using (var context = new ITIContext())
			{
				var author = context.Authers
					.FirstOrDefault(a => a.email == enteredUsername && a.Password == enteredPassword);

				if (author != null)
				{
					Form3 thirdForm = new Form3(author.id); // Pass the author's ID

					thirdForm.TopMost = true;

					thirdForm.Show();
					this.Hide();

				}
				else
				{
					MessageBox.Show("Invalid username or password. Please try again.");
					txt_pass.Clear();
					txt_email.Clear();
				}
			}
		}

		private void Login_Load_1(object sender, EventArgs e)
		{

		}
	}
}
