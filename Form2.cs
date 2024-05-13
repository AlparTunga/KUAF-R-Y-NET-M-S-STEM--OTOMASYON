using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYS
{

    public partial class KYS2 : Form
    {
        Books _books = new Books();
        public KYS2()
        {
            InitializeComponent();
            male1.Visible = false;
            female1.Visible = false;
            books1.Visible = false;
            employeersInterface1.Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            male1.BringToFront();
            books1.Visible = false;
            male1.Visible = true;
            employeersInterface1.Visible = false;
            female1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeersInterface1.BringToFront();
            employeersInterface1.Visible = true;
            books1.Visible = false;
            female1.Visible = false;
            male1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            female1.BringToFront();
            books1.Visible = false;
            female1.Visible = true;
            employeersInterface1.Visible = false;
            male1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            books1.BringToFront();
            books1.Visible = true;
            employeersInterface1.Visible = false;
            male1.Visible = false;
            female1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            _books.load();
        }




    }
}
