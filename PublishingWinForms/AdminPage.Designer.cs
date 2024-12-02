namespace PublishingWinForms
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.bYearInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bPrintRunInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bGenreInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAuthorInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTitleInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mDateInput = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mPrintRunInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mIssueInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mTitleInput = new System.Windows.Forms.TextBox();
            this.mDgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.aMagazineInput = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.aPriceInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.aTypeInput = new System.Windows.Forms.TextBox();
            this.aDgv = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pDateInput = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pPrintRunInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pTitleInput = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pTypeInput = new System.Windows.Forms.TextBox();
            this.pDgv = new System.Windows.Forms.DataGridView();
            this.saveItem = new System.Windows.Forms.Button();
            this.searchItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDgv)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 541);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.bYearInput);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bPrintRunInput);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bGenreInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bAuthorInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bTitleInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книжки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(661, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Рік публікації";
            // 
            // bYearInput
            // 
            this.bYearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bYearInput.Location = new System.Drawing.Point(666, 370);
            this.bYearInput.Name = "bYearInput";
            this.bYearInput.Size = new System.Drawing.Size(214, 34);
            this.bYearInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Наклад";
            // 
            // bPrintRunInput
            // 
            this.bPrintRunInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPrintRunInput.Location = new System.Drawing.Point(369, 440);
            this.bPrintRunInput.Name = "bPrintRunInput";
            this.bPrintRunInput.Size = new System.Drawing.Size(214, 34);
            this.bPrintRunInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(364, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Жанр";
            // 
            // bGenreInput
            // 
            this.bGenreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGenreInput.Location = new System.Drawing.Point(369, 370);
            this.bGenreInput.Name = "bGenreInput";
            this.bGenreInput.Size = new System.Drawing.Size(214, 34);
            this.bGenreInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // bAuthorInput
            // 
            this.bAuthorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAuthorInput.Location = new System.Drawing.Point(29, 440);
            this.bAuthorInput.Name = "bAuthorInput";
            this.bAuthorInput.Size = new System.Drawing.Size(214, 34);
            this.bAuthorInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва";
            // 
            // bTitleInput
            // 
            this.bTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTitleInput.Location = new System.Drawing.Point(29, 370);
            this.bTitleInput.Name = "bTitleInput";
            this.bTitleInput.Size = new System.Drawing.Size(214, 34);
            this.bTitleInput.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mDateInput);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.mPrintRunInput);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.mIssueInput);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.mTitleInput);
            this.tabPage2.Controls.Add(this.mDgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнали";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mDateInput
            // 
            this.mDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mDateInput.Location = new System.Drawing.Point(364, 453);
            this.mDateInput.Name = "mDateInput";
            this.mDateInput.Size = new System.Drawing.Size(293, 34);
            this.mDateInput.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(359, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата публікації";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(359, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Наклад";
            // 
            // mPrintRunInput
            // 
            this.mPrintRunInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mPrintRunInput.Location = new System.Drawing.Point(364, 383);
            this.mPrintRunInput.Name = "mPrintRunInput";
            this.mPrintRunInput.Size = new System.Drawing.Size(293, 34);
            this.mPrintRunInput.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(19, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Номер випуску";
            // 
            // mIssueInput
            // 
            this.mIssueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mIssueInput.Location = new System.Drawing.Point(24, 453);
            this.mIssueInput.Name = "mIssueInput";
            this.mIssueInput.Size = new System.Drawing.Size(214, 34);
            this.mIssueInput.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(19, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Назва";
            // 
            // mTitleInput
            // 
            this.mTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTitleInput.Location = new System.Drawing.Point(24, 383);
            this.mTitleInput.Name = "mTitleInput";
            this.mTitleInput.Size = new System.Drawing.Size(214, 34);
            this.mTitleInput.TabIndex = 12;
            // 
            // mDgv
            // 
            this.mDgv.AllowUserToAddRows = false;
            this.mDgv.AllowUserToDeleteRows = false;
            this.mDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDgv.Location = new System.Drawing.Point(7, 16);
            this.mDgv.Name = "mDgv";
            this.mDgv.ReadOnly = true;
            this.mDgv.RowHeadersWidth = 51;
            this.mDgv.RowTemplate.Height = 24;
            this.mDgv.Size = new System.Drawing.Size(913, 301);
            this.mDgv.TabIndex = 11;
            this.mDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.aMagazineInput);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.aPriceInput);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.aTypeInput);
            this.tabPage3.Controls.Add(this.aDgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(926, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Реклама";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(318, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Для журналу";
            // 
            // aMagazineInput
            // 
            this.aMagazineInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aMagazineInput.FormattingEnabled = true;
            this.aMagazineInput.Location = new System.Drawing.Point(323, 380);
            this.aMagazineInput.Name = "aMagazineInput";
            this.aMagazineInput.Size = new System.Drawing.Size(382, 37);
            this.aMagazineInput.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(19, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 29);
            this.label14.TabIndex = 15;
            this.label14.Text = "Вартість";
            // 
            // aPriceInput
            // 
            this.aPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aPriceInput.Location = new System.Drawing.Point(24, 453);
            this.aPriceInput.Name = "aPriceInput";
            this.aPriceInput.Size = new System.Drawing.Size(214, 34);
            this.aPriceInput.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(19, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 29);
            this.label15.TabIndex = 13;
            this.label15.Text = "Тип реклами";
            // 
            // aTypeInput
            // 
            this.aTypeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aTypeInput.Location = new System.Drawing.Point(24, 383);
            this.aTypeInput.Name = "aTypeInput";
            this.aTypeInput.Size = new System.Drawing.Size(214, 34);
            this.aTypeInput.TabIndex = 12;
            // 
            // aDgv
            // 
            this.aDgv.AllowUserToAddRows = false;
            this.aDgv.AllowUserToDeleteRows = false;
            this.aDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDgv.Location = new System.Drawing.Point(7, 23);
            this.aDgv.Name = "aDgv";
            this.aDgv.ReadOnly = true;
            this.aDgv.RowHeadersWidth = 51;
            this.aDgv.RowTemplate.Height = 24;
            this.aDgv.Size = new System.Drawing.Size(913, 301);
            this.aDgv.TabIndex = 11;
            this.aDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pDateInput);
            this.tabPage4.Controls.Add(this.label);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.pPrintRunInput);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.pTitleInput);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.pTypeInput);
            this.tabPage4.Controls.Add(this.pDgv);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(926, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Типографія";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pDateInput
            // 
            this.pDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pDateInput.Location = new System.Drawing.Point(364, 468);
            this.pDateInput.Name = "pDateInput";
            this.pDateInput.Size = new System.Drawing.Size(287, 34);
            this.pDateInput.TabIndex = 20;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(359, 435);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(234, 29);
            this.label.TabIndex = 19;
            this.label.Text = "Дата виготовлення";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(359, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 29);
            this.label18.TabIndex = 17;
            this.label18.Text = "Наклад";
            // 
            // pPrintRunInput
            // 
            this.pPrintRunInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pPrintRunInput.Location = new System.Drawing.Point(364, 383);
            this.pPrintRunInput.Name = "pPrintRunInput";
            this.pPrintRunInput.Size = new System.Drawing.Size(287, 34);
            this.pPrintRunInput.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(19, 435);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 29);
            this.label19.TabIndex = 15;
            this.label19.Text = "Назва";
            // 
            // pTitleInput
            // 
            this.pTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTitleInput.Location = new System.Drawing.Point(24, 468);
            this.pTitleInput.Name = "pTitleInput";
            this.pTitleInput.Size = new System.Drawing.Size(273, 34);
            this.pTitleInput.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(19, 351);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 29);
            this.label20.TabIndex = 13;
            this.label20.Text = "Тип продукції";
            // 
            // pTypeInput
            // 
            this.pTypeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTypeInput.Location = new System.Drawing.Point(24, 383);
            this.pTypeInput.Name = "pTypeInput";
            this.pTypeInput.Size = new System.Drawing.Size(273, 34);
            this.pTypeInput.TabIndex = 12;
            // 
            // pDgv
            // 
            this.pDgv.AllowUserToAddRows = false;
            this.pDgv.AllowUserToDeleteRows = false;
            this.pDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pDgv.Location = new System.Drawing.Point(3, 18);
            this.pDgv.Name = "pDgv";
            this.pDgv.ReadOnly = true;
            this.pDgv.RowHeadersWidth = 51;
            this.pDgv.RowTemplate.Height = 24;
            this.pDgv.Size = new System.Drawing.Size(913, 301);
            this.pDgv.TabIndex = 11;
            this.pDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // saveItem
            // 
            this.saveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveItem.Location = new System.Drawing.Point(32, 633);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(187, 80);
            this.saveItem.TabIndex = 1;
            this.saveItem.Text = "Save";
            this.saveItem.UseVisualStyleBackColor = true;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // searchItem
            // 
            this.searchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchItem.Location = new System.Drawing.Point(758, 633);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(187, 80);
            this.searchItem.TabIndex = 2;
            this.searchItem.Text = "Search";
            this.searchItem.UseVisualStyleBackColor = true;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteItem.Location = new System.Drawing.Point(256, 633);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(187, 80);
            this.deleteItem.TabIndex = 3;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInput.Location = new System.Drawing.Point(498, 633);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(254, 80);
            this.searchInput.TabIndex = 3;
            this.searchInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchInput_MouseClick);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(913, 297);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 745);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.saveItem);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDgv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox bTitleInput;
        private System.Windows.Forms.Button saveItem;
        private System.Windows.Forms.Button searchItem;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bYearInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bPrintRunInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bGenreInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bAuthorInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mPrintRunInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mIssueInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mTitleInput;
        private System.Windows.Forms.DataGridView mDgv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox aPriceInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox aTypeInput;
        private System.Windows.Forms.DataGridView aDgv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox pPrintRunInput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pTitleInput;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox pTypeInput;
        private System.Windows.Forms.DataGridView pDgv;
        private System.Windows.Forms.DateTimePicker mDateInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aMagazineInput;
        private System.Windows.Forms.DateTimePicker pDateInput;
        private System.Windows.Forms.DataGridView dgv;
    }
}