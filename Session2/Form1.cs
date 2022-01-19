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
    public partial class Form1 : Form
    {
        private int _errors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Helper.LoadImages();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper._blocked)
            {
                MessageBox.Show("You are blocked from using the system for 1 minute","Warning");
            }
            else
            {
                var u = Db.db.User.FirstOrDefault(x => x.Username == textBox1.Text &&
                                                       x.Password == textBox2.Text);

                if(u != null)
                {
                    Hide();
                    new FormMain(u).ShowDialog();
                    Close();
                } else
                {
                    MessageBox.Show("Wrong Credentials");
                    _errors++;
                    if(_errors > 3)
                    {
                        Helper.Block();
                        MessageBox.Show("You entered incorrect credentials 3 times, you are blocked from using the system for 1 minute","Warning");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
