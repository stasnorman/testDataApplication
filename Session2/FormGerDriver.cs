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
    public partial class FormGerDriver : Form
    {
        private int _errors;

        public FormGerDriver()
        {
            InitializeComponent();
        }

        private void FormGerDriver_Load(object sender, EventArgs e)
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
                                             d.Email
                                         }).ToList();
        }

        private void edit(object sender, EventArgs e)
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
                new FormCadDriver(p).ShowDialog();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select a Driver");
            }
        }

        private void back(object sender, EventArgs e)
        {
            Close();
        }
    }
}
