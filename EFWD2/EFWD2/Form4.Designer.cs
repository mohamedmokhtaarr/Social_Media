namespace EFWD2
{
	partial class Form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn_save = new Button();
			txt_title = new TextBox();
			txt_post = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			cmb_cat = new ComboBox();
			SuspendLayout();
			// 
			// btn_save
			// 
			btn_save.Location = new Point(324, 158);
			btn_save.Name = "btn_save";
			btn_save.Size = new Size(113, 29);
			btn_save.TabIndex = 0;
			btn_save.Text = "Save";
			btn_save.UseVisualStyleBackColor = true;
			//btn_save.Click += btn_save_Click;
			// 
			// txt_title
			// 
			txt_title.Location = new Point(149, 40);
			txt_title.Name = "txt_title";
			txt_title.Size = new Size(125, 27);
			txt_title.TabIndex = 1;
			// 
			// txt_post
			// 
			txt_post.Location = new Point(149, 115);
			txt_post.Name = "txt_post";
			txt_post.Size = new Size(572, 27);
			txt_post.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(55, 40);
			label1.Name = "label1";
			label1.Size = new Size(38, 20);
			label1.TabIndex = 4;
			label1.Text = "Title";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(419, 47);
			label2.Name = "label2";
			label2.Size = new Size(65, 20);
			label2.TabIndex = 5;
			label2.Text = "Catigory";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(55, 115);
			label3.Name = "label3";
			label3.Size = new Size(36, 20);
			label3.TabIndex = 6;
			label3.Text = "Post";
			// 
			// cmb_cat
			// 
			cmb_cat.FormattingEnabled = true;
			cmb_cat.Location = new Point(510, 44);
			cmb_cat.Name = "cmb_cat";
			cmb_cat.Size = new Size(151, 28);
			cmb_cat.TabIndex = 7;
			// 
			// Form4
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.zzzz;
			ClientSize = new Size(800, 450);
			Controls.Add(cmb_cat);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txt_post);
			Controls.Add(txt_title);
			Controls.Add(btn_save);
			Name = "Form4";
			Text = "Form4";
			Load += Form4_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_save;
		private TextBox txt_title;
		private TextBox txt_post;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox cmb_cat;
	}
}