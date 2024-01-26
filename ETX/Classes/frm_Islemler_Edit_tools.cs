using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETX.Classes
{
    internal class frm_Islemler_Edit_tools
    {

        public Dictionary<String, String> get_Islemler_Edit_data(int ID)
        {
            Dictionary<String, String> dt = new Dictionary<String, String>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();

                    String query = @"select ID, Code, Name, Type_ID = ISNULL(Type_ID,0), Group_ID = ISNULL(Group_ID,0), Sub_Group_ID = ISNULL(Sub_Group_ID,0), Unit_ID = ISNULL(Unit_ID,0), 
                        Brand_ID = ISNULL(Brand_ID,0), Series_No, Barcode, Consumption_Rate_ID, Exp, Piece, Kg, Volume, Unit_Price, Vat_Rate, Vat_Included = ISNULL(Vat_Included,0), 
                        Active = ISNULL(Active,0) from dbo.StockCard where ID =@p1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", ID);

                        SqlDataReader dtr = cmd.ExecuteReader();
                        while (dtr.Read())
                        {

                            dt.Add("Code", dtr["Code"].ToString());
                            dt.Add("Name", dtr["Name"].ToString());
                            dt.Add("Type_ID", dtr["Type_ID"].ToString());
                            dt.Add("Group_ID", dtr["Group_ID"].ToString());
                            dt.Add("Unit_ID", dtr["Unit_ID"].ToString());
                            dt.Add("Sub_Group_ID", dtr["Sub_Group_ID"].ToString());
                            dt.Add("Brand_ID", dtr["Brand_ID"].ToString());
                            dt.Add("Series_No", dtr["Series_No"].ToString());
                            dt.Add("Barcode", dtr["Barcode"].ToString());
                            dt.Add("Consumption_Rate_ID", dtr["Consumption_Rate_ID"].ToString());
                            dt.Add("Exp", dtr["Exp"].ToString());
                            dt.Add("Piece", dtr["Piece"].ToString());
                            dt.Add("Volume", dtr["Volume"].ToString());
                            dt.Add("Kg", dtr["Kg"].ToString());
                            dt.Add("Unit_Price", dtr["Unit_Price"].ToString());
                            dt.Add("Vat_Rate", dtr["Vat_Rate"].ToString());

                            byte Vat_Included = (byte)((bool)dtr["Vat_Included"] ? 1 : 0);
                            byte Active = (byte)((bool)dtr["Active"] ? 1 : 0);
                            dt.Add("Vat_Included", Vat_Included.ToString());
                            dt.Add("Active", Active.ToString());

                        }
                    }
                    conn.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return dt;
        }


        public int save_Islemler_Edit_data(int ID, String Code, String Name, int Type_ID, int Group_ID, int Sub_Group_ID, int Unit_ID, int Brand_ID, String Series_No, String Barcode, byte Consumption_Rate_ID, String Exp, int Piece, decimal Volume, decimal Kg, decimal Unit_Price, decimal Vat_Rate, bool Vat_Included, bool Active)
        {
            int rtn_ID = 0;
            

             if (ID > 0) //update
             {

             }
             else //insert 
             {

             }

            return rtn_ID;
        }





    }
}
