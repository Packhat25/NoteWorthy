using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace NoteWorthy
{    
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
            string hashedPassword = Utilities.HashPassword(password);
            {
                using (myConn = new OleDbConnection(ConnectionString))
                {
                    try
                    {
                        myConn.Open();
                        string query = "INSERT INTO Users (Username, [Password], DateCreated) VALUES (?, ?, ?)";

                        using (cmd = new OleDbCommand(query, myConn))
                        {
                            cmd.Parameters.AddWithValue("?", username);
                            cmd.Parameters.AddWithValue("?", hashedPassword);
                            cmd.Parameters.AddWithValue("?", DateTime.Now.Date);

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
            string hashPassword = Utilities.HashPassword(password);

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
        public void addBookmark(string title, string genre, string volume, string edition, string chapter, string pageNum, string author)
        {
            using (OleDbConnection myConn = new OleDbConnection(ConnectionString))
            {
                try
                {
                    myConn.Open();
                    string query = "INSERT INTO Bookmarks (UserID, Title, Genre, Volume, Edition, Chapter, PageNumber, DateAdded) " +
                                   "VALUES (@userID, @title, @genre, @volume, @edition, @chapter, @pageNumber, @dateAdded)";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@userID", SessionManager.CurrentUserID);  // Match UserID
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@genre", genre);    // Added Genre
                        cmd.Parameters.AddWithValue("@volume", volume);
                        cmd.Parameters.AddWithValue("@edition", edition);
                        cmd.Parameters.AddWithValue("@chapter", chapter);
                        cmd.Parameters.AddWithValue("@pageNumber", pageNum);
                        cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now.Date); // Corrected DateAdded

                        int result = cmd.ExecuteNonQuery(); // Store result

                        if (result > 0)
                        {
                            MessageBox.Show("Bookmark added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add bookmark. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}