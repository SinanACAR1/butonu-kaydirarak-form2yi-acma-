using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x = x + 5;
            
            }


            pictureBox1.Location = new Point(x, y);

            if (pictureBox1.Right > pictureBox2.Right)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

     
    }
}
