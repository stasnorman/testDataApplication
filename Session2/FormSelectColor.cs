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
    public partial class FormSelectColor : Form
    {
        private FormCadVehicle _form;

        public FormSelectColor(FormCadVehicle form)
        {
            InitializeComponent();
            _form = form;
        }

        private void FormSelectColor_Load(object sender, EventArgs e)
        {
            foreach (var item in Db.db.CustomColor)
            {
                var panel = new Panel
                {
                    Size = new Size(36, 39)
                };
                panel.BackColor = System.Drawing.ColorTranslator.FromHtml(item.Code);

                panel.Click += (ae, ea) =>
                {
                    _form._color = item;
                    Close();
                };

                tableLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
