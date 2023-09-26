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
	public partial class PostLayout : UserControl
	{
		public PostLayout()
		{
			InitializeComponent();
		}

		public void getPosts()
		{
			var context = new ITIContext();
			var posts = context.Posts.ToList();

			foreach (post item in posts)
			{
				var post = new Post();
				post.update_data(item);
				flowLayoutPanel1.Controls.Add(post);

			}

		}
		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
