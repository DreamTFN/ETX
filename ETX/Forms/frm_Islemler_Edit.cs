using DevExpress.XtraEditors.Controls;
using ETX.Classes;
using ETX.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ETX.Entities;
using System.Linq;
using System.Globalization;


namespace ETX.Forms
{
    public partial class frm_Islemler_Edit : DevExpress.XtraEditors.XtraForm
    {
        int ID = 0;
        public frm_Islemler_Edit(int income_ID)
        {
            InitializeComponent();
            ID = income_ID;

            Get_Data();
            Fill_comboBoxs();
        }

        private void Fill_comboBoxs()
        {
            //islemgrubu_lookUpEdit
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    string query = "select C.ID, Grup = C.Name from dbo.StockGroup C order by C.Name";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            islemgrubu_lookUpEdit.Properties.DataSource = dataTable;
                            islemgrubu_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Grup", 100, "Grup"));
                            islemgrubu_lookUpEdit.Properties.DisplayMember = "Grup";
                            islemgrubu_lookUpEdit.Properties.ValueMember = "ID";
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //altgrubu_lookUpEdit
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    string query = "select C.ID, Alt_Grup = C.Name from dbo.StockSubGroup C order by C.Name";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            altgrubu_lookUpEdit.Properties.DataSource = dataTable;
                            altgrubu_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Alt_Grup", 100, "Alt_Grup"));
                            altgrubu_lookUpEdit.Properties.DisplayMember = "Alt_Grup";
                            altgrubu_lookUpEdit.Properties.ValueMember = "ID";
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //birimi_lookUpEdit
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    string query = "select C.ID, Birim = C.Name from dbo.StockUnitType C order by C.Name";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            birimi_lookUpEdit.Properties.DataSource = dataTable;
                            birimi_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Birim", 100, "Birim"));
                            birimi_lookUpEdit.Properties.DisplayMember = "Birim";
                            birimi_lookUpEdit.Properties.ValueMember = "ID";
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //marka_lookUpEdit
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    string query = "select C.ID, Marka = C.Name from dbo.Brand C order by C.Name";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            marka_lookUpEdit.Properties.DataSource = dataTable;
                            marka_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Marka", 100, "Marka"));
                            marka_lookUpEdit.Properties.DisplayMember = "Marka";
                            marka_lookUpEdit.Properties.ValueMember = "ID";
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }


        private void Get_Data()
        {
            if (ID > 0)
            {
                frm_Islemler_Edit_tools fst = new frm_Islemler_Edit_tools();

                Dictionary<String, String> dtr = fst.get_Islemler_Edit_data(ID);

                islemkodu_textEdit.Text = dtr["Code"];
                islemadi_textEdit.Text = dtr["Name"];
                tipi_lookUpEdit.EditValue = int.Parse(dtr["Type_ID"]);
                islemgrubu_lookUpEdit.EditValue = int.Parse(dtr["Group_ID"]);
                birimi_lookUpEdit.EditValue = int.Parse(dtr["Unit_ID"]);
                altgrubu_lookUpEdit.EditValue = int.Parse(dtr["Sub_Group_ID"]);
                marka_lookUpEdit.EditValue = int.Parse(dtr["Brand_ID"]);
                serino_textEdit.Text = dtr["Series_No"];
                barkod_textEdit.Text = dtr["Barcode"];
                tuketimhizi_textEdit.Text = dtr["Consumption_Rate_ID"];
                aciklama_memoEdit.Text = dtr["Exp"];
                adetlitremiktari_textEdit.Text = dtr["Piece"];
                hacim_textEdit.Text = dtr["Volume"];
                adetkgmiktari_textEdit.Text = dtr["Kg"];
                birimfiyat_textEdit.Text = dtr["Unit_Price"];
                kdvorani_textEdit.Text = dtr["Vat_Rate"];
                byte Vat_Included = byte.Parse(dtr["Vat_Included"]);
                kdvdahil_comboBoxEdit.SelectedIndex = Vat_Included;
                byte Active = byte.Parse(dtr["Active"]);
                durum_comboBoxEdit.SelectedIndex = Active;
            }


        }

