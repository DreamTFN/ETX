using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using ETX.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ETX.Forms
{
    public partial class frm_Siparisler : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public frm_Siparisler()
        {
            InitializeComponent();
            SearchPanelShrink(1);
            Fill_DataGrid();
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

        public void Fill_DataGrid()
        {
            frm_Siparisler_tools fst = new frm_Siparisler_tools();

            gridControl.DataSource = fst.Get_Data();
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["Adı"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["Miktar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Miktar"].SummaryItem.DisplayFormat = "";
            gridView1.Columns["Tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Tutar"].SummaryItem.DisplayFormat = "";
            gridView1.Columns["KDV"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["KDV"].SummaryItem.DisplayFormat = "";

            gridView1.OptionsView.ShowFooter = true;
            // Handle the CustomSummaryCalculate event
            gridView1.CustomSummaryCalculate += gridView1_CustomSummaryCalculate;

        }

        private void UpdateForm_DataUpdated_F(object sender, EventArgs e)
        {
            Fill_DataGrid();
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
                frm_Siparisler_Edit fedit = new frm_Siparisler_Edit(aa);
                fedit.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Siparisler_Edit fedit = new frm_Siparisler_Edit(0);
            fedit.DataUpdated_F += UpdateForm_DataUpdated_F;
            fedit.Show();
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                e.TotalValue = view.RowCount; // Line count
            }
        }

        private void yenile_siparisler_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fill_DataGrid();
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                siparisler_popupMenu.ShowPopup(Control.MousePosition);
            }
        }

    }
}