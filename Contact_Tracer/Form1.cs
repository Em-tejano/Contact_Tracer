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
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper() + ", " + MidNameBox.Text.ToUpper();
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
                MidNameBox.Text = "";
            }
            else
            {
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper();
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
            }
            string pth = Environment.CurrentDirectory + "/" + "List";
            DirectoryInfo Newpth;
            Newpth = Directory.CreateDirectory(pth);
            StreamWriter OutputFile;
            DateTime date = DateTime.Now;
            OutputFile = File.AppendText(Newpth + "/" + NameVar + ".txt");
            OutputFile.WriteLine("=====" + date + "=====");
            OutputFile.WriteLine("Age: " + AgeBox.Text.ToUpper());
            OutputFile.WriteLine("Address: " + BrgyBox.Text.ToUpper() + ", " + CityBox.Text.ToUpper() + ", " + ProvinceBox.Text.ToUpper());
            OutputFile.Close();
            AgeBox.Text = "";
            CityBox.Text = "";
            BrgyBox.Text = "";
            ProvinceBox.Text = "";
        }

        private void Reader_Click(object sender, EventArgs e)
        {
            AgeBox.Visible = false;
            AgeLabel.Visible = false;
            BrgyBox.Visible = false;
            brgyLabel.Visible = false;
            CityBox.Visible = false;
            cityLabel.Visible = false;
            ProvinceBox.Visible = false;
            provinceLabel.Visible = false;
            Instructions.Visible = false;
            string NameVar;
            if (MidNameBox.Text.Length > 0)
            {
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper() + ", " + MidNameBox.Text.ToUpper();
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
                MidNameBox.Text = "";
            }
            else
            {
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper();
                LstNameBox.Text = "";
                FrstNameBox.Text = "";
            }
            if (NameVar.Length == 0 || NameVar.Equals(null))
            {
                if (NameVar.Length == 0)
                {
                    MessageBox.Show("Input the name first!");
                }
                else
                {
                    MessageBox.Show("Input data first!");
                }
            }
            else 
            {
                string pth = Environment.CurrentDirectory + "/" + "List";
                StreamReader fileReader;
                fileReader = File.OpenText(pth + "/" + NameVar + ".txt");
                while (!fileReader.EndOfStream)
                {
                    DataLabel.Text += fileReader.ReadLine() + "\n";
                } 
            }
        }
    }
}
