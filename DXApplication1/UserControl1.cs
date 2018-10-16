using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    [ToolboxItem(true)]
    public partial class UserControl1 : UserControl
    {
        public string Text1 { get; set; }
        public UserControl1()
        {
            InitializeComponent();
        }


        public string GetValue()
        {
            return this.textBox1.Text + "|" + checkBox1.Checked;
        }

    }
}
