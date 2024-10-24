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
            this.lblHeaderStudentHome.AutoSize = true;
            this.lblHeaderStudentHome.Location = new System.Drawing.Point(297, 9);
            this.lblHeaderStudentHome.Name = "lblHeaderStudentHome";
            this.lblHeaderStudentHome.Size = new System.Drawing.Size(152, 13);
            this.lblHeaderStudentHome.TabIndex = 0;
            this.lblHeaderStudentHome.Text = "AIT Book Library Student View";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(776, 197);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.Location = new System.Drawing.Point(12, 239);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(131, 23);
            this.btnListAllBooks.TabIndex = 2;
            this.btnListAllBooks.Text = "List All Books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            this.btnListAllBooks.Click += new System.EventHandler(this.btnListAllBooks_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 295);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by ...";
            // 
            // lblPublishYear
            // 
            this.lblPublishYear.AutoSize = true;
            this.lblPublishYear.Location = new System.Drawing.Point(16, 329);
            this.lblPublishYear.Name = "lblPublishYear";
            this.lblPublishYear.Size = new System.Drawing.Size(67, 13);
            this.lblPublishYear.TabIndex = 4;
            this.lblPublishYear.Text = "Publish year:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 360);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(111, 326);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(100, 20);
            this.txtPublishYear.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(111, 360);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 8;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // btnSearchPublishYear
            // 
            this.btnSearchPublishYear.Location = new System.Drawing.Point(248, 324);
            this.btnSearchPublishYear.Name = "btnSearchPublishYear";
            this.btnSearchPublishYear.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPublishYear.TabIndex = 9;
            this.btnSearchPublishYear.Text = "Search";
            this.btnSearchPublishYear.UseVisualStyleBackColor = true;
            this.btnSearchPublishYear.Click += new System.EventHandler(this.btnSearchPublishYear_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(248, 358);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCategory.TabIndex = 10;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(392, 284);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(106, 24);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Reserve Book";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(533, 284);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(97, 24);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(16, 396);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(64, 13);
            this.lblBookName.TabIndex = 13;
            this.lblBookName.Text = "Book name:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(111, 393);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 14;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnSearchBookName
            // 
            this.btnSearchBookName.Location = new System.Drawing.Point(248, 391);
            this.btnSearchBookName.Name = "btnSearchBookName";
            this.btnSearchBookName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBookName.TabIndex = 15;
            this.btnSearchBookName.Text = "Search";
            this.btnSearchBookName.UseVisualStyleBackColor = true;
            this.btnSearchBookName.Click += new System.EventHandler(this.btnSearchBookName_Click);
            // 
            // lblBookSelectedName
            // 
            this.lblBookSelectedName.AutoSize = true;
            this.lblBookSelectedName.Location = new System.Drawing.Point(658, 244);
            this.lblBookSelectedName.Name = "lblBookSelectedName";
            this.lblBookSelectedName.Size = new System.Drawing.Size(84, 13);
            this.lblBookSelectedName.TabIndex = 16;
            this.lblBookSelectedName.Text = "(None Selected)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(712, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "StudentHomeForm";
            this.Text = "StudentHomeForm";
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