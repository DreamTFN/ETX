using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ETX.Classes
{
    internal class frm_Islemler_tools
    {

        public DataTable get_Islemler_Grid_data ()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open ();

                    String query =
                    @"select SC.ID, 
                    [İşlem Kodu]                = SC.Code, 
                    [İşlem Adı]                 = SC.Name, 
                    [Grubu]                     = SG.Name, 
                    [Alt Grubu]                 = SSG.Name, 
                    [Birimi]                    = SUT.Name, 
                    [Birim Fiyatı]              = ISNULL(round(SC.Unit_Price,2),0), 
                    [Birim Fiyatı (Kdv Dahil)]  = round(case when Vat_Included = 1 or ISNULL(SC.Vat_Rate, 0) = 0 then SC.Unit_Price else ISNULL(SC.Unit_Price,0) * ((100 + SC.Vat_Rate) / 100) end,2),
                    [Kdv Oranı]                 = SC.Vat_Rate, 
                    [Durum]                     = case SC.Active when 1 then 'Aktif' else 'Pasif' end
                    --SCR.Name Rate_Name, 
                    from dbo.StockCard SC 
                    left join dbo.StockGroup SG on SC.Group_ID = SG.ID
                    left join dbo.StockSubGroup SSG on SC.Sub_Group_ID = SSG.ID
                    left join dbo.StockUnitType SUT on SC.Unit_ID = SUT.ID
                    left join dbo.StockConsumptionRate SCR on SC.Consumption_Rate_ID = SCR.ID
                    left join dbo.Brand B on SC.Brand_ID = B.ID
                    where SC.Active = 1
                    order by SC.Name, SC.Code";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill (dt);
                    }
                    conn.Close();
                }

            } 
            catch ( Exception es) { MessageBox.Show(es.ToString()); }
            
            return dt;

        }


    }
}
