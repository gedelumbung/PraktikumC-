/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 03/01/2011
 * Time: 22:04
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
	/// Description of Lembur.
	/// </summary>
	public partial class Lembur : Form
	{
		public OleDbConnection database;
		public string id_kar,tgl,gaji;
		public Lembur()
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
			if (rdNormal.Checked==true) 
			{
				string SQLString = "INSERT INTO tbl_gaji(id_karyawan, tgl_posting, gaji) VALUES('"+id_kar+"', '"+tgl+"', '"+gaji+"');";
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
                MessageBox.Show("Data Gaji sudah disimpan!!\nGaji anda Rp."+gaji+"");
                this.Close();
			}
			else if(rdLembur.Checked==true)
			{
				int gaji_asli = Convert.ToInt32(gaji);
				int gaji_lembur = Convert.ToInt32(gaji_asli*2);
				int total_gaji = Convert.ToInt32(gaji_asli + gaji_lembur);
				string SQLString = "INSERT INTO tbl_gaji(id_karyawan, tgl_posting, gaji) VALUES('"+id_kar+"', '"+tgl+"', '"+total_gaji+"');";
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
                MessageBox.Show("Data Gaji sudah disimpan!!\nGaji anda Rp."+total_gaji+"");
                this.Close();
			}
		}
		
	}
}
