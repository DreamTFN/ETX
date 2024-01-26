using DevExpress.Diagram.Core.Shapes;
using DevExpress.XtraEditors;
using ETX.Context;
using ETX.Entities;
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
    public partial class frm_Anlasmalar : DevExpress.XtraEditors.XtraForm
    {
        public frm_Anlasmalar()
        {
            InitializeComponent();
            SearchPanelShrink(1);
            Fill_DataGrid();
        }

        public void Fill_DataGrid()
        {

            using (var context = new Context.EtxContext())
            {
                List<Agreement> agreements = context.Agreements
                    .OrderByDescending(a => a.Name)
                    .ToList();

                anlasmalar_gridControl.DataSource = agreements;
            }
        }

        public void SearchPanelShrink(int Start)
        {
            if (search_sidePanel.Size.Width >= 30 || Start == 1)
            {
                search_sidePanel.Size = new System.Drawing.Size(20, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.prev_16x16;
            }
            else
            {
                search_sidePanel.Size = new System.Drawing.Size(200, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.next_16x16;
            }
        }

        private void openclose_Button_Click(object sender, EventArgs e)
        {
            SearchPanelShrink(0);
        }

        private void yeni_Button_Click(object sender, EventArgs e)
        {
            frm_Anlasmalar_Edit ae = new frm_Anlasmalar_Edit(0);
            ae.Show();
        }


        private void anlasmalar_gridView_DoubleClick(object sender, EventArgs e)
        {
            ETX.Entities.Agreement agreement = (ETX.Entities.Agreement)anlasmalar_gridView.GetFocusedRow();
            if (agreement != null)
            {
                short aa = agreement.Id;
                frm_Anlasmalar_Edit fedit = new frm_Anlasmalar_Edit(aa);
                fedit.Show();
            }
        }
    }
}