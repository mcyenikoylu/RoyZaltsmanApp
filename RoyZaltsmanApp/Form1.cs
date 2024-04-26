using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoyZaltsmanApp
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraForm1 form1 = new XtraForm1();
            form1.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraForm2 form1 = new XtraForm2();
            form1.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FluentDesignForm1 form1 = new FluentDesignForm1();
            form1.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            XtraForm5 form1 = new XtraForm5();
            form1.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            XtraForm4 form1 = new XtraForm4();
            form1.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            XtraForm3 form1 = new XtraForm3();
            form1.ShowDialog();
        }
    }
}
