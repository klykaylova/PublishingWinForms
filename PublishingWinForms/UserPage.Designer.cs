namespace PublishingWinForms
{
    partial class UserPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inputBooks = new System.Windows.Forms.TextBox();
            this.searchBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Magazines = new System.Windows.Forms.DataGridView();
            this.searchMagazines = new System.Windows.Forms.Button();
            this.inputMagazines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_PrintingHouse = new System.Windows.Forms.DataGridView();
            this.searchPrintingHouse = new System.Windows.Forms.Button();
            this.inputPrintingHouse = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magazines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrintingHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 605);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_Books);
            this.tabPage1.Controls.Add(this.searchBooks);
            this.tabPage1.Controls.Add(this.inputBooks);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книжки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgv_Magazines);
            this.tabPage2.Controls.Add(this.searchMagazines);
            this.tabPage2.Controls.Add(this.inputMagazines);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнали";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgv_PrintingHouse);
            this.tabPage3.Controls.Add(this.searchPrintingHouse);
            this.tabPage3.Controls.Add(this.inputPrintingHouse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(894, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Типографія";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // inputBooks
            // 
            this.inputBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBooks.Location = new System.Drawing.Point(113, 483);
            this.inputBooks.Name = "inputBooks";
            this.inputBooks.Size = new System.Drawing.Size(340, 45);
            this.inputBooks.TabIndex = 2;
            // 
            // searchBooks
            // 
            this.searchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBooks.Location = new System.Drawing.Point(524, 428);
            this.searchBooks.Name = "searchBooks";
            this.searchBooks.Size = new System.Drawing.Size(246, 100);
            this.searchBooks.TabIndex = 3;
            this.searchBooks.Text = "Пошук";
            this.searchBooks.UseVisualStyleBackColor = true;
            this.searchBooks.Click += new System.EventHandler(this.searchBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть назву книги:";
            // 
            // dgv_Books
            // 
            this.dgv_Books.AllowUserToAddRows = false;
            this.dgv_Books.AllowUserToDeleteRows = false;
            this.dgv_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Location = new System.Drawing.Point(6, 6);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.ReadOnly = true;
            this.dgv_Books.RowHeadersWidth = 51;
            this.dgv_Books.RowTemplate.Height = 24;
            this.dgv_Books.Size = new System.Drawing.Size(876, 387);
            this.dgv_Books.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введіть назву журналу:";
            // 
            // dgv_Magazines
            // 
            this.dgv_Magazines.AllowUserToAddRows = false;
            this.dgv_Magazines.AllowUserToDeleteRows = false;
            this.dgv_Magazines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Magazines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Magazines.Location = new System.Drawing.Point(9, 27);
            this.dgv_Magazines.Name = "dgv_Magazines";
            this.dgv_Magazines.ReadOnly = true;
            this.dgv_Magazines.RowHeadersWidth = 51;
            this.dgv_Magazines.RowTemplate.Height = 24;
            this.dgv_Magazines.Size = new System.Drawing.Size(876, 387);
            this.dgv_Magazines.TabIndex = 5;
            // 
            // searchMagazines
            // 
            this.searchMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchMagazines.Location = new System.Drawing.Point(527, 449);
            this.searchMagazines.Name = "searchMagazines";
            this.searchMagazines.Size = new System.Drawing.Size(246, 100);
            this.searchMagazines.TabIndex = 7;
            this.searchMagazines.Text = "Пошук";
            this.searchMagazines.UseVisualStyleBackColor = true;
            this.searchMagazines.Click += new System.EventHandler(this.searchMagazines_Click);
            // 
            // inputMagazines
            // 
            this.inputMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputMagazines.Location = new System.Drawing.Point(69, 504);
            this.inputMagazines.Name = "inputMagazines";
            this.inputMagazines.Size = new System.Drawing.Size(405, 45);
            this.inputMagazines.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введіть назву типографії:";
            // 
            // dgv_PrintingHouse
            // 
            this.dgv_PrintingHouse.AllowUserToAddRows = false;
            this.dgv_PrintingHouse.AllowUserToDeleteRows = false;
            this.dgv_PrintingHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_PrintingHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrintingHouse.Location = new System.Drawing.Point(9, 27);
            this.dgv_PrintingHouse.Name = "dgv_PrintingHouse";
            this.dgv_PrintingHouse.ReadOnly = true;
            this.dgv_PrintingHouse.RowHeadersWidth = 51;
            this.dgv_PrintingHouse.RowTemplate.Height = 24;
            this.dgv_PrintingHouse.Size = new System.Drawing.Size(876, 387);
            this.dgv_PrintingHouse.TabIndex = 5;
            // 
            // searchPrintingHouse
            // 
            this.searchPrintingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPrintingHouse.Location = new System.Drawing.Point(531, 449);
            this.searchPrintingHouse.Name = "searchPrintingHouse";
            this.searchPrintingHouse.Size = new System.Drawing.Size(246, 100);
            this.searchPrintingHouse.TabIndex = 7;
            this.searchPrintingHouse.Text = "Пошук";
            this.searchPrintingHouse.UseVisualStyleBackColor = true;
            this.searchPrintingHouse.Click += new System.EventHandler(this.searchPrintingHouse_Click);
            // 
            // inputPrintingHouse
            // 
            this.inputPrintingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPrintingHouse.Location = new System.Drawing.Point(38, 504);
            this.inputPrintingHouse.Name = "inputPrintingHouse";
            this.inputPrintingHouse.Size = new System.Drawing.Size(442, 45);
            this.inputPrintingHouse.TabIndex = 6;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 629);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magazines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrintingHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox inputBooks;
        private System.Windows.Forms.Button searchBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Magazines;
        private System.Windows.Forms.Button searchMagazines;
        private System.Windows.Forms.TextBox inputMagazines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_PrintingHouse;
        private System.Windows.Forms.Button searchPrintingHouse;
        private System.Windows.Forms.TextBox inputPrintingHouse;
    }
}

