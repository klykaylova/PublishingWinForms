using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingWinForms
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
            LoadData();
            ConfigureDataGridHeaders();
        }

        private static readonly string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\PublisherDataBase.mdf")};Integrated Security=True";

        // Завантаження всіх даних
        private void LoadData()
        {
            LoadBooks();
            LoadMagazinesWithAds();
            LoadPrintingHouse();
        }

        // Налаштування назв колонок DataGridView українською мовою
        private void ConfigureDataGridHeaders()
        {
            dgv_Books.Columns["BookID"].HeaderText = "ID Книги";
            dgv_Books.Columns["Title"].HeaderText = "Назва";
            dgv_Books.Columns["Author"].HeaderText = "Автор";
            dgv_Books.Columns["Genre"].HeaderText = "Жанр";
            dgv_Books.Columns["PrintRun"].HeaderText = "Наклад";
            dgv_Books.Columns["PublishedYear"].HeaderText = "Рік публікації";

            dgv_Magazines.Columns["MagazineID"].HeaderText = "ID Журналу";
            dgv_Magazines.Columns["Назва"].HeaderText = "Назва";
            dgv_Magazines.Columns["Номер випуску"].HeaderText = "Номер випуску";
            dgv_Magazines.Columns["Наклад"].HeaderText = "Наклад";
            dgv_Magazines.Columns["Дата публікації"].HeaderText = "Дата публікації";
            dgv_Magazines.Columns["Тип реклами"].HeaderText = "Тип реклами";
            dgv_Magazines.Columns["Вартість реклами"].HeaderText = "Вартість реклами";

            dgv_PrintingHouse.Columns["PrintingID"].HeaderText = "ID Продукції";
            dgv_PrintingHouse.Columns["ProductType"].HeaderText = "Тип продукції";
            dgv_PrintingHouse.Columns["Title"].HeaderText = "Назва";
            dgv_PrintingHouse.Columns["PrintRun"].HeaderText = "Наклад";
            dgv_PrintingHouse.Columns["ProductionDate"].HeaderText = "Дата виготовлення";
        }

        // Завантаження таблиці Books
        private void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);
                dgv_Books.DataSource = booksTable;
            }
        }

        // Завантаження таблиці Magazines з інтеграцією реклами
        private void LoadMagazinesWithAds()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        m.MagazineID, 
                        m.Title AS Назва, 
                        m.IssueNumber AS [Номер випуску], 
                        m.PrintRun AS Наклад, 
                        m.PublishedDate AS [Дата публікації],
                        ISNULL(a.AdType, N'Без реклами') AS [Тип реклами],
                        ISNULL(a.Price, 0) AS [Вартість реклами]
                    FROM Magazines m
                    LEFT JOIN AdPlacements a ON m.MagazineID = a.MagazineID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable magazinesTable = new DataTable();
                adapter.Fill(magazinesTable);
                dgv_Magazines.DataSource = magazinesTable;
            }
        }

        // Завантаження таблиці PrintingHouse
        private void LoadPrintingHouse()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PrintingHouse";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable printingHouseTable = new DataTable();
                adapter.Fill(printingHouseTable);
                dgv_PrintingHouse.DataSource = printingHouseTable;
            }
        }

        // Обробники кнопок пошуку
        private void searchBooks_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT * 
                    FROM Books 
                    WHERE Title LIKE @Search OR Author LIKE @Search OR Genre LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{inputBooks.Text.Trim()}%");
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);
                dgv_Books.DataSource = booksTable;
            }
        }

        private void searchMagazines_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        m.MagazineID, 
                        m.Title AS Назва, 
                        m.IssueNumber AS [Номер випуску], 
                        m.PrintRun AS Наклад, 
                        m.PublishedDate AS [Дата публікації],
                        ISNULL(a.AdType, N'Без реклами') AS [Тип реклами],
                        ISNULL(a.Price, 0) AS [Вартість реклами]
                    FROM Magazines m
                    LEFT JOIN AdPlacements a ON m.MagazineID = a.MagazineID
                    WHERE m.Title LIKE @Search";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{inputMagazines.Text.Trim()}%");
                DataTable magazinesTable = new DataTable();
                adapter.Fill(magazinesTable);
                dgv_Magazines.DataSource = magazinesTable;
            }
        }

        private void searchPrintingHouse_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT * 
                    FROM PrintingHouse 
                    WHERE ProductType LIKE @Search OR Title LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{inputPrintingHouse.Text.Trim()}%");
                DataTable printingHouseTable = new DataTable();
                adapter.Fill(printingHouseTable);
                dgv_PrintingHouse.DataSource = printingHouseTable;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
