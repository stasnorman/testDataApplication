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
    public partial class FormPrint : Form
    {
        public FormPrint(int _id)
        {
            InitializeComponent();
            lblSurname.Text = "teste";

            var driver = Db.db.Driver.FirstOrDefault(x => x.Identifier == _id);
            pictureBox2.Image = Helper.Convert(driver.Photo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrint_Load(object sender, EventArgs e)
        {

        }

        internal void Print(string sfd)
        {
            var bit = new Bitmap(panel1.Width, panel1.Height);

            panel1.DrawToBitmap(bit, new Rectangle(Point.Empty, bit.Size));

            bit.Save(sfd);
            MessageBox.Show("Printed","Success!");
        }
    }
}
