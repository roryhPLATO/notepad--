using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //ignore
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        // fix in next build
        private void btnColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.HotPink;
            btnColor.BackColor = Color.HotPink;
            btnKill.BackColor = Color.HotPink;
            btnOk.BackColor = Color.HotPink;
            label1.BackColor = Color.HotPink;
            label1.ForeColor= Color.HotPink;
            btnOk.ForeColor= Color.HotPink;
            btnColor.ForeColor = Color.HotPink;
            btnKill.ForeColor = Color.HotPink;
            nickName.BackColor = Color.HotPink;
            btnDate.BackColor = Color.HotPink;
            button2.BackColor = Color.HotPink;
            btnSound.BackColor = Color.HotPink;
            btnSound.ForeColor = Color.HotPink;
            btnDate.ForeColor = Color.HotPink; 
            button2.ForeColor = Color.HotPink;
           
        }

        // change name in final build
        private void btnKill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            Form4 form4= new Form4();
            form4.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // haha nice
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
