using DevExpress.XtraEditors;
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
using DevExpress.XtraCharts;

namespace ETX.Forms
{
    public partial class frm_Islemler_Edit_SablonListesi_Edit : DevExpress.XtraEditors.XtraForm
    {

        Context.EtxContext context = new Context.EtxContext();
        short income_ID = 0;
        public frm_Islemler_Edit_SablonListesi_Edit(short ID)
        {
            InitializeComponent();
            income_ID = ID;

            Fill_Fields(income_ID);
        }


        private void Fill_Fields(int ID)
        {

            if (ID == 0)
            {
                islemler_groupControl.Enabled = false;
                sil_Button.Enabled = false;
            }
            else
            {
                int stockTemplateId = income_ID;
                StockTemplate stockTemplate = context.StockTemplates.FirstOrDefault(s => s.Id == stockTemplateId);

                islemkodu_textBox.Text = stockTemplate.Code;
                islemadi_textBox.Text = stockTemplate.Name;
                exp_memoEdit.Text = stockTemplate.Exp;
                tur_lookUpEdit.Text = stockTemplate.TypeId.ToString();
            }

        }

        private void Kaydet(int i_ID)
        {
            if (i_ID == 0)
            {
                StockTemplate stocktmp = new StockTemplate();

                stocktmp.Code = islemkodu_textBox.Text;
                stocktmp.Name = islemadi_textBox.Text;
                stocktmp.Exp = exp_memoEdit.Text;
                stocktmp.InsertUser = (short)Tools.user_ID;
                context.StockTemplates.Add(stocktmp);
                context.Update(stocktmp);

                income_ID = stocktmp.Id;
            }
            else
            {
                StockTemplate stocktedit = new StockTemplate();

                stocktedit.Id = (short)i_ID;
                stocktedit.Code = islemkodu_textBox.Text;
                stocktedit.Name = islemadi_textBox.Text;
                stocktedit.Exp = exp_memoEdit.Text;
                stocktedit.EditUser = (short)Tools.user_ID;
                stocktedit.EditDate = DateTime.Now;
                context.Update(stocktedit);

            }
        }

        private void Sil (short i_ID)
        {
            if (i_ID > 0)
            {
                var stockTempToDelete = context.StockTemplates.FirstOrDefault(s => s.Id == i_ID);
                context.StockTemplates.Remove(stockTempToDelete);
                int rtn = context.SaveChanges();
            }
            else
            {
                MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void kaydet_Button_Click(object sender, EventArgs e)
        {
            Kaydet (income_ID);
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {
            Sil (income_ID);
        }



    }
}