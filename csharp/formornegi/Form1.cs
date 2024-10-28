using System;
using System.Data;
using System.Data.SqlClient;
namespace kitapsqlornegi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=kitap; Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
            verilerigetir();
        }

        private void ulkeekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into telefonkodlari values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", ulketextbox.Text);
            komut.Parameters.AddWithValue("@p2", telkodtextbox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Baþarýlý", "Bilgilendirme");
            verilerigetir();
        }

        public void verilerigetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from telefonkodlari", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
