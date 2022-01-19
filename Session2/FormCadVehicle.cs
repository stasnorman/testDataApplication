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
    public partial class FormCadVehicle : Form
    {
        public CustomColor _color;
        private Driver _selectedDriver;

        public FormCadVehicle()
        {
            InitializeComponent();
        }

        private void FormCadVehicle_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = Db.db.CustomColor.ToList();

            _color = Db.db.CustomColor.FirstOrDefault();

            ShowColor();

            enginetype.ValueMember = "Id";
            enginetype.DisplayMember = "Name";
            enginetype.DataSource = Db.db.EngineType.ToList();
        }

        private void ShowColor()
        {
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(_color.Code);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(_color.Code);
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml(_color.Code);

            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValue = _color.Id;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                var ve = new Vehicle();

                var u = Db.db.Vehicle.FirstOrDefault(x => x.VIN == vin.Text);

                var oldDriver = -1;

                if (u != null)
                {
                    ve = u;
                    oldDriver = u.DriverId.Value;
                }

                ve.VIN = vin.Text;
                ve.Mark = mark.Text;
                ve.Model = model.Text;
                ve.VehicleType = type.Text;
                ve.VehicleCategory = category.Text;
                ve.Year = (int) year.Value;
                ve.EngineNumber = enginenumber.Text;
                ve.EngineModel = enginemodel.Text;
                ve.EngineYear = (int) engineyear.Value;
                ve.EnginePower = enginepower.Text;
                ve.Horsepower = horsepower.Text;
                ve.MaximumLoad = (double) maximumload.Value;
                ve.Weight = (int) weight.Value;
                ve.EngineTypeId = (int) enginetype.SelectedValue;
                ve.EngineType = Db.db.EngineType.FirstOrDefault(x => x.Id == ve.EngineTypeId);
                ve.WeightInKg = (int) weightinkg.Value;
                ve.TypeDrive = typedrive.Text;
                ve.Comments = comments.Text;
                ve.DriverId = _selectedDriver.Identifier;
                ve.Driver = _selectedDriver;
                ve.CustomColor = _color;

                if (u == null)
                {
                    Db.db.Vehicle.Add(ve);
                    Db.db.SaveChanges();
                }
                else if (oldDriver > -1 && ve.DriverId != oldDriver)
                {
                    Db.db.VehicleHistory.Add(new VehicleHistory
                    {
                        Comment = "",
                        DateChanged = DateTime.Now,
                        Driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == oldDriver),
                        LastOwnerId = oldDriver,
                        Vehicle = ve,
                        VehicleId = ve.Id
                    });
                }
                Db.db.SaveChanges();


                MessageBox.Show("Vehicle saved", "Success");
                Close();
            }
        }

        private bool valida()
        {
            if (_selectedDriver == null)
            {
                MessageBox.Show("Select a driver by clicking in a suggestion" +
                    "");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vin.Text))
            {
                MessageBox.Show("Complete the field VIN");
                return false;
            }

            if (!new VIN_LIB.Class1().CheckVIN(vin.Text))
            {
                MessageBox.Show("The VIN is not valid");
                return false;
            }

            if (string.IsNullOrWhiteSpace(mark.Text))
            {
                MessageBox.Show("Complete the field Middle Mark");
                return false;
            }

            if (string.IsNullOrWhiteSpace(model.Text))
            {
                MessageBox.Show("Complete the field Last Model");
                return false;
            }

            if (string.IsNullOrWhiteSpace(type.Text))
            {
                MessageBox.Show("Complete the field Vehicle Type");
                return false;
            }

            if (string.IsNullOrWhiteSpace(category.Text))
            {
                MessageBox.Show("Complete the field Vehicle Category");
                return false;
            }

            if (string.IsNullOrWhiteSpace(typedrive.Text))
            {
                MessageBox.Show("Complete the field Type of Drive");
                return false;
            }

            if (enginetype.SelectedValue == null)
            {
                MessageBox.Show("Complete the field Engine Type");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            new FormSelectColor(this).ShowDialog();
            ShowColor();
        }

        private void driver_TextChanged(object sender, EventArgs e)
        {
            var context = new ContextMenu();
            var drivers = Db.db.Driver.ToList().Where(x => $"{x.Name} {x.MiddleName} {x.Surname}".ToLower().Contains(driver.Text.ToLower())).ToList();

            _selectedDriver = null;

            foreach (var item in drivers)
            {
                var mItem = new MenuItem($"{item.Name} {item.MiddleName} {item.Surname} - 05/12/1987", (ae, ea) =>
                {
                    _selectedDriver = item;
                    driver.TextChanged -= driver_TextChanged;
                    driver.Text = $"{_selectedDriver.Name} {_selectedDriver.MiddleName} {_selectedDriver.Surname}";
                    driver.TextChanged += driver_TextChanged;
                });
                context.MenuItems.Add(mItem);
            }
            context.Show(driver, new Point(0, driver.Height));
            driver.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void driver_Leave(object sender, EventArgs e)
        {
            var drivers = Db.db.Driver.ToList().Where(x => $"{x.Name} {x.MiddleName} {x.Surname}".ToLower().Contains(driver.Text.ToLower())).ToList();

            if (!drivers.Any())
            {
                if (MessageBox.Show("No driver match with this name\nDo you want to create a driver?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new FormCadDriver(name: driver.Text).ShowDialog();
                }
            }
        }

        private void vin_Leave(object sender, EventArgs e)
        {
            var v = Db.db.Vehicle.FirstOrDefault(x => x.VIN == vin.Text);

            if (v != null)
            {
                MessageBox.Show("A Vehicle was found with this VIN. Loading information", "Information");

                mark.Text = v.Mark;
                model.Text = v.Model;
                type.Text = v.VehicleType;
                category.Text = v.VehicleCategory;
                year.Value = v.Year;
                enginenumber.Text = v.EngineNumber;
                enginemodel.Text = v.EngineModel;
                if (v.EngineYear != null)
                    engineyear.Value = (decimal) v.EngineYear;
                enginepower.Text = v.EnginePower;
                horsepower.Text = v.Horsepower;
                if (v.MaximumLoad != null)
                    maximumload.Value = (decimal) v.MaximumLoad;
                weight.Value = v.Weight;
                enginetype.SelectedValue = v.EngineTypeId;
                if (v.WeightInKg != null)
                    weightinkg.Value = (decimal) v.WeightInKg;
                typedrive.Text = v.TypeDrive;
                comments.Text = v.Comments;
                driver.Text = $"{v.Driver.Name} {v.Driver.MiddleName} {v.Driver.Surname}";
                if (v.CustomColor != null)
                {
                    _color = v.CustomColor;
                    ShowColor();
                }

                _selectedDriver = v.Driver;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 7)
            {
                try
                {
                    _color = Db.db.CustomColor.FirstOrDefault(x => x.Code.ToLower() == textBox1.Text.ToLower());
                    if (_color == null)
                        throw new Exception();
                    ShowColor();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid or unknown color code", "Error");
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _color = Db.db.CustomColor.FirstOrDefault(x => x.Id == (int) comboBox1.SelectedValue);
            ShowColor();
        }

        private void vin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
