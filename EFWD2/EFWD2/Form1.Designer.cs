namespace EFWD2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txt_name = new TextBox();
			txt_email = new TextBox();
			txt_password = new TextBox();
			txt_age = new TextBox();
			btn_register = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.HighlightText;
			label1.Location = new Point(110, 38);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(107, 84);
			label2.Name = "label2";
			label2.Size = new Size(52, 20);
			label2.TabIndex = 2;
			label2.Text = "E-mail";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(420, 80);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(434, 38);
			label4.Name = "label4";
			label4.Size = new Size(36, 20);
			label4.TabIndex = 6;
			label4.Text = "Age";
			// 
			// txt_name
			// 
			txt_name.BackColor = SystemColors.Info;
			txt_name.Location = new Point(195, 35);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(193, 27);
			txt_name.TabIndex = 9;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(195, 77);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(193, 27);
			txt_email.TabIndex = 10;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(511, 77);
			txt_password.Name = "txt_password";
			txt_password.Size = new Size(194, 27);
			txt_password.TabIndex = 11;
			// 
			// txt_age
			// 
			txt_age.Location = new Point(511, 31);
			txt_age.Name = "txt_age";
			txt_age.Size = new Size(194, 27);
			txt_age.TabIndex = 12;
			// 
			// btn_register
			// 
			btn_register.Location = new Point(331, 133);
			btn_register.Name = "btn_register";
			btn_register.Size = new Size(139, 29);
			btn_register.TabIndex = 14;
			btn_register.Text = "Register";
			btn_register.UseVisualStyleBackColor = true;
			btn_register.Click += btn_register_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.zzzz;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(761, 450);
			Controls.Add(btn_register);
			Controls.Add(txt_age);
			Controls.Add(txt_password);
			Controls.Add(txt_email);
			Controls.Add(txt_name);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "login";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txt_name;
		private TextBox txt_email;
		private TextBox txt_password;
		private TextBox txt_age;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private Button btn_register;
	}
}