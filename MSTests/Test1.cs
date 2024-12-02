using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.SqlClient;

namespace PublishingWinForms.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        private readonly string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\..\PublisherDataBase.mdf")};Integrated Security=True";

        [TestMethod]
        public void LoadTable_Books_ReturnsData()
        {
            // Arrange
            string query = "SELECT * FROM Books";
            DataTable result = new DataTable();

            // Act
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(result);
            }

            // Assert
            Assert.IsTrue(result.Rows.Count > 0, "Books table should not be empty.");
        }

        [TestMethod]
        public void InsertBook_ValidData_InsertsSuccessfully()
        {
            // Arrange
            string insertQuery = "INSERT INTO Books (Title, Author, Genre, PrintRun, PublishedYear) VALUES (@Title, @Author, @Genre, @PrintRun, @Year)";
            string selectQuery = "SELECT COUNT(*) FROM Books WHERE Title = @Title";
            int initialCount, finalCount;

            // Act
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Count initial rows with specific title
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Title", "Test Book");
                    initialCount = (int)selectCommand.ExecuteScalar();
                }

                // Insert new book
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Title", "Test Book");
                    insertCommand.Parameters.AddWithValue("@Author", "Test Author");
                    insertCommand.Parameters.AddWithValue("@Genre", "Test Genre");
                    insertCommand.Parameters.AddWithValue("@PrintRun", 1000);
                    insertCommand.Parameters.AddWithValue("@Year", 2024);
                    insertCommand.ExecuteNonQuery();
                }

                // Count rows again
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Title", "Test Book");
                    finalCount = (int)selectCommand.ExecuteScalar();
                }
            }

            // Assert
            Assert.AreEqual(initialCount + 1, finalCount, "Row count should increase by one.");
        }

        [TestMethod]
        public void DeleteBook_ValidId_DeletesSuccessfully()
        {
            // Arrange
            string deleteQuery = "DELETE FROM Books WHERE Title = @Title";
            string insertQuery = "INSERT INTO Books (Title, Author, Genre, PrintRun, PublishedYear) VALUES (@Title, @Author, @Genre, @PrintRun, @Year)";
            string selectQuery = "SELECT COUNT(*) FROM Books WHERE Title = @Title";
            int initialCount, finalCount;

            // Act
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert new book for deletion
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Title", "Delete Test Book");
                    insertCommand.Parameters.AddWithValue("@Author", "Test Author");
                    insertCommand.Parameters.AddWithValue("@Genre", "Test Genre");
                    insertCommand.Parameters.AddWithValue("@PrintRun", 1000);
                    insertCommand.Parameters.AddWithValue("@Year", 2024);
                    insertCommand.ExecuteNonQuery();
                }

                // Count rows with specific title
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Title", "Delete Test Book");
                    initialCount = (int)selectCommand.ExecuteScalar();
                }

                // Delete the book
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Title", "Delete Test Book");
                    deleteCommand.ExecuteNonQuery();
                }

                // Count rows again
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Title", "Delete Test Book");
                    finalCount = (int)selectCommand.ExecuteScalar();
                }
            }

            // Assert
            Assert.AreEqual(initialCount - 1, finalCount, "Row count should decrease by one.");
        }
    }
}
