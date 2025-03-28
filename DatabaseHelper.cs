using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace NoteWorthy
{
   public class Security
{
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            // Convert hashed bytes to a readable string format
            StringBuilder builder = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                builder.Append(b.ToString("x2")); // Convert to hexadecimal
            }
            return builder.ToString();
            }
        }
    }
    public class DatabaseHelper
    {
        
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public static string DatabasePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Database", "BookmarkProject.accdb");
        public static string ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};";

        public void testCon()
        {
            myConn = new OleDbConnection(ConnectionString);
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        public void register(string username, string password) 
        {
            string hashedPassword = Security.HashPassword(password);
            {
                using (myConn = new OleDbConnection(ConnectionString))
                {
                    try
                    {
                        myConn.Open();                      
                        string query = "INSERT INTO Users (Username, [Password], DateAdded) VALUES (?, ?, ?)";

                        using (cmd = new OleDbCommand(query, myConn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@passwordHash", hashedPassword);
                            cmd.Parameters.Add("@dateCreated", OleDbType.Date).Value = DateTime.Now.Date;

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to register. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public int? LogIN(string username, string password)
        {
            string hashPassword = Security.HashPassword(password);

            using (myConn = new OleDbConnection(ConnectionString))
            {
                try
                {
                    myConn.Open();

                    string query = "SELECT UserID FROM Users WHERE LCASE(Username) = LCASE(@username) AND [Password] = @hashPassword";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashPassword", hashPassword);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);  
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool UsernameExists(string username)
        {
            bool exists = false;
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    int count = (int)cmd.ExecuteScalar(); 
                    exists = count > 0; 
                }
            }
            return exists;
        }

    }
}
