using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class FormRecognizeFine : Form
    {
        private int _id;

        public FormRecognizeFine(int id = 0)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormRecognizeFine_Load(object sender, EventArgs e)
        {
            var fine = Db.db.Fine.FirstOrDefault(x => x.Id == _id);

            using(var client = new WebClient())
            {
                try
                {
                    var ms = client.OpenRead(fine.Photo);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error on getting the image!!\nCheck API\nLink: '"+fine.Photo+"'","Error");
                }
            }
        }
        

        private void edit(object sender, EventArgs e)
        {
            var fine = Db.db.Fine.FirstOrDefault(x => x.Id == _id);
            fine.CarNum = textBox1.Text;
            Db.db.SaveChanges();
            MessageBox.Show("Car number saved!");
            Close();
        }

        private void back(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var web = (HttpWebRequest) WebRequest.Create("http://solutions2019.hakta.pro/api/postFine");
                web.Method = "POST";
                web.Accept = "application/json";
                web.ContentType = "application/json";

                var message = new FineBody
                {
                    id = _id.ToString(),
                    message = "not recognized"
                };

                new DataContractJsonSerializer(typeof(FineBody)).WriteObject(web.GetRequestStream(), message);
                var ms = web.GetResponse().GetResponseStream();
                var sr = new StreamReader(ms);

                var str = sr.ReadToEnd();
                var a = 2;
                MessageBox.Show("Request Sent");
                Close();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Bad Request");
            }
        }
    }

    public class FineBody
    {
        public string id { get; set; }
        public string message { get; set; }
        public FineBody()
        {

        }
    }
    
}
