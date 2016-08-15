using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch(count)
            {
                case 0:
                    count++;
                    pictureBox1.Image=WindowsFormsApplication2.Properties.Resources._0065080_large;
                    break;
                case 1:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources._1011744431;
                    break;
                case 2:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources._829200823_m;
                    break;
                case 3:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.BBkCpDX_img;
                    break;
                case 4:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.CLOCK;
                    break;
                case 5:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.original_152189161;
                    break;
                case 6:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.desktop;
                    break;
                case 7:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.DICK;
                    break;
                case 8:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.doom;
                    break;
                case 9:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.optiongirl;
                    break;
                case 10:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.original_157129051;
                    break;
                case 11:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.original_157129171;
                    break;
                case 12:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE16;
                    break;
                case 13:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE17;
                    break;
                case 14:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE19;
                    break;
                case 15:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE20;
                    break;
                case 16:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE24;
                    break;
                case 17:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE28;
                    break;
                case 18:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE29;
                    break;
                case 19:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE30;
                    break;
                case 20:
                    count++;
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.PICTURE27;
                    break;
        }
    }
}}

