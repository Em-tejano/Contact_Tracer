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

namespace Contact_Tracer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOky_Click(object sender, EventArgs e)
        {
            string NameVar;
            if (MidNameBox.Text.Length > 0)
            {
                NameVar = LstNameBox.Text + ", " + FrstNameBox.Text + ", " + MidNameBox;
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
                MidNameBox.Text = "";
            }
            else
            {
                NameVar = LstNameBox.Text + ", " + FrstNameBox.Text;
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
            }
            string pth = Environment.CurrentDirectory + "/" + "List";
            DirectoryInfo Newpth;
            Newpth = Directory.CreateDirectory(pth);
            StreamWriter OutputFile;
            DateTime date = DateTime.Now;
            OutputFile = File.AppendText(Newpth + "/" + NameVar);
            OutputFile.WriteLine("=====" + date + "=====");
            OutputFile.WriteLine();
            
        }
    }
}
