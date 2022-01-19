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

namespace Session2
{
    public partial class FormMain : Form
    {
        private User _user;

        public FormMain(User u)
        {
            InitializeComponent();
            _user = u;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Helper.LoadImages();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new FormCadDriver().ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sfd = new FolderBrowserDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fines = Db.db.Fine.Where(x => x.Status == "unpaid").ToList();

                var values = (from d in fines
                              group d by d.CarNum into g
                              select new
                              {
                                  g.Key,
                                  fines = g.ToList()
                              }).ToList();

                var root = Path.Combine(sfd.SelectedPath, "Exported Fines");
                Directory.CreateDirectory(root);

                foreach (var item in values)
                {
                    var lines = new List<string>
                    {
                        "id;date;car_num;licence_num"
                    };

                    foreach (var fine in item.fines)
                    {
                        lines.Add($"{fine.Id};{fine.CreateDate.ToString("d/M/yyyy HH:mm")};{fine.CarNum};{fine.LicenceNum}");
                        Db.db.Fine.FirstOrDefault(x => x.Id == fine.Id).Status = "transferred to the FBS";
                    }


                    if (string.IsNullOrWhiteSpace(item.Key))
                    {
                        var path = Path.Combine(root, "fines_NOT_RECOGNIZED.csv");
                        File.WriteAllLines(path, lines);
                    }
                    else
                    {
                        var path = Path.Combine(root, "fines_" + item.Key+".csv");
                        File.WriteAllLines(path, lines);
                    }
                }
                Db.db.SaveChanges();


                MessageBox.Show("Export with success", "Done!");


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new FormFines().ShowDialog();
            Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            new FormGerDriver().ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new FormGerLicence().ShowDialog();
            Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new FormHistoryLicence().ShowDialog();
            Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new FormCharts().ShowDialog();
            Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            new FormCadVehicle().ShowDialog();
            Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            new FormHistoryVehicle().ShowDialog();
            Show();
        }
    }
}
