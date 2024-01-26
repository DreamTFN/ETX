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
using NCalc;

namespace ETX.Forms
{
    public partial class frm_Anlasmalar_Edit : DevExpress.XtraEditors.XtraForm
    {
        short Mast_ID = 0;
        public frm_Anlasmalar_Edit(short ID)
        {
            InitializeComponent();
            Mast_ID = ID;

            if (Mast_ID > 0)
            {
                Fill_Top_Data();
                Fill_DataGrid();
            }
            else
            {
                tabNavigationPage2.Enabled = false;
            }
        }

        private void Fill_Top_Data()
        {

            using (var context = new Context.EtxContext())
            {
                Agreement agr = context.Agreements.FirstOrDefault(s => s.Id == Mast_ID);
                islemkodu_textBox.Text = agr.Code;
                islemadi_textBox.Text = agr.Name;
                durum_gridLookUpEdit.Text = agr.Active.ToString();
            }

        }

        private void Fill_DataGrid()
        {

            using (var context = new Context.EtxContext())
            {
                var result = (from SC in context.StockCards
                              join AD in context.AgreementDets on SC.Id equals AD.StockCardId
                              where AD.MastId == Mast_ID
                              select new
                              {
                                  ID = AD.Id,
                                  Stock_Name = SC.Name,
                                  Formula = AD.Formula,
                                  Insert_Date = AD.InsertDate,
                              }).ToList();

                islemler_gridControl.DataSource = result;
            }

        }


        private void Kaydet(short income_ID)
        {

            if (income_ID == 0) //insert
            {
                using (var context = new Context.EtxContext())
                {
                    Agreement agreement = new Agreement();

                    agreement.Active = true;
                    agreement.Code = islemkodu_textBox.Text;
                    agreement.Name = islemadi_textBox.Text;

                    context.Add(agreement);
                    context.SaveChanges();

                    Mast_ID = agreement.Id;

                    if (Mast_ID > 0)
                    {
                        groupControl2.Enabled = true;
                    }
                }

            }
            else
            {
                using (var context = new Context.EtxContext())
                {
                    Agreement agreement = new Agreement();

                    agreement.Id = income_ID;
                    agreement.Active = true;
                    agreement.Code = islemkodu_textBox.Text;
                    agreement.Name = islemadi_textBox.Text;

                    context.Update(agreement);
                    int affetedrow = context.SaveChanges();
                }

            }


        }


        private void kaydet_Button_Click(object sender, EventArgs e)
        {
            Kaydet(Mast_ID);
        }

        private void ekle_Button_Click(object sender, EventArgs e)
        {
            using (var context = new Context.EtxContext())
            {
                AgreementDet agrdet = new AgreementDet();

                string st_code = stockcardcode_textBox.Text;

                StockCard stockCard = context.StockCards.FirstOrDefault(s => s.Code == st_code);

                int control = 0;
                if (stockCard == null) { MessageBox.Show(st_code + " stok kodu ile bir stok kartı bulunamadı. Lütfen konrol edin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (!Forumla_Validation(formula_memoEdit.Text)) { MessageBox.Show(formula_memoEdit.Text + " girilen formül hatalı. Lütfen konrol edin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { control = 1; }


                if (control > 0)
                {
                    int StockCard_ID = stockCard.Id;
                    agrdet.Active = true;
                    agrdet.MastId = Mast_ID;
                    agrdet.StockCardId = StockCard_ID;
                    agrdet.Formula = formula_memoEdit.Text;
                    context.Add(agrdet);
                    int rtn = context.SaveChanges();

                    if (rtn > 0)
                    {
                        Fill_DataGrid();
                    }
                }

            }
        }

        public bool Forumla_Validation(String formula)
        {
            bool rtn = false;

            string formulaFromUser = formula;// "if (K1 > 0, 25, 0)";

            try
            {
                // Validate syntax
                Expression expression = new Expression(formulaFromUser);

                // Validate parameters
                ValidateParameters(expression);

                // Optional: Evaluate with dummy values
                EvaluateWithDummyValues(expression);

                Console.WriteLine("Formula is valid.");
                rtn = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return rtn;
        }



        static void ValidateParameters(Expression expression)
        {
            // Define a list of allowed parameters
            List<string> allowedParameters = new List<string> { "K1", "K2" };

            // Get the parameters used in the expression
            IEnumerable<string> usedParameters = expression.Parameters.Keys;

            // Check if all used parameters are allowed
            foreach (string parameter in usedParameters)
            {
                if (!allowedParameters.Contains(parameter))
                {
                    throw new Exception($"Parameter '{parameter}' is not allowed.");
                }
            }
        }

        static void EvaluateWithDummyValues(Expression expression)
        {
            // Set dummy parameter values
            expression.Parameters["K1"] = 5;
            expression.Parameters["K2"] = 8;

            // Attempt to evaluate with dummy values
            object result = expression.Evaluate();

            // If needed, check the result or handle exceptions during evaluation
            Console.WriteLine("Result: " + result);
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {

            if (Mast_ID > 0)
            {

                var msg_respond = MessageBox.Show("Silmek istediğinizden emin misiniz ? ", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (msg_respond == DialogResult.Yes)
                {
                    using (var context = new Context.EtxContext())
                    {
                        var del_val = context.Agreements.FirstOrDefault(s => s.Id == Mast_ID);
                        if (del_val != null)
                        {
                            context.Agreements.Remove(del_val);
                            int rnt = context.SaveChanges();

                            if (rnt > 0)
                            {
                                MessageBox.Show("İşlem kaydı silinidi !", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }


            }

        }

        private void kaldir_simpleButton_Click(object sender, EventArgs e)
        {
            int rowHandle = islemler_gridView.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                short value = (short)islemler_gridView.GetRowCellValue(rowHandle, islemler_gridView.Columns["ID"]);

                if (value > 0)
                {
                    var msg_respond = MessageBox.Show("Silmek istediğinizden emin misiniz ? ", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (msg_respond == DialogResult.Yes)
                    {
                        using (var context = new Context.EtxContext())
                        {
                            var del_val = context.AgreementDets.FirstOrDefault(s => s.Id == value);

                            if (del_val != null)
                            {
                                context.AgreementDets.Remove(del_val);
                                int rtn = context.SaveChanges();
                            }
                        }
                    }
                }
            }
        }

        private void info_Button_Click(object sender, EventArgs e)
        {
            frm_Anlasmalar_Edit_Ornek aeo = new frm_Anlasmalar_Edit_Ornek();
            aeo.Show();
        }


    }
}