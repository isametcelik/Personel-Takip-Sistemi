﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPersonelTakip.Model;

namespace WinFormPersonelTakip
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection con;
		SqlCommand cmd;
		string connectionString = "Data Source=DESKTOP-0NAO5B2\\SQLEXPRESS;Initial Catalog=PersonelDb;Integrated Security=True;";
		//
		int personelId = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			birimLoad();
			personelLoad();			
		}

		//void BirimGetir()
		//{
		//	IDataBase db = new IDataBase();
		//	DataTable veriler = db.BirimGetir();
		//	foreach (DataRow row in veriler.Rows)
		//	{
		//		cbbBirim.Items.Add(row["birim"].ToString());
		//	}
		//}

		void birimLoad()
		{
			try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("select * from birimler", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cbbBirim.Items.Add(row["birim"].ToString());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

		}

		void personelLoad()
		{
			try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("select * from personeller", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
                dg.Columns["id"].Visible = false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
		}

		void personelEkle()
		{
			try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("insert into personeller (sicil, ad, soyad, cinsiyet, dogumTarihi, birim, tel, adres) values (@sicil, @ad, @soyad, @cinsiyet, @dogumTarihi, @birim, @tel, @adres)", con);
                con.Open();
                cmd.Parameters.Add("@sicil", SqlDbType.Int).Value = txtSicil.Text;
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = txtAd.Text;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = txtSoyad.Text;
                 string cinsiyetDegeri = "";
                if (radiobtnErkek.Checked)
                {
                    cinsiyetDegeri = radiobtnErkek.Text;
                }
                else if (radiobtnKadın.Checked)
                {
                    cinsiyetDegeri = radiobtnKadın.Text;
                }
                cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = cinsiyetDegeri;
                cmd.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = maskedDogumTarihi.Text;
                cmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = cbbBirim.Text;
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = maskedTel.Text;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

			personelLoad();
		}

		void personelGuncelle()
		{
			try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("update personeller set sicil = @sicil, ad = @ad, soyad = @soyad, cinsiyet = @cinsiyet, dogumTarihi = @dogumTarihi, birim = @birim, cepTel = @cepTel, adres = @adres where id = @id", con);
                con.Open();

                cmd.Parameters.Add("@sicil", SqlDbType.Int).Value = txtSicil.Text;
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = txtAd.Text;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = txtSoyad.Text;
                string cinsiyetDegeri = "";
                if (radiobtnErkek.Checked)
                {
                    cinsiyetDegeri = radiobtnErkek.Text;
                }
                else if (radiobtnKadın.Checked)
                {
                    cinsiyetDegeri = radiobtnKadın.Text;
                }
                cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = cinsiyetDegeri;
                cmd.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = maskedDogumTarihi.Text;
                cmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = cbbBirim.Text;
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = maskedTel.Text;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = personelId;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }


			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@sicil", SqlDbType.Int) { Value = txtSicil.Text });
			parameters.Add(new SqlParameter("@ad", SqlDbType.VarChar) { Value = txtAd.Text });
			parameters.Add(new SqlParameter("@soyad", SqlDbType.VarChar) { Value = txtSoyad.Text });
			string cinsiyet = "";
			if (radiobtnErkek.Checked)
			{
				cinsiyet = radiobtnErkek.Text;
			}
			else if (radiobtnKadın.Checked)
			{
				cinsiyet = radiobtnKadın.Text;
			}
			parameters.Add(new SqlParameter("@cinsiyet", SqlDbType.VarChar) { Value = cinsiyet });
			parameters.Add(new SqlParameter("@dogumTarihi", SqlDbType.Date) { Value = maskedDogumTarihi.Text });
			parameters.Add(new SqlParameter("@birim", SqlDbType.VarChar) { Value = cbbBirim.Text });
			parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar) { Value = maskedTel.Text });
			parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });
			parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = personelId });
			IDataBase.executeNonQuery("update personeller set sicil = @sicil, ad = @ad, soyad = @soyad, cinsiyet = @cinsiyet, dogumTarihi = @dogumTarihi, birim = @birim, cepTel = @cepTel, adres = @adres where id = @id", parameters);


			personelLoad();
		}

		void temizle()
		{
			personelId = 0;

			foreach (var item in tableLayoutPanel1.Controls)
			{
				if (item is TextBox)
				{
					((TextBox)item).Text = "";
				}

				if (item is MaskedTextBox)
				{
					((MaskedTextBox)item).Text = "";
				}

				if (item is ComboBox)
				{
					((ComboBox)item).Text = "";
				}
			}

			foreach (var item in tableLayoutPanel2.Controls)
			{
				if (item is RadioButton)
				{
					((RadioButton)item).Checked = false;
				}
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (personelId == 0)
			{
				personelEkle();
			}
			else
			{
				MessageBox.Show("Seçili Personel Var");
			}
		}

		private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				personelId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);

				try
                {
                    con = new SqlConnection(connectionString);
                    cmd = new SqlCommand("select * from personeller where id = @id", con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = personelId;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    radiobtnErkek.Checked = false;
					radiobtnKadın.Checked = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        txtSicil.Text = row["sicil"].ToString();
                        txtAd.Text = row["ad"].ToString();
                        txtSoyad.Text = row["soyad"].ToString();
                        string cinsiyet = row["cinsiyet"].ToString();
                        if (cinsiyet == radiobtnErkek.Text)
                        {
                            radiobtnErkek.Checked = true;
                        }
                        else if (cinsiyet == radiobtnKadın.Text)
                        {
							radiobtnKadın.Checked = true;
                        }

                        maskedDogumTarihi.Text = string.Format("{0:dd/MM/yyyy}", row["dogumTarihi"]);
                        cbbBirim.Text = row["birim"].ToString();
                        maskedTel.Text = row["tel"].ToString();
                        txtAdres.Text = row["adres"].ToString();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

				radiobtnErkek.Checked = false;
				radiobtnKadın.Checked = false;
				foreach (DataRow row in IDataBase.DataToDataTable("select * from personeller where id = @id",
					new SqlParameter("@id", SqlDbType.Int) { Value = personelId }).Rows)
				{
					txtSicil.Text = row["sicil"].ToString();
					txtAd.Text = row["ad"].ToString();
					txtSoyad.Text = row["soyad"].ToString();
					string cinsiyet = row["cinsiyet"].ToString();
					if (cinsiyet == radiobtnErkek.Text)
					{
						radiobtnErkek.Checked = true;
					}
					else if (cinsiyet == radiobtnKadın.Text)
					{
						radiobtnKadın.Checked = true;
					}

					maskedDogumTarihi.Text = string.Format("{0:dd/MM/yyyy}", row["dogumTarihi"]);
					cbbBirim.Text = row["birim"].ToString();
					maskedTel.Text = row["tel"].ToString();
					txtAdres.Text = row["adres"].ToString();
				}

			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (personelId > 0)
			{
				personelGuncelle();
			}
			else
			{
				MessageBox.Show("Personel Seçiniz");
			}
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void dg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
