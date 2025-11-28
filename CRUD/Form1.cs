using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-9OQQDC3\SQLEXPRESS;
                                            Database=db_smkn1jkt;
                                            Integrated Security=True;
                                            Encrypt=False";

        private void database()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tb_xirpl25";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tb_xirpl25 (id_nomorsiswa, nama, nis, kelas, nowhatsapp) VALUES (@id_nomorsiswa ,@nama, @nis, @kelas, @nowhatsapp)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_nomorsiswa", textBox1.Text);
                    command.Parameters.AddWithValue("@nama", textBox2.Text);
                    command.Parameters.AddWithValue("@nis", textBox3.Text);
                    command.Parameters.AddWithValue("@kelas", textBox4.Text);
                    command.Parameters.AddWithValue("@nowhatsapp", textBox5.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan.");
                        database();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM tb_xirpl25 WHERE id_nomorsiswa = @id_nomorsiswa";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_nomorsiswa", textBox1.Text);

                    try
                    {
                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.");
                            database();  
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Pilih data dulu dari tabel sebelum mengedit!");
                return;
            }

            if (MessageBox.Show("Yakin ingin mengubah data ini?",
                                "Konfirmasi Edit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE tb_xirpl25 SET nama = @nama, nis = @nis, kelas = @kelas, nowhatsapp = @nowhatsapp " +
                               "WHERE id_nomorsiswa = @id_nomorsiswa";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_nomorsiswa", textBox1.Text);
                    command.Parameters.AddWithValue("@nama", textBox2.Text);
                    command.Parameters.AddWithValue("@nis", textBox3.Text);
                    command.Parameters.AddWithValue("@kelas", textBox4.Text);
                    command.Parameters.AddWithValue("@nowhatsapp", textBox5.Text);

                    try
                    {
                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate.");
                            database(); 
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin mau keluar?",
                                                  "Konfirmasi",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
