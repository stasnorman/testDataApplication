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
    public partial class FormVehicleInfo : Form
    {
        private int _id;
        public Random _random = new Random();

        public FormVehicleInfo(int id = 0)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormVehicleInfo_Load(object sender, EventArgs e)
        {

            Carrega();

            comboBox1.SelectedIndex = 0;
            CarregaImages();


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
                var licence = Db.db.VehicleHistory.FirstOrDefault(x => x.Id == p);
                new FormCommentVehicle(licence).ShowDialog();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void Carrega()
        {
            var ve = Db.db.Vehicle.FirstOrDefault(x => x.Id == _id);
            if (!string.IsNullOrWhiteSpace(ve.LicencePlate))
                label7.Text = ve.LicencePlate;

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = (from d in Db.db.Driver.Where(x => x.Identifier != ve.DriverId).ToList()
                                    select new
                                    {
                                        Id = d.Identifier,
                                        Name = $"{d.Name} {d.MiddleName} {d.Surname}"
                                    }).ToList();


            lblOwner.Text = ve.Driver.Name;

            dataGridViewF1.DataSource = (from d in Db.db.VehicleHistory.Where(x => x.VehicleId == _id).ToList()
                                         select new
                                         {
                                             d.Id,
                                             Last_Owner = $"{d.Driver.Name} {d.Driver.MiddleName} {d.Driver.Surname}",
                                             Date_Changed = d.DateChanged.ToString("dd/MM/yyyy HH:mm"),
                                             d.Comment,
                                         }).ToList();

            dataGridViewF1.Columns[0].Visible = false;
            foreach (DataGridViewColumn item in dataGridViewF1.Columns)
            {
                item.HeaderText = item.HeaderText.Replace("_", " ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(ofd.FileName);
                    new FormLoadImage(_id, img).ShowDialog();
                    CarregaImages();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Image");
                }
            }
        }

        private void CarregaImages()
        {
            dataGridViewF2.DataSource = Db.db.VehicleImage.ToList().Where(x => x.VehicleId == _id).Select(x => new
            {
                Image = new Bitmap(Helper.Convert(x.Image), 80, 80)
            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var v = Db.db.Vehicle.FirstOrDefault(x => x.Id == _id);
            Db.db.VehicleHistory.Add(new VehicleHistory
            {
                DateChanged = DateTime.Now,
                Driver = v.Driver,
                LastOwnerId = v.DriverId,
                Vehicle = v,
                VehicleId = v.Id
            });

            Db.db.SaveChanges();
            v.Driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == (int) comboBox1.SelectedValue);
            Db.db.SaveChanges();
            MessageBox.Show("Driver changed");
            Carrega();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Letters = "ABEKMHOPCTYX";
            var ve = Db.db.Vehicle.FirstOrDefault(x => x.Id == _id);

            ve.LicencePlate = $"{Letters[_random.Next(0,Letters.Length)]}{_random.Next(1,1000).ToString("000")}{Letters[_random.Next(0, Letters.Length)]}{Letters[_random.Next(0, Letters.Length)]}{_random.Next(1, 1000).ToString("000")}";
            label7.Text = ve.LicencePlate;
            Db.db.SaveChanges();

        }
    }
}
