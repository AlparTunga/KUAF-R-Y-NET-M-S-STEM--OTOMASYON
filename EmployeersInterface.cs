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
    
    public partial class EmployeersInterface : UserControl
    {
        EmployeersDal _employeers = new EmployeersDal();
        public EmployeersInterface()
        {
            InitializeComponent();
        }
        public void load()
        {
            dgwEmployeers.DataSource = _employeers.GetAll();
        }
        private void dgwEmployeers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbjup.Text=dgwEmployeers.CurrentRow.Cells[3].Value.ToString();
            tbsalup.Text= dgwEmployeers.CurrentRow.Cells[4].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            _employeers.Add(new Employeers
            {
                Name=tbn.Text,
                Surname=tbs.Text,
                Job=tbj.Text,
                Salary= Convert.ToInt32(tbsal.Text)
            });
              
        }

        private void upd_Click(object sender, EventArgs e)
        {
            Employeers employeers = new Employeers
            {
                Id = Convert.ToInt32(dgwEmployeers.CurrentRow.Cells[0].Value),
                Name = dgwEmployeers.CurrentRow.Cells[1].Value.ToString(),
                Surname = dgwEmployeers.CurrentRow.Cells[2].Value.ToString(),
                Job = tbjup.Text,
                Salary=Convert.ToInt32(tbsalup.Text)
            };
            _employeers.Update(employeers);
            load();
            tbjup.Clear();
            tbsalup.Clear();
            
            MessageBox.Show("Çalışan bilgileri güncellendi.");
        }

        private void dlt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwEmployeers.CurrentRow.Cells[0].Value);
            _employeers.Delete(id);
            load();          
            MessageBox.Show("Çalışan silindi.");
            tbjup.Clear();
            tbsalup.Clear();
        }

        private void rnw_Click(object sender, EventArgs e)
        {
            load();
        }

        private void EmployeersInterface_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}

