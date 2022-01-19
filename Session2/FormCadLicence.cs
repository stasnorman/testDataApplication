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
    public partial class FormCadLicence : Form
    {
        private int _id;

        public FormCadLicence(int id = 0)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormCadLicence_Load(object sender, EventArgs e)
        {

            var cities = Db.db.Driver.ToList().Where(x => x.RegistrationAddress.Contains(",")).Select(x => x.RegistrationAddress.Split(',')[0]).ToList();
            registrationCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            registrationCity.AutoCompleteCustomSource.AddRange(cities.ToArray());

            comboBox1.SelectedIndex = 0;

            if (_id > 0)
            {
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

                name.Text = driver.Name;
                middleName.Text = driver.MiddleName;
                lastName.Text = driver.Surname;
                passportSeries.Text = driver.PassportSeries;
                passportNumber.Text = driver.PassportNumber;
                mobilePhone.Text = driver.MobilePhone;
                email.Text = driver.Email;
                postcode.Text = driver.PostCode;

                name.ReadOnly = true;
                middleName.ReadOnly = true;
                lastName.ReadOnly = true;
                passportSeries.ReadOnly = true;
                passportNumber.ReadOnly = true;
                mobilePhone.ReadOnly = true;
                email.ReadOnly = true;
                postcode.ReadOnly = true;
                registration.ReadOnly = true;
                registrationCity.ReadOnly = true;
                residence.ReadOnly = true;
                residenceCity.ReadOnly = true;
                place.ReadOnly = true;
                position.ReadOnly = true;
                button3.Visible = false;

                if (driver.RegistrationAddress.Contains(","))
                {
                    var vals = driver.RegistrationAddress.Split(',');
                    registration.Text = vals[1].Trim();
                    registrationCity.Text = vals[0].Trim();
                }
                else
                {
                    registration.Text = driver.RegistrationAddress;
                }

                if (driver.ResidenceAddress.Contains(","))
                {
                    var vals = driver.ResidenceAddress.Split(',');

                    residence.Text = vals[1].Trim();
                    residenceCity.Text = vals[0].Trim();
                }
                else
                {
                    residence.Text = driver.ResidenceAddress;
                }

                place.Text = driver.PlaceOfWork;
                position.Text = driver.Position;
                try
                {
                    pictureBox1.Image = Helper.Convert(driver.Photo);
                }
                catch (Exception)
                {
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                var driver = new Driver();

                if (_id > 0)
                    driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == _id);

                driver.Name = name.Text;
                driver.MiddleName = middleName.Text;
                driver.Surname = lastName.Text;
                driver.PassportSeries = passportSeries.Text;
                driver.PassportNumber = passportNumber.Text;
                driver.MobilePhone = mobilePhone.Text;
                driver.Email = email.Text;
                driver.PostCode = postcode.Text;
                driver.RegistrationAddress = $"{registrationCity.Text}, {registration.Text}";
                driver.ResidenceAddress = $"{residenceCity.Text}, {residence.Text}";
                driver.PlaceOfWork = place.Text;
                driver.Position = position.Text;
                driver.Photo = Helper.Convert(pictureBox1.Image);

                if (_id == 0)
                {
                    driver.Identifier = Db.db.Driver.Any() ? Db.db.Driver.Max(x => x.Identifier) + 1 : 1;
                    Db.db.Driver.Add(driver);
                }

                Db.db.SaveChanges();

                var licence = new Licence();

                if (driver.Licence != null)
                    licence = driver.Licence;

                licence.ExpireDate = expireDate.Value;
                licence.LicenceDate = licenceDate.Value;
                licence.Number = licenceNumber.Text;
                licence.Series = licenceSeries.Text;

                var status = comboBox1.Text;

                if (licence.Status != "")
                    if (licence.Status != status)
                        Db.db.LicenceHistory.Add(new LicenceHistory
                        {
                            ExpireDate = expireDate.Value,
                            LicenceDate = licenceDate.Value,
                            LicenceNumber = licenceNumber.Text,
                            LicenceSeries = licenceSeries.Text,
                            Status = comboBox1.Text,
                            Categories = GetCategories(),
                            DateChanged = DateTime.Now,
                            Licence = licence,
                        });

                licence.Status = comboBox1.Text;
                licence.Categories = GetCategories();

                if (driver.Licence == null)
                    Db.db.Licence.Add(licence);

                driver.Licence = licence;

                Db.db.SaveChanges();

                MessageBox.Show("Driver saved", "Success");
                Close();
            }
        }

        private string GetCategories()
        {
            var list = new List<string>();

            foreach (CheckBox item in panel2.Controls)
            {
                if (item.Checked)
                    list.Add(item.Text);
            }

            return String.Join(", ", list);
        }

        private bool valida()
        {
            if (string.IsNullOrWhiteSpace(licenceNumber.Text))
            {
                MessageBox.Show("Complete the field Licence Number");
                return false;
            }

            if (string.IsNullOrWhiteSpace(licenceSeries.Text))
            {
                MessageBox.Show("Complete the field Licence Series");
                return false;
            }

            if (_id == 0)
            {
                if (string.IsNullOrWhiteSpace(name.Text))
                {
                    MessageBox.Show("Complete the field Name");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(middleName.Text))
                {
                    MessageBox.Show("Complete the field Middle Name");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(lastName.Text))
                {
                    MessageBox.Show("Complete the field Last Name");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(passportNumber.Text))
                {
                    MessageBox.Show("Complete the field Passport Number");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(passportSeries.Text))
                {
                    MessageBox.Show("Complete the field Passport Series");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(email.Text))
                {
                    MessageBox.Show("Complete the field Email");
                    return false;
                }
                else
                {
                    var regex = new Regex(@"(.+)@(.+)\.(.+)");
                    if (!regex.Match(email.Text).Success)
                    {
                        MessageBox.Show("Insert a valid email (anything@anything.anything)");
                        return false;
                    }
                }

                if (string.IsNullOrWhiteSpace(registrationCity.Text))
                {
                    MessageBox.Show("Complete the field Registration City");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(registration.Text))
                {
                    MessageBox.Show("Complete the field Registration Address");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(residenceCity.Text))
                {
                    MessageBox.Show("Complete the field Residence City");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(residence.Text))
                {
                    MessageBox.Show("Complete the field Residence Address");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(mobilePhone.Text))
                {
                    MessageBox.Show("Complete the field Mobile Phone");
                    return false;
                }



                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Complete the field Photo");
                    return false;
                }
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "JPG or PNG|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(ofd.FileName);
                    var wi = img.Width / 3;
                    var he = img.Height / 4;
                    var bytes = File.ReadAllBytes(ofd.FileName).Length;
                    if (img.Width > img.Height)
                    {
                        MessageBox.Show("The image is not vertical");
                    }
                    else if (bytes / 1024 / 1024 > 2)
                    {
                        MessageBox.Show("The image is large than 2 megabytes");
                    }
                    else if (wi != he)
                    {
                        MessageBox.Show("The image is not 3x4");
                    }
                    else
                    {
                        pictureBox1.Image = img;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image");
                }
            }
        }
    }
}
