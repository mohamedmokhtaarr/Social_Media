namespace EFWD2
{
	partial class Form2
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
			label1 = new Label();
			label2 = new Label();
			txt_username = new TextBox();
			txt_pass = new TextBox();
			btn_signin = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(80, 49);
			label1.Name = "label1";
			label1.Size = new Size(82, 20);
			label1.TabIndex = 0;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(433, 49);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 2;
			label2.Text = "Password";
			label2.Click += label2_Click;
			// 
			// txt_username
			// 
			txt_username.Location = new Point(185, 46);
			txt_username.Name = "txt_username";
			txt_username.Size = new Size(206, 27);
			txt_username.TabIndex = 3;
			// 
			// txt_pass
			// 
			txt_pass.Location = new Point(522, 42);
			txt_pass.Name = "txt_pass";
			txt_pass.Size = new Size(190, 27);
			txt_pass.TabIndex = 5;
			// 
			// btn_signin
			// 
			btn_signin.Location = new Point(341, 94);
			btn_signin.Name = "btn_signin";
			btn_signin.Size = new Size(133, 29);
			btn_signin.TabIndex = 6;
			btn_signin.Text = "Sign in";
			btn_signin.UseVisualStyleBackColor = true;
			btn_signin.Click += btn_signin_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.zzzz;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_signin);
			Controls.Add(txt_pass);
			Controls.Add(txt_username);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form2";
			Text = "Form2";
			Load += Form2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txt_username;
		private TextBox txt_pass;
		private Button btn_signin;
	}
}