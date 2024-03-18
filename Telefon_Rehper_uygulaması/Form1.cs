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

namespace Telefon_Rehper_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Rehper;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KISILER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void temizle()
        {
            txt_AD.Text = "";
            txt_SOYAD.Text = "";
            msk_TEL.Text = "";
            txt_ID.Text = "";
            txt_MAİL.Text = "";
            txt_AD.Focus();
        }
        void ekle()
        {
            if (string.IsNullOrWhiteSpace(txt_AD.Text) || string.IsNullOrWhiteSpace(txt_SOYAD.Text) || string.IsNullOrWhiteSpace(msk_TEL.Text) || string.IsNullOrWhiteSpace(txt_MAİL.Text))
            {//string.null veya boşluk varsa ifadeler true oluyor
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO KISILER (AD,SOYAD,TELEFON,MAIL) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_AD.Text);
                komut.Parameters.AddWithValue("@p2", txt_SOYAD.Text);
                komut.Parameters.AddWithValue("@p3", msk_TEL.Text);
                komut.Parameters.AddWithValue("@p4", txt_MAİL.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rehperinize Eklendi" + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void guncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" UPDATE KISILER SET AD = @p1, SOYAD = @p2, TELEFON = @p3, MAIL = @p4 WHERE ID = @p5", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_AD.Text);
                komut.Parameters.AddWithValue("@p2", txt_SOYAD.Text);
                komut.Parameters.AddWithValue("@p3", msk_TEL.Text);
                komut.Parameters.AddWithValue("@p4", txt_MAİL.Text);
                komut.Parameters.AddWithValue("@p5", txt_ID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rehperinizden Silinmiştir " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void sil()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("  DELETE FROM  KISILER where ID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_ID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rehperinizden Silinmiştir " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_AD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_SOYAD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            msk_TEL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_MAİL.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_TEMİZLE_Click(object sender, EventArgs e)
        {
            temizle();

        }
        private void btn_EKLE_Click(object sender, EventArgs e)
        {
            ekle();
        }
        private void btn_GÜNCELLE_Click(object sender, EventArgs e)
        {
            guncelle(); 
        }
        private void btn_SİL_Click(object sender, EventArgs e)
        {
            sil();
        }

       

      
    }
}
