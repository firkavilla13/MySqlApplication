using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlApllciation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszoTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;

            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();
                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue(@"nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab!=0)
                {
                    MessageBox.Show("A user mar letezik");
                    return;
                }

                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhasznalo (nev, jelszo, regdatum) VALUES (@nev, @jelszo, @regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum",regdatum);
                int erintettSorok = command.ExecuteNonQuery();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();                
                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM felhasznalo WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev", nev);                         
                int erintettSorok = command.ExecuteNonQuery();
                if (command.ExecuteNonQuery()==0)
                {
                    MessageBox.Show("Felhasználó törölve!");
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");

                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;

            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "UPDATE  felhasznalo SET regdatum = @regdatum WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Felhasználó szüledési dátum módósítva!");
                }
                else
                {
                    MessageBox.Show("Sikertelen módosítás!");

                }
            }
        }
    }
    
}
