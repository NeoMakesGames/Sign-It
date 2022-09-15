using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Sign_It_App
{
    public class DatabaseFunctions
    {
        public static int currentUser;

        public static string getString(int id, string objID, string path)
        {
            //Establece una coneccion a la base de datos
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            //Crea un comando que colecciona toda la informacion de un usuario especificado por id
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios WHERE id = " + id, con);
            //Crea una variable que lee los datos
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Obtiene el resultado deseado en objID del usuario seleccionado
            string result = reader[objID].ToString();
            //Cierra la coneccion a la base de datos
            con.Close();
            //Devuelve como string el resultado que se buscaba
            return result;
        }

        public static bool checkIfNameExists(string name, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios WHERE Nombre = '" + name + "'", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public static bool checkIfThereAreUsers(string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public static int getIDFromName(string name, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios WHERE Nombre = '" + name + "'", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = Convert.ToInt32(reader["ID"]);
            con.Close();
            return result;
        }

        public static void addUser(string name, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Usuarios (Nombre, XP) VALUES ('" + name + "', " + 0 + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("¡Usuario agregado! (Agregaste a " + name + ")");
        }

        public static void updateListBox(ListBox listBox, string path)
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

        public static void addXP(int id, int amount, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Usuarios SET XP = XP + " + amount + " WHERE id = " + id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("¡XP agregada! (Se sumó " + amount + ")");
        }

        public static int checkXP(int id, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\" + Environment.UserName + "\\Documents\\SignIt.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT XP FROM Usuarios WHERE id = " + id, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = Convert.ToInt32(reader["XP"]);
            con.Close();
            return result;
        }

        public static void deleteUser(int id, string path)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Usuarios WHERE id = " + id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("¡Usuario " + id + " eliminado!");
            //updateListBox(lb, path);
        }


    }
}