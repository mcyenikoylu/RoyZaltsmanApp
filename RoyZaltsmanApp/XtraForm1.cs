using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace RoyZaltsmanApp
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();

            PaintStyleCollection.DefaultPaintStyles.Add(new MySkinViewInfoRegistrator());
            xtraTabControl1.PaintStyleName = "MyStyle";
            xtraTabControl1.Tag = iconRectangle;
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        Dictionary<XtraTabPage, Rectangle> iconRectangle = new Dictionary<XtraTabPage, Rectangle>();
        private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            XtraTabControl tc = sender as XtraTabControl;
            BaseTabControlViewInfo vi = (tc as IXtraTab).ViewInfo;
            BaseTabHitInfo hitInfo = vi.CalcHitInfo(e.Location);
            Rectangle r;
            if (hitInfo.HitTest == XtraTabHitTest.PageHeader && iconRectangle.TryGetValue(hitInfo.Page as XtraTabPage, out r) && r.Contains(e.Location))
            {
                // click
                System.Diagnostics.Debugger.Break();
            }

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}