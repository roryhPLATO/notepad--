﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // change button names to song names
        // add images?
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Program Files (x86)\diaryProject\diaryProject\sounds\sound1.wav");
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Program Files (x86)\diaryProject\diaryProject\sounds\sound2.wav");
            player1.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"C:\Program Files (x86)\diaryProject\diaryProject\sounds\sound3.wav");
            player2.Play();
        }

        //ignore smh
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
