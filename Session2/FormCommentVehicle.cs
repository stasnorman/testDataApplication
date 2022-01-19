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
    public partial class FormCommentVehicle : Form
    {
        private VehicleHistory _licence;

        public FormCommentVehicle(VehicleHistory licence)
        {
            InitializeComponent();
            _licence = licence;
        }

        private void FormCommentVehicle_Load(object sender, EventArgs e)
        {
            textBox1.Text = _licence.Comment;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _licence.Comment = textBox1.Text;
            Db.db.SaveChanges();
            Close();
        }
    }
}
