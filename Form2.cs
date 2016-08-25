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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "İş kontrol ediliyor";
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
    }
}
