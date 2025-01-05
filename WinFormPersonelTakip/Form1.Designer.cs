namespace WinFormPersonelTakip
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.radiobtnErkek = new System.Windows.Forms.RadioButton();
			this.radiobtnKadın = new System.Windows.Forms.RadioButton();
			this.txtSicil = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.maskedDogumTarihi = new System.Windows.Forms.MaskedTextBox();
			this.maskedTel = new System.Windows.Forms.MaskedTextBox();
			this.cbbBirim = new System.Windows.Forms.ComboBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.dg = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 471);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Bilgileri";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.btnGuncelle, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnTemizle, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnEkle, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 410);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 40);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGuncelle.Location = new System.Drawing.Point(96, 3);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(87, 34);
			this.btnGuncelle.TabIndex = 1;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			// 
			// btnTemizle
			// 
			this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTemizle.Location = new System.Drawing.Point(189, 3);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(87, 34);
			this.btnTemizle.TabIndex = 2;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = true;
			// 
			// btnEkle
			// 
			this.btnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEkle.Location = new System.Drawing.Point(3, 3);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(87, 34);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtSicil, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtSoyad, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.maskedDogumTarihi, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.maskedTel, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.cbbBirim, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtAdres, 1, 7);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 36);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 368);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sicil:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Soyad:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Cinsiyet:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "DoğumTarihi:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Birim:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 263);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefon:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 307);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "Adres:";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.62385F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.37615F));
			this.tableLayoutPanel2.Controls.Add(this.radiobtnErkek, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.radiobtnKadın, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 134);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 38);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// radiobtnErkek
			// 
			this.radiobtnErkek.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radiobtnErkek.AutoSize = true;
			this.radiobtnErkek.Location = new System.Drawing.Point(3, 9);
			this.radiobtnErkek.Name = "radiobtnErkek";
			this.radiobtnErkek.Size = new System.Drawing.Size(59, 20);
			this.radiobtnErkek.TabIndex = 0;
			this.radiobtnErkek.TabStop = true;
			this.radiobtnErkek.Text = "Erkek";
			this.radiobtnErkek.UseVisualStyleBackColor = true;
			// 
			// radiobtnKadın
			// 
			this.radiobtnKadın.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radiobtnKadın.AutoSize = true;
			this.radiobtnKadın.Location = new System.Drawing.Point(68, 9);
			this.radiobtnKadın.Name = "radiobtnKadın";
			this.radiobtnKadın.Size = new System.Drawing.Size(62, 20);
			this.radiobtnKadın.TabIndex = 1;
			this.radiobtnKadın.TabStop = true;
			this.radiobtnKadın.Text = "Kadın";
			this.radiobtnKadın.UseVisualStyleBackColor = true;
			// 
			// txtSicil
			// 
			this.txtSicil.Location = new System.Drawing.Point(100, 3);
			this.txtSicil.Name = "txtSicil";
			this.txtSicil.Size = new System.Drawing.Size(134, 22);
			this.txtSicil.TabIndex = 10;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(100, 46);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(134, 22);
			this.txtAd.TabIndex = 11;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(100, 90);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(134, 22);
			this.txtSoyad.TabIndex = 12;
			// 
			// maskedDogumTarihi
			// 
			this.maskedDogumTarihi.Location = new System.Drawing.Point(100, 178);
			this.maskedDogumTarihi.Mask = "00/00/0000";
			this.maskedDogumTarihi.Name = "maskedDogumTarihi";
			this.maskedDogumTarihi.Size = new System.Drawing.Size(128, 22);
			this.maskedDogumTarihi.TabIndex = 13;
			this.maskedDogumTarihi.ValidatingType = typeof(System.DateTime);
			// 
			// maskedTel
			// 
			this.maskedTel.Location = new System.Drawing.Point(100, 266);
			this.maskedTel.Mask = "(999) 000-0000";
			this.maskedTel.Name = "maskedTel";
			this.maskedTel.Size = new System.Drawing.Size(131, 22);
			this.maskedTel.TabIndex = 14;
			// 
			// cbbBirim
			// 
			this.cbbBirim.FormattingEnabled = true;
			this.cbbBirim.Location = new System.Drawing.Point(100, 222);
			this.cbbBirim.Name = "cbbBirim";
			this.cbbBirim.Size = new System.Drawing.Size(128, 24);
			this.cbbBirim.TabIndex = 15;
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(100, 310);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(134, 55);
			this.txtAdres.TabIndex = 16;
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Location = new System.Drawing.Point(310, 21);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersVisible = false;
			this.dg.RowHeadersWidth = 51;
			this.dg.RowTemplate.Height = 24;
			this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dg.Size = new System.Drawing.Size(585, 526);
			this.dg.TabIndex = 1;
			this.dg.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentDoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(907, 559);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Personel Takip";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RadioButton radiobtnErkek;
		private System.Windows.Forms.RadioButton radiobtnKadın;
		private System.Windows.Forms.TextBox txtSicil;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.MaskedTextBox maskedDogumTarihi;
		private System.Windows.Forms.MaskedTextBox maskedTel;
		private System.Windows.Forms.ComboBox cbbBirim;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.DataGridView dg;
	}
}

