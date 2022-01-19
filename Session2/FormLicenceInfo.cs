using Session2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class FormLicenceInfo : Form
    {
        private int _id;

        public FormLicenceInfo(int id = 0)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormLicenceInfo_Load(object sender, EventArgs e)
        {
            Carrega();

            foreach (DataGridViewColumn item in dataGridViewF1.Columns)
            {
                item.HeaderText = item.HeaderText.Replace("_", " ");
            }

            comboBox1.SelectedIndex = 0;

            var driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == _id);

            if (driver.Licence != null)
            {
                var li = driver.Licence;
                expireDate.Value = li.ExpireDate;
                licenceDate.Value = li.LicenceDate;
                licenceNumber.Text = li.Number;
                licenceSeries.Text = li.Series;
                comboBox1.Text = li.Status;

                var list = li.Categories.Split(',');

                foreach (CheckBox item in panel2.Controls)
                {
                    if (list.Select(x => x.Trim()).Any(x => x == item.Text))
                    {
                        item.Checked = true;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                var licence = Db.db.LicenceHistory.FirstOrDefault(x => x.Id == p);
                new FormComment(licence).ShowDialog();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void Carrega()
        {
            dataGridViewF1.DataSource = (from d in Db.db.LicenceHistory.Where(x => x.LicenceId == _id).ToList()
                                         select new
                                         {
                                             d.Id,
                                             d.Status,
                                             Date_Changed = d.DateChanged.ToString("dd/MM/yyyy HH:mm"),
                                             d.Comment,
                                             Indicator = Helper.CreateIndicator(d.Status)
                                         }).ToList();

            dataGridViewF1.Columns[0].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                    panel1.BackColor = Color.Red;
                    break;
                case 2:
                    panel1.BackColor = Color.Green;
                    break;
                case 3:
                    panel1.BackColor = Color.Gray;
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JPEG File | *.jpeg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var bit = Resources.driver_license_template;
                var driver = Db.db.Licence.FirstOrDefault(x => x.Id == _id).Driver.FirstOrDefault();

                using (var g = Graphics.FromImage(bit))
                {
                    if (driver.Photo != null)
                        g.DrawImage(Helper.Convert(driver.Photo), new Rectangle(68, 230, 198, 293));
                    else
                        g.FillRectangle(Brushes.White, new Rectangle(68, 230, 198, 293));

                    var font = new Font("Tahoma", 12);
                    var fontBig = new Font("Tahoma", 13,FontStyle.Bold);
                    g.DrawString("Surname", fontBig, Brushes.Black, 334, 217);
                    g.DrawString(driver.Surname, font, Brushes.Black, 334, 237);

                    g.DrawString("Name   Middle Name", fontBig, Brushes.Black, 334, 257);
                    g.DrawString($"{driver.Name} {driver.MiddleName}", font, Brushes.Black, 334, 277);

                    g.DrawString($"Residence Address", fontBig, Brushes.Black, 334, 327);
                    g.DrawString($"{driver.ResidenceAddress}", font, Brushes.Black, 334, 307);

                    g.DrawString($"Date           Expire Date", fontBig, Brushes.Black, 334, 357);
                    g.DrawString($"{driver.Licence.LicenceDate.ToString("dd/MM/yyyy")}", font, Brushes.Black, 334, 377);
                    g.DrawString($"{driver.Licence.LicenceDate.ToString("dd/MM/yyyy")}", font, Brushes.Black, 404, 377);

                    g.DrawString($"Series      Number", fontBig, Brushes.Black, 334, 407);
                    g.DrawString($"{driver.Licence.Series}", font, Brushes.Black, 334, 427);
                    g.DrawString($"{driver.Licence.Number}", font, Brushes.Black, 404, 427);

                    g.DrawString($"Categories", fontBig, Brushes.Black, 334, 447);
                    g.DrawString($"{driver.Licence.Categories}", font, Brushes.Black, 334, 467);

                    g.DrawString($"Status", fontBig, Brushes.Black, 55, 560);
                    g.DrawString($"{driver.Licence.Status}", font, Brushes.Black, 80, 580);

                    var brush = Brushes.Red;

                    if (driver.Licence.Status == "active")
                        brush = Brushes.Green;
                    if (driver.Licence.Status == "invalidated")
                        brush = Brushes.Gray;

                    g.FillRectangle(brush, new Rectangle(55,580,17,17));
                }

                bit.Save(sfd.FileName);
                MessageBox.Show("Printed!","Success");
            }
        }
    }
}
