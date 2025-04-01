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
        public static string? DatabasePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Database", "BookmarkProject.accdb");
        public static string? ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};";

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

                        object? result = cmd.ExecuteScalar();

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
                    int? count = (int)cmd.ExecuteScalar();
                    exists = count > 0;
                }
            }
            return exists;
        }
        public DataTable GetBookmarks()
        {
            DataTable dt = new DataTable();

            try
            {
                myConn = new OleDbConnection(ConnectionString);
                myConn.Open();

                string query = "SELECT bookmarkID ,Title, Genre, Volume, Edition, Chapter, PageNumber, Author, DateAdded FROM Bookmarks WHERE UserID = @userID";

                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userID", SessionManager.CurrentUserID);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn?.Close();
            }

            return dt;
        }
        public void addBookmark(string title, string genre, string volume, string edition, string chapter, string pageNum, string author)
        {
            using (OleDbConnection myConn = new OleDbConnection(ConnectionString))
            {
                try
                {
                    myConn.Open();
                    string query = "INSERT INTO Bookmarks (UserID, Title, Genre, Volume, Edition, Chapter, PageNumber, Author, DateAdded) " +
                                   "VALUES (@userID, @title, @genre, @volume, @edition, @chapter, @pageNumber, @author, @dateAdded)";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@userID", SessionManager.CurrentUserID);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@volume", volume);
                        cmd.Parameters.AddWithValue("@edition", edition);
                        cmd.Parameters.AddWithValue("@chapter", chapter);
                        cmd.Parameters.AddWithValue("@pageNumber", pageNum);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now.Date);

                        int result = cmd.ExecuteNonQuery();

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
        public void DeleteBookmark(int bookmarkID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(ConnectionString))
                {
                    myConn.Open();
                    string query = "DELETE FROM Bookmarks WHERE BookmarkID = @bookmarkID";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@bookmarkID", bookmarkID);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Bookmark deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete bookmark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateBookmark(int bookmarkID, string title, string genre, string volume, string edition, string chapter, string pageNum, string author)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(ConnectionString))
                {
                    myConn.Open();

                    string query = "UPDATE Bookmarks SET Title = ?, Genre = ?, Volume = ?, Edition = ?, Chapter = ?, PageNumber = ?, Author = ? WHERE BookmarkID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@volume", volume);
                        cmd.Parameters.AddWithValue("@edition", edition);
                        cmd.Parameters.AddWithValue("@chapter", chapter);
                        cmd.Parameters.AddWithValue("@pageNumber", pageNum);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@bookmarkID", bookmarkID);

                        int result = cmd.ExecuteNonQuery();
                        if(result>0)
                            {
                                MessageBox.Show("Bookmark updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        else
                            {
                                MessageBox.Show("Failed to update bookmark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Dictionary<string, int> GetGenreDistribution()
        {
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();

            string query = "SELECT Genre, COUNT(*) AS Count FROM Bookmarks WHERE UserID = ? GROUP BY Genre";

            using (OleDbConnection myConn = new OleDbConnection(ConnectionString))
            {
                myConn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUserID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string genre = reader["Genre"].ToString();
                            int count = Convert.ToInt32(reader["Count"]);
                            genreCounts[genre] = count;
                        }
                    }
                }
            }

            return genreCounts;
        }
    }
}