using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileManagerPro.App
{
    public partial class MertKaplanFileManager : Form
    {
        public MertKaplanFileManager()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        void CheckFolderCreated()
        {
            string _ProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string _MertKaplanFileManagerFolder = _ProgramFilesPath + @"\MertKaplanFileManagerFolder";
            string _PathText = _MertKaplanFileManagerFolder + @"\Path.txt";
            string _LogFolder = _MertKaplanFileManagerFolder + @"\Logs\";

            //Klasör yoksa MertKaplanFileManagerFolder Klasör oluştur, varsa bir şey yapma.
            if (!Directory.Exists(_MertKaplanFileManagerFolder))
            {
                Directory.CreateDirectory(_MertKaplanFileManagerFolder);
            }
            else
            {
            }

            //Desktopun içerisinde Mert Kaplan File Manager Folder içinde Path.txt yoksa....
            if (File.Exists(_PathText) == false)
            {
                File.WriteAllText(_PathText, _PathText);
                txtboxFolder.Text = File.ReadAllText(_PathText).ToString();
                txtboxFolder.Text = Path.GetDirectoryName(_PathText).ToString();
            }
            else 
            if(File.Exists(_PathText)==true) //eğer path.txt varsa
            {
                //bu path'i txtbox'a ata
                txtboxFolder.Text = File.ReadAllText(_PathText).ToString();

                //txt box'a atanan bu path bir dizin midir yoksa file midir kontrol et
                //eğer file ise, file'in pathini al
                if (File.Exists(txtboxFolder.Text))
                {
                    txtboxFolder.Text = Path.GetDirectoryName(txtboxFolder.Text).ToString();
                }
                //file değilse bir directory ise directory'nin dizinini al
                else if (Directory.Exists(txtboxFolder.Text))
                {
                    txtboxFolder.Text = Path.GetFullPath(txtboxFolder.Text);
                }
                else { }
            }
            else { label1.Text = "Bir hata oluştu"; }
         

            if (!Directory.Exists(_LogFolder))
            {
                Directory.CreateDirectory(_LogFolder);

            }
            else
            { }
        }

        void InitializeAllFiles()
        {
            string _MertKaplanFileManagerFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MertKaplanFileManagerFolder";
            string[] files = Directory.GetFiles(txtboxFolder.Text, "*", SearchOption.AllDirectories);
            DateTime LogFileDate = DateTime.Now.Date;
            DateTime LogFileHourMin = DateTime.Now;
            //save log path
            string logfilename = LogFileDate.ToString("D") + " " + LogFileHourMin.ToString("HH.mm.ss") + ".txt";
            File.WriteAllText(_MertKaplanFileManagerFolder+@"\Logs\" + logfilename, "Files Log Created At " + DateTime.Now + Environment.NewLine);
            foreach (string _Path in files)
            {
                FileInfo file = new FileInfo(_Path);
                File.AppendAllText(_MertKaplanFileManagerFolder + @"\Logs\" + logfilename, file.Name + " " + file.FullName + " " + file.Extension + " " + file.CreationTime + " " + file.LastWriteTime + Environment.NewLine);
            }
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            CheckFolderCreated();
            InitializeAllFiles();
            DefaultClock();
            fillDetailsFromTextBox(getPathFromTextBox());
            getFolders();
            getFolderFiles();
            
        }

      

        //old functions before v4  ///
        string getPathFromTextBox()
        {
            string path = txtboxFolder.Text;
            return path;
        }

        void fillDetailsFromTextBox(string path)
        {
            path = getPathFromTextBox();
            FileInfo file = new FileInfo(path);
            txtboxFileName.Text = file.Name;
            txtboxFolder.Text = file.FullName;
            txtboxFileType.Text = file.Extension;
            txtboxCreatedDate.Text = (file.CreationTime).ToString();
            txtboxModifiedDate.Text = (file.LastWriteTime).ToString();
        }

        void getFolderFiles()
        {

            string[] allTypeOfFiles = Directory.GetFiles(getPathFromTextBox(), "*");
            listBoxDirectoryFiles.Items.AddRange(allTypeOfFiles);

        }

        void getFolders()
        {
            string[] getFoldersArray = Directory.GetDirectories(getPathFromTextBox(), "*");
            listBoxDirectoryFiles.Items.AddRange(getFoldersArray);
        }

        //Get path from list box and send.
        void getPathFromSelectedItemSender(string selectedFileWithItem)
        {
            fillDetailsBySelected(selectedFileWithItem);
        }

        //For the selected item, Update details with this function
        void fillDetailsBySelected(string path)
        {
            if (path == "")
            {
                path = txtboxFolder.Text;
            }
            FileInfo file = new FileInfo(path);
            ///IMPORTANT AREA

            txtboxFileName.Text = file.Name;
            txtboxFolder.Text = file.FullName;
            txtboxFileType.Text = file.Extension;
            txtboxCreatedDate.Text = (file.CreationTime).ToString();
            txtboxModifiedDate.Text = (file.LastWriteTime).ToString();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (checkPathExit() == false)
                return;
            else
            {
                listBoxDirectoryFiles.Items.Clear();
                fillDetailsFromTextBox(getPathFromTextBox());
                getFolders();
                getFolderFiles();

            }
        }

        public bool checkPathExit()
        {
            bool condition;
            if (Directory.Exists(getPathFromTextBox()))
            {
                if (Directory.GetDirectories(getPathFromTextBox()).Length != 0 && Directory.GetFiles(getPathFromTextBox()).Length != 0)
                {
                    label1.Text = "Dosya ve file bulundu";
                    condition = true;
                }
                else if (Directory.GetDirectories(getPathFromTextBox()).Length != 0 && Directory.GetFiles(getPathFromTextBox()).Length == 0)
                {
                    label1.Text = "Dizin bulundu dosya bulunamadı";
                    condition = true;
                }
                else if (Directory.GetDirectories(getPathFromTextBox()).Length == 0 && Directory.GetFiles(getPathFromTextBox()).Length != 0)
                {
                    label1.Text = "Dizin bulunamadi dosya bulundu";
                    condition = true;
                }
                else
                {
                    label1.Text = "Dosya veya Dizin Bulunamadi";
                    condition = true;
                }
            }
            else
            { condition = false; }
            return condition;
        }

        private void listBoxDirectoryFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBoxDirectoryFiles.GetItemText(listBoxDirectoryFiles.SelectedItem);
            getPathFromSelectedItemSender(text);
        }

        private void btnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            //Sil ve sonra listele
        
                if (checkIsSelectedAFile() == true) { 
            string beforeDeletingFolder = Path.GetDirectoryName(getPathFromTextBox());
            File.Delete(getPathFromTextBox());
            listBoxDirectoryFiles.Items.Clear();
            fillDetailsBySelected(beforeDeletingFolder);
            getFolders();
            getFolderFiles();
                }
                else
                {
                    label1.Text = "Lütfen bir dosya seçiniz.";
                }
         }
            
      

        private void btnDeleteSelectedFolder_Click(object sender, EventArgs e)
        {
            string beforeDeletingFolder = Path.GetDirectoryName(getPathFromTextBox());
            if (checkPathExit() == true)
            {
                try
            {
                    
                 DirectoryInfo _DirectoryInfo = new DirectoryInfo(getPathFromTextBox());
                    if (checkIsSelectedAFolder() == true)
                    { _DirectoryInfo.Delete();
                        label1.Text = "Silinme başarılı";
                    }
                    else
                        label1.Text = "Lütfen bir folder seçiniz.";
            }

            catch (IOException)
            {
                Directory.Delete(getPathFromTextBox(), true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(getPathFromTextBox(), true);
            }
            }
            else { label1.Text = "Lütfen bir folder seçiniz"; }
            txtboxFolder.Text = beforeDeletingFolder;
            fillDetailsFromTextBox(beforeDeletingFolder);
            listBoxDirectoryFiles.Items.Clear();
            getFolders();
            getFolderFiles();
        }

        void DefaultClock()
        {
            txtHourEntered.Text = "00";
            txtMinEntered.Text = "00";
        }
        private void btnDeleteOnlyCurrentFolderFolders_Click(object sender, EventArgs e)
        {


            string[] Directories = Directory.GetDirectories(getPathFromTextBox(), "*");

            if (checkPathExit() == true)
            {
                foreach (string _Path in Directories)
                {
                    try
                    {
                        DirectoryInfo _DirectoryInfo = new DirectoryInfo(_Path);
                        _DirectoryInfo.Delete();
                        label1.Text = "Dizinin içerisindeki tüm klasör ve alt klasörler silindi.";
                    }

                    catch (IOException)
                    {
                        Directory.Delete(_Path, true);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Directory.Delete(_Path, true);
                    }
                }
                listBoxDirectoryFiles.Items.Clear();
                fillDetailsFromTextBox(getPathFromTextBox());
                getFolderFiles();
                getFolders();
            }
            else { label1.Text = "İşlem başarısız"; }
        }
        private void btnDeleteAllSubCategories_Click(object sender, EventArgs e)
        {

            string beforeDeletingFolder = Path.GetDirectoryName(getPathFromTextBox());
            if (checkPathExit() == true)
            {
                Directory.Delete(getPathFromTextBox(), recursive: true);
            }
            listBoxDirectoryFiles.Items.Clear();
            txtboxFolder.Text = beforeDeletingFolder;
            getFolderFiles();
            getFolders();
            fillDetailsFromTextBox(beforeDeletingFolder);
        }

        private void btnDeleteOnlyFolderFiles_Click(object sender, EventArgs e)
        {

            if (checkPathExit() == true)
            {
                DirectoryInfo _DirectoryInfo = new DirectoryInfo(getPathFromTextBox());
                foreach (FileInfo _FileInfo in _DirectoryInfo.GetFiles())
                {
                    label1.Text = "Klasör İçindeki Tüm Dosyalar Silindi";
                    _FileInfo.Delete();
                }
                listBoxDirectoryFiles.Items.Clear();
                fillDetailsFromTextBox(getPathFromTextBox());
                getFolders();

            }
            else { }
        }

        private void btnDeleteFilesUnderSubFolders_Click(object sender, EventArgs e)
        {

            if (checkPathExit() == true)
            {
                string[] _Files = Directory.GetFiles(getPathFromTextBox(), "*", SearchOption.AllDirectories);
                foreach (string _Path in _Files)
                {
                    FileInfo _FileInfo = new FileInfo(_Path);
                    _FileInfo.Delete();
                }
                listBoxDirectoryFiles.Items.Clear();
                getFolders();
                getFolderFiles();

            }
        }

        private void btnBackToFolder_Click(object sender, EventArgs e)
        {
            string _CdDOTDOT = Path.GetDirectoryName(getPathFromTextBox());
            txtboxFolder.Text = _CdDOTDOT;
            listBoxDirectoryFiles.Items.Clear();
            fillDetailsFromTextBox(_CdDOTDOT);
            getFolders();
            getFolderFiles();
        }

        bool IsNumeric(string _enteredValue)
        {
            foreach (char letter in _enteredValue)
            {
                if (!Char.IsNumber(letter)) return false;
            }
            return true;
        }

        
        void GetUserEnteredParameters()
        {
            
            string path = getPathFromTextBox();
            if (path == null)
            { path = @"C:\\"; }
            else 
                
            {
                DateTime _UserSelectedDate = datePicker.Value;

             
                int _Hour = Convert.ToInt32(txtHourEntered.Text);
                int _Time = Convert.ToInt32(txtMinEntered.Text);
                TimeSpan _TimeSpan = new TimeSpan(_Hour, _Time, 0);
                DateTime _AfterTimeSpan = _UserSelectedDate.Date + _TimeSpan;
             

                string UserEnteredFileType = "*"+ txtEnterFileTypeForList.Text;
                if (checkBoxShowSubFolderFiles.Checked == false)
                {
                    string[] files = Directory.GetFiles(path, UserEnteredFileType);
                    foreach (string _Path in files)
                    {
                        FileInfo file = new FileInfo(_Path);
                        if (file.CreationTime < _AfterTimeSpan)
                        {
                            File.Delete(_Path);
                        }
                        else
                        {
                            label12.Text = "Silinecek Dosya Bulunamadı.";
                        }
                    }
                    listBoxParameters.Items.AddRange(files);
                }
                else
                { string[] files = Directory.GetFiles(path, UserEnteredFileType, SearchOption.AllDirectories); 
                foreach (string _Path in files)
                {
                    FileInfo file = new FileInfo(_Path);
                    if(file.CreationTime<_AfterTimeSpan)
                    {
                        File.Delete(_Path);
                    }
                    else
                    {
                        label12.Text = "Silinecek Dosya Bulunamadı.";
                    }
                }
                listBoxParameters.Items.AddRange(files);
            }
            }
        }
        void ShowRequestedFiles(DateTime EnteredDate, int EnteredHour, int EnteredMin, string enteredType)
        {
            listBoxParameters.Items.Clear();
            if (EnteredHour < 24 && EnteredMin < 60)
            {
                TimeSpan _TimeSpan = new TimeSpan(EnteredHour, EnteredMin, 0);
                DateTime DeleteFileIfOldThenThis = EnteredDate.Date + _TimeSpan;
                label12.Text = "Aşağıdaki gördüğünüz dosyaların\nKlasörü: "+ getPathFromTextBox() + " 'dedir\nUzantısı: " + enteredType + " olan tüm dosyalardır\n" + DeleteFileIfOldThenThis.ToString() + "'dan eskidir:";
                string txtboxpath = getPathFromTextBox();

                string[] selectedFilesList= Directory.GetFiles(txtboxpath, "*"+txtEnterFileTypeForList.Text);
                foreach (string _Path in selectedFilesList)
                {
                    FileInfo file = new FileInfo(_Path);
                    if(file.CreationTime<DeleteFileIfOldThenThis)
                    {
                        listBoxParameters.Items.Add(_Path);
                    }
                }




                //string[] files = Directory.GetFiles(getPathFromTextBox(), "*" + enteredType);
                //listBoxParameters.Items.Clear();
                //listBoxParameters.Items.AddRange(files);
            }
            else
            {
                label1.Text = "Girdiğiniz saati kontrol edin.";
            }
        }

        void ShowRequestedFilesAndSubFolderFiles(DateTime EnteredDate, int EnteredHour, int EnteredMin, string enteredType)
        {
            listBoxParameters.Items.Clear();
            if (EnteredHour < 24 && EnteredMin < 60)
            {
                TimeSpan _TimeSpan = new TimeSpan(EnteredHour, EnteredMin, 0);
                DateTime DeleteFileIfOldThenThis = EnteredDate.Date + _TimeSpan;
                label12.Text = "Aşağıdaki gördüğünüz dosyaların\nKlasörleri: " + getPathFromTextBox() + " ve alt klasörlerindedir.\nUzantısı: " + enteredType + " olan tüm dosyalardır\n" + DeleteFileIfOldThenThis.ToString() + "'dan eskidir:";
                string txtboxpath = getPathFromTextBox();

                string[] selectedFilesList = Directory.GetFiles(txtboxpath, "*" + txtEnterFileTypeForList.Text, SearchOption.AllDirectories);
                foreach (string _Path in selectedFilesList)
                {
                    FileInfo file = new FileInfo(_Path);
                    if (file.CreationTime < DeleteFileIfOldThenThis)
                    {
                        listBoxParameters.Items.Add(_Path);
                    }
                }




                //string[] files = Directory.GetFiles(getPathFromTextBox(), "*" + enteredType);
                //listBoxParameters.Items.Clear();
                //listBoxParameters.Items.AddRange(files);
            }
            else
            {
                label12.Text = "Girdiğiniz saati kontrol edin.";
            }
        }


        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if(checkIsSelectedAFile()==true)
            {
                label12.Text = "Bir dosya seçtiniz. Lütfen bir folder seçiniz.";
                listBoxParameters.Items.Clear();
            }
            else
            { 
            DateTime UserSelectedDate = datePicker.Value;
                if (checkBoxShowSubFolderFiles.Checked == false)
                {
                    if (IsNumeric(txtHourEntered.Text) == true && IsNumeric(txtMinEntered.Text) == true)
                        ShowRequestedFiles(UserSelectedDate, Convert.ToInt32(txtHourEntered.Text), Convert.ToInt32(txtMinEntered.Text), txtEnterFileTypeForList.Text);
                    else
                        label1.Text = "Saate karakter girdiniz. Lütfen nümerik bir değer girin.";
                }
                else
                {
                    if (IsNumeric(txtHourEntered.Text) == true && IsNumeric(txtMinEntered.Text) == true)
                        ShowRequestedFilesAndSubFolderFiles(UserSelectedDate, Convert.ToInt32(txtHourEntered.Text), Convert.ToInt32(txtMinEntered.Text), txtEnterFileTypeForList.Text);
                    else
                        label1.Text = "Saate karakter girdiniz. Lütfen nümerik bir değer girin.";
                    
                }
            }
        }

        bool checkIsSelectedAFile()
        {
            FileInfo _FileInfo = new FileInfo(getPathFromTextBox());
            if (_FileInfo.Exists)
            {
                return true;
            }
            else { return false; }
        }

        bool checkIsSelectedAFolder()
        {
            DirectoryInfo _DirectoryInfo = new DirectoryInfo(getPathFromTextBox());
            if(_DirectoryInfo.Exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void deleteBeforeThisDateBtn_Click(object sender, EventArgs e)
        {
            
            GetUserEnteredParameters();
            listBoxParameters.Items.Clear();
            listBoxDirectoryFiles.Items.Clear();
            fillDetailsFromTextBox(getPathFromTextBox());
            getFolders();
            getFolderFiles();
        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mertkaplanblog.wordpress.com");
        }

        ///TEK ZAMANA INDIRGE SU ANDA DEFAULTU DATETIMENOW YAP 
        ///SEARCH ISLEMI TEK LISTBOXDA OLSUN

    }
}
