using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class FormHistoryLicence : Form
    {
        private int _errors;

        public FormHistoryLicence()
        {
            InitializeComponent();
        }

        private void FormHistoryLicence_Load(object sender, EventArgs e)
        {
            Carrega();

        }

        private void Carrega()
        {
            dataGridViewF1.DataSource = (from d in Db.db.Driver.ToList()
                                         select new
                                         {
                                             d.Identifier,
                                             Name = $"{d.Name} {d.MiddleName} {d.Surname}",
                                             d.Email,
                                             Licence_Status = d.Licence.Status,
                                             Licence_Categories = d.Licence.Categories,
                                         }).ToList();

            dataGridViewF1.Columns[0].Visible = false;

            foreach (DataGridViewColumn item in dataGridViewF1.Columns)
            {
                item.HeaderText = item.HeaderText.Replace("_", " ");
            }
        }



        private void back(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var p = 0;
            try
            {
                p = (dataGridViewF1.SelectedRows[0].Cells[0].Value as Int32?) ?? 0;
            }
            catch (Exception)
            {
            }

            if (p > 0)
            {
                Hide();
                new FormLicenceInfo(p).ShowDialog();
                Show();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
            
        }
    }
}
