namespace TA_project
{
	partial class Admin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
			this.button1 = new System.Windows.Forms.Button();
			this.Nametxt = new System.Windows.Forms.Label();
			this.EMAIL = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LOGINFORM = new System.Windows.Forms.Label();
			this.login_data_error = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.exit_label = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(102, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(480, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "LOGIN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Nametxt
			// 
			this.Nametxt.AutoSize = true;
			this.Nametxt.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Nametxt.Location = new System.Drawing.Point(115, 187);
			this.Nametxt.Name = "Nametxt";
			this.Nametxt.Size = new System.Drawing.Size(47, 28);
			this.Nametxt.TabIndex = 1;
			this.Nametxt.Text = "Name";
			this.Nametxt.Click += new System.EventHandler(this.Namelb1_Click);
			// 
			// EMAIL
			// 
			this.EMAIL.AutoSize = true;
			this.EMAIL.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EMAIL.ForeColor = System.Drawing.SystemColors.Highlight;
			this.EMAIL.Location = new System.Drawing.Point(115, 222);
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.Size = new System.Drawing.Size(46, 28);
			this.EMAIL.TabIndex = 2;
			this.EMAIL.Text = "Email";
			this.EMAIL.Click += new System.EventHandler(this.Emaillb2_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(164, 193);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(382, 25);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.NametextBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(130, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 28);
			this.label2.TabIndex = 5;
			this.label2.Text = "ID";
			this.label2.Click += new System.EventHandler(this.IDlb3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(92, 305);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password";
			this.label3.Click += new System.EventHandler(this.Passwordlb1_Click);
			// 
			// LOGINFORM
			// 
			this.LOGINFORM.AutoSize = true;
			this.LOGINFORM.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LOGINFORM.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.LOGINFORM.Location = new System.Drawing.Point(276, 15);
			this.LOGINFORM.Name = "LOGINFORM";
			this.LOGINFORM.Size = new System.Drawing.Size(166, 54);
			this.LOGINFORM.TabIndex = 9;
			this.LOGINFORM.Text = "LOG IN\r\n";
			this.LOGINFORM.Click += new System.EventHandler(this.LOGINFORM_Click);
			// 
			// login_data_error
			// 
			this.login_data_error.AutoSize = true;
			this.login_data_error.Location = new System.Drawing.Point(188, 167);
			this.login_data_error.Name = "login_data_error";
			this.login_data_error.Size = new System.Drawing.Size(10, 13);
			this.login_data_error.TabIndex = 10;
			this.login_data_error.Text = " ";
			this.login_data_error.Click += new System.EventHandler(this.login_data_error_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(314, 105);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Location = new System.Drawing.Point(102, 214);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 1);
			this.panel1.TabIndex = 13;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel2.Location = new System.Drawing.Point(102, 256);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 1);
			this.panel2.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel3.Location = new System.Drawing.Point(102, 298);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(480, 1);
			this.panel3.TabIndex = 15;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox2.ForeColor = System.Drawing.Color.Black;
			this.textBox2.Location = new System.Drawing.Point(164, 228);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(382, 25);
			this.textBox2.TabIndex = 16;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox3.ForeColor = System.Drawing.Color.Black;
			this.textBox3.Location = new System.Drawing.Point(164, 271);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(382, 25);
			this.textBox3.TabIndex = 17;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox4.ForeColor = System.Drawing.Color.Black;
			this.textBox4.Location = new System.Drawing.Point(164, 311);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(382, 25);
			this.textBox4.TabIndex = 18;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel4.Location = new System.Drawing.Point(102, 342);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(480, 1);
			this.panel4.TabIndex = 19;
			// 
			// exit_label
			// 
			this.exit_label.AutoSize = true;
			this.exit_label.BackColor = System.Drawing.Color.CornflowerBlue;
			this.exit_label.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit_label.ForeColor = System.Drawing.Color.White;
			this.exit_label.Location = new System.Drawing.Point(282, 420);
			this.exit_label.Name = "exit_label";
			this.exit_label.Size = new System.Drawing.Size(122, 18);
			this.exit_label.TabIndex = 25;
			this.exit_label.Text = "EXIT WINDOW";
			this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(480, 353);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(102, 17);
			this.checkBox1.TabIndex = 26;
			this.checkBox1.Text = "Show Password";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(304, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 33);
			this.label1.TabIndex = 27;
			this.label1.Text = "Admin";
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(704, 696);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.exit_label);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.login_data_error);
			this.Controls.Add(this.LOGINFORM);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.EMAIL);
			this.Controls.Add(this.Nametxt);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Admin";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Nametxt;
		private System.Windows.Forms.Label EMAIL;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LOGINFORM;
		private System.Windows.Forms.Label login_data_error;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label exit_label;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
	}
}

