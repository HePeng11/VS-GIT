using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form4 : Form
    {
        public Form4(IntPtr parentHandle)
        {
            InitializeComponent();
            List<User> users = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                users.Add(new User());
            }
            dataGridView1.DataSource = users;
            DataGridViewComboBoxColumn cl = new DataGridViewComboBoxColumn
            {
                Name = "excelCol",
                HeaderText = "匹配Excel列"
            };
            for (int i = 0; i < 5; i++)
            {
                cl.Items.Add(i + "");
            }
            dataGridView1.Columns.Add(cl);
            dataGridView1.CellClick += DataGridView1_CellClick;
            UIHelper.SetParent(this.Handle, parentHandle);
        }

        /// <summary>
        /// 点击一次就下拉 避免原生DataGridViewComboBox的bug
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1[e.ColumnIndex, e.RowIndex] != null && !dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                DataGridViewComboBoxColumn comboBoxColumn = dataGridView1.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
                if (comboBoxColumn != null)
                {
                    dataGridView1.BeginEdit(true);
                    DataGridViewComboBoxEditingControl comboBoxEditingControl = dataGridView1.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboBoxEditingControl != null)
                    {
                        comboBoxEditingControl.DroppedDown = true;
                    }
                }
            }

        }
    }

    public class User
    {
        public string MyProperty { get; set; } = "MyProperty";
        public string MyProperty1 { get; set; } = "MyProperty1";
        public string MyProperty2 { get; set; } = "MyProperty2";
    }

    public class ParentUser: User
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Guid ParentGuid { get; set; }
      
    }
}
