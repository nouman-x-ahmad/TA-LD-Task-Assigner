﻿namespace TA_project
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tA_UserContr1 = new TA_project.TA_UserContr();
			this.lD_UserContr1 = new TA_project.LD_UserContr();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(578, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Faculty";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Location = new System.Drawing.Point(2, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 602);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "Teacher Assistant";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(63, 383);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 48);
			this.button2.TabIndex = 1;
			this.button2.Text = "Lab Demonstrator";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tA_UserContr1
			// 
			this.tA_UserContr1.Location = new System.Drawing.Point(235, 111);
			this.tA_UserContr1.Name = "tA_UserContr1";
			this.tA_UserContr1.Size = new System.Drawing.Size(859, 492);
			this.tA_UserContr1.TabIndex = 2;
			// 
			// lD_UserContr1
			// 
			this.lD_UserContr1.Location = new System.Drawing.Point(224, 111);
			this.lD_UserContr1.Name = "lD_UserContr1";
			this.lD_UserContr1.Size = new System.Drawing.Size(950, 522);
			this.lD_UserContr1.TabIndex = 3;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1094, 605);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tA_UserContr1);
			this.Controls.Add(this.lD_UserContr1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private TA_UserContr tA_UserContr1;
		private LD_UserContr lD_UserContr1;
	}
}