namespace AITBookLibraryLocal
{
    partial class StudentHomeForm
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
            this.lblHeaderStudentHome = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.btnListAllBooks = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblPublishYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSearchPublishYear = new System.Windows.Forms.Button();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnSearchBookName = new System.Windows.Forms.Button();
            this.lblBookSelectedName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderStudentHome
            // 
            this.lblHeaderStudentHome.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblHeaderStudentHome.AutoSize = true;
            this.lblHeaderStudentHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeaderStudentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderStudentHome.Location = new System.Drawing.Point(474, 19);
            this.lblHeaderStudentHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderStudentHome.Name = "lblHeaderStudentHome";
            this.lblHeaderStudentHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeaderStudentHome.Size = new System.Drawing.Size(217, 26);
            this.lblHeaderStudentHome.TabIndex = 0;
            this.lblHeaderStudentHome.Text = "AIT Library Student";
            this.lblHeaderStudentHome.Click += new System.EventHandler(this.lblHeaderStudentHome_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(479, 64);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 62;
            this.dataGridViewBooks.Size = new System.Drawing.Size(625, 333);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllBooks.Location = new System.Drawing.Point(37, 261);
            this.btnListAllBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(190, 45);
            this.btnListAllBooks.TabIndex = 2;
            this.btnListAllBooks.Text = "List All Books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            this.btnListAllBooks.Click += new System.EventHandler(this.btnListAllBooks_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(32, 76);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 22);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by ...";
            // 
            // lblPublishYear
            // 
            this.lblPublishYear.AutoSize = true;
            this.lblPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishYear.Location = new System.Drawing.Point(29, 120);
            this.lblPublishYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublishYear.Name = "lblPublishYear";
            this.lblPublishYear.Size = new System.Drawing.Size(114, 22);
            this.lblPublishYear.TabIndex = 4;
            this.lblPublishYear.Text = "Publish year:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(29, 166);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 22);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublishYear.Location = new System.Drawing.Point(192, 116);
            this.txtPublishYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(184, 26);
            this.txtPublishYear.TabIndex = 7;
            this.txtPublishYear.TextChanged += new System.EventHandler(this.txtPublishYear_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Location = new System.Drawing.Point(192, 162);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(184, 26);
            this.txtCategory.TabIndex = 8;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // btnSearchPublishYear
            // 
            this.btnSearchPublishYear.Location = new System.Drawing.Point(393, 114);
            this.btnSearchPublishYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchPublishYear.Name = "btnSearchPublishYear";
            this.btnSearchPublishYear.Size = new System.Drawing.Size(68, 29);
            this.btnSearchPublishYear.TabIndex = 9;
            this.btnSearchPublishYear.Text = "Search";
            this.btnSearchPublishYear.UseVisualStyleBackColor = true;
            this.btnSearchPublishYear.Click += new System.EventHandler(this.btnSearchPublishYear_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(393, 160);
            this.btnSearchCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(68, 30);
            this.btnSearchCategory.TabIndex = 10;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.White;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(37, 316);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(190, 46);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Reserve Book";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(264, 261);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(198, 46);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(29, 211);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(105, 22);
            this.lblBookName.TabIndex = 13;
            this.lblBookName.Text = "Book name:";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(192, 207);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(184, 26);
            this.txtBookName.TabIndex = 14;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnSearchBookName
            // 
            this.btnSearchBookName.Location = new System.Drawing.Point(393, 205);
            this.btnSearchBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBookName.Name = "btnSearchBookName";
            this.btnSearchBookName.Size = new System.Drawing.Size(68, 31);
            this.btnSearchBookName.TabIndex = 15;
            this.btnSearchBookName.Text = "Search";
            this.btnSearchBookName.UseVisualStyleBackColor = true;
            this.btnSearchBookName.Click += new System.EventHandler(this.btnSearchBookName_Click);
            // 
            // lblBookSelectedName
            // 
            this.lblBookSelectedName.AutoSize = true;
            this.lblBookSelectedName.Location = new System.Drawing.Point(980, 402);
            this.lblBookSelectedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookSelectedName.Name = "lblBookSelectedName";
            this.lblBookSelectedName.Size = new System.Drawing.Size(124, 20);
            this.lblBookSelectedName.TabIndex = 16;
            this.lblBookSelectedName.Text = "(None Selected)";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(264, 316);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 46);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1130, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBookSelectedName);
            this.Controls.Add(this.btnSearchBookName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.btnSearchPublishYear);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPublishYear);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPublishYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnListAllBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.lblHeaderStudentHome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentHomeForm";
            this.Text = "StudentHomeForm";
            this.Load += new System.EventHandler(this.StudentHomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderStudentHome;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button btnListAllBooks;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblPublishYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSearchPublishYear;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnSearchBookName;
        private System.Windows.Forms.Label lblBookSelectedName;
        private System.Windows.Forms.Button btnExit;
    }
}