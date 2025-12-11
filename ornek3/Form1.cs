using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-74SKFQ4C\\SQLEXPRESS;Initial Catalog=ajanda;Integrated Security=True;");

        void temizle()
        {
            textBoxgorev.Text = "";
            maskedTextBoxsaat.Text = "";
            comboBoxGun.Text = "";
        }
        DataGridViewCell seciliHucre;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ajandaDataSet.ajanda_table' table. You can move, or remove it, as needed.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string gun = comboBoxGun.SelectedItem.ToString();
            string gorev = textBoxgorev.Text;
            string saat = maskedTextBoxsaat.Text;

            //saat var mı??
            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM ajanda_table WHERE [saat/gün] = @saat", baglanti);
            kontrol.Parameters.AddWithValue("@saat", saat);

            int varMi = (int)kontrol.ExecuteScalar();

            if (varMi > 0)
            {
                string sql = $"UPDATE ajanda_table SET [{gun}] = @gorev WHERE [saat/gün] = @saat";
                SqlCommand guncelle = new SqlCommand(sql, baglanti);
                guncelle.Parameters.AddWithValue("@gorev", gorev);
                guncelle.Parameters.AddWithValue("@saat", saat);
                guncelle.ExecuteNonQuery();
            }
            else
            {
                string sql = $"INSERT INTO ajanda_table ([saat/gün], [{gun}]) VALUES (@saat, @gorev)";
                SqlCommand ekle = new SqlCommand(sql, baglanti);
                ekle.Parameters.AddWithValue("@saat", saat);
                ekle.Parameters.AddWithValue("@gorev", gorev);
                ekle.ExecuteNonQuery();
            }

            MessageBox.Show("eklendi!");
            baglanti.Close();
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            this.ajanda_tableTableAdapter.Fill(this.ajandaDataSet.ajanda_table);
            //saatleri sıralamalı yazdırır.
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ajanda_table ORDER BY [saat/gün]", baglanti);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int satir = e.RowIndex;
            int sutun = e.ColumnIndex;

            seciliHucre = dataGridView1.Rows[satir].Cells[sutun];

            maskedTextBoxsaat.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBoxgorev.Text = dataGridView1.Rows[satir].Cells[sutun].Value.ToString();
            comboBoxGun.Text = dataGridView1.Columns[sutun].HeaderText;
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string gun = comboBoxGun.Text.Trim();
            string gorev = textBoxgorev.Text;
            string saat = maskedTextBoxsaat.Text;

            if (!string.IsNullOrEmpty(gun))
            {
                SqlCommand komutsil = new SqlCommand($"UPDATE ajanda_table SET [{gun}] = NULL WHERE [saat/gün] = @saat AND [{gun}] = @gorev", baglanti);
                komutsil.Parameters.AddWithValue("@saat", saat);
                komutsil.Parameters.AddWithValue("@gorev", gorev);
                komutsil.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("delete from ajanda_table where [saat/gün] =@saat", baglanti);
                komut.Parameters.AddWithValue("@saat", saat);
                komut.ExecuteNonQuery();

            }
            // Silme işleminden sonra boş satırları kontrol et
            SqlCommand temizleKomut = new SqlCommand("DELETE FROM ajanda_table WHERE " +
                "[pazartesi] IS NULL AND [salı] IS NULL AND [çarşamba] IS NULL AND " +
                "[perşembe] IS NULL AND [cuma] IS NULL AND [cumartesi] IS NULL AND [pazar] IS NULL", baglanti);
            temizleKomut.ExecuteNonQuery();


            MessageBox.Show("silindi!");
            baglanti.Close();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string gun = comboBoxGun.Text.Trim();
            string yeniGorev = textBoxgorev.Text;   // kullanıcı değiştirdiyse yeni görev burada
            string saat = maskedTextBoxsaat.Text;

            SqlCommand komutGuncelle = new SqlCommand(
                $"UPDATE ajanda_table SET [{gun}] = @yeniGorev WHERE [saat/gün] = @saat",
                baglanti);

            komutGuncelle.Parameters.AddWithValue("@saat", saat);
            komutGuncelle.Parameters.AddWithValue("@yeniGorev", yeniGorev);

            komutGuncelle.ExecuteNonQuery();

            MessageBox.Show("Görev güncellendi");
            baglanti.Close();
        }

        private void radioOnemli_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOnemli.Checked && seciliHucre != null)
            {
                seciliHucre.Style.BackColor = Color.Red;
                seciliHucre.Style.ForeColor = Color.White;
            }

        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioTamam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTamam.Checked && seciliHucre != null)
            {
                seciliHucre.Style.BackColor = Color.LightGreen;
                seciliHucre.Style.ForeColor = Color.Black;
            }
        }
    }
}

