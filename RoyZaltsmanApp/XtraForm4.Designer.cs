namespace RoyZaltsmanApp
{
    partial class XtraForm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 369);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(557, 46);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Item1";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Item2";
            // 
            // XtraForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 415);
            this.Controls.Add(this.officeNavigationBar1);
            this.Name = "XtraForm4";
            this.Text = "XtraForm4";
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
    }
}