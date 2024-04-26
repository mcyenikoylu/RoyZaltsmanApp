using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab;
using DevExpress.Utils;
using DevExpress.XtraTab.ViewInfo;

namespace RoyZaltsmanApp
{
    public class MySkinTabPainter : SkinTabPainter
    {
        public MySkinTabPainter(IXtraTab tabControl)
            : base(tabControl)
        {

        }



        protected override void DrawHeader(TabDrawArgs e)
        {
            base.DrawHeader(e);

            Dictionary<XtraTabPage, Rectangle> d = (e.ViewInfo.TabControl as XtraTabControl).Tag as Dictionary<XtraTabPage, Rectangle>;
            BaseTabPageViewInfo hInfo = e.ViewInfo.SelectedTabPageViewInfo;
            Rectangle r = new Rectangle(hInfo.Bounds.X, hInfo.Bounds.Y + 5, 40, 20);
            XtraTabPage p = e.ViewInfo.SelectedTabPage as XtraTabPage;
            if (!d.ContainsKey(p))
                d[p] = r;
            e.Graphics.DrawString("X", AppearanceObject.DefaultFont, Brushes.Red, r);
        }
    }
}
