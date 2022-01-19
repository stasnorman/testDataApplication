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
    public partial class FormHistoryVehicle : Form
    {
        private int _errors;

        public FormHistoryVehicle()
        {
            InitializeComponent();
        }

        private void FormHistoryVehicle_Load(object sender, EventArgs e)
        {
            Carrega();

        }

        private void Carrega()
        {
            dataGridViewF1.DataSource = (from d in Db.db.Vehicle.ToList()
                                         select new
                                         {
                                             d.Id,
                                             d.VIN,
                                             Driver = d.Driver.Name,
                                             d.Year
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
                new FormVehicleInfo(p).ShowDialog();
                Show();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select a Vehicle");
            }
            
        }
    }
}
