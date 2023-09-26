using EFWD2.Models;
using Guna.UI2.WinForms;
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
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void SignUp_Load(object sender, EventArgs e)
		{

		}

		private void signupbtn_Click(object sender, EventArgs e)
		{
			using (var context = new ITIContext())
			{
				auther newAuthor = new auther
				{
					userName = txt_name.Text,
					email = txt_email.Text,
					Password = txt_password.Text,
					age = int.Parse(txt_age.Text),
					img = ImageToBase64(guna2CirclePictureBox1.Image,

					System.Drawing.Imaging.ImageFormat.Png)
				};

				context.Authers.Add(newAuthor);
				context.SaveChanges();
			}

			MessageBox.Show("Author registered successfully.");


			this.Close();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

			{

				string selectedFile = opnfd.FileName;
				guna2CirclePictureBox1.Image = Image.FromFile(selectedFile);
				guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


			}
		}

		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{

		}

		public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
		{
			using (MemoryStream ms = new MemoryStream())

			{
				image.Save(ms, format);

				byte[] imageBytes = ms.ToArray();
				string base64String = Convert.ToBase64String(imageBytes);
				return base64String;

			}
		}

		public Image Base64ToImage(string base64String)

		{

			// Convert Base64 String to byte[]

			byte[] imageBytes = Convert.FromBase64String(base64String);

			MemoryStream ms = new MemoryStream(imageBytes, 0,

			  imageBytes.Length);


			// Convert byte[] to Image

			ms.Write(imageBytes, 0, imageBytes.Length);

			Image image = Image.FromStream(ms, true);

			return image;

		}

		private void picbox1_Click(object sender, EventArgs e)
		{

		}
	}
}

