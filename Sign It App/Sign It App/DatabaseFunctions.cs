using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_It_App
{
    public class DatabaseFunctions
    {
        public string getString(int id, string objID, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios WHERE id = " + id, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string result = reader[objID].ToString();
            con.Close();
            return result;
        }

        public void addUser(string name, int xp, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Usuarios (Nombre, XP) VALUES ('" + name + "', " + xp + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("¡Usuario agregado! (" + xp + " " + name + ")");
        }

        public void updateListBox(ListBox listBox, string path)
        {
            listBox.Items.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox.Items.Add(reader["Id"].ToString() + " " + reader["Nombre"].ToString());
            }
            con.Close();
        }

        public void deleteUser(int id, ListBox lb, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Usuarios WHERE id = " + id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("¡Usuario " + id + " eliminado!");
            updateListBox(lb, path);
        }
    }
}
