using System;
using System.Collections.Generic;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab;


namespace RoyZaltsmanApp
{
    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator
    {
        public MySkinViewInfoRegistrator()
        {

        }

        public override string ViewName
        {
            get
            {
                return "MyStyle";
            }
        }

        public override BaseTabPainter CreatePainter(IXtraTab tabControl)
        {
            return new MySkinTabPainter(tabControl);
        }
    }
}
