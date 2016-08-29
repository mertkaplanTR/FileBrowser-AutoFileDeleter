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
using System.IO.Compression;

namespace FileManagerPro.App
{
    public partial class Form2 : Form
    {
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtBoxSourceFolder;
        private TextBox txtBoxDestinationFolder;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtFileSearchWhatKindOfTypeWillMove;
        private Label label4;
        private IContainer components;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "İş kontrol ediliyor";
            txtBoxSourceFolder.Text = @"C:\Users\Unknown\Desktop\testfolder\";
            txtBoxDestinationFolder.Text= @"C:\Users\Unknown\Desktop\testfolder\tasinacakfolder\";
            checkEverySecond();
            CheckFolderCreated();

        }

        void CheckFolderCreated()
        {
            string _ProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string _MertKaplanFileManagerFolder = _ProgramFilesPath+@"\MertKaplanFileManagerFoder";
            string _PathText = _MertKaplanFileManagerFolder+@"\Path.txt";
            string _LogFolder= _MertKaplanFileManagerFolder+@"\Logs\";
           
            if(!Directory.Exists(_MertKaplanFileManagerFolder))
            {
                Directory.CreateDirectory(_MertKaplanFileManagerFolder);
               
            }
           

             if(!File.Exists(_PathText))
            {
                File.WriteAllText(_PathText, _PathText);
              
            }
          

             if(!Directory.Exists(_LogFolder))
            {
                Directory.CreateDirectory(_LogFolder);
               
            }
         
            

        }

        void checkEverySecond()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime _alinan = new DateTime(2016, 08, 23, 10, 05, 45);
            if (_alinan <= DateTime.Now)
            {
                label1.Text = "Baslattim isi";
                
            }
               
            else
                label1.Text = "Daha zamanı var";
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.txtBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileSearchWhatKindOfTypeWillMove = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtBoxSourceFolder
            // 
            this.txtBoxSourceFolder.Location = new System.Drawing.Point(12, 86);
            this.txtBoxSourceFolder.Name = "txtBoxSourceFolder";
            this.txtBoxSourceFolder.Size = new System.Drawing.Size(340, 20);
            this.txtBoxSourceFolder.TabIndex = 1;
            // 
            // txtBoxDestinationFolder
            // 
            this.txtBoxDestinationFolder.Location = new System.Drawing.Point(358, 86);
            this.txtBoxDestinationFolder.Name = "txtBoxDestinationFolder";
            this.txtBoxDestinationFolder.Size = new System.Drawing.Size(340, 20);
            this.txtBoxDestinationFolder.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination Folder:";
            // 
            // txtFileSearchWhatKindOfTypeWillMove
            // 
            this.txtFileSearchWhatKindOfTypeWillMove.Location = new System.Drawing.Point(15, 145);
            this.txtFileSearchWhatKindOfTypeWillMove.Name = "txtFileSearchWhatKindOfTypeWillMove";
            this.txtFileSearchWhatKindOfTypeWillMove.Size = new System.Drawing.Size(337, 20);
            this.txtFileSearchWhatKindOfTypeWillMove.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(714, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileSearchWhatKindOfTypeWillMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxDestinationFolder);
            this.Controls.Add(this.txtBoxSourceFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ZipFile.CreateFromDirectory(textBox1.Text, textBox2.Text + @"\DEMO.zip");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\temp\");
            string[] files = Directory.GetFiles(txtBoxSourceFolder.Text, "*" + txtFileSearchWhatKindOfTypeWillMove.Text);
            foreach (string _Path in files)
            {
                FileInfo file = new FileInfo(_Path);
                //string filename = file.Name;
                //string destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp\";
                //string fullpath = filename + destination;
                // file.MoveTo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp\"+ file.Name);
                file.MoveTo(txtBoxDestinationFolder.Text + file.Name);
            }

            // Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp");

        }
    }
}
