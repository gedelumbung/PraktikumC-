/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 03/01/2011
 * Time: 22:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas_praktikum_2
{
	partial class Lembur
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.rdLembur = new System.Windows.Forms.RadioButton();
			this.rdNormal = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.rdLembur);
			this.groupBox1.Controls.Add(this.rdNormal);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(357, 113);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Batas Jam Kerja Pegawai";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(249, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Hitung Gaji";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// rdLembur
			// 
			this.rdLembur.Location = new System.Drawing.Point(10, 49);
			this.rdLembur.Name = "rdLembur";
			this.rdLembur.Size = new System.Drawing.Size(325, 24);
			this.rdLembur.TabIndex = 1;
			this.rdLembur.TabStop = true;
			this.rdLembur.Text = "08:00 - 20:00 ( Jam normal + Jam lembur dengan upah ekstra )";
			this.rdLembur.UseVisualStyleBackColor = true;
			// 
			// rdNormal
			// 
			this.rdNormal.Location = new System.Drawing.Point(10, 19);
			this.rdNormal.Name = "rdNormal";
			this.rdNormal.Size = new System.Drawing.Size(319, 24);
			this.rdNormal.TabIndex = 0;
			this.rdNormal.TabStop = true;
			this.rdNormal.Text = "08:00 - 14:00 ( Jam normal kerja dengan upah standar)";
			this.rdNormal.UseVisualStyleBackColor = true;
			// 
			// Lembur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 137);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Lembur";
			this.Text = "Batas Jam Kerja";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton rdNormal;
		private System.Windows.Forms.RadioButton rdLembur;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
