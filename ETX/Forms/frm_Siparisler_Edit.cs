using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using ETX.Classes;
using ETX.Context;
using ETX.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using NCalc;
using DevExpress.XtraSpreadsheet.Model;
//using Matheval;
using DevExpress.CodeParser.VB.Preprocessor;

namespace ETX.Forms
{
    public partial class frm_Siparisler_Edit : DevExpress.XtraEditors.XtraForm
    {
        int ID = 0;
        int Client_ID = 0;

        decimal Onceki_Miktar = 0;
        decimal Sonraki_Miktar = 0;
        decimal Onceki_Toplam_Tutar = 0;
        decimal Sonraki_Toplam_Tutar = 0;
        DateTime Insert_Date = DateTime.Now;
        public frm_Siparisler_Edit(int income_ID)
        {
            InitializeComponent();
            ID = income_ID;
            Form_Apperance(ID);
            musteriadi_textBox.ReadOnly = true;
            musterisoyadi_textBox.ReadOnly = true;

            katilimcisayisi_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            katilimcisayisi_textEdit.Properties.Mask.EditMask = "n0";
            katilimcisayisi_textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;

        }

        // DateTime.Parse ()

        public void Form_Apperance(int ID)
        {
            if (ID > 0)
            {
                Fill_ComboBoxes();
                Fill_Top_Datas(ID);
                Fill_DataGrid(ID);
                islemler_groupControl.Enabled = true;
                delete_Button.Visible = true;
                save_Button.Text = "Güncelle";
            }
            else
            {
                Fill_ComboBoxes();
                islemler_groupControl.Enabled = false;
                delete_Button.Visible = false;

            }
        }


        private void Anlasmaya_Gore_Guncelle(int Agreement_ID, int Siparis_ID, int Islem_ID, int Kisi_Sayisi, string Fizikel_Alan)
        {
            Agreement_ID = 3;
            Islem_ID = 317;
            Kisi_Sayisi = 150;

            if (Agreement_ID > 0 && Kisi_Sayisi > 0)
            {
                
                try
                {
                    string Formula = "";
                    using (var context = new EtxContext())
                    {
                        var List = (from DetAgr in context.AgreementDets
                                    where DetAgr.MastId == Agreement_ID
                                    where DetAgr.StockCardId == Islem_ID
                                    select new
                                    {
                                        DetAgr.Formula,
                                    }
                                    ).ToList();

                        foreach (var item in List)
                        {
                            Formula = item.Formula;
                            break;
                        }
                    }

                    if (Formula.Length > 1)
                    {

                        Expression expr = new Expression(Formula);

                        if (Formula.Contains("K2")) { expr.Parameters["K2"] = Kisi_Sayisi; } // kişi sayısı
                        if (Formula.Contains("FA")) { expr.Parameters["FA"] = Fizikel_Alan; } // fiziksel alan

                        decimal Fiyat_Katsayisi = decimal.TryParse (expr.Evaluate().ToString(), out decimal result) ? result : 0 ;

                        Console.WriteLine(Fiyat_Katsayisi); // 25

                    }

                }
                catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                if (Islem_ID == 0) // bütün işlemleri güncelle
                {

                }
                else
                {

                }
               

            }


            /*

                    foreach (var c in result)
                    {
                        islemadi_textBox.Text = c.Name;
                        tarih_dateEdit.Text = c.Date_.ToString();
                        bool aa = bool.TryParse(c.Pay_Type.ToString(), out aa);
                        int Pay_Type = (aa == true) ? 1 : 0;
                        odemeturu_comboBox.SelectedIndex = Pay_Type;
                        tc_textBox.Text = c.SSN;
                        musteriadi_textBox.Text = c.Person_Name;
                        musterisoyadi_textBox.Text = c.Person_Surname;
                        exp_memoEdit.Text = c.Exp;

                        int Hall_ID = 0;
                        bool hl_select = int.TryParse(c.Hall_ID.ToString(), out Hall_ID);
                        fizikialan_lookUpEdit.EditValue = (hl_select == true) ? Hall_ID : 0;
                        int Agreement_ID = 0;
                        bool agr_select = int.TryParse(c.Agreement_ID.ToString(), out Agreement_ID);
                        anlasma_lookUpEdit.EditValue = (agr_select == true) ? Agreement_ID : 0;
                        katilimcisayisi_textEdit.Text = c.Attendee_Count.ToString();
                        Insert_Date = DateTime.ParseExact(c.Insert_Date.ToString(), new[] { "dd.MM.yyyy HH:mm:ss", "d.MM.yyyy HH:mm:ss", "dd.M.yyyy HH:mm:ss", "d.M.yyyy HH:mm:ss", "yyyyMMdd HH:mm:ss" }, new System.Globalization.CultureInfo("tr-TR"), System.Globalization.DateTimeStyles.None);

                    }

             using NCalc;

            // Veritabanından gelen formül
            string formula = "IF(K2 >= 150, 25, 10)";

            // NCalc nesnesi oluştur
            Expression expr = new Expression(formula);

            // Parametreleri tanımla
            expr.Parameters["K2"] = 150;

            // Formülü değerlendir
            int Fiyat_Katsayisi = Convert.ToInt32(expr.Evaluate());

            // Sonucu yazdır
            Console.WriteLine(Fiyat_Katsayisi); // 25

             */


        }

