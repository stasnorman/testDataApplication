using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Session2
{
    public partial class FormCharts : Form
    {
        public FormCharts()
        {
            InitializeComponent();
        }

        private void FormCharts_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Year;
            
            startYear.Value = DateTime.Now.Year - 1;
            endYear.Value = DateTime.Now.Year + 1;
            year.Value = DateTime.Now.Year;
            weekYear.Value = DateTime.Now.Year;
            month.SelectedIndex = DateTime.Now.Month-1;

        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Carrega();
        }

        private void Carrega()
        {
            var list = Db.db.Licence.Where(x => x.LicenceDate.Year == numericUpDown1.Value).ToList();

            var values = (from d in list
                          group d by new { d.LicenceDate.Month } into g
                          select new
                          {
                              g.Key.Month,
                              values = g.ToList()
                          }).OrderBy(x => x.Month).ToList();

            var series = new Series();
            series.IsValueShownAsLabel = true;
            var index = 0;
            var valorMes = new List<ValorMes>();
            foreach (var item in values)
            {
                var mes = Helper.GetMonth(item.Month);
                series.Points.AddXY(item.Month, item.values.Count);
                series.Points[index].AxisLabel = mes;
                index++;

                valorMes.Add(new ValorMes
                {
                    Month = mes,
                    Quantity = item.values.Count
                });
            }
            dataGridViewF1.DataSource = valorMes.ToList();

            lblData.Visible = values.Count == 0;

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File | *.csv";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                var list = Db.db.Licence.ToList().Where(x => x.LicenceHistory.LastOrDefault() != null)
                                                 .Where(x => x.LicenceHistory.LastOrDefault().DateChanged.Year >= (int)startYear.Value)
                                                 .Where(x => x.LicenceHistory.LastOrDefault().DateChanged.Year <= (int)endYear.Value)
                                                 .Where(x => x.Status == "withdrawn").ToList();

                var days = list.Select(x => x.LicenceHistory.LastOrDefault().DateChanged.Year).ToList();
                var asd = Db.db.LicenceHistory.Where(x => x.Licence == null && x.LicenceId == null).Select(x => x.DateChanged.Year).ToList();
                days.AddRange(asd);

                var years = days.OrderBy(x => x).Distinct().ToList();
                var lines = new List<string>();
                var str = string.Join(";",years);
                lines.Add(str);


                var values = new List<int>();
                foreach (var item in years)
                {
                    var qntd = list.Count(x => x.LicenceHistory.LastOrDefault().DateChanged.Year == item);
                    qntd += asd.Count(x => x == item);
                    values.Add(qntd);
                }
                lines.Add(string.Join(";", values));

                File.WriteAllLines(sfd.FileName, lines);
                MessageBox.Show("Exported");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File | *.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var list = Db.db.Licence.ToList().Where(x => x.LicenceHistory.LastOrDefault() != null)
                                                 .Where(x => x.LicenceHistory.LastOrDefault().DateChanged.Year == (int)year.Value)
                                                 .Where(x => x.Status == "withdrawn").ToList();

                var days = list.Select(x => x.LicenceHistory.LastOrDefault().DateChanged.Month).ToList();
                var asd = Db.db.LicenceHistory.Where(x => x.Licence == null && x.LicenceId == null).Select(x => x.DateChanged.Month).ToList();
                days.AddRange(asd);

                var months = days.OrderBy(x => x).Distinct().ToList();
                var lines = new List<string>();
                var str = string.Join(";", months.Select(x => Helper.GetMonth(x)));
                lines.Add(str);


                var values = new List<int>();
                foreach (var item in months)
                {
                    var qntd = list.Count(x => x.LicenceHistory.LastOrDefault().DateChanged.Month == item);
                    qntd += asd.Count(x => x == item);
                    values.Add(qntd);
                }
                lines.Add(string.Join(";", values));

                File.WriteAllLines(sfd.FileName, lines);
                MessageBox.Show("Exported");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File | *.csv";    

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var list = Db.db.Licence.ToList().Where(x => x.LicenceHistory.LastOrDefault() != null)
                                                 .Where(x => x.LicenceHistory.LastOrDefault().DateChanged.Year == (int)weekYear.Value)
                                                 .Where(x => x.LicenceHistory.LastOrDefault().DateChanged.Month == month.SelectedIndex+1)
                                                 .Where(x => x.Status == "withdrawn").ToList();


                var days = list.Select(x => x.LicenceHistory.LastOrDefault().DateChanged.DayOfWeek).ToList();
                var asd = Db.db.LicenceHistory.Where(x => x.Licence == null && x.LicenceId == null).Select(x => x.DateChanged.DayOfWeek).ToList();
                days.AddRange(asd);

                var daysOfWeek = days.OrderBy(x => x).Distinct().ToList();
                var lines = new List<string>();
                var str = string.Join(";", daysOfWeek.Select(x => x.ToString()));
                lines.Add(str);


                var values = new List<int>();
                foreach (var item in daysOfWeek)
                {
                    var qntd = list.Count(x => x.LicenceHistory.LastOrDefault().DateChanged.DayOfWeek == item);
                    qntd += asd.Count(x => x == item);
                    values.Add(qntd);
                }
                lines.Add(string.Join(";", values));

                File.WriteAllLines(sfd.FileName, lines);

                MessageBox.Show("Exported");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < qntd.Value; i++)
            {
                Db.db.LicenceHistory.Add(new LicenceHistory
                {
                    DateChanged = dateTimePicker1.Value,
                    Status = "withdrawn"
                });
            }
            Db.db.SaveChanges();
            MessageBox.Show("Imported");
        }
    }

    public class ValorMes
    {
        public string Month { get; set; }
        public int Quantity { get; set; }
    }
}
