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

namespace TelephoneDirectory
{
    public partial class Main : Form
    {
        SqlConnection TelephoneDirectoryConnection = new SqlConnection();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string TelephoneDirectoryConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User2\ITMO\ADO.NET\TelephoneDirectory\TelephoneDirectory\DatabaseTelephoneDirectory.mdf;Integrated Security=True";

            TelephoneDirectoryConnection = new SqlConnection(TelephoneDirectoryConnectionString);
            {

                try

                {

                    if (TelephoneDirectoryConnection.State != ConnectionState.Open)

                    {

                        TelephoneDirectoryConnection.ConnectionString = TelephoneDirectoryConnectionString;

                        TelephoneDirectoryConnection.Open();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения с базой данных");
                }

                SqlDataReader TelephoneDirectoryReader = null;

                SqlCommand command = new SqlCommand("SELECT [Id],[TelephoneNumber],[Surname],[Name] FROM [Subscribers]", TelephoneDirectoryConnection);

                try
                {
                    TelephoneDirectoryReader = command.ExecuteReader();
                    while (TelephoneDirectoryReader.Read())
                    {
                        listBox1.Items.Add(Convert.ToString(TelephoneDirectoryReader["Id"]) + "---" + Convert.ToString(TelephoneDirectoryReader["TelephoneNumber"]) + "---" + Convert.ToString(TelephoneDirectoryReader["Surname"]) + "  " + Convert.ToString(TelephoneDirectoryReader["Name"]));
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (TelephoneDirectoryReader != null)
                        TelephoneDirectoryReader.Close();
                }
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelephoneDirectoryConnection != null && TelephoneDirectoryConnection.State != ConnectionState.Closed)
                TelephoneDirectoryConnection.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TelephoneDirectoryConnection != null && TelephoneDirectoryConnection.State != ConnectionState.Closed)
                TelephoneDirectoryConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Subscribers] (CityCode, City, TelephoneNumber, Surname, Name) VALUES (@CityCode, @City, @TelephoneNumber, @Surname, @Name)", TelephoneDirectoryConnection);
            command.Parameters.AddWithValue("CityCode", textBox1.Text);
            command.Parameters.AddWithValue("City", textBox3.Text);
            command.Parameters.AddWithValue("TelephoneNumber", textBox2.Text);
            command.Parameters.AddWithValue("Surname", textBox4.Text); 
            command.Parameters.AddWithValue("Name", textBox5.Text);
            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE [Subscribers] SET [CityCode]=@CityCode, [City]=@City, [TelephoneNumber]=@TelephoneNumber, [Surname]=@Surname, [Name]=@Name WHERE [Id]=@Id", TelephoneDirectoryConnection);
            command.Parameters.AddWithValue("Id", textBox13.Text);
            command.Parameters.AddWithValue("CityCode", textBox10.Text);
            command.Parameters.AddWithValue("City", textBox8.Text);
            command.Parameters.AddWithValue("TelephoneNumber", textBox9.Text);
            command.Parameters.AddWithValue("Surname", textBox7.Text);
            command.Parameters.AddWithValue("Name", textBox6.Text);
            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Subscribers]  WHERE [Id]=@Id", TelephoneDirectoryConnection);
            command.Parameters.AddWithValue("Id", textBox15.Text);
            command.ExecuteNonQuery();
        }

        SqlDataReader TelephoneDirectoryReader = null;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [Subscribers] WHERE [Surname]=@Surname AND [Name]=@Name", TelephoneDirectoryConnection);
                command.Parameters.AddWithValue("Surname", textBox12.Text);
                command.Parameters.AddWithValue("Name", textBox11.Text);
                TelephoneDirectoryReader = command.ExecuteReader();
                while (TelephoneDirectoryReader.Read())
                {
                    listBox2.Items.Add(Convert.ToString(TelephoneDirectoryReader["Id"]) + "---" + Convert.ToString(TelephoneDirectoryReader["CityCode"]) + "---" + Convert.ToString(TelephoneDirectoryReader["City"]) + "---" + Convert.ToString(TelephoneDirectoryReader["TelephoneNumber"]) + "---" + Convert.ToString(TelephoneDirectoryReader["Surname"]) + "  " + Convert.ToString(TelephoneDirectoryReader["Name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (TelephoneDirectoryReader != null)
                    TelephoneDirectoryReader.Close();
            }
        }
    }
}
