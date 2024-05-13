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
    public partial class Female : UserControl
    {
        public Female()
        {
            InitializeComponent();
        }
        CustomerDal _customerDal = new CustomerDal();
        string Trans = "";
        int total = 0;
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Trans += checkBox1.Text + ",";
                    total += 200;
                }
                if (checkBox2.Checked == true)
                {
                    Trans += checkBox2.Text + ",";
                    total += 100;
                }
                if (checkBox3.Checked == true)
                {
                    Trans += checkBox3.Text + ",";
                    total += 75;
                }
                if (checkBox4.Checked == true)
                {
                    Trans += checkBox4.Text + ",";
                    total += 200;
                }
                if (checkBox5.Checked == true)
                {
                    Trans += checkBox5.Text + ",";
                    total += 350;
                }
                if (checkBox6.Checked == true)
                {
                    Trans += checkBox6.Text + ",";
                    total += 50;
                }
                if (checkBox7.Checked == true)
                {
                    Trans += checkBox7.Text + ",";
                    total += 450;
                }
                if (checkBox8.Checked == true)
                {
                    Trans += checkBox8.Text + ",";
                    total += 200;
                }
                _customerDal.Add(new Customers
                {
                    Name = nameb.Text,
                    Surname = surnameb.Text,
                    Date = dateb.Text,
                    Transaction = Trans,
                    TransactionPrice = total
                });
                MessageBox.Show("Randevu verildi");
            }
        }

        private void Female_Load(object sender, EventArgs e)
        {
            dateb.Text = "T:xx.xx.xxxx,S:xx.xx";
        }
    }
}

