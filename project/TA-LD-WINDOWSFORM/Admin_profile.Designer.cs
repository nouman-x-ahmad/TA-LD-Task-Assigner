namespace TA_project
{
	partial class Admin_profile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_profile));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Admin_title = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Admin_label4 = new System.Windows.Forms.Label();
			this.LD_label3 = new System.Windows.Forms.Label();
			this.TA_label2 = new System.Windows.Forms.Label();
			this.faculty_label1 = new System.Windows.Forms.Label();
			this.username_label = new System.Windows.Forms.Label();
			this.faculty_data21 = new TA_project.faculty_data2();
			this.lD_data41 = new TA_project.LD_data4();
			this.tA_data31 = new TA_project.TA_data3();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Admin_title
			// 
			this.Admin_title.AutoSize = true;
			this.Admin_title.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Admin_title.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Admin_title.Location = new System.Drawing.Point(347, 9);
			this.Admin_title.Name = "Admin_title";
			this.Admin_title.Size = new System.Drawing.Size(156, 24);
			this.Admin_title.TabIndex = 1;
			this.Admin_title.Text = "Admin Control";
			this.Admin_title.Click += new System.EventHandler(this.Admin_title_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel1.Controls.Add(this.Admin_label4);
			this.panel1.Controls.Add(this.LD_label3);
			this.panel1.Controls.Add(this.TA_label2);
			this.panel1.Controls.Add(this.faculty_label1);
			this.panel1.Controls.Add(this.username_label);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(161, 602);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Admin_label4
			// 
			this.Admin_label4.AutoSize = true;
			this.Admin_label4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Admin_label4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Admin_label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Admin_label4.Location = new System.Drawing.Point(14, 96);
			this.Admin_label4.Name = "Admin_label4";
			this.Admin_label4.Size = new System.Drawing.Size(95, 30);
			this.Admin_label4.TabIndex = 6;
			this.Admin_label4.Text = "ADMIN";
			this.Admin_label4.Click += new System.EventHandler(this.Admin_label4_Click);
			// 
			// LD_label3
			// 
			this.LD_label3.AutoSize = true;
			this.LD_label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LD_label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.LD_label3.Location = new System.Drawing.Point(14, 246);
			this.LD_label3.Name = "LD_label3";
			this.LD_label3.Size = new System.Drawing.Size(45, 30);
			this.LD_label3.TabIndex = 5;
			this.LD_label3.Text = "LD";
			this.LD_label3.Click += new System.EventHandler(this.LD_label3_Click);
			// 
			// TA_label2
			// 
			this.TA_label2.AutoSize = true;
			this.TA_label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TA_label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.TA_label2.Location = new System.Drawing.Point(14, 200);
			this.TA_label2.Name = "TA_label2";
			this.TA_label2.Size = new System.Drawing.Size(44, 30);
			this.TA_label2.TabIndex = 4;
			this.TA_label2.Text = "TA";
			this.TA_label2.Click += new System.EventHandler(this.TA_label2_Click);
			// 
			// faculty_label1
			// 
			this.faculty_label1.AutoSize = true;
			this.faculty_label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.faculty_label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.faculty_label1.Location = new System.Drawing.Point(14, 146);
			this.faculty_label1.Name = "faculty_label1";
			this.faculty_label1.Size = new System.Drawing.Size(121, 30);
			this.faculty_label1.TabIndex = 3;
			this.faculty_label1.Text = "FACULTY";
			this.faculty_label1.Click += new System.EventHandler(this.faculty_label1_Click);
			// 
			// username_label
			// 
			this.username_label.AutoSize = true;
			this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_label.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.username_label.Location = new System.Drawing.Point(56, 18);
			this.username_label.Name = "username_label";
			this.username_label.Size = new System.Drawing.Size(75, 16);
			this.username_label.TabIndex = 1;
			this.username_label.Tag = "username";
			this.username_label.Text = "username";
			this.username_label.Click += new System.EventHandler(this.username_label_Click);
			// 
			// faculty_data21
			// 
			this.faculty_data21.Location = new System.Drawing.Point(167, 0);
			this.faculty_data21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.faculty_data21.Name = "faculty_data21";
			this.faculty_data21.Size = new System.Drawing.Size(634, 602);
			this.faculty_data21.TabIndex = 4;
			// 
			// lD_data41
			// 
			this.lD_data41.Location = new System.Drawing.Point(167, 0);
			this.lD_data41.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lD_data41.Name = "lD_data41";
			this.lD_data41.Size = new System.Drawing.Size(621, 590);
			this.lD_data41.TabIndex = 5;
			this.lD_data41.Load += new System.EventHandler(this.lD_data41_Load);
			// 
			// tA_data31
			// 
			this.tA_data31.Location = new System.Drawing.Point(172, 9);
			this.tA_data31.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tA_data31.Name = "tA_data31";
			this.tA_data31.Size = new System.Drawing.Size(605, 570);
			this.tA_data31.TabIndex = 6;
			// 
			// Admin_profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(800, 602);
			this.Controls.Add(this.lD_data41);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Admin_title);
			this.Controls.Add(this.tA_data31);
			this.Controls.Add(this.faculty_data21);
			this.Name = "Admin_profile";
			this.Text = "Admin_profile";
			this.Load += new System.EventHandler(this.Admin_profile_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label Admin_title;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label username_label;
		private admin_data1 admin_data11;
		private faculty_data2 faculty_data21;
		private LD_data4 lD_data41;
		private TA_data3 tA_data31;
		private System.Windows.Forms.Label faculty_label1;
		private System.Windows.Forms.Label LD_label3;
		private System.Windows.Forms.Label TA_label2;
		private System.Windows.Forms.Label Admin_label4;
	}
}