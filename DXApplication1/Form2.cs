

namespace DXApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.DirectoryServices;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class Form2 : Form
    {
        public Form2()
        {
            Application.EnableVisualStyles();
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //TextRenderer textRenderer;
            //Graphics graphics;
            //richEditControl1.Text = Properties.Settings.Default.TestSet1;
            //Properties.Settings settings = new Properties.Settings();
            //settings.TestSet1 = "testsettings123";
            //settings.Save();
            //settings.Reload();
            //var p = System.Diagnostics.Process.GetCurrentProcess();
            //MessageBox.Show(p.ProcessName);
            
            textEdit1.Text = (string)Program.KeyValuePairs.Get("key1");
            lookUpEdit1.Properties.DataSource = new List<int>() { 1, 2, 3 };
            lookUpEdit1.Properties.TextEditStyle =  DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            var d = fontDialog1.Color;
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 创建Windows帐户
        /// </summary>
        /// <param name="pathname"></param>
        /// <returns></returns>
        public void CreateLocalUser(string username, string password, string description)
        {
            DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            var newUser = localMachine.Children.Add(username, "user");
            newUser.Invoke("SetPassword", new object[] { password });
            newUser.Invoke("Put", new object[] { "Description", description });
            newUser.CommitChanges();
            localMachine.Close();
            newUser.Close();
        }

        /// <summary>
        /// 删除Windows用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool DeleteWinUser(string username)
        {
            try
            {
                using (DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer"))
                {
                    //删除存在用户
                    var delUser = localMachine.Children.Find(username, "user");
                    if (delUser != null)
                    {
                        localMachine.Children.Remove(delUser);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void spreadsheetControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
