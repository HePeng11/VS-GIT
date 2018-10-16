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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            //this.ribbonControl1.Size = new System.Drawing.Size(1230, 147);
            ////this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            //this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            //this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            //this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            //ribbonControl1.ApplicationButtonDropDownControl = backstageViewControl1;
            _3dAirControl _3DAirControl = new _3dAirControl();
            _3DAirControl.Dock = System.Windows.Forms.DockStyle.Fill;
            _3DAirControl.Location = new System.Drawing.Point(0, 184);
            _3DAirControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _3DAirControl.Name = "simu3DAirPanel1";
            _3DAirControl.Size = new System.Drawing.Size(1172, 521);
            _3DAirControl.TabIndex = 10;
            var mainDoc = documentManager1.View.AddDocument(_3DAirControl);
            mainDoc.Caption = "模型视图";
            mainDoc.Properties.AllowDock = DevExpress.Utils.DefaultBoolean.False;
            mainDoc.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
            mainDoc.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            documentManager1.View.AddDocument(_3DAirControl);
            _3DAirControl.Simu3DAir.Init(1);
            _3DAirControl.Simu3DAir.SetLoadFileProcessCtrl(false);
            _3DAirControl.Simu3DAir.OpenModel(@"E:\teamSvn\operation\SIMU.ConstructionManagementPlanning\SIMU.CMP.Startup\bin\Debug\Project\Demo\07CBE9D8E2384929873B507772B9BE53.3gd");

        }

        private void RibbonControl1_ApplicationButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
