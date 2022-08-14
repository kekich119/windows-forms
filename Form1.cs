using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = button2.Location.X;
            int y = button2.Location.Y;
            
            if (x < 10)
            {
                button2.Location = new System.Drawing.Point(100, y);
            }
            else
            {
                button2.Location = new System.Drawing.Point(x - 10, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("Я ТАК И ЗНАЛ!!!");
        }
    }
    }
