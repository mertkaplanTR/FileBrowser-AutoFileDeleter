namespace FileManagerPro.App
{
    partial class MertKaplanFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MertKaplanFileManager));
            this.txtMinEntered = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHourEntered = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteFilesUnderSubFolders = new System.Windows.Forms.Button();
            this.btnDeleteOnlyCurrentFolderFolders = new System.Windows.Forms.Button();
            this.btnDeleteOnlyFolderFiles = new System.Windows.Forms.Button();
            this.btnDeleteAllSubCategories = new System.Windows.Forms.Button();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.txtboxFolder = new System.Windows.Forms.TextBox();
            this.listBoxDirectoryFiles = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtboxModifiedDate = new System.Windows.Forms.TextBox();
            this.txtboxCreatedDate = new System.Windows.Forms.TextBox();
            this.txtboxFileType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteBeforeThisDateBtn = new System.Windows.Forms.Button();
            this.listBoxParameters = new System.Windows.Forms.ListBox();
            this.txtEnterFileTypeForList = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBackToFolder = new System.Windows.Forms.Button();
            this.btnDeleteSelectedFolder = new System.Windows.Forms.Button();
            this.checkBoxShowSubFolderFiles = new System.Windows.Forms.CheckBox();
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtMinEntered
            // 
            this.txtMinEntered.Location = new System.Drawing.Point(206, 400);
            this.txtMinEntered.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinEntered.Name = "txtMinEntered";
            this.txtMinEntered.Size = new System.Drawing.Size(30, 20);
            this.txtMinEntered.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = ":";
            // 
            // txtHourEntered
            // 
            this.txtHourEntered.Location = new System.Drawing.Point(150, 400);
            this.txtHourEntered.Margin = new System.Windows.Forms.Padding(4);
            this.txtHourEntered.Name = "txtHourEntered";
            this.txtHourEntered.Size = new System.Drawing.Size(30, 20);
            this.txtHourEntered.TabIndex = 52;
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.Location = new System.Drawing.Point(150, 428);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 20);
            this.datePicker.TabIndex = 51;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // btnDeleteFilesUnderSubFolders
            // 
            this.btnDeleteFilesUnderSubFolders.Location = new System.Drawing.Point(682, 279);
            this.btnDeleteFilesUnderSubFolders.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFilesUnderSubFolders.Name = "btnDeleteFilesUnderSubFolders";
            this.btnDeleteFilesUnderSubFolders.Size = new System.Drawing.Size(100, 52);
            this.btnDeleteFilesUnderSubFolders.TabIndex = 50;
            this.btnDeleteFilesUnderSubFolders.Text = "Dizin İçindeki ve Alt Klasörlerdeki Tüm Dosyaları Sil";
            this.btnDeleteFilesUnderSubFolders.UseVisualStyleBackColor = true;
            this.btnDeleteFilesUnderSubFolders.Click += new System.EventHandler(this.btnDeleteFilesUnderSubFolders_Click);
            // 
            // btnDeleteOnlyCurrentFolderFolders
            // 
            this.btnDeleteOnlyCurrentFolderFolders.Location = new System.Drawing.Point(682, 187);
            this.btnDeleteOnlyCurrentFolderFolders.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOnlyCurrentFolderFolders.Name = "btnDeleteOnlyCurrentFolderFolders";
            this.btnDeleteOnlyCurrentFolderFolders.Size = new System.Drawing.Size(100, 36);
            this.btnDeleteOnlyCurrentFolderFolders.TabIndex = 49;
            this.btnDeleteOnlyCurrentFolderFolders.Text = "Bu Dizin İçindeki Tüm Klasörleri Sil";
            this.btnDeleteOnlyCurrentFolderFolders.UseVisualStyleBackColor = true;
            this.btnDeleteOnlyCurrentFolderFolders.Click += new System.EventHandler(this.btnDeleteOnlyCurrentFolderFolders_Click);
            // 
            // btnDeleteOnlyFolderFiles
            // 
            this.btnDeleteOnlyFolderFiles.Location = new System.Drawing.Point(682, 231);
            this.btnDeleteOnlyFolderFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOnlyFolderFiles.Name = "btnDeleteOnlyFolderFiles";
            this.btnDeleteOnlyFolderFiles.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteOnlyFolderFiles.TabIndex = 47;
            this.btnDeleteOnlyFolderFiles.Text = "Bu Dizin İçindeki Dosyaları Sil";
            this.btnDeleteOnlyFolderFiles.UseVisualStyleBackColor = true;
            this.btnDeleteOnlyFolderFiles.Click += new System.EventHandler(this.btnDeleteOnlyFolderFiles_Click);
            // 
            // btnDeleteAllSubCategories
            // 
            this.btnDeleteAllSubCategories.Location = new System.Drawing.Point(682, 144);
            this.btnDeleteAllSubCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllSubCategories.Name = "btnDeleteAllSubCategories";
            this.btnDeleteAllSubCategories.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteAllSubCategories.TabIndex = 46;
            this.btnDeleteAllSubCategories.Text = "Bu Dizini Tamamen Sil";
            this.btnDeleteAllSubCategories.UseVisualStyleBackColor = true;
            this.btnDeleteAllSubCategories.Click += new System.EventHandler(this.btnDeleteAllSubCategories_Click);
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(682, 45);
            this.btnDeleteSelectedItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(100, 41);
            this.btnDeleteSelectedItem.TabIndex = 44;
            this.btnDeleteSelectedItem.Text = "Sadece Seçilen Dosyayı Sil";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.btnDeleteSelectedItem_Click);
            // 
            // txtboxFolder
            // 
            this.txtboxFolder.Location = new System.Drawing.Point(152, 42);
            this.txtboxFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFolder.Name = "txtboxFolder";
            this.txtboxFolder.Size = new System.Drawing.Size(460, 20);
            this.txtboxFolder.TabIndex = 31;
            // 
            // listBoxDirectoryFiles
            // 
            this.listBoxDirectoryFiles.FormattingEnabled = true;
            this.listBoxDirectoryFiles.Location = new System.Drawing.Point(150, 181);
            this.listBoxDirectoryFiles.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDirectoryFiles.Name = "listBoxDirectoryFiles";
            this.listBoxDirectoryFiles.Size = new System.Drawing.Size(460, 160);
            this.listBoxDirectoryFiles.TabIndex = 43;
            this.listBoxDirectoryFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectoryFiles_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(618, 42);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(56, 299);
            this.btnShow.TabIndex = 42;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtboxModifiedDate
            // 
            this.txtboxModifiedDate.Location = new System.Drawing.Point(151, 153);
            this.txtboxModifiedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxModifiedDate.Name = "txtboxModifiedDate";
            this.txtboxModifiedDate.Size = new System.Drawing.Size(460, 20);
            this.txtboxModifiedDate.TabIndex = 41;
            // 
            // txtboxCreatedDate
            // 
            this.txtboxCreatedDate.Location = new System.Drawing.Point(152, 125);
            this.txtboxCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxCreatedDate.Name = "txtboxCreatedDate";
            this.txtboxCreatedDate.Size = new System.Drawing.Size(460, 20);
            this.txtboxCreatedDate.TabIndex = 40;
            // 
            // txtboxFileType
            // 
            this.txtboxFileType.Location = new System.Drawing.Point(152, 97);
            this.txtboxFileType.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFileType.Name = "txtboxFileType";
            this.txtboxFileType.Size = new System.Drawing.Size(460, 20);
            this.txtboxFileType.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Değiştirilme Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Oluşturulma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Dizin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Dosya Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dosya Özellikleri";
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(152, 70);
            this.txtboxFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(460, 20);
            this.txtboxFileName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Dosya Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(148, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Arama Yap:";
            // 
            // deleteBeforeThisDateBtn
            // 
            this.deleteBeforeThisDateBtn.Location = new System.Drawing.Point(618, 456);
            this.deleteBeforeThisDateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBeforeThisDateBtn.Name = "deleteBeforeThisDateBtn";
            this.deleteBeforeThisDateBtn.Size = new System.Drawing.Size(65, 212);
            this.deleteBeforeThisDateBtn.TabIndex = 56;
            this.deleteBeforeThisDateBtn.Text = "Listelenen Dosyaları Sil";
            this.deleteBeforeThisDateBtn.UseVisualStyleBackColor = true;
            this.deleteBeforeThisDateBtn.Click += new System.EventHandler(this.deleteBeforeThisDateBtn_Click);
            // 
            // listBoxParameters
            // 
            this.listBoxParameters.FormattingEnabled = true;
            this.listBoxParameters.Location = new System.Drawing.Point(150, 456);
            this.listBoxParameters.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParameters.Name = "listBoxParameters";
            this.listBoxParameters.Size = new System.Drawing.Size(460, 212);
            this.listBoxParameters.TabIndex = 57;
            // 
            // txtEnterFileTypeForList
            // 
            this.txtEnterFileTypeForList.Location = new System.Drawing.Point(150, 372);
            this.txtEnterFileTypeForList.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterFileTypeForList.Name = "txtEnterFileTypeForList";
            this.txtEnterFileTypeForList.Size = new System.Drawing.Size(126, 20);
            this.txtEnterFileTypeForList.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 434);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Karşılaştırılacak Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Saat Dakika:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 375);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "File Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(291, 403);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Aranan Deger: ";
            // 
            // btnBackToFolder
            // 
            this.btnBackToFolder.Location = new System.Drawing.Point(523, 353);
            this.btnBackToFolder.Name = "btnBackToFolder";
            this.btnBackToFolder.Size = new System.Drawing.Size(151, 39);
            this.btnBackToFolder.TabIndex = 63;
            this.btnBackToFolder.Text = "Geri";
            this.btnBackToFolder.UseVisualStyleBackColor = true;
            this.btnBackToFolder.Click += new System.EventHandler(this.btnBackToFolder_Click);
            // 
            // btnDeleteSelectedFolder
            // 
            this.btnDeleteSelectedFolder.Location = new System.Drawing.Point(682, 96);
            this.btnDeleteSelectedFolder.Name = "btnDeleteSelectedFolder";
            this.btnDeleteSelectedFolder.Size = new System.Drawing.Size(100, 41);
            this.btnDeleteSelectedFolder.TabIndex = 64;
            this.btnDeleteSelectedFolder.Text = "Sadece Seçilen Klasörü Sil";
            this.btnDeleteSelectedFolder.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedFolder.Click += new System.EventHandler(this.btnDeleteSelectedFolder_Click);
            // 
            // checkBoxShowSubFolderFiles
            // 
            this.checkBoxShowSubFolderFiles.AutoSize = true;
            this.checkBoxShowSubFolderFiles.Location = new System.Drawing.Point(294, 370);
            this.checkBoxShowSubFolderFiles.Name = "checkBoxShowSubFolderFiles";
            this.checkBoxShowSubFolderFiles.Size = new System.Drawing.Size(193, 17);
            this.checkBoxShowSubFolderFiles.TabIndex = 65;
            this.checkBoxShowSubFolderFiles.Text = "Alt Klasörlerdeki Dosyalarıda Göster";
            this.checkBoxShowSubFolderFiles.UseVisualStyleBackColor = true;
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Location = new System.Drawing.Point(778, 655);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(82, 13);
            this.linkLabelWeb.TabIndex = 66;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "MertKaplanBlog";
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // MertKaplanFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(872, 676);
            this.Controls.Add(this.linkLabelWeb);
            this.Controls.Add(this.checkBoxShowSubFolderFiles);
            this.Controls.Add(this.btnDeleteSelectedFolder);
            this.Controls.Add(this.btnBackToFolder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEnterFileTypeForList);
            this.Controls.Add(this.listBoxParameters);
            this.Controls.Add(this.deleteBeforeThisDateBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMinEntered);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHourEntered);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnDeleteFilesUnderSubFolders);
            this.Controls.Add(this.btnDeleteOnlyCurrentFolderFolders);
            this.Controls.Add(this.btnDeleteOnlyFolderFiles);
            this.Controls.Add(this.btnDeleteAllSubCategories);
            this.Controls.Add(this.btnDeleteSelectedItem);
            this.Controls.Add(this.txtboxFolder);
            this.Controls.Add(this.listBoxDirectoryFiles);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtboxModifiedDate);
            this.Controls.Add(this.txtboxCreatedDate);
            this.Controls.Add(this.txtboxFileType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MertKaplanFileManager";
            this.Text = "MK-Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinEntered;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHourEntered;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnDeleteFilesUnderSubFolders;
        private System.Windows.Forms.Button btnDeleteOnlyCurrentFolderFolders;
        private System.Windows.Forms.Button btnDeleteOnlyFolderFiles;
        private System.Windows.Forms.Button btnDeleteAllSubCategories;
        private System.Windows.Forms.Button btnDeleteSelectedItem;
        private System.Windows.Forms.TextBox txtboxFolder;
        private System.Windows.Forms.ListBox listBoxDirectoryFiles;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtboxModifiedDate;
        private System.Windows.Forms.TextBox txtboxCreatedDate;
        private System.Windows.Forms.TextBox txtboxFileType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteBeforeThisDateBtn;
        private System.Windows.Forms.ListBox listBoxParameters;
        private System.Windows.Forms.TextBox txtEnterFileTypeForList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBackToFolder;
        private System.Windows.Forms.Button btnDeleteSelectedFolder;
        private System.Windows.Forms.CheckBox checkBoxShowSubFolderFiles;
        private System.Windows.Forms.LinkLabel linkLabelWeb;
    }
}

