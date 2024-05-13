using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYS
{
    public partial class Books : UserControl
    {
        CustomerDal _customerDal = new CustomerDal();
        public Books()
        {
            InitializeComponent();
        }
        
        public void load()
        {
            dgwCustomers.DataSource = _customerDal.GetAll();
        }
        private void Books_Load(object sender, EventArgs e)
        {
            dgwCustomers.DataSource = _customerDal.GetAll();
            tbd.Text = "T:xx.xx.xxxx,S:xx.xx";
        }

        private void btsrc_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers
            {
                Id = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value),
                Name = tbi.Text,
                Surname = tbsi.Text,
                Transaction = dgwCustomers.CurrentRow.Cells[3].Value.ToString(),
                TransactionPrice = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[4].Value),
                Date = tbd.Text
            };
            _customerDal.Update(customer);
            dgwCustomers.DataSource = _customerDal.GetAll();
            tbi.Clear();
            tbsi.Clear();
            tbd.Clear();
            MessageBox.Show("Randevu durumu güncellendi.");
            tbd.Text = "T:xx.xx.xxxx,S:xx.xx";

        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbd.Clear();
            tbi.Text = dgwCustomers.CurrentRow.Cells[1].Value.ToString();
            tbsi.Text = dgwCustomers.CurrentRow.Cells[2].Value.ToString();
            tbd.Text = dgwCustomers.CurrentRow.Cells[5].Value.ToString();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value);
            _customerDal.Delete(id);
            dgwCustomers.DataSource = _customerDal.GetAll();
            tbi.Clear();
            tbsi.Clear();
            tbd.Clear();
            MessageBox.Show("Randevu silindi.");
            tbd.Text = "T:xx.xx.xxxx,S:xx.xx";
        }

        private void renew_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
