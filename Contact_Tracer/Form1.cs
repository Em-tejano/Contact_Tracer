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
            btnOky.Visible = false;
            btnAdd.Visible = true;
            ListlistBox.Visible = true;
            string NameVar;
            if (MidNameBox.Text.Length > 0)
            {
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper() + ", " + MidNameBox.Text.ToUpper();
                //LstNameBox.Text = "";
                //FrstNameBox.Text = "";
                //MidNameBox.Text = "";
            }
            else
            {
                NameVar = LstNameBox.Text.ToUpper() + ", " + FrstNameBox.Text.ToUpper();
                //LstNameBox.Text = "";
                //FrstNameBox.Text = "";
            }
            string pth = Environment.CurrentDirectory + "/" + "List";
            StreamReader fileReader;
            if (NameVar.Length > 2)
            {
                if (!Directory.Exists(Environment.CurrentDirectory + "/" + "List"))
                {
                    MessageBox.Show("Input a data first!");
                }
                else
                {
                    try
                    {
                        fileReader = File.OpenText(pth + "/" + NameVar + ".txt");
                        //while (!fileReader.EndOfStream)
                        //{
                            ListlistBox.Items.Add(fileReader.ReadLine() + "\n");
                        //}
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The name does not exist in the database!");
                    }
                }
                
            }
            else
            {
                
            }
            LstNameBox.Text = "";
            FrstNameBox.Text = "";
            MidNameBox.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgeBox.Visible = true;
            AgeLabel.Visible = true;
            BrgyBox.Visible = true;
            brgyLabel.Visible = true;
            CityBox.Visible = true;
            cityLabel.Visible = true;
            ProvinceBox.Visible = true;
            provinceLabel.Visible = true;
            Instructions.Visible = true;
            btnOky.Visible = true;
            btnAdd.Visible = false;
            ListlistBox.Visible = false;
            ListlistBox.Items.Clear();
        }
    }
}
