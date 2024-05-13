using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace KYS
{
    public partial class Male : UserControl
    {
        public Male()
        {
            InitializeComponent();
        }

        Books _books = new Books();
        CustomerDal _customerDal = new CustomerDal();
        private void Male_Load(object sender, EventArgs e)
        {
            
        }
        string Trans = "";
        int total = 0;
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Trans += checkBox1.Text + ",";
                    total += 100;
                }
                if (checkBox2.Checked == true)
                {
                    Trans += checkBox2.Text + ",";
                    total += 50;
                }
                if (checkBox3.Checked == true)
                {
                    Trans += checkBox3.Text + ",";
                    total += 50;
                }
                if (checkBox4.Checked == true)
                {
                    Trans += checkBox4.Text + ",";
                    total += 30;
                }
                if (checkBox5.Checked == true)
                {
                    Trans += checkBox5.Text + ",";
                    total += 50;
                }
                if (checkBox6.Checked == true)
                {
                    Trans += checkBox6.Text + ",";
                    total += 25;
                }
                _customerDal.Add(new Customers
                {
                    Name = nameb.Text,
                    Surname = surnameb.Text,
                    Date = dateb.Text,
                    Transaction = Trans,
                    TransactionPrice = total
                });
                Trans = "";
                total = 0;
                MessageBox.Show("Randevu verildi");
                _books.load();
            }
            else
            {
                MessageBox.Show("Lütfen yapılacak işlemi seçiniz.");
            }
        }

        private void Male_Load_1(object sender, EventArgs e)
        {
            dateb.Text = "T:xx.xx.xxxx,S:xx.xx";
        }
    }
}
    

