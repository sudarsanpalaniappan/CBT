﻿
namespace WindowsFormsApp1
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.BOXNO1 = new System.Windows.Forms.TextBox();
			this.BOXNO2 = new System.Windows.Forms.TextBox();
			this.BOXNO3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(189, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Department:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(170, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Student name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(195, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Register no:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(337, 317);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Store";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(248, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "Enter the details";
			// 
			// BOXNO1
			// 
			this.BOXNO1.Location = new System.Drawing.Point(337, 123);
			this.BOXNO1.Name = "BOXNO1";
			this.BOXNO1.Size = new System.Drawing.Size(100, 20);
			this.BOXNO1.TabIndex = 8;
			// 
			// BOXNO2
			// 
			this.BOXNO2.Location = new System.Drawing.Point(337, 181);
			this.BOXNO2.Name = "BOXNO2";
			this.BOXNO2.Size = new System.Drawing.Size(100, 20);
			this.BOXNO2.TabIndex = 9;
			// 
			// BOXNO3
			// 
			this.BOXNO3.Location = new System.Drawing.Point(334, 237);
			this.BOXNO3.Name = "BOXNO3";
			this.BOXNO3.Size = new System.Drawing.Size(100, 20);
			this.BOXNO3.TabIndex = 10;
			this.BOXNO3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BOXNO3);
			this.Controls.Add(this.BOXNO2);
			this.Controls.Add(this.BOXNO1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox BOXNO1;
		private System.Windows.Forms.TextBox BOXNO2;
		private System.Windows.Forms.TextBox BOXNO3;
	}
}

