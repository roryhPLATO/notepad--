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
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace diaryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // change look and feel to something more modern for final build
        // if its not hard make it so form2 closes when an app is opened
        // add a "home" button????
        // nvm maybe dont you only have like 2 days left dumbass

        private void btnOk_Click(object sender, EventArgs e)
        {
            //File.WriteAllText("tempname.txt", txtEntry.Text);
            //txtEntry.Clear();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DOCNAME.txt"), true))
            {
                outputFile.WriteLine(txtEntry.Text);
            }

            txtEntry.Clear();

            // probably change directory or make it so users can choose directory in final build
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEntry.Clear();
            txtEntry.Focus();

        }

        // remove thread sleep in final build
        private void btnEnd_Click(object sender, EventArgs e)
        {

            Thread.Sleep(2000);
            this.Close();
        }

        // maybe fix this in final build
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        //ignore
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
