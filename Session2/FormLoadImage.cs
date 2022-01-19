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
    public partial class FormLoadImage : Form
    {
        private int _id;
        private Image _image;

        public FormLoadImage(int id, Image img)
        {
            InitializeComponent();
            _image = img;
            pictureBox1.Image = _image;
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = _image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Db.db.VehicleImage.Add(new VehicleImage
            {
                Image = Helper.Convert(pictureBox1.Image),
                Vehicle = Db.db.Vehicle.FirstOrDefault(x => x.Id == _id),
                VehicleId = _id
            });
            Db.db.SaveChanges();
            MessageBox.Show("Image uploaded","Success");
            Close();
        }

        private void FormLoadImage_Load(object sender, EventArgs e)
        {

        }
    }
}
