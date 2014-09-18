/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 03/01/2011
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;  //memanggil library database

namespace tugas_praktikum_2
{
	/// <summary>
	/// Description of Karyawan.
	/// </summary>
	public partial class Karyawan : Form
	{
		public OleDbConnection database;
		public string namakar,alamatkar,ttlkar,idkar,jabatankar,tglskr,gjSt;
		public Karyawan()
		{
			
			InitializeComponent();
			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=karyawan.mdb";
            try
            {

                database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
			
		}
		private void ambilData(string perintah)
		{
			try {
			OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
			rekapGaji.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            rekapGaji.Columns.Clear(); // <-- clear columns
            //---------------------------------
            SQLQuery.CommandText = perintah;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            rekapGaji.DataSource = data;
            rekapGaji.AllowUserToAddRows = false; // remove the null line
            rekapGaji.ReadOnly = true;
            rekapGaji.Columns[0].Visible = false; //id gaji
            rekapGaji.Columns[1].Visible = false; //id karyawan
            rekapGaji.Columns[2].HeaderText = "Tanggal Gaji";
            rekapGaji.Columns[2].Width = 155; //tipe cd
            rekapGaji.Columns[3].HeaderText = "Jumlah Gaji";
            rekapGaji.Columns[3].Width = 190; //tipe cd
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		void KaryawanFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void KaryawanLoad(object sender, EventArgs e)
		{
			tglSekarang.Text = DateTime.Now.ToString();
			tglskr = DateTime.Now.ToString();
			namaKar.Text = namakar;
			jbtKar.Text = jabatankar;
			almtKar.Text = alamatkar;
			tglKar.Text = ttlkar;
			idKaryawan.Text = idkar;
			gjStandar.Text = gjSt;
			string perintah = ("select * from tbl_gaji where id_karyawan='"+idkar+"'");
			ambilData(perintah);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (rdYa.Checked==true) {
				string SQLString = "INSERT INTO tbl_gaji(id_karyawan, tgl_posting, gaji) VALUES('"+idkar+"', '"+tglskr+"', '0');";
				OleDbCommand SQLCommand = new OleDbCommand();
                SQLCommand.CommandText = SQLString;
                SQLCommand.Connection = database;
                int response = -1;
                try
                {
                    response = SQLCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Anda tidak diperbolehkan masuk..!!\nGaji anda Rp.0,00");
			}
			else if (rdTidak.Checked==true) {
            	Lembur Lmb = new Lembur();
            	Lmb.id_kar =idkar;
            	Lmb.tgl = tglskr;
            	Lmb.gaji = gjSt;
            	Lmb.Show();
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string perintah = ("select * from tbl_gaji where id_karyawan='"+idkar+"'");
			ambilData(perintah);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Jika memilih pilihan YA, maka anda dianggap tidak masuk dan gaji anda Rp.0,00\nDan jika memilih TIDAK, maka anda akan ditanya apakah anda lembur atau hanya kerja pada jam normal saja.");
		}
		
		void KeluarLogOutToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
