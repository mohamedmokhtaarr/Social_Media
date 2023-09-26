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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		//private void btn_save_Click(object sender, EventArgs e)
		//{
		//	string title = txt_title.Text;
		//	string description = txt_post.Text;
		//	int categoryId = (int)cmb_cat.SelectedValue; // Assuming you populate the combo box with category data.

		//	// Get the currently logged-in author's ID
		//	int authorId = GetLoggedInAuthorId(); // Replace with your method to get the author's ID.

		//	// Create a new Post object and save it to the database
		//	using (var context = new ITIContext())
		//	{
		//		post newPost = new post
		//		{
		//			title = title,
		//			desc = description,
		//			catId = categoryId,
		//			autherId = authorId,
		//			date = DateTime.Now 
		//		};

		//		context.Posts.Add(newPost);
		//		context.SaveChanges();
		//	}

			
		//	DialogResult = DialogResult.OK;
		//	Close();
		//}
	}
}
