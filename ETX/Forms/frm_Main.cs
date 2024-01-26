using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETX.Forms
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();

            var version = typeof(Program).Assembly.GetName().Version;
            Console.WriteLine($"Version: {version}");
            this.Text = "ETX  v" + version;

            Conn_Xml_Parse cxp = new Conn_Xml_Parse();
            cxp.Parse();
        }

        frm_Siparisler frm_siparisler;
        private void siparis_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm_siparisler == null || frm_siparisler.IsDisposed)
            {
                frm_siparisler = new frm_Siparisler();
                frm_siparisler.MdiParent = this;
                frm_siparisler.Show();
            }
            else
            {
                frm_siparisler.Activate();
            }
        }


        frm_Islemler frm_islemler;
        private void islemler_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_islemler == null || frm_islemler.IsDisposed)
            {
                frm_islemler = new frm_Islemler();
                frm_islemler.MdiParent = this;
                frm_islemler.Show();
            }
            else
            {
                frm_islemler.Activate();
            }
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            */
        }

        frm_FizikiAlanlar frm_fizikialanlar;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_fizikialanlar == null || frm_fizikialanlar.IsDisposed)
            {
                frm_fizikialanlar = new frm_FizikiAlanlar();
                frm_fizikialanlar.MdiParent = this;
                frm_fizikialanlar.Show();
            }
            else
            {
                frm_fizikialanlar.Activate();
            }
        }

        frm_Anlasmalar frm_anlasmalar;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_anlasmalar == null || frm_anlasmalar.IsDisposed)
            {
                frm_anlasmalar = new frm_Anlasmalar();
                frm_anlasmalar.MdiParent = this;
                frm_anlasmalar.Show();
            }
            else
            {
                frm_anlasmalar.Activate();
            }

        }
    }
}