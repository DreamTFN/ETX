using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using ETX.Context;

namespace ETX.Forms
{
    public partial class frm_Islemler_Edit_SablonListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_Islemler_Edit_SablonListesi()
        {
            InitializeComponent();
            Fill_GridView();
        }


        private void Fill_GridView()
        {
            using (var context = new Context.EtxContext())
            {
                List<StockTemplate> stockTemplates = context.StockTemplates
                    .OrderByDescending(s => s.Active)
                    .ThenBy(s => s.Name)
                .ToList();

                gridControl1.DataSource = stockTemplates;

                gridView1.Columns["Id"].Visible = false;
                gridView1.Columns["StockTemplateDets"].Visible = false;
                //gridView1.Columns[nameof(StockTemplate.Id)].Caption = "ID";
                gridView1.Columns[nameof(StockTemplate.Code)].Caption = "Kod";
                gridView1.Columns[nameof(StockTemplate.Name)].Caption = "Ad";
                gridView1.Columns[nameof(StockTemplate.TypeId)].Caption = "Tur_ID";
                gridView1.Columns[nameof(StockTemplate.InsertUser)].Caption = "Ekleyen Kullanıcı";
                gridView1.Columns[nameof(StockTemplate.InsertDate)].Caption = "Eklenme Tarihi";
                gridView1.Columns[nameof(StockTemplate.EditUser)].Caption = "Düzenleyen Kullanıcı";
                gridView1.Columns[nameof(StockTemplate.EditDate)].Caption = "Düzenlenme Tarihi";
                gridView1.Columns[nameof(StockTemplate.Active)].Caption = "Aktif";

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Islemler_Edit_SablonListesi_Edit fies = new frm_Islemler_Edit_SablonListesi_Edit(0);
            fies.Show();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                short aa = (short)dr["ID"];
                frm_Islemler_Edit_SablonListesi_Edit fies = new frm_Islemler_Edit_SablonListesi_Edit(aa);
                fies.Show();
            }

        }
    }
}