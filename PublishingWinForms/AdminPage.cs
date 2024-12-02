using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PublishingWinForms
{
    public partial class AdminPage : Form
    {
        private static readonly string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\PublisherDataBase.mdf")};Integrated Security=True";
        private int selectedRowId = -1;
        private string currentTable = "Books";

        public AdminPage()
        {
            InitializeComponent();
            LoadAllData();
        }

        // Завантаження всіх таблиць
        private void LoadAllData()
        {
            LoadTable("Books", dgv);
            LoadTable("Magazines", mDgv);
            LoadTable("AdPlacements", aDgv);
            LoadTable("PrintingHouse", pDgv);
            LoadComboBoxMagazines();
        }

        // Завантаження даних у конкретну таблицю
        private void LoadTable(string tableName, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
        }

        // Завантаження назв журналів у ComboBox
        private void LoadComboBoxMagazines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MagazineID, Title FROM Magazines";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                aMagazineInput.DataSource = dataTable;
                aMagazineInput.DisplayMember = "Title";
                aMagazineInput.ValueMember = "MagazineID";
            }
        }

        // Обробка кліку на клітинку DataGridView
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = sender as DataGridView;
                if (dg == null) return;

                DataGridViewRow row = dg.Rows[e.RowIndex];
                selectedRowId = Convert.ToInt32(row.Cells[0].Value);

                if (dg == dgv)
                {
                    currentTable = "Books";
                    bTitleInput.Text = row.Cells["Title"].Value?.ToString();
                    bAuthorInput.Text = row.Cells["Author"].Value?.ToString();
                    bGenreInput.Text = row.Cells["Genre"].Value?.ToString();
                    bPrintRunInput.Text = row.Cells["PrintRun"].Value?.ToString();
                    bYearInput.Text = row.Cells["PublishedYear"].Value?.ToString();
                }
                else if (dg  == mDgv)
                {
                    currentTable = "Magazines";
                    mTitleInput.Text = row.Cells["Title"].Value?.ToString();
                    mIssueInput.Text = row.Cells["IssueNumber"].Value?.ToString();
                    mPrintRunInput.Text = row.Cells["PrintRun"].Value?.ToString();
                    mDateInput.Value = Convert.ToDateTime(row.Cells["PublishedDate"].Value);
                }
                else if (dg  == aDgv)
                {
                    currentTable = "AdPlacements";
                    aTypeInput.Text = row.Cells["AdType"].Value?.ToString();
                    aPriceInput.Text = row.Cells["Price"].Value?.ToString();
                    aMagazineInput.SelectedValue = row.Cells["MagazineID"].Value;
                }
                else if (dg  == pDgv)
                {
                    currentTable = "PrintingHouse";
                    pTypeInput.Text = row.Cells["ProductType"].Value?.ToString();
                    pTitleInput.Text = row.Cells["Title"].Value?.ToString();
                    pPrintRunInput.Text = row.Cells["PrintRun"].Value?.ToString();
                    pDateInput.Value = Convert.ToDateTime(row.Cells["ProductionDate"].Value);
                }
            }
        }

        // Обробник кнопки Save
        private void saveItem_Click(object sender, EventArgs e)
        {
            if (currentTable == "Books")
            {
                SaveBooks();
            }
            else if (currentTable == "Magazines")
            {
                SaveMagazines();
            }
            else if (currentTable == "AdPlacements")
            {
                SaveAdvertisements();
            }
            else if (currentTable == "PrintingHouse")
            {
                SavePrintingHouse();
            }

            LoadAllData(); // Перезавантаження даних
        }

        // Збереження книги
        private void SaveBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = selectedRowId == -1
                    ? "INSERT INTO Books (Title, Author, Genre, PrintRun, PublishedYear) VALUES (@Title, @Author, @Genre, @PrintRun, @Year)"
                    : "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, PrintRun = @PrintRun, PublishedYear = @Year WHERE BookID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", bTitleInput.Text);
                command.Parameters.AddWithValue("@Author", bAuthorInput.Text);
                command.Parameters.AddWithValue("@Genre", bGenreInput.Text);
                command.Parameters.AddWithValue("@PrintRun", bPrintRunInput.Text);
                command.Parameters.AddWithValue("@Year", bYearInput.Text);
                if (selectedRowId != -1)
                    command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно збережені!");
            }
        }

        private void SaveAdvertisements()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = selectedRowId == -1
                    ? "INSERT INTO AdPlacements (MagazineID, AdType, Price) VALUES (@MagazineID, @Type, @Price)"
                    : "UPDATE AdPlacements SET MagazineID = @MagazineID, AdType = @Type, Price = @Price WHERE AdID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MagazineID", aMagazineInput.SelectedValue);
                command.Parameters.AddWithValue("@Type", aTypeInput.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(aPriceInput.Text));
                if (selectedRowId != -1)
                    command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно збережені!");
            }
        }

        // Обробник події зміни вкладки
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllData();
            ClearTextboxes();
            switch (tabControl1.SelectedIndex)
            {
                case 0: 
                    currentTable = "Books";
                    break;
                case 1:
                    currentTable = "Magazines";
                    break;
                case 2:
                    currentTable = "AdPlacements";
                    break;
                case 3:
                    currentTable = "PrintingHouse";
                    break;
                default: break;
            }
        }

        // Очищення текстових полів
        private void ClearTextboxes()
        {
            bTitleInput.Clear();
            bAuthorInput.Clear();
            bGenreInput.Clear();
            bPrintRunInput.Clear();
            bYearInput.Clear();
            mTitleInput.Clear();
            mIssueInput.Clear();
            mPrintRunInput.Clear();
            aTypeInput.Clear();
            aPriceInput.Clear();
            pTypeInput.Clear();
            pTitleInput.Clear();
            pPrintRunInput.Clear();
            selectedRowId = -1;
        }

        private void SaveMagazines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = selectedRowId == -1
                    ? "INSERT INTO Magazines (Title, IssueNumber, PrintRun, PublishedDate) VALUES (@Title, @Issue, @PrintRun, @Date)"
                    : "UPDATE Magazines SET Title = @Title, IssueNumber = @Issue, PrintRun = @PrintRun, PublishedDate = @Date WHERE MagazineID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", mTitleInput.Text);
                command.Parameters.AddWithValue("@Issue", ValidateInteger(mIssueInput.Text, "Номер випуску"));
                command.Parameters.AddWithValue("@PrintRun", ValidateInteger(mPrintRunInput.Text, "Тираж"));
                command.Parameters.AddWithValue("@Date", mDateInput.Value);
                if (selectedRowId != -1)
                    command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно збережені!");
            }
        }

        private void SavePrintingHouse()
        {
            ValidateFields();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = selectedRowId == -1
                    ? "INSERT INTO PrintingHouse (ProductType, Title, PrintRun, ProductionDate) VALUES (@Type, @Title, @PrintRun, @Date)"
                    : "UPDATE PrintingHouse SET ProductType = @Type, Title = @Title, PrintRun = @PrintRun, ProductionDate = @Date WHERE PrintingID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", pTypeInput.Text);
                command.Parameters.AddWithValue("@Title", pTitleInput.Text);
                command.Parameters.AddWithValue("@PrintRun", ValidateInteger(pPrintRunInput.Text, "Тираж"));
                command.Parameters.AddWithValue("@Date", pDateInput.Value);
                if (selectedRowId != -1)
                    command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно збережені!");
            }
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (selectedRowId == -1)
            {
                MessageBox.Show("Виберіть рядок для видалення.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM {currentTable} WHERE {GetPrimaryKey()} = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", selectedRowId);
                command.ExecuteNonQuery();

                MessageBox.Show("Рядок успішно видалено!");
                LoadAllData();
                ClearTextboxes();
            }
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string searchValue = searchInput.Text;
                string searchColumn = currentTable == "AdPlacements" ? "AdType" : "Title";
                string query = $"SELECT * FROM {currentTable} WHERE " + searchColumn + " LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{searchValue}%");

                DataTable searchResults = new DataTable();
                adapter.Fill(searchResults);

                if (currentTable == "Books") dgv.DataSource = searchResults;
                if (currentTable == "Magazines") mDgv.DataSource = searchResults;
                if (currentTable == "AdPlacements") aDgv.DataSource = searchResults;
                if (currentTable == "PrintingHouse") pDgv.DataSource = searchResults;

                MessageBox.Show($"Знайдено {searchResults.Rows.Count} записів.");
            }
        }

        // Перевірка даних
        private int ValidateInteger(string input, string fieldName)
        {
            if (!int.TryParse(input, out int result))
            {
                throw new ArgumentException($"Поле '{fieldName}' має містити тільки ціле число.");
            }
            return result;
        }

        // Повертає назву первинного ключа для таблиці
        private string GetPrimaryKey()
        {
            switch (currentTable)
            {
                case "Books":
                    return "BookID";
                case "Magazines":
                    return "MagazineID";
                case "AdPlacements":
                    return "AdID";
                case "PrintingHouse":
                    return "PrintingID";
                default:
                    throw new InvalidOperationException("Невідома таблиця.");
            }
        }


        // Валідація текстових полів
        private bool ValidateFields()
        {
            try
            {
                if (currentTable == "Books")
                {
                    ValidateInteger(bPrintRunInput.Text, "Тираж");
                    ValidateInteger(bYearInput.Text, "Рік");
                }
                else if (currentTable == "Magazines")
                {
                    ValidateInteger(mIssueInput.Text, "Номер випуску");
                    ValidateInteger(mPrintRunInput.Text, "Тираж");
                }
                else if (currentTable == "AdPlacements")
                {
                    ValidateInteger(aPriceInput.Text, "Ціна");
                }
                else if (currentTable == "PrintingHouse")
                {
                    ValidateInteger(pPrintRunInput.Text, "Тираж");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void searchInput_MouseClick(object sender, MouseEventArgs e)
        {
            LoadAllData();
        }
    }
}
