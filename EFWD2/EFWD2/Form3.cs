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
	public partial class Form3 : Form
	{
		private int loggedInAuthorId;
		public Form3(int autherId)
		{
			InitializeComponent();
			loggedInAuthorId = autherId;
			postLayout1.getPosts();

		}

		private void btn_mypost_Click(object sender, EventArgs e)
		{


		}

		private void btn_addpost_Click(object sender, EventArgs e)
		{
			Form4 newPostForm = new Form4();

			// Show the NewPostForm
			DialogResult result = newPostForm.ShowDialog();

			// Check if the author saved the post
			if (result == DialogResult.OK)
			{

			}
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
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

		private void guna2Button2_Click(object sender, EventArgs e)
		{

		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void postLayout1_Load(object sender, EventArgs e)
		{

		}
	}
}
