namespace TA_project
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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tasktable = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tasktable)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button1.Location = new System.Drawing.Point(849, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 33);
			this.button1.TabIndex = 7;
			this.button1.Text = "Done";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(390, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 44);
			this.label2.TabIndex = 6;
			this.label2.Text = "Task Assigned";
			// 
			// tasktable
			// 
			this.tasktable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tasktable.Location = new System.Drawing.Point(105, 270);
			this.tasktable.Name = "tasktable";
			this.tasktable.RowHeadersWidth = 51;
			this.tasktable.RowTemplate.Height = 24;
			this.tasktable.Size = new System.Drawing.Size(842, 282);
			this.tasktable.TabIndex = 5;
			this.tasktable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskTA_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(426, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 46);
			this.label1.TabIndex = 4;
			this.label1.Text = "LD Profile";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 607);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tasktable);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.tasktable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView tasktable;
		private System.Windows.Forms.Label label1;
	}
}