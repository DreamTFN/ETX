using ETX.Classes;
using System;
using System.Globalization;


namespace ETX.Forms
{
    public partial class frm_Siparisler_Edit_IslemListesi_Edit : DevExpress.XtraEditors.XtraForm
    {
        int ID = 0;
        public frm_Siparisler_Edit_IslemListesi_Edit(int income_ID)
        {
            InitializeComponent();
            ID = income_ID;
            Fill_DataGrid();
        }


        private void Fill_DataGrid()
        {
            frm_Siparisler_Edit_tools set = new frm_Siparisler_Edit_tools();
            gridControl1.DataSource = set.get_Siparis_Edit_Islemler_Listesi_Grid_Datas(ID);

            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["Miktar"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Birim Fiyatı"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["ID"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Işlem Kodu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Işlem Adı"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Grubu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Alt Grubu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Depo"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Kdv Oranı"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Depo Bakiyesi"].OptionsColumn.AllowEdit = false;
            //gridView1.Columns["Toplam"].OptionsColumn.AllowEdit = false;

        }

        public event EventHandler DataUpdated;
        protected virtual void OnDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void ekle_Button_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frm_Siparisler_Edit_tools set = new frm_Siparisler_Edit_tools();

            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                int rtn_ID = (int) gridView1.GetRowCellValue(rowHandle, "ID");
                decimal Quantity = decimal.Parse (gridView1.GetRowCellValue(rowHandle, "Miktar").ToString(), CultureInfo.CurrentCulture);
                decimal Unit_Price = decimal.Parse(gridView1.GetRowCellValue(rowHandle, "Birim Fiyatı").ToString(), CultureInfo.CurrentCulture);
                decimal Vat_Rate = decimal.Parse (gridView1.GetRowCellValue(rowHandle, "Kdv Oranı").ToString(), CultureInfo.CurrentCulture);
                    
                if (rtn_ID > 0)
                {                   
                    set.add_update_Process(ID, rtn_ID, Quantity, 1, 0, 0, 0);
                }
            }

            Fill_DataGrid(); 
            OnDataUpdated();
        }


        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        /*
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Miktar" || e.Column.FieldName == "Birim Fiyatı")
            {
               // e.Appearance.BackColor = Color.OldLace;
            }
        */
        }
    }
}