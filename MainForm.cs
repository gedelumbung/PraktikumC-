/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 03/01/2011
 * Time: 12:38
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public OleDbConnection database;
		public MainForm()
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if (usTeks.Text=="" && psTeks.Text=="") {
				MessageBox.Show("Username dan Password masih kosong.");
			}
			else{
				string username=usTeks.Text.ToString();
				string password=psTeks.Text.ToString();
				try {
				OleDbCommand SQLQuery = new OleDbCommand();
            	DataTable data = null;
            	OleDbDataAdapter dataAdapter = null;
            	SQLQuery.CommandText = ("select * from tbl_karyawan left join tbl_jabatan on tbl_karyawan.id_jabatan=tbl_jabatan.id_jabatan where username='"+username+"' and password='"+password+"'");
            	SQLQuery.Connection = database;
            	data = new DataTable();
            	dataAdapter = new OleDbDataAdapter(SQLQuery);
            	dataAdapter.Fill(data);
            	foreach(DataRow drRow in data.Rows)
            	{
            		if(username==drRow["username"].ToString() && password==drRow["password"].ToString())
            		{
            			string nama = drRow["nama_karyawan"].ToString();
            			string alamat = drRow["alamat"].ToString();
            			string tgl_lahir = drRow["tgl_lahir"].ToString();
            			string id_karyawan = drRow["id_karyawan"].ToString();
            			string jabatan = drRow["jabatan"].ToString();
            			string gjiSt = drRow["gaji_standar"].ToString();
            			Karyawan frmKaryawan = new Karyawan();
            			frmKaryawan.namakar = nama;
            			frmKaryawan.alamatkar = alamat;
            			frmKaryawan.ttlkar = tgl_lahir;
            			frmKaryawan.idkar = id_karyawan;
            			frmKaryawan.jabatankar = jabatan;
            			frmKaryawan.gjSt = gjiSt;
            			frmKaryawan.Show();
            			this.Hide();
            		}
            		else
            		{
            			MessageBox.Show("salah");
            		}
            	}
				} 
			
                	catch (Exception ex)
                	{
                  	  MessageBox.Show(ex.Message);
                	}
				}
		}
		
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void KeluarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
