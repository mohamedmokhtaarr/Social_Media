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
	public partial class Post : UserControl
	{
		public Post()
		{
			InitializeComponent();
		}

		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{

		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Post_Load(object sender, EventArgs e)
		{

		}
		public void update_data(post post)
		{
			//guna2CirclePictureBox1.Image = Base64ToImage(post.auther.img);

			guna2HtmlLabel1.Text = post.auther.userName;
			guna2HtmlLabel2.Text = post.Catigory.name;
			//guna2DateTimePicker1.Value = (DateTime)post.date;
			guna2TextBox1.Text = post.desc;
			//guna2PictureBox1.Image = Base64ToImage(post.img);


		}

		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{

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
	}
}
