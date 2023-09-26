using EFWD2.Models;

namespace EFWD2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_register_Click(object sender, EventArgs e)
		{
			using (var context = new ITIContext())
			{
				auther newAuthor = new auther
				{
					userName = txt_name.Text,
					email = txt_email.Text,
					Password = txt_password.Text,
					age = int.Parse(txt_age.Text)
				};

				context.Authers.Add(newAuthor);
				context.SaveChanges();
			}

			MessageBox.Show("Author registered successfully.");
			var newForm = new Form2();
			newForm.Show();
		}
	}
}