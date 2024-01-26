using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETX.Classes
{
    internal class frm_Siparisler_tools
    {
        public DataTable Get_Data ()
        {

            DataTable dt = new DataTable ();

            try
            {
                using (SqlConnection conn = new SqlConnection (Tools.Constring))
                {
                    conn.Open ();
					String query =
                    @"with Cnts 
					as
					(
						select Tra_ID, sum (Quantity) Inserted_Quantity from dbo.StockOrderTraDet where Type_ =  0 group by Tra_ID
					),
					Last_
					as
					(
						select SO.ID, SO.Name, ISNULL(C.Name,'')+ISNULL(C.Person_Name,'')+' '+ISNULL(C.Person_Surname,'') Client_Name, SO.Date_, SO.Delivery_Date, SO.Exp, SO.Approve, 
						sum (SOT.Quantity) S_Quantity, sum (Total_Price) S_Price, sum (Total_Vat) S_Vat, dbo.username(SO.Insert_User, SO.Insert_Date) Insert_User_Name, SO.Insert_Date, 
						case when SO.Plasiyer_Person_ID = 0 then 'Sistem' else P.Name+' '+P.Surname end Plasiyer_Person_Name,
						ISNULL(sum (CT.Inserted_Quantity),0) Inserted_Quantity, SO.Plasiyer_Person_ID, SO.Client_ID, S.Name Request_Storage_Name, SO.Request_Storage_ID
						from dbo.StockOrder SO
						left join dbo.StockOrderTra SOT on SO.ID = SOT.Mast_ID and ISNULL(SOT.Cancel,0) = 0
						left join dbo.Client C on SO.Client_ID = C.ID
						left join dbo.Persons P on SO.Plasiyer_Person_ID = P.ID
						left join dbo.Storages S on SO.Request_Storage_ID = S.ID
						left join Cnts CT on SOT.ID = CT.Tra_ID
						group by SO.ID, SO.Name, C.Name, C.Person_Name, C.Person_Surname, SO.Date_, SO.Delivery_Date, SO.Exp, SO.Approve, SO.Insert_User, SO.Insert_Date, P.Name, P.Surname, SO.Plasiyer_Person_ID, SO.Client_ID, S.Name, SO.Request_Storage_ID
					)
					select L.ID, 
					[Adı]			= L.Name, 
					[Müşteri]		= L.Client_Name, 
					[Tarih]			= L.Date_, 
					[Açıklama]		= L.Exp, 
					[Miktar]		= round(L.S_Quantity,2), 
					[Tutar]			= round(L.S_Price,2), 
					[KDV]			= round (L.S_Vat,2), 
					[Ekleyen]		= L.Insert_User_Name, 
					[Ekleme Tarihi]	= L.Insert_Date, 
					[Depo]			= L.Request_Storage_Name 
					--L.Delivery_Date, 
					--L.Approve, 
					--L.Plasiyer_Person_Name, L.Inserted_Quantity, L.Plasiyer_Person_ID, L.Client_ID, 
					from Last_ L 
					where L.ID > 0
					order by L.Approve, L.Insert_Date desc";
                    using (SqlDataAdapter cmd = new SqlDataAdapter(query, conn))
					{
						cmd.Fill (dt);
					}


                    conn.Close();
                }

            } catch (Exception e) { MessageBox.Show(e.ToString()); }



            return dt;
        }

    }
}