        private void guncelle_Button_Click(object sender, EventArgs e)
        {

            bool control = false;

            if (islemkodu_textEdit.Text.Length == 0) { MessageBox.Show("Lütfen işlem kodu alanını doldurun !"); }
            else if (islemadi_textEdit.Text.Length == 0) { MessageBox.Show("Lütfen işlem adı alanını doldurun !"); }
            else { control = true; }

            if (control == true)
            {

                String Code_2 = (islemkodu_textEdit.Text.Length > 0) ? islemkodu_textEdit.Text : null;

                String Name_2 = (islemadi_textEdit.Text.Length > 0) ? islemadi_textEdit.Text : null;

                short Type_ID = 0; if (tipi_lookUpEdit.EditValue != null) { Type_ID = short.TryParse(tipi_lookUpEdit.EditValue.ToString(), out short parsedValue) ? parsedValue : Type_ID; }

                short Group_ID = 0; if (islemgrubu_lookUpEdit.EditValue != null) { Group_ID = short.TryParse(islemgrubu_lookUpEdit.EditValue.ToString(), out short parsedValue) ? parsedValue : Group_ID; }

                short Sub_Group_ID = 0; if (altgrubu_lookUpEdit.EditValue != null) { Sub_Group_ID = short.TryParse(altgrubu_lookUpEdit.EditValue.ToString(), out short parsedValue) ? parsedValue : Sub_Group_ID; }

                byte Unit_ID = 0; if (birimi_lookUpEdit.EditValue != null) { Unit_ID = byte.TryParse(birimi_lookUpEdit.EditValue.ToString(), out byte parsedValue) ? parsedValue : Unit_ID; }

                short Brand_ID = 0; if (marka_lookUpEdit.EditValue != null) { Brand_ID = short.TryParse(marka_lookUpEdit.EditValue.ToString(), out short parsedValue) ? parsedValue : Brand_ID; }

                String Series_No = (serino_textEdit.Text.Length > 0) ? serino_textEdit.Text : null;

                String Barcode = (barkod_textEdit.Text.Length > 0) ? barkod_textEdit.Text : null;

                byte Consumption_Rate_ID = 0; if (tuketimhizi_textEdit.EditValue != null) { Consumption_Rate_ID = byte.TryParse(tuketimhizi_textEdit.EditValue.ToString(), out byte parsedValue) ? parsedValue : Consumption_Rate_ID; }

                String Exp = (aciklama_memoEdit.Text.Length > 0) ? aciklama_memoEdit.Text : null;

                short Piece = 0; if (adetlitremiktari_textEdit.EditValue != null) { Piece = short.TryParse(adetlitremiktari_textEdit.EditValue.ToString(), out short parsedValue) ? parsedValue : Piece; }

                decimal Kg = decimal.TryParse(adetkgmiktari_textEdit.Text, out Kg) ? Kg : 0;

                decimal Volume = decimal.TryParse(hacim_textEdit.Text, out Volume) ? Volume : 0;

                double Unit_Price = double.TryParse(birimfiyat_textEdit.Text, out Unit_Price) ? Unit_Price : 0;

                double Vat_Rate = double.TryParse(kdvorani_textEdit.Text, out Vat_Rate) ? Vat_Rate : 0;

                bool Vat_Included = false; if (kdvdahil_comboBoxEdit.EditValue != null) { Vat_Included = (kdvdahil_comboBoxEdit.SelectedIndex == 1) ? true : false; }

                bool Active = false; if (durum_comboBoxEdit.EditValue != null) { Active = (durum_comboBoxEdit.SelectedIndex == 1) ? true : false; }


                Context.EtxContext context = new Context.EtxContext();

                StockCard stokcard = new StockCard();

                if (ID > 0) //update
                {

                    var context2 = new Context.EtxContext();
                    FormattableString sql = $"SELECT ID, Code, Name, Type_ID, Group_ID, Sub_Group_ID, Unit_ID, Brand_ID, Series_No, Barcode, Consumption_Rate_ID, Exp, Piece, Lt, Kg, Volume, Unit_Price, Vat_Rate, Vat_Included, Insert_User, Insert_Date, Edit_User, Edit_Date = getdate(), Active from StockCard where ID = {ID}";
                    var book = context2.StockCards.FromSql(sql).FirstOrDefault();

                    String insdate = book.InsertDate.ToString();
                    DateTime insertDate = DateTime.ParseExact(insdate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    String edtdate = book.EditDate.ToString();
                    DateTime editDate = DateTime.ParseExact(edtdate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    //farklı bir context nesnesi oluşturulmalı çünkü birinden select diğerinden update kaydı böyle yapılabiliyor. Edit_Date queryden gelen değer olaracağı için getdate () ile döndürüldü 



                    stokcard.Id = ID;
                    stokcard.Code = Code_2;
                    stokcard.Name = Name_2;
                    stokcard.TypeId = Type_ID;
                    if (Group_ID > 0) { stokcard.GroupId = Group_ID; }
                    if (Sub_Group_ID > 0) { stokcard.SubGroupId = Sub_Group_ID; }
                    if (Unit_ID > 0) { stokcard.UnitId = Unit_ID; }
                    if (Brand_ID > 0) { stokcard.BrandId = Brand_ID; }
                    if (Series_No != null) { stokcard.SeriesNo = Series_No; }
                    if (Barcode != null) { stokcard.Barcode = Barcode; }
                    if (Consumption_Rate_ID > 0) { stokcard.ConsumptionRateId = Consumption_Rate_ID; }
                    if (Exp != null) { stokcard.Exp = Exp; }
                    if (Piece > 0) { stokcard.Piece = Piece; }
                    if (Kg > 0) { stokcard.Kg = Kg; }
                    if (Vat_Rate > 0) { stokcard.VatRate = Vat_Rate; }
                    if (Volume > 0) { stokcard.Volume = Volume; }
                    if (Unit_Price > 0) { stokcard.UnitPrice = Unit_Price; }
                    stokcard.VatIncluded = Vat_Included;
                    stokcard.Active = Active;
                    stokcard.EditUser = (short)Tools.user_ID;
                    stokcard.InsertDate = insertDate;
                    stokcard.EditDate = editDate;

                    context.Entry(stokcard).State = EntityState.Modified;
                    int rowsAffected = context.SaveChanges();

                    if (rowsAffected > 0) { MessageBox.Show("İşlem kaydı yapıldı !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else //insert 
                {
                    bool isCodeUnique = context.StockCards.Any(s => s.Code == Code_2);

                    if (isCodeUnique) { MessageBox.Show("Stok kodu sisteme kayıtlı. Lütfen kontrol edin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {

                        stokcard.Code = Code_2;
                        stokcard.Name = Name_2;
                        stokcard.TypeId = Type_ID;
                        if (Group_ID > 0) { stokcard.GroupId = Group_ID; }
                        if (Sub_Group_ID > 0) { stokcard.SubGroupId = Sub_Group_ID; }
                        if (Unit_ID > 0) { stokcard.UnitId = Unit_ID; }
                        if (Brand_ID > 0) { stokcard.BrandId = Brand_ID; }
                        if (Series_No != null) { stokcard.SeriesNo = Series_No; }
                        if (Barcode != null) { stokcard.Barcode = Barcode; }
                        if (Consumption_Rate_ID > 0) { stokcard.ConsumptionRateId = Consumption_Rate_ID; }
                        if (Exp != null) { stokcard.Exp = Exp; }
                        if (Piece > 0) { stokcard.Piece = Piece; }
                        if (Kg > 0) { stokcard.Kg = Kg; }
                        if (Vat_Rate > 0) { stokcard.VatRate = Vat_Rate; }
                        if (Volume > 0) { stokcard.Volume = Volume; }
                        if (Unit_Price > 0) { stokcard.UnitPrice = Unit_Price; }
                        stokcard.VatIncluded = Vat_Included;
                        stokcard.Active = Active;
                        stokcard.InsertUser = (short)Tools.user_ID;

                        context.Add(stokcard);

                        context.SaveChanges();

                        int insertedId = stokcard.Id;

                        if (insertedId > 0) { ID = insertedId; MessageBox.Show("İşlem kaydı yapıldı !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                }


            }


        }

        private void sil_Button_Click(object sender, EventArgs e)
        {

            if (ID > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Context.EtxContext context = new Context.EtxContext();

                    var stockCardToDelete = context.StockCards.FirstOrDefault(s => s.Id == ID);

                    if (stockCardToDelete != null)
                    {
                        context.StockCards.Remove(stockCardToDelete);
                        int rtn = context.SaveChanges();

                        if (rtn > 0)
                        {
                            MessageBox.Show("İşlem kaydı silindi !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
    }
}