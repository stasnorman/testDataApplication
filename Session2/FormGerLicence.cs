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
    public partial class FormGerLicence : Form
    {
        private int _errors;

        public FormGerLicence()
        {
            InitializeComponent();
        }

        private void FormGerLicence_Load(object sender, EventArgs e)
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
                                             d.LicenceId
                                         }).ToList();

            dataGridViewF1.Columns[3].Visible = false;

            foreach (DataGridViewRow item in dataGridViewF1.Rows)
            {
                if (!string.IsNullOrWhiteSpace(item.Cells[3].Value.ToString()))
                {
                    item.DefaultCellStyle.BackColor = Color.FromArgb(255, 170, 172);
                }
            }
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
                var driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == p);

                new FormCadLicence(p).ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new FormCadLicence().ShowDialog();
            Show();
        }
    }
}
