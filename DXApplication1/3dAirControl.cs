using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxSimuworksActiveXLib;

namespace DXApplication1
{
    public partial class _3dAirControl : UserControl
    {
        public AxSimuworksActiveX Simu3DAir { get; private set; }
        

        public _3dAirControl()
        {
            InitializeComponent();

            Simu3DAir = new AxSimuworksActiveX() { Dock = DockStyle.Fill };
            this.splitContainerControl1.Panel1.Controls.Add(Simu3DAir);
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }
    }
}
