using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class FormFines : Form
    {
        private int _errors;

        public FormFines()
        {
            InitializeComponent();
        }

        private void FormFines_Load(object sender, EventArgs e)
        {
            Carrega();
        }

        private void Carrega()
        {
            dataGridViewF1.DataSource = (from d in Db.db.Fine.ToList()
                                         select new
                                         {
                                             d.Id,
                                             d.CreateDate,
                                             d.Status,
                                             Licence_Number = d.LicenceNum,
                                             Car_Number = d.CarNum
                                         }).ToList();

            dataGridViewF1.Columns[0].Visible = false;

            foreach (DataGridViewColumn item in dataGridViewF1.Columns)
            {
                item.HeaderText = item.HeaderText.Replace("_", " ");
            }
        }

        private void edit(object sender, EventArgs e)
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
                new FormRecognizeFine(p).ShowDialog();
                Carrega();
            }
            else
            {
                MessageBox.Show("Select a Fine");
            }
        }

        private void back(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var ms = new MemoryStream();
                var sw = new StreamWriter(ms);
                var str = File.ReadAllText(ofd.FileName);
                sw.Write(str);
                sw.Flush();
                ms.Position = 0;
                var result = new DataContractJsonSerializer(typeof(FineResult)).ReadObject(ms) as FineResult;

                foreach (var item in result.data)
                {
                    Db.db.Fine.Add(new Fine
                    {
                       Id = int.Parse(item.id),
                       CarNum = item.car_num,
                       CreateDate = DateTime.ParseExact(item.create_date,"yyyy-MM-dd HH:mm:ss",CultureInfo.InvariantCulture),
                       LicenceNum = item.licence_num,
                       Photo = item.photo,
                       Status = "unpaid"
                    });
                }
                Db.db.SaveChanges();
            }
        }
    }

    public class FineResult
    {
        public List<FineJson> data { get; set; }
        public bool success { get; set; }
        public FineResult()
        {

        }
    }

    public class FineJson
    {
        public string id { get; set; }
        public string car_num { get; set; }
        public string licence_num { get; set; }
        public string create_date { get; set; }
        public string photo { get; set; }

        public FineJson()
        {

        }
    }
}
