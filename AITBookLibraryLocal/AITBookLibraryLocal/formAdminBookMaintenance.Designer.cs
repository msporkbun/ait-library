namespace AITBookLibraryLocal
{
    partial class formAdminBookMaintenance
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
            this.lblAddBookHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddBookISBN = new System.Windows.Forms.TextBox();
            this.txtAddBookBookName = new System.Windows.Forms.TextBox();
            this.txtAddBookPublishYear = new System.Windows.Forms.TextBox();
            this.txtAddBookPages = new System.Windows.Forms.TextBox();
            this.txtAddBookPublisher = new System.Windows.Forms.TextBox();
            this.comAddBookAuthor = new System.Windows.Forms.ComboBox();
            this.comAddBookCategory = new System.Windows.Forms.ComboBox();
            this.comAddBookLanguage = new System.Windows.Forms.ComboBox();
            this.btnBookMaintenanceAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditBookISBN = new System.Windows.Forms.TextBox();
            this.txtEditBookBookName = new System.Windows.Forms.TextBox();
            this.comEditBookAuthor = new System.Windows.Forms.ComboBox();
            this.comEditBookCategory = new System.Windows.Forms.ComboBox();
            this.comEditBookLanguage = new System.Windows.Forms.ComboBox();
            this.txtEditBookPublishYear = new System.Windows.Forms.TextBox();
            this.txtEditBookPages = new System.Windows.Forms.TextBox();
            this.txtEditBookPublisher = new System.Windows.Forms.TextBox();
            this.btnBookMaintenanceUpdate = new System.Windows.Forms.Button();
            this.dgvBookMaintenance = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBookMMaintRefreshList = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBookMaintenanceDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookMaintenance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddBookHeader
            // 
            this.lblAddBookHeader.AutoSize = true;
            this.lblAddBookHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBookHeader.Location = new System.Drawing.Point(55, 13);
            this.lblAddBookHeader.Name = "lblAddBookHeader";
            this.lblAddBookHeader.Size = new System.Drawing.Size(71, 13);
            this.lblAddBookHeader.TabIndex = 0;
            this.lblAddBookHeader.Text = "ADD BOOK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Language:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Publish Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pages:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Publisher:";
            // 
            // txtAddBookISBN
            // 
            this.txtAddBookISBN.Location = new System.Drawing.Point(83, 41);
            this.txtAddBookISBN.Name = "txtAddBookISBN";
            this.txtAddBookISBN.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookISBN.TabIndex = 9;
            // 
            // txtAddBookBookName
            // 
            this.txtAddBookBookName.Location = new System.Drawing.Point(83, 68);
            this.txtAddBookBookName.Name = "txtAddBookBookName";
            this.txtAddBookBookName.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookBookName.TabIndex = 10;
            // 
            // txtAddBookPublishYear
            // 
            this.txtAddBookPublishYear.Location = new System.Drawing.Point(83, 174);
            this.txtAddBookPublishYear.Name = "txtAddBookPublishYear";
            this.txtAddBookPublishYear.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookPublishYear.TabIndex = 14;
            // 
            // txtAddBookPages
            // 
            this.txtAddBookPages.Location = new System.Drawing.Point(83, 201);
            this.txtAddBookPages.Name = "txtAddBookPages";
            this.txtAddBookPages.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookPages.TabIndex = 15;
            // 
            // txtAddBookPublisher
            // 
            this.txtAddBookPublisher.Location = new System.Drawing.Point(83, 228);
            this.txtAddBookPublisher.Name = "txtAddBookPublisher";
            this.txtAddBookPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookPublisher.TabIndex = 16;
            // 
            // comAddBookAuthor
            // 
            this.comAddBookAuthor.FormattingEnabled = true;
            this.comAddBookAuthor.Location = new System.Drawing.Point(83, 95);
            this.comAddBookAuthor.Name = "comAddBookAuthor";
            this.comAddBookAuthor.Size = new System.Drawing.Size(121, 21);
            this.comAddBookAuthor.TabIndex = 17;
            // 
            // comAddBookCategory
            // 
            this.comAddBookCategory.FormattingEnabled = true;
            this.comAddBookCategory.Location = new System.Drawing.Point(83, 122);
            this.comAddBookCategory.Name = "comAddBookCategory";
            this.comAddBookCategory.Size = new System.Drawing.Size(121, 21);
            this.comAddBookCategory.TabIndex = 18;
            // 
            // comAddBookLanguage
            // 
            this.comAddBookLanguage.FormattingEnabled = true;
            this.comAddBookLanguage.Location = new System.Drawing.Point(83, 147);
            this.comAddBookLanguage.Name = "comAddBookLanguage";
            this.comAddBookLanguage.Size = new System.Drawing.Size(121, 21);
            this.comAddBookLanguage.TabIndex = 19;
            // 
            // btnBookMaintenanceAdd
            // 
            this.btnBookMaintenanceAdd.Location = new System.Drawing.Point(58, 261);
            this.btnBookMaintenanceAdd.Name = "btnBookMaintenanceAdd";
            this.btnBookMaintenanceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookMaintenanceAdd.TabIndex = 20;
            this.btnBookMaintenanceAdd.Text = "Add";
            this.btnBookMaintenanceAdd.UseVisualStyleBackColor = true;
            this.btnBookMaintenanceAdd.Click += new System.EventHandler(this.btnBookMaintenanceAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "EDIT BOOK";
            // 
            // txtEditBookISBN
            // 
            this.txtEditBookISBN.Location = new System.Drawing.Point(83, 40);
            this.txtEditBookISBN.Name = "txtEditBookISBN";
            this.txtEditBookISBN.Size = new System.Drawing.Size(100, 20);
            this.txtEditBookISBN.TabIndex = 22;
            // 
            // txtEditBookBookName
            // 
            this.txtEditBookBookName.Location = new System.Drawing.Point(83, 67);
            this.txtEditBookBookName.Name = "txtEditBookBookName";
            this.txtEditBookBookName.Size = new System.Drawing.Size(100, 20);
            this.txtEditBookBookName.TabIndex = 23;
            // 
            // comEditBookAuthor
            // 
            this.comEditBookAuthor.FormattingEnabled = true;
            this.comEditBookAuthor.Location = new System.Drawing.Point(83, 94);
            this.comEditBookAuthor.Name = "comEditBookAuthor";
            this.comEditBookAuthor.Size = new System.Drawing.Size(121, 21);
            this.comEditBookAuthor.TabIndex = 24;
            // 
            // comEditBookCategory
            // 
            this.comEditBookCategory.FormattingEnabled = true;
            this.comEditBookCategory.Location = new System.Drawing.Point(83, 122);
            this.comEditBookCategory.Name = "comEditBookCategory";
            this.comEditBookCategory.Size = new System.Drawing.Size(121, 21);
            this.comEditBookCategory.TabIndex = 25;
            // 
            // comEditBookLanguage
            // 
            this.comEditBookLanguage.FormattingEnabled = true;
            this.comEditBookLanguage.Location = new System.Drawing.Point(83, 150);
            this.comEditBookLanguage.Name = "comEditBookLanguage";
            this.comEditBookLanguage.Size = new System.Drawing.Size(121, 21);
            this.comEditBookLanguage.TabIndex = 26;
            // 
            // txtEditBookPublishYear
            // 
            this.txtEditBookPublishYear.Location = new System.Drawing.Point(83, 178);
            this.txtEditBookPublishYear.Name = "txtEditBookPublishYear";
            this.txtEditBookPublishYear.Size = new System.Drawing.Size(100, 20);
            this.txtEditBookPublishYear.TabIndex = 27;
            // 
            // txtEditBookPages
            // 
            this.txtEditBookPages.Location = new System.Drawing.Point(83, 205);
            this.txtEditBookPages.Name = "txtEditBookPages";
            this.txtEditBookPages.Size = new System.Drawing.Size(100, 20);
            this.txtEditBookPages.TabIndex = 28;
            // 
            // txtEditBookPublisher
            // 
            this.txtEditBookPublisher.Location = new System.Drawing.Point(83, 232);
            this.txtEditBookPublisher.Name = "txtEditBookPublisher";
            this.txtEditBookPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtEditBookPublisher.TabIndex = 29;
            // 
            // btnBookMaintenanceUpdate
            // 
            this.btnBookMaintenanceUpdate.Location = new System.Drawing.Point(58, 267);
            this.btnBookMaintenanceUpdate.Name = "btnBookMaintenanceUpdate";
            this.btnBookMaintenanceUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBookMaintenanceUpdate.TabIndex = 30;
            this.btnBookMaintenanceUpdate.Text = "Update";
            this.btnBookMaintenanceUpdate.UseVisualStyleBackColor = true;
            this.btnBookMaintenanceUpdate.Click += new System.EventHandler(this.btnBookMaintenanceUpdate_Click);
            // 
            // dgvBookMaintenance
            // 
            this.dgvBookMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookMaintenance.Location = new System.Drawing.Point(357, 48);
            this.dgvBookMaintenance.Name = "dgvBookMaintenance";
            this.dgvBookMaintenance.Size = new System.Drawing.Size(431, 344);
            this.dgvBookMaintenance.TabIndex = 31;
            this.dgvBookMaintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectBook);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "BOOK LIST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "DELETE";
            // 
            // btnBookMMaintRefreshList
            // 
            this.btnBookMMaintRefreshList.Location = new System.Drawing.Point(529, 398);
            this.btnBookMMaintRefreshList.Name = "btnBookMMaintRefreshList";
            this.btnBookMMaintRefreshList.Size = new System.Drawing.Size(75, 23);
            this.btnBookMMaintRefreshList.TabIndex = 34;
            this.btnBookMMaintRefreshList.Text = "Refresh List";
            this.btnBookMMaintRefreshList.UseVisualStyleBackColor = true;
            this.btnBookMMaintRefreshList.Click += new System.EventHandler(this.btnBookMMaintRefreshList_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "For the selected book:";
            // 
            // btnBookMaintenanceDelete
            // 
            this.btnBookMaintenanceDelete.Location = new System.Drawing.Point(132, 41);
            this.btnBookMaintenanceDelete.Name = "btnBookMaintenanceDelete";
            this.btnBookMaintenanceDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBookMaintenanceDelete.TabIndex = 36;
            this.btnBookMaintenanceDelete.Text = "Delete";
            this.btnBookMaintenanceDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBookMaintenanceDelete);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(382, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 87);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btnBookMaintenanceUpdate);
            this.panel2.Controls.Add(this.txtEditBookPublisher);
            this.panel2.Controls.Add(this.txtEditBookPages);
            this.panel2.Controls.Add(this.txtEditBookPublishYear);
            this.panel2.Controls.Add(this.comEditBookLanguage);
            this.panel2.Controls.Add(this.comEditBookCategory);
            this.panel2.Controls.Add(this.comEditBookAuthor);
            this.panel2.Controls.Add(this.txtEditBookBookName);
            this.panel2.Controls.Add(this.txtEditBookISBN);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(26, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 301);
            this.panel2.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Publisher:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Pages:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Publish Year:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Language:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Category:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Author:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Book Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "ISBN:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBookMaintenanceAdd);
            this.panel3.Controls.Add(this.comAddBookLanguage);
            this.panel3.Controls.Add(this.comAddBookCategory);
            this.panel3.Controls.Add(this.comAddBookAuthor);
            this.panel3.Controls.Add(this.txtAddBookPublisher);
            this.panel3.Controls.Add(this.txtAddBookPages);
            this.panel3.Controls.Add(this.txtAddBookPublishYear);
            this.panel3.Controls.Add(this.txtAddBookBookName);
            this.panel3.Controls.Add(this.txtAddBookISBN);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblAddBookHeader);
            this.panel3.Location = new System.Drawing.Point(26, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 293);
            this.panel3.TabIndex = 39;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(712, 582);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // formAdminBookMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBookMMaintRefreshList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvBookMaintenance);
            this.Name = "formAdminBookMaintenance";
            this.Text = "formAdminBookMaintenance";
            this.Load += new System.EventHandler(this.formAdminBookMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookMaintenance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBookHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddBookISBN;
        private System.Windows.Forms.TextBox txtAddBookBookName;
        private System.Windows.Forms.TextBox txtAddBookPublishYear;
        private System.Windows.Forms.TextBox txtAddBookPages;
        private System.Windows.Forms.TextBox txtAddBookPublisher;
        private System.Windows.Forms.ComboBox comAddBookAuthor;
        private System.Windows.Forms.ComboBox comAddBookCategory;
        private System.Windows.Forms.ComboBox comAddBookLanguage;
        private System.Windows.Forms.Button btnBookMaintenanceAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditBookISBN;
        private System.Windows.Forms.TextBox txtEditBookBookName;
        private System.Windows.Forms.ComboBox comEditBookAuthor;
        private System.Windows.Forms.ComboBox comEditBookCategory;
        private System.Windows.Forms.ComboBox comEditBookLanguage;
        private System.Windows.Forms.TextBox txtEditBookPublishYear;
        private System.Windows.Forms.TextBox txtEditBookPages;
        private System.Windows.Forms.TextBox txtEditBookPublisher;
        private System.Windows.Forms.Button btnBookMaintenanceUpdate;
        private System.Windows.Forms.DataGridView dgvBookMaintenance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBookMMaintRefreshList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBookMaintenanceDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}