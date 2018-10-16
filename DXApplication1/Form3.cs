using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Visible = false;

            System.Windows.Forms.ComboBox combobox = new System.Windows.Forms.ComboBox
            {
                Location = new Point(comboBox1.Location.X, comboBox1.Location.Y + 30 * (3)),
                Name = "combobox_" + 1,
                Size = comboBox1.Size
            };
          
            combobox.Tag = "createcomboboxpbstype";
            var list1 = new List<string>() { "1234", "wewer", "gggggggg" };
            combobox.DataSource = list1;
            this.navigationPage4.Controls.Add(combobox);
            combobox.SelectedText = "gggggggg";
            combobox.SelectedItem = "gggggggg";
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox.SelectedIndexChanged += Combobox_SelectedIndexChanged;
         
        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as System.Windows.Forms.ComboBox;

        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
