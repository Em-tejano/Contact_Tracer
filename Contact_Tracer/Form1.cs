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
                NameVar = LstNameBox.Text + "," + FrstNameBox.Text + "," + MidNameBox;
            }
            else
            {
                NameVar = LstNameBox.Text + "," + FrstNameBox.Text;
            }
            StreamWriter outputfile;
            outputfile = File.AppendText("Data.txt");
            StreamReader filetxt;
            filetxt = File.OpenText("Data.txt");
            if (File.Exists(NameVar))
            {

            }
            outputfile.WriteLine("Name: " + NameVar);

        }
    }
}
