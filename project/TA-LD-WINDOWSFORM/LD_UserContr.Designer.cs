namespace TA_project
{
	partial class LD_UserContr
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LDlist = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.LDlist)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(632, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 26);
			this.button1.TabIndex = 14;
			this.button1.Text = "Assign";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(512, 213);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 124);
			this.textBox1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(562, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 27);
			this.label2.TabIndex = 12;
			this.label2.Text = "Enter to Assign Task";
			// 
			// LDlist
			// 
			this.LDlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LDlist.Location = new System.Drawing.Point(111, 108);
			this.LDlist.Name = "LDlist";
			this.LDlist.RowHeadersWidth = 51;
			this.LDlist.RowTemplate.Height = 24;
			this.LDlist.Size = new System.Drawing.Size(275, 363);
			this.LDlist.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(126, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 33);
			this.label1.TabIndex = 10;
			this.label1.Text = "Assigned LD List";
			// 
			// LD_UserContr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LDlist);
			this.Controls.Add(this.label1);
			this.Name = "LD_UserContr";
			this.Size = new System.Drawing.Size(950, 522);
			this.Load += new System.EventHandler(this.LD_UserContr_Load);
			((System.ComponentModel.ISupportInitialize)(this.LDlist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView LDlist;
		private System.Windows.Forms.Label label1;
	}
}
