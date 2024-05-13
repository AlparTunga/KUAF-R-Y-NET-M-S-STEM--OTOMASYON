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
    public partial class Form1 : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ext_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Are your sure?","Exiting",MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes) 
            { 
                Application.Exit(); 
            }
        }
        
        private void log_Click(object sender, EventArgs e)
        {
            if(tb1.Text=="1" && tb2.Text == "1")
            {      
            KYS2 frm = new KYS2();
            frm.Show();
            this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please try again.");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
