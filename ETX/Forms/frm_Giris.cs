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
    public partial class frm_Giris : DevExpress.XtraEditors.XtraForm
    {
        public frm_Giris()
        {
            InitializeComponent();
            Conn_Xml_Parse cxp = new Conn_Xml_Parse();
            cxp.Parse();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Hide();
            frm_Main frm = new frm_Main();
            frm.Closed += (s, args) => this.Close();
            frm.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}