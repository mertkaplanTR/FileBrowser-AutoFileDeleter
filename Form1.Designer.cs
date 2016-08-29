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
            this.listBoxDestinationExplorer = new System.Windows.Forms.ListBox();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCompressAndDeleteListedFiles = new System.Windows.Forms.Button();
            this.btnCompressListedFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMinEntered
            // 
            this.txtMinEntered.Location = new System.Drawing.Point(159, 394);
            this.txtMinEntered.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinEntered.Name = "txtMinEntered";
            this.txtMinEntered.Size = new System.Drawing.Size(30, 20);
            this.txtMinEntered.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = ":";
            // 
            // txtHourEntered
            // 
            this.txtHourEntered.Location = new System.Drawing.Point(103, 393);
            this.txtHourEntered.Margin = new System.Windows.Forms.Padding(4);
            this.txtHourEntered.Name = "txtHourEntered";
            this.txtHourEntered.Size = new System.Drawing.Size(30, 20);
            this.txtHourEntered.TabIndex = 52;
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.Location = new System.Drawing.Point(103, 420);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 20);
            this.datePicker.TabIndex = 51;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // btnDeleteFilesUnderSubFolders
            // 
            this.btnDeleteFilesUnderSubFolders.Location = new System.Drawing.Point(1164, 286);
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
            this.btnDeleteOnlyCurrentFolderFolders.Location = new System.Drawing.Point(1164, 181);
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
            this.btnDeleteOnlyFolderFiles.Location = new System.Drawing.Point(1164, 225);
            this.btnDeleteOnlyFolderFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOnlyFolderFiles.Name = "btnDeleteOnlyFolderFiles";
            this.btnDeleteOnlyFolderFiles.Size = new System.Drawing.Size(100, 53);
            this.btnDeleteOnlyFolderFiles.TabIndex = 47;
            this.btnDeleteOnlyFolderFiles.Text = "Bu Dizin İçindeki Dosyaları Sil";
            this.btnDeleteOnlyFolderFiles.UseVisualStyleBackColor = true;
            this.btnDeleteOnlyFolderFiles.Click += new System.EventHandler(this.btnDeleteOnlyFolderFiles_Click);
            // 
            // btnDeleteAllSubCategories
            // 
            this.btnDeleteAllSubCategories.Location = new System.Drawing.Point(1164, 138);
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
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(1164, 48);
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
            this.txtboxFolder.Location = new System.Drawing.Point(103, 48);
            this.txtboxFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFolder.Name = "txtboxFolder";
            this.txtboxFolder.Size = new System.Drawing.Size(984, 20);
            this.txtboxFolder.TabIndex = 31;
            // 
            // listBoxDirectoryFiles
            // 
            this.listBoxDirectoryFiles.FormattingEnabled = true;
            this.listBoxDirectoryFiles.Location = new System.Drawing.Point(103, 178);
            this.listBoxDirectoryFiles.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDirectoryFiles.Name = "listBoxDirectoryFiles";
            this.listBoxDirectoryFiles.Size = new System.Drawing.Size(983, 160);
            this.listBoxDirectoryFiles.TabIndex = 43;
            this.listBoxDirectoryFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectoryFiles_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1089, 48);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(71, 290);
            this.btnShow.TabIndex = 42;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtboxModifiedDate
            // 
            this.txtboxModifiedDate.Location = new System.Drawing.Point(103, 153);
            this.txtboxModifiedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxModifiedDate.Name = "txtboxModifiedDate";
            this.txtboxModifiedDate.Size = new System.Drawing.Size(983, 20);
            this.txtboxModifiedDate.TabIndex = 41;
            // 
            // txtboxCreatedDate
            // 
            this.txtboxCreatedDate.Location = new System.Drawing.Point(103, 125);
            this.txtboxCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxCreatedDate.Name = "txtboxCreatedDate";
            this.txtboxCreatedDate.Size = new System.Drawing.Size(984, 20);
            this.txtboxCreatedDate.TabIndex = 40;
            // 
            // txtboxFileType
            // 
            this.txtboxFileType.Location = new System.Drawing.Point(103, 101);
            this.txtboxFileType.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFileType.Name = "txtboxFileType";
            this.txtboxFileType.Size = new System.Drawing.Size(984, 20);
            this.txtboxFileType.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label6.Location = new System.Drawing.Point(4, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "Değiştirilme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label5.Location = new System.Drawing.Point(11, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Oluşturulma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label4.Location = new System.Drawing.Point(53, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Dizin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Dosya Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dosya Özellikleri";
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(103, 76);
            this.txtboxFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(983, 20);
            this.txtboxFileName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Dosya Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.label8.Location = new System.Drawing.Point(99, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Arama Yap:";
            // 
            // deleteBeforeThisDateBtn
            // 
            this.deleteBeforeThisDateBtn.Location = new System.Drawing.Point(103, 666);
            this.deleteBeforeThisDateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBeforeThisDateBtn.Name = "deleteBeforeThisDateBtn";
            this.deleteBeforeThisDateBtn.Size = new System.Drawing.Size(126, 40);
            this.deleteBeforeThisDateBtn.TabIndex = 56;
            this.deleteBeforeThisDateBtn.Text = "Listelenen Dosyaları Sil";
            this.deleteBeforeThisDateBtn.UseVisualStyleBackColor = true;
            this.deleteBeforeThisDateBtn.Click += new System.EventHandler(this.deleteBeforeThisDateBtn_Click);
            // 
            // listBoxParameters
            // 
            this.listBoxParameters.FormattingEnabled = true;
            this.listBoxParameters.Location = new System.Drawing.Point(103, 448);
            this.listBoxParameters.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParameters.Name = "listBoxParameters";
            this.listBoxParameters.Size = new System.Drawing.Size(594, 212);
            this.listBoxParameters.TabIndex = 57;
            // 
            // txtEnterFileTypeForList
            // 
            this.txtEnterFileTypeForList.Location = new System.Drawing.Point(103, 366);
            this.txtEnterFileTypeForList.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterFileTypeForList.Name = "txtEnterFileTypeForList";
            this.txtEnterFileTypeForList.Size = new System.Drawing.Size(126, 20);
            this.txtEnterFileTypeForList.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label9.Location = new System.Drawing.Point(46, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 59;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label10.Location = new System.Drawing.Point(9, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 60;
            this.label10.Text = "Saat Dakika:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label11.Location = new System.Drawing.Point(23, 369);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 61;
            this.label11.Text = "File Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(237, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Aranan Deger: ";
            // 
            // btnBackToFolder
            // 
            this.btnBackToFolder.Location = new System.Drawing.Point(1024, 345);
            this.btnBackToFolder.Name = "btnBackToFolder";
            this.btnBackToFolder.Size = new System.Drawing.Size(136, 42);
            this.btnBackToFolder.TabIndex = 63;
            this.btnBackToFolder.Text = "Geri";
            this.btnBackToFolder.UseVisualStyleBackColor = true;
            this.btnBackToFolder.Click += new System.EventHandler(this.btnBackToFolder_Click);
            // 
            // btnDeleteSelectedFolder
            // 
            this.btnDeleteSelectedFolder.Location = new System.Drawing.Point(1164, 90);
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
            this.checkBoxShowSubFolderFiles.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.checkBoxShowSubFolderFiles.Location = new System.Drawing.Point(236, 366);
            this.checkBoxShowSubFolderFiles.Name = "checkBoxShowSubFolderFiles";
            this.checkBoxShowSubFolderFiles.Size = new System.Drawing.Size(278, 18);
            this.checkBoxShowSubFolderFiles.TabIndex = 65;
            this.checkBoxShowSubFolderFiles.Text = "Alt Klasörlerdeki Dosyalarıda Göster";
            this.checkBoxShowSubFolderFiles.UseVisualStyleBackColor = true;
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Location = new System.Drawing.Point(1183, 685);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(82, 13);
            this.linkLabelWeb.TabIndex = 66;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "MertKaplanBlog";
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // listBoxDestinationExplorer
            // 
            this.listBoxDestinationExplorer.FormattingEnabled = true;
            this.listBoxDestinationExplorer.Location = new System.Drawing.Point(703, 448);
            this.listBoxDestinationExplorer.Name = "listBoxDestinationExplorer";
            this.listBoxDestinationExplorer.Size = new System.Drawing.Size(561, 212);
            this.listBoxDestinationExplorer.TabIndex = 69;
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(703, 422);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(211, 20);
            this.txtBoxDestination.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label13.Location = new System.Drawing.Point(701, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 14);
            this.label13.TabIndex = 71;
            this.label13.Text = "Destination:";
            // 
            // btnCompressAndDeleteListedFiles
            // 
            this.btnCompressAndDeleteListedFiles.Location = new System.Drawing.Point(837, 666);
            this.btnCompressAndDeleteListedFiles.Name = "btnCompressAndDeleteListedFiles";
            this.btnCompressAndDeleteListedFiles.Size = new System.Drawing.Size(139, 40);
            this.btnCompressAndDeleteListedFiles.TabIndex = 72;
            this.btnCompressAndDeleteListedFiles.Text = "Listelenenleri Sıkıştır ve Sil";
            this.btnCompressAndDeleteListedFiles.UseVisualStyleBackColor = true;
            this.btnCompressAndDeleteListedFiles.Click += new System.EventHandler(this.btnCompressAndDeleteListedFiles_Click);
            // 
            // btnCompressListedFiles
            // 
            this.btnCompressListedFiles.Location = new System.Drawing.Point(704, 666);
            this.btnCompressListedFiles.Name = "btnCompressListedFiles";
            this.btnCompressListedFiles.Size = new System.Drawing.Size(127, 53);
            this.btnCompressListedFiles.TabIndex = 73;
            this.btnCompressListedFiles.Text = "Listelilenleri Destinationa Taşı ve Sıkıştır ";
            this.btnCompressListedFiles.UseVisualStyleBackColor = true;
            this.btnCompressListedFiles.Click += new System.EventHandler(this.btnCompressListedFiles_Click);
            // 
            // MertKaplanFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1354, 721);
            this.Controls.Add(this.btnCompressListedFiles);
            this.Controls.Add(this.btnCompressAndDeleteListedFiles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.listBoxDestinationExplorer);
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
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "MertKaplanFileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MK-Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ListBox listBoxDestinationExplorer;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCompressAndDeleteListedFiles;
        private System.Windows.Forms.Button btnCompressListedFiles;
    }
}