        private void Fill_DataGrid(int ID)
        {
            frm_Siparisler_Edit_tools fset = new frm_Siparisler_Edit_tools();
            gridControl1.DataSource = fset.get_Siparisler_Grid_Datas(ID);

            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["Işlem Kodu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Stok Adı"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Miktar"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Birim Fiyatı"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Tutar"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["KDV"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Grubu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Alt Grubu"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Orjinal Birim Fiyatı"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Toplam"].OptionsColumn.AllowEdit = true;

            gridView1.Columns["Işlem Kodu"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["Miktar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Miktar"].SummaryItem.DisplayFormat = "{0:n2}";
            gridView1.Columns["Tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Tutar"].SummaryItem.DisplayFormat = "{0:n2}";
            gridView1.Columns["KDV"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["KDV"].SummaryItem.DisplayFormat = "{0:n2}";
            gridView1.Columns["Toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Toplam"].SummaryItem.DisplayFormat = "{0:n2}";
            gridView1.OptionsView.ShowFooter = true;
            // Handle the CustomSummaryCalculate event
            gridView1.CustomSummaryCalculate += gridView1_CustomSummaryCalculate;

        }

        private void UpdateForm_DataUpdated(object sender, EventArgs e)
        {
            Fill_DataGrid(ID);
        }


        private int Client_Check(String SSN)
        {

            if (SSN.Length == 10 || SSN.Length == 11)
            {
                frm_Siparisler_Edit_tools fst = new frm_Siparisler_Edit_tools();
                Dictionary<String, String> dsd = fst.get_Client_Datas(SSN);

                if (dsd.Count > 0)
                {
                    Client_ID = (dsd["Client_ID"].Length > 0) ? int.Parse(dsd["Client_ID"]) : 0;
                    musteriadi_textBox.Text = dsd["Person_Name"];
                    musterisoyadi_textBox.Text = dsd["Person_Surname"];
                }
            }

            if (Client_ID == 0) /*sorgu client ID döndürmediyse eklenebilmesi için ad soyad alanını aç*/
            {
                musteriadi_textBox.ReadOnly = false;
                musterisoyadi_textBox.ReadOnly = false;
            }


            return Client_ID;

        }

        private void Fill_ComboBoxes()
        {
            /*
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();

                    string query = "select ID, Tur = Name from dbo.StockOrderKind where Active = 1 order by Name";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            tur_lookUpEdit.Properties.DataSource = dataTable;

                            tur_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Tur", 100, "Tur"));

                            tur_lookUpEdit.Properties.DisplayMember = "Tur";
                            tur_lookUpEdit.Properties.ValueMember = "ID";
                        }
                    }{


                    conn.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            */

            //anlasma fill 
            using (var context = new Context.EtxContext())
            {
                var list = (from agr in context.Agreements
                            where agr.Active == true
                            select new
                            {
                                agr.Id,
                                agr.Name,
                            }).ToList();

                anlasma_lookUpEdit.Properties.DataSource = list;
                anlasma_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Name", 100, "Adı"));
                anlasma_lookUpEdit.Properties.ValueMember = "Id";
                anlasma_lookUpEdit.Properties.DisplayMember = "Name";
            }

            //fiziki alan fill
            using (var context = new Context.EtxContext())
            {
                var list = (from hl in context.Halls
                            where hl.Active == true
                            select new
                            {
                                hl.Id,
                                hl.Name,
                            }
                            ).ToList();
                fizikialan_lookUpEdit.Properties.DataSource = list;
                fizikialan_lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Name", 100, "Adı"));
                fizikialan_lookUpEdit.Properties.ValueMember = "Id";
                fizikialan_lookUpEdit.Properties.DisplayMember = "Name";
            }


        }


        private void Fill_Top_Datas(int ID)
        {
            //Fill_tur_comboBox ();

            if (ID > 0)
            {

                using (var context = new EtxContext())
                {
                    var result = from so in context.StockOrders
                                 join c in context.Clients on so.ClientId equals c.Id into cj
                                 from c in cj.DefaultIfEmpty()
                                 where so.Id == ID
                                 select new
                                 {
                                     Name = so.Name,
                                     Date_ = so.Date,
                                     Pay_Type = so.PayType,
                                     SSN = c.Ssn,
                                     Person_Name = c.Name + c.PersonName,
                                     Person_Surname = c.PersonSurname,
                                     Exp = so.Exp,
                                     Kind_ID = so.KindId,
                                     Hall_ID = so.HallId,
                                     Agreement_ID = so.AgreementId,
                                     Attendee_Count = so.AttendeeCount,
                                     Request_Storage_ID = so.RequestStorageId,
                                     Insert_Date = so.InsertDate,
                                     Edit_Date = so.EditDate,
                                     //Insert_User_Name   = context.GetUsername(so.InsertUser, so.InsertDate).FirstOrDefault().Username,
                                     //Edit_User_Name     = so.EditUser > 0 ? context.GetUsername(so.EditUser, so.EditDate).FirstOrDefault()?.Username : null,
                                     //Client_ID          = so.ClientId,
                                 };


                    foreach (var c in result)
                    {
                        islemadi_textBox.Text = c.Name;
                        tarih_dateEdit.Text = c.Date_.ToString();
                        bool aa = bool.TryParse(c.Pay_Type.ToString(), out aa);
                        int Pay_Type = (aa == true) ? 1 : 0;
                        odemeturu_comboBox.SelectedIndex = Pay_Type;
                        tc_textBox.Text = c.SSN;
                        musteriadi_textBox.Text = c.Person_Name;
                        musterisoyadi_textBox.Text = c.Person_Surname;
                        exp_memoEdit.Text = c.Exp;

                        int Hall_ID = 0;
                        bool hl_select = int.TryParse(c.Hall_ID.ToString(), out Hall_ID);
                        fizikialan_lookUpEdit.EditValue = (hl_select == true) ? Hall_ID : 0;
                        int Agreement_ID = 0;
                        bool agr_select = int.TryParse(c.Agreement_ID.ToString(), out Agreement_ID);
                        anlasma_lookUpEdit.EditValue = (agr_select == true) ? Agreement_ID : 0;
                        katilimcisayisi_textEdit.Text = c.Attendee_Count.ToString();
                        Insert_Date = DateTime.ParseExact(c.Insert_Date.ToString(), new[] { "dd.MM.yyyy HH:mm:ss", "d.MM.yyyy HH:mm:ss", "dd.M.yyyy HH:mm:ss", "d.M.yyyy HH:mm:ss", "yyyyMMdd HH:mm:ss" }, new System.Globalization.CultureInfo("tr-TR"), System.Globalization.DateTimeStyles.None);

                    }

                }

            }
        }

        private void tc_ara_Button_Click(object sender, EventArgs e)
        {
            String SSN = tc_textBox.Text;
            Client_Check(SSN);
        }

        private void save_Button_Click(object sender, EventArgs e)
        {

            int control = 0;
            if (tc_textBox.Text.Length < 10 && tc_textBox.Text.Length > 11) { MessageBox.Show("Tc / Verigi No alanını hatalı !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { Client_ID = Client_Check(tc_textBox.Text); }

            if (islemadi_textBox.Text.Length == 0) { MessageBox.Show("Lütfen işlem adı alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (fizikialan_lookUpEdit.Text.Length == 0) { MessageBox.Show("Lütfen fiziki alan alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (tarih_dateEdit.Text.Length == 0) { MessageBox.Show("Lütfen işlem tarih alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (odemeturu_comboBox.Text.Length == 0) { MessageBox.Show("Lütfen ödeme türü alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (musteriadi_textBox.Text.Length == 0) { MessageBox.Show("Lütfen müşteri adı alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (katilimcisayisi_textEdit.Text.Length == 0) { MessageBox.Show("Lütfen katılımcı sayısı alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                control = 1;
            }


            if (control > 0)
            {
                if (ID > 0)
                {
                    try
                    {

                        using (var context = new EtxContext())
                        {

                            StockOrder so = new StockOrder();

                            so.Id = ID;
                            so.Name = islemadi_textBox.Text;
                            so.ClientId = (short)Client_ID;
                            so.Date = tarih_dateEdit.DateTime;
                            so.Exp = exp_memoEdit.Text;
                            so.PayType = (byte)odemeturu_comboBox.SelectedIndex;
                            so.InsertUser = (short)Tools.user_ID;
                            so.InsertDate = Insert_Date;
                            so.RequestStorageId = 1;

                            if (anlasma_lookUpEdit.EditValue != null)
                            {
                                short agreementIdValue;
                                bool agr_success = Int16.TryParse(anlasma_lookUpEdit.EditValue.ToString(), out agreementIdValue);
                                if (agr_success) { so.AgreementId = agreementIdValue; }
                            }
                            so.AttendeeCount = int.Parse(katilimcisayisi_textEdit.Text);
                            so.HallId = Int16.Parse(fizikialan_lookUpEdit.EditValue.ToString());
                            context.Update(so);
                            int rtn = context.SaveChanges();

                            if (rtn > 0)
                            {
                                OnDataUpdated_F();
                                Form_Apperance(ID);
                                MessageBox.Show("İşlem kayıt yapıldı !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else { MessageBox.Show("İşlem başarısız, lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                else
                {
                    using (var context = new EtxContext())
                    {

                        StockOrder so = new StockOrder();

                        so.Name = islemadi_textBox.Text;
                        so.ClientId = (short)Client_ID;
                        so.Date = tarih_dateEdit.DateTime;
                        so.Exp = exp_memoEdit.Text;
                        so.PayType = (byte)odemeturu_comboBox.SelectedIndex;
                        so.InsertUser = (short)Tools.user_ID;
                        so.RequestStorageId = 1;
                        if (anlasma_lookUpEdit.EditValue != null)
                        {
                            short agreementIdValue;
                            bool agr_success = Int16.TryParse(anlasma_lookUpEdit.EditValue.ToString(), out agreementIdValue);
                            if (agr_success) { so.AgreementId = agreementIdValue; }
                        }
                        so.AttendeeCount = int.Parse(katilimcisayisi_textEdit.Text);
                        so.HallId = Int16.Parse(fizikialan_lookUpEdit.EditValue.ToString());
                        context.Add(so);
                        int rnt = context.SaveChanges();

                        if (rnt > 0)
                        {
                            ID = so.Id;
                            OnDataUpdated_F();
                            Form_Apperance(ID);
                            MessageBox.Show("İşlem kayıt yapıldı !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { MessageBox.Show("İşlem başarısız, lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

                }



                /*
                frm_Siparisler_Edit_tools fedt = new frm_Siparisler_Edit_tools();

                if (Client_ID == 0)
                {
                    Client_ID = fedt.save_Client_Datas(musteriadi_textBox.Text, musterisoyadi_textBox.Text, tc_textBox.Text, Tools.user_ID);
                }

                String Pay_Period = "0";
                int Plasiyer_Person_ID = 0;
                int Request_Storage_ID = 1;
                int rtn_ID = 0;
                int Kind_ID = int.Parse(tur_lookUpEdit.EditValue.ToString());

                DateTime Tarih = tarih_dateEdit.DateTime;

                rtn_ID = fedt.save_Siparisler_Top_Datas(ID, islemadi_textBox.Text, Kind_ID, Client_ID, Tarih, Tarih, exp_memoEdit.Text, odemeturu_comboBox.SelectedIndex, Pay_Period, Plasiyer_Person_ID, Tools.user_ID, Request_Storage_ID);

                ID = rtn_ID;

                if (rtn_ID > 0)
                {
                    OnDataUpdated_F();
                    Form_Apperance(rtn_ID);
                    MessageBox.Show("İşlem kayıt yapıldı !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("İşlem başarısız, lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                */
            }
        }

        public event EventHandler DataUpdated_F;
        protected virtual void OnDataUpdated_F()
        {
            DataUpdated_F?.Invoke(this, EventArgs.Empty);
        }

        private void islemekle_Button_Click(object sender, EventArgs e)
        {
            frm_Siparisler_Edit_IslemListesi_Edit dd = new frm_Siparisler_Edit_IslemListesi_Edit(ID);
            dd.DataUpdated += UpdateForm_DataUpdated;
            dd.Show();
        }

        private void islemkaldir_Button_Click(object sender, EventArgs e)
        {
            frm_Siparisler_Edit_tools dd = new frm_Siparisler_Edit_tools();

            int[] selectedRows = gridView1.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (int rowHandle in selectedRows)
                    {
                        long Tra_ID = (long)gridView1.GetRowCellValue(rowHandle, "ID");
                        dd.delete_Process(Tra_ID);
                    }

                    Fill_DataGrid(ID);
                }
            }
            else { MessageBox.Show("Lütfen silmek istediğiniz işlemleri seçin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            int del = 0;
            frm_Siparisler_Edit_tools dd = new frm_Siparisler_Edit_tools();
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                del = dd.delete_Siparis(ID);
            }

            if (del > 0)
            {
                OnDataUpdated_F();
                MessageBox.Show("İşlem kaydı başarıyla silindi !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else { MessageBox.Show("İşlem kaydı silinemedi !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                e.TotalValue = view.RowCount; // Line count
            }
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Miktar")
            {
                object cellValue = view.GetFocusedRowCellValue("Miktar");
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    if (decimal.TryParse(cellValue.ToString(), out decimal parsedValue)) { Onceki_Miktar = parsedValue; }
                    else { MessageBox.Show("Miktar alanı hatalı lütfen kontrol edin !"); }
                }
                else
                {
                    MessageBox.Show("Miktar alanı hatalı lütfen kontrol edin !");
                }
            }

            else if (view.FocusedColumn.FieldName == "Tutar")
            {
                object cellValue = view.GetFocusedRowCellValue("Tutar");
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    if (decimal.TryParse(cellValue.ToString(), out decimal parsedValue)) { Onceki_Toplam_Tutar = parsedValue; }
                    else { MessageBox.Show("Tutar alanı hatalı lütfen kontrol edin !"); }
                }
                else
                {
                    MessageBox.Show("Tutar alanı hatalı lütfen kontrol edin !");
                }
            }


        }

        private void gridView1_HiddenEditor(object sender, EventArgs e)
        {
            frm_Siparisler_Edit_tools set = new frm_Siparisler_Edit_tools();

            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Miktar")
            {
                object cellValue = view.GetFocusedRowCellValue("Miktar");
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    if (decimal.TryParse(cellValue.ToString(), out decimal parsedValue))
                    {
                        Sonraki_Miktar = parsedValue;

                        if (Onceki_Miktar != Sonraki_Miktar)
                        {
                            decimal Vat_Rate = 0;
                            int StockOrderTra_ID = 0;
                            decimal Unit_Price = 0;

                            if (int.TryParse(view.GetFocusedRowCellValue("ID").ToString(), out int parsedval)) { StockOrderTra_ID = parsedval; }
                            if (decimal.TryParse(view.GetFocusedRowCellValue("KDV Oranı").ToString(), out decimal parsedval2)) { Vat_Rate = parsedval2; }
                            if (decimal.TryParse(view.GetFocusedRowCellValue("Birim Fiyatı").ToString(), out decimal parsedval3)) { Unit_Price = parsedval3; }

                            int rtn = set.add_update_Process(ID, 0, 0, 2, StockOrderTra_ID, 0, Sonraki_Miktar);
                            if (rtn > 0) { Fill_DataGrid(ID); }

                        }
                    }
                    else { MessageBox.Show("Miktar alanı hatalı lütfen kontrol edin !"); }
                }
                else { MessageBox.Show("Miktar alanı hatalı lütfen kontrol edin !"); }
            }

            else if (view.FocusedColumn.FieldName == "Toplam")
            {
                object cellValue = view.GetFocusedRowCellValue("Toplam");
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    if (decimal.TryParse(cellValue.ToString(), out decimal parsedValue))
                    {
                        Sonraki_Toplam_Tutar = parsedValue;

                        if (Onceki_Toplam_Tutar != Sonraki_Toplam_Tutar)
                        {
                            decimal Vat_Rate = 0;
                            int StockOrderTra_ID = 0;
                            decimal Toplam_Miktar = 0;

                            if (int.TryParse(view.GetFocusedRowCellValue("ID").ToString(), out int parsedval)) { StockOrderTra_ID = parsedval; }
                            if (decimal.TryParse(view.GetFocusedRowCellValue("KDV Oranı").ToString(), out decimal parsedval2)) { Vat_Rate = parsedval2; }
                            if (decimal.TryParse(view.GetFocusedRowCellValue("Miktar").ToString(), out decimal parsedval3)) { Toplam_Miktar = parsedval3; }

                            int rtn = set.add_update_Process(ID, 0, 0, 3, StockOrderTra_ID, Sonraki_Toplam_Tutar, Toplam_Miktar);
                            if (rtn > 0) { Fill_DataGrid(ID); }

                        }
                    }
                    else { MessageBox.Show("Tutar alanı hatalı lütfen kontrol edin !"); }
                }
                else { MessageBox.Show("Tutar alanı hatalı lütfen kontrol edin !"); }
            }



        }

        private void frm_Siparisler_Edit_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int KS = int.TryParse(katilimcisayisi_textEdit.Text, out int result) ? result : 0;
            int Agreement_ID = int.TryParse (anlasma_lookUpEdit.Properties.ValueMember, out int result2) ? result2 : 0;

            string Fiziksel_Alan = fizikialan_lookUpEdit.Properties.ValueMember;

            Anlasmaya_Gore_Guncelle(Agreement_ID, ID, 0, KS, Fiziksel_Alan);
        }
    }
}