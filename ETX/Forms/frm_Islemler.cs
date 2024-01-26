using DevExpress.Data;
using ETX.Classes;
using System;
using System.Data;

namespace ETX.Forms
{
    public partial class frm_Islemler : DevExpress.XtraEditors.XtraForm
    {
        public frm_Islemler()
        {
            InitializeComponent();

            SearchPanelShrink(1);

            Fill_DataTable();
        }

        public void Fill_DataTable()
        {

            frm_Islemler_tools isl = new frm_Islemler_tools();
            gridControl.DataSource = isl.get_Islemler_Grid_data();
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["İşlem Kodu"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;

            gridView1.OptionsView.ShowFooter = true;
            // Handle the CustomSummaryCalculate event
            gridView1.CustomSummaryCalculate += gridView1_CustomSummaryCalculate;

        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                e.TotalValue = view.RowCount; // Line count
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

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                int aa = (int)dr["ID"];
                frm_Islemler_Edit fedit = new frm_Islemler_Edit(aa);
                fedit.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Islemler_Edit fedit = new frm_Islemler_Edit(0);
            fedit.Show();
        }

        private void frm_Islemler_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_Islemler_Edit_SablonListesi fii = new frm_Islemler_Edit_SablonListesi();
            fii.Show();
        }
    }
}