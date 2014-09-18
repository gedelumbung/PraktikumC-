/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 03/01/2011
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas_praktikum_2
{
	partial class Karyawan
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keluarLogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tglSekarang = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.rdTidak = new System.Windows.Forms.RadioButton();
			this.rdYa = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.gjStandar = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.idKaryawan = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.rekapGaji = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.tglKar = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.almtKar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.jbtKar = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.namaKar = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rekapGaji)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(449, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.keluarLogOutToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.menuToolStripMenuItem.Text = "Aplikasi";
			// 
			// keluarLogOutToolStripMenuItem
			// 
			this.keluarLogOutToolStripMenuItem.Name = "keluarLogOutToolStripMenuItem";
			this.keluarLogOutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.keluarLogOutToolStripMenuItem.Text = "Keluar dan Log Out";
			this.keluarLogOutToolStripMenuItem.Click += new System.EventHandler(this.KeluarLogOutToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "APLIKASI PENGHITUNGAN UPAH";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "PT. Tembus Sana Tembus Sini";
			// 
			// tglSekarang
			// 
			this.tglSekarang.Location = new System.Drawing.Point(314, 53);
			this.tglSekarang.Name = "tglSekarang";
			this.tglSekarang.Size = new System.Drawing.Size(123, 23);
			this.tglSekarang.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(320, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Anda Log In Tanggal :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.rdTidak);
			this.groupBox1.Controls.Add(this.rdYa);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(425, 61);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Isi Absensi";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(342, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 30);
			this.button2.TabIndex = 10;
			this.button2.Text = "Keterangan";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(288, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 30);
			this.button1.TabIndex = 9;
			this.button1.Text = "PILIH";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// rdTidak
			// 
			this.rdTidak.Location = new System.Drawing.Point(237, 23);
			this.rdTidak.Name = "rdTidak";
			this.rdTidak.Size = new System.Drawing.Size(54, 24);
			this.rdTidak.TabIndex = 8;
			this.rdTidak.TabStop = true;
			this.rdTidak.Text = "Tidak";
			this.rdTidak.UseVisualStyleBackColor = true;
			// 
			// rdYa
			// 
			this.rdYa.Location = new System.Drawing.Point(195, 23);
			this.rdYa.Name = "rdYa";
			this.rdYa.Size = new System.Drawing.Size(39, 24);
			this.rdYa.TabIndex = 7;
			this.rdYa.TabStop = true;
			this.rdYa.Text = "Ya";
			this.rdYa.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Apakah anda terlambat masuk kerja?";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.gjStandar);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.idKaryawan);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.rekapGaji);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.tglKar);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.almtKar);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.jbtKar);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.namaKar);
			this.groupBox2.Location = new System.Drawing.Point(12, 146);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(425, 246);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Detail Rekapan Gaji";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(77, 215);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 18);
			this.label10.TabIndex = 20;
			this.label10.Text = "Gaji Standar :";
			// 
			// gjStandar
			// 
			this.gjStandar.Location = new System.Drawing.Point(155, 212);
			this.gjStandar.Name = "gjStandar";
			this.gjStandar.ReadOnly = true;
			this.gjStandar.Size = new System.Drawing.Size(96, 20);
			this.gjStandar.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(9, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 18);
			this.label9.TabIndex = 18;
			this.label9.Text = "ID :";
			// 
			// idKaryawan
			// 
			this.idKaryawan.Location = new System.Drawing.Point(35, 212);
			this.idKaryawan.Name = "idKaryawan";
			this.idKaryawan.ReadOnly = true;
			this.idKaryawan.Size = new System.Drawing.Size(35, 20);
			this.idKaryawan.TabIndex = 17;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(276, 206);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(139, 30);
			this.button3.TabIndex = 11;
			this.button3.Text = "Refresh Data Rekap Gaji";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// rekapGaji
			// 
			this.rekapGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rekapGaji.Location = new System.Drawing.Point(9, 69);
			this.rekapGaji.Name = "rekapGaji";
			this.rekapGaji.Size = new System.Drawing.Size(406, 131);
			this.rekapGaji.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(219, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "TTL :";
			// 
			// tglKar
			// 
			this.tglKar.Location = new System.Drawing.Point(276, 43);
			this.tglKar.Name = "tglKar";
			this.tglKar.ReadOnly = true;
			this.tglKar.Size = new System.Drawing.Size(143, 20);
			this.tglKar.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(219, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 18);
			this.label8.TabIndex = 13;
			this.label8.Text = "Alamat :";
			// 
			// almtKar
			// 
			this.almtKar.Location = new System.Drawing.Point(276, 20);
			this.almtKar.Name = "almtKar";
			this.almtKar.ReadOnly = true;
			this.almtKar.Size = new System.Drawing.Size(143, 20);
			this.almtKar.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(9, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "Jabatan :";
			// 
			// jbtKar
			// 
			this.jbtKar.Location = new System.Drawing.Point(66, 42);
			this.jbtKar.Name = "jbtKar";
			this.jbtKar.ReadOnly = true;
			this.jbtKar.Size = new System.Drawing.Size(143, 20);
			this.jbtKar.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Nama :";
			// 
			// namaKar
			// 
			this.namaKar.Location = new System.Drawing.Point(66, 19);
			this.namaKar.Name = "namaKar";
			this.namaKar.ReadOnly = true;
			this.namaKar.Size = new System.Drawing.Size(143, 20);
			this.namaKar.TabIndex = 8;
			// 
			// Karyawan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 404);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tglSekarang);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Karyawan";
			this.Text = "Karyawan";
			this.Load += new System.EventHandler(this.KaryawanLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KaryawanFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rekapGaji)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox gjStandar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView rekapGaji;
		private System.Windows.Forms.RadioButton rdTidak;
		private System.Windows.Forms.RadioButton rdYa;
		private System.Windows.Forms.TextBox tglKar;
		private System.Windows.Forms.TextBox almtKar;
		private System.Windows.Forms.TextBox jbtKar;
		private System.Windows.Forms.TextBox idKaryawan;
		private System.Windows.Forms.TextBox namaKar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label tglSekarang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem keluarLogOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
