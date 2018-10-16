using DevExpress.Utils;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            
            this.Shown += Form5_Shown;

        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            var location = new Point(10, 60);
            Form4 form4 = new Form4(this.Handle)
            {
                Location = location,
                Size = new Size(Width, Height / 2)
            };
            form4.Opacity = 0.5d;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Show();
            //form4.BringToFront();
            //form4.TopLevel = true;
            form4.TopMost = true;
            //form4.Activate();
            //form4.Focus();
            //pictureBox1.SendToBack();

        }

        private string pathname = string.Empty;     		//定义路径名变量
        private void button1_Click(object sender, EventArgs e)  	//打开方法
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                    pathname = file.FileName;   //获得文件的绝对路径
                    this.pictureBox1.Load(pathname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  //保存方法
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            if (save.FileName != string.Empty)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }


    }
}
