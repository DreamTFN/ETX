using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ETX.Classes
{
    internal class frm_Siparisler_Edit_tools
    {

        public Dictionary<String, String> get_Client_Datas (String SSN)
        {
            Dictionary<String, String> dt = new Dictionary<String, String>();
            try
            {
                using (SqlConnection conn = new SqlConnection (Tools.Constring))
                {
                    conn.Open ();
                    String query = "select top 1 ID, Name, concat (Name, Person_Name) Person_Name, Person_Surname from dbo.Client where SSN = @p1 order by Insert_Date desc";
                    using (SqlCommand cmd = new SqlCommand (query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", SSN);

                        using (SqlDataReader sq = cmd.ExecuteReader())
                        {
                            while (sq.Read())
                            {
                                dt.Add("Client_ID", sq["ID"].ToString());
                                dt.Add("Name", sq["Name"].ToString());
                                dt.Add("Person_Name", sq["Person_Name"].ToString());
                                dt.Add("Person_Surname", sq["Person_Surname"].ToString());
                            }
                        }

                    }
                    conn.Close();

                }
            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            return dt;
        }

        public int save_Client_Datas(String Person_Name, String Person_Surname, String SSN, int Insert_User)
        {
            int Client_ID = 0;
            //int rtn = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    String query = @"insert into dbo.Client (Name, Person_Name, Person_Surname, SSN, Insert_User, Special_Key) values (@Name, @Person_Name, @Person_Surname, @SSN, @Insert_User, 0); SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Person_Name);
                        cmd.Parameters.AddWithValue("@Person_Name", Person_Name);
                        cmd.Parameters.AddWithValue("@Person_Surname", Person_Surname);
                        cmd.Parameters.AddWithValue("@SSN", SSN);
                        cmd.Parameters.AddWithValue("@Insert_User", Insert_User);

                        Client_ID = Convert.ToInt32(cmd.ExecuteScalar());

                    }

                    conn.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }


            return Client_ID;
        }


        public Dictionary<String, String> get_Siparisler_Top_Datas(int ID)
        {
            Dictionary<String, String> dc = new Dictionary<String, string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    //int rtn = 0;
                    String query = @"select SO.Name, SO.Client_ID, SO.Date_, SO.Exp, SO.Pay_Type, SO.Request_Storage_ID, dbo.username (SO.Insert_User, SO.Insert_Date) Insert_User_Name, SO.Insert_Date, 
                    dbo.username (SO.Edit_User, SO.Edit_Date) Edit_User_Name, SO.Edit_Date, C.SSN, concat (C.Name,C.Person_Name) Person_Name, C.Person_Surname, SO.Kind_ID 
                    from dbo.StockOrder SO
                    left join dbo.Client C on SO.Client_ID = C.ID 
                    where SO.ID = @p1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", ID);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                dc.Add("Name", reader["Name"].ToString());
                                dc.Add("Client_ID", reader["Client_ID"].ToString());
                                DateTime dateValue = reader.GetDateTime(reader.GetOrdinal("Date_"));
                                dc.Add("Date_", dateValue.ToString("dd.MM.yyyy"));
                                //dc.Add("Date_", reader.GetDateTime(reader.GetOrdinal("Date_")).ToString("dd-MM-yyyy"));
                                //dc.Add("Date_", reader["Date_"].ToString());
                                dc.Add("Exp", reader["Exp"].ToString());
                                dc.Add("Pay_Type", reader["Pay_Type"].ToString());
                                dc.Add("Request_Storage_ID", reader["Request_Storage_ID"].ToString());
                                dc.Add("Insert_User_Name", reader["Insert_User_Name"].ToString());
                                dc.Add("Insert_Date", reader["Insert_Date"].ToString());
                                dc.Add("Edit_User_Name", reader["Edit_User_Name"].ToString());
                                dc.Add("Edit_Date", reader["Edit_Date"].ToString());
                                dc.Add("SSN", reader["SSN"].ToString());
                                dc.Add("Person_Name", reader["Person_Name"].ToString());
                                dc.Add("Person_Surname", reader["Person_Surname"].ToString());                             
                                dc.Add("Kind_ID", reader["Kind_ID"].ToString());                             
                            }
                        }

                    }
                    conn.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return dc;
        }

        public int  save_Siparisler_Top_Datas (int ID, String Name, int Kind_ID, int Client_ID, DateTime Date_, DateTime Delivery_Date, String Exp, int Pay_Type, String Pay_Period, int Plasiyer_Person_ID, int Insert_User, int Request_Storage_ID)
        {
            int rtn_ID = 0;

            try
            {

                using (SqlConnection conn = new SqlConnection (Tools.Constring))
                {
                    conn.Open ();
                    String query = "";
                    if (ID > 0)
                    {
                        query = @"update dbo.StockOrder set Name = @Name, Kind_ID = @Kind_ID, Client_ID = @Client_ID, Date_ = @Date_, Delivery_Date = @Delivery_Date, Exp = @Exp, Pay_Type = @Pay_Type, Pay_Period = @Pay_Period, Plasiyer_Person_ID = @Plasiyer_Person_ID, 
                        Edit_User = @Insert_User, Edit_Date = getdate(), Request_Storage_ID = @Request_Storage_ID where ID = " + ID + "; select ID = " + ID;
                    }
                    else
                    { 
                        query = @"insert into dbo.StockOrder (Name, Kind_ID, Client_ID, Date_, Delivery_Date, Exp, Pay_Type, Pay_Period, Plasiyer_Person_ID, Insert_User, Request_Storage_ID) values 
                        (@Name, @Kind_ID, @Client_ID, @Date_, @Delivery_Date, @Exp, @Pay_Type, @Pay_Period, @Plasiyer_Person_ID, @Insert_User, @Request_Storage_ID); SELECT SCOPE_IDENTITY()";
                    }

                    using (SqlCommand cmd = new SqlCommand (query, conn))
                    {
                        cmd.Parameters.AddWithValue ("@Name", Name);
                        cmd.Parameters.AddWithValue ("@Kind_ID", Kind_ID);
                        cmd.Parameters.AddWithValue ("@Client_ID", Client_ID);
                        cmd.Parameters.AddWithValue ("@Date_", Date_);
                        cmd.Parameters.AddWithValue ("@Delivery_Date", Delivery_Date);
                        cmd.Parameters.AddWithValue ("@Exp", Exp);
                        cmd.Parameters.AddWithValue ("@Pay_Type", Pay_Type);
                        cmd.Parameters.AddWithValue ("@Pay_Period", Pay_Period);
                        cmd.Parameters.AddWithValue ("@Plasiyer_Person_ID", Plasiyer_Person_ID);
                        cmd.Parameters.AddWithValue ("@Insert_User", Insert_User);
                        cmd.Parameters.AddWithValue ("@Request_Storage_ID", Request_Storage_ID);

                        rtn_ID = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                    conn.Close ();
                }

            } catch (Exception e) { MessageBox.Show (e.ToString()); }

            return rtn_ID;
        }


        public DataTable get_Siparisler_Grid_Datas (int ID)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection (Tools.Constring))
                {
                    conn.Open ();
                    String query =
                    @"select SOT.ID, 
                    [Işlem Kodu]            = SC.Code, 
                    [Stok Adı]              = SC.Name, 
                    [Grubu]                 = SG.Name, 
                    [Alt Grubu]             = SSG.Name, 
                    [Birim Fiyatı]          = round (SOT.Unit_Price,2), 
                    [Miktar]                = round(SOT.Quantity,2), 
                    [Tutar]                 = round(SOT.Total_Price,2), 
                    [KDV]                   = round(SOT.Total_Vat,2), 
                    [Toplam]                = round((ISNULL(SOT.Total_Price,0) + ISNULL(SOT.Total_Vat,0)),2),
                    [Orjinal Birim Fiyatı]  = round(SOT.Orj_Unit_Price,2),
                    [KDV Oranı]             = SC.Vat_Rate, 
                    [Birimi]                = SUT.Name 
                    /*, SOT.Cancel, SC.Lt * SOT.Quantity LT, SOT.Insert_Date,*/
                    from dbo.StockOrderTra SOT
                    inner join dbo.StockCard SC on SOT.Stock_Card_ID = SC.ID
                    left join dbo.StockGroup SG on SC.Group_ID = SG.ID
                    left join dbo.StockSubGroup SSG on SC.Sub_Group_ID = SSG.ID
                    left join dbo.StockUnitType SUT on SC.Unit_ID = SUT.ID
                    where SOT.Mast_ID = @p1";
                    using (SqlDataAdapter cmd = new SqlDataAdapter(query, conn))
                    {
                        cmd.SelectCommand.Parameters.AddWithValue("@p1", ID);
                        cmd.Fill(dt);
                    }
                    conn.Close ();

                }

            } catch (Exception e) { MessageBox.Show (e.ToString()); }



            return dt;
        }


        public int delete_Siparis(int ID)
        {
            int rtn = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    String query = @"delete from dbo.StockOrder where ID = @ID --and ISNULL(Approve,0) = 0";
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("ID", ID);
                        rtn = cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return rtn;
        }












        //Siparis_Edit_Islemler_Listesi işlemleri alanı BAŞLANGIÇ

        public DataTable get_Siparis_Edit_Islemler_Listesi_Grid_Datas(int ID)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(Tools.Constring))
                {
                    conn.Open();
                    String query =
                    @"select distinct SC.ID, 
                    [Işlem Kodu]            = SC.Code, 
                    [Işlem Adı]             = SC.Name, 
                    [Grubu]                 = SG.Name, 
                    [Alt Grubu]             = SSG.Name, 
                    [Depo]                  = ST.Storage_Name,   
                    [Depo Bakiyesi]         = ISNULL(ST.Quantity,0),
                    [Miktar]                = 1,
					[Birim Fiyatı]          = ISNULL(SC.Unit_Price,0),
                    [Kdv Oranı]             = Vat_Rate
                    /*SCR.Name Rate_Name,*/
					from dbo.StockCard SC
					left join dbo.StockGroup SG on SC.Group_ID = SG.ID 
					left join dbo.StockSubGroup SSG on SC.Sub_Group_ID = SSG.ID 
					left join dbo.StockConsumptionRate SCR on SC.Consumption_Rate_ID = SCR.ID
					left join dbo.VW_StockTra ST on SC.ID = ST.Stock_Card_ID and ST.Storage_ID = ISNULL((select top 1 SUC.Storage_ID from StorageUserCor SUC where SUC.User_ID = @user_ID order by SUC.Storage_ID),0)
					where SC.Active = 1 and SC.ID not in (select Stock_Card_ID from dbo.StockOrderTra where Mast_ID = @ID)
					order by SC.Name, SC.Code";
                    using (SqlDataAdapter cmd = new SqlDataAdapter(query, conn))
                    {
                        cmd.SelectCommand.Parameters.AddWithValue("@ID", ID);
                        cmd.SelectCommand.Parameters.AddWithValue("@user_ID", Tools.user_ID);
                        cmd.Fill(dt);
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            return dt;
        }

        
        public int add_update_Process (int Siparis_ID, int Stock_Card_ID, decimal Quantity,  byte Tur, int StockOrderTra_ID, decimal Toplam_Tutar, decimal Toplam_Miktar)
        {
            int rtn = 0;

            decimal Unit_Price              = 0; 
            decimal Vat_Rate                = 0;
            byte Vat_Included               = 0;
            decimal Unit_Price_Witout_Vat   = 0;

            if (Tur == 1) // işlem ekleme
            {
                // bu verilerin doğrudan db den alınmasının sebebi gridden gelen yuvarlama ile tutarların değişmesini engellemek  
                try
                {
                    using (SqlConnection conn = new SqlConnection (Tools.Constring))
                    {
                        conn.Open();
                        String query = "select Unit_Price = ISNULL(Unit_Price,0), Vat_Rate = ISNULL(Vat_Rate,0), Vat_Included = ISNULL (Vat_Included,0) from dbo.StockCard where ID = @Stock_Card_ID";                          

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        { 
                            cmd.Parameters.AddWithValue ("@Stock_Card_ID", Stock_Card_ID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            { 
                                while (reader.Read())
                                {
                                    Unit_Price = decimal.Parse(reader["Unit_Price"].ToString());
                                    Vat_Rate = decimal.Parse(reader["Vat_Rate"].ToString());
                                    Vat_Included = reader["Vat_Included"] != DBNull.Value ? (byte)((bool)reader["Vat_Included"] ? 1 : 0) : (byte)0;
                                }
                            }
                        }

                        conn.Close();
                    }

                }
                catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }



                if (Vat_Included == 1) //birim fiyat kdv li ise
                {                 
                    decimal calc_vat_rate = (Vat_Rate > 0) ? 1 + (Vat_Rate / 100) : 1;
                    Unit_Price_Witout_Vat = Unit_Price / calc_vat_rate;
                }
                else //birim fiyat kdvsiz ise
                {                    
                    Unit_Price_Witout_Vat = Unit_Price;
                }


                decimal Total_Price = Unit_Price_Witout_Vat * Quantity;
                decimal Total_Vat = ((Total_Price * Vat_Rate) / 100);

                Quantity = Math.Round(Quantity, 10);
                Unit_Price = Math.Round(Unit_Price_Witout_Vat, 10);
                Total_Price = Math.Round(Total_Price, 10);
                Total_Vat = Math.Round(Total_Vat, 10);

                try
                {
                    using (SqlConnection conn = new SqlConnection (Tools.Constring))
                    {
                        String query = @"insert into dbo.StockOrderTra (Mast_ID, Stock_Card_ID, Quantity, Orj_Unit_Price, Unit_Price, Total_Price, Total_Vat, Insert_User) values 
                        (@Mast_ID, @Stock_Card_ID, @Quantity, (select top 1 Unit_Price from dbo.StockCard where ID = @Stock_Card_ID), @Unit_Price, @Total_Price, @Total_Vat, @Insert_User)";
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand (query, conn))
                        {
                            cmd.Parameters.AddWithValue("Mast_ID", Siparis_ID);
                            cmd.Parameters.AddWithValue("Stock_Card_ID", Stock_Card_ID);
                            cmd.Parameters.AddWithValue("Quantity", Quantity);
                            cmd.Parameters.AddWithValue("Unit_Price", Unit_Price);
                            cmd.Parameters.AddWithValue("Total_Price", Total_Price);
                            cmd.Parameters.AddWithValue("Total_Vat", Total_Vat);
                            cmd.Parameters.AddWithValue("Insert_User", Tools.user_ID);
                            cmd.ExecuteReader ();                    
                        }
                        conn.Close();
                    }
                }
                catch (Exception e) { MessageBox.Show("İşlem başarsız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            } 


            else if (Tur == 2) // işlem guncelle toplam miktar
            {

                // bu verilerin doğrudan db den alınmasının sebebi gridden gelen yuvarlama ile tutarların değişmesini engellemek  
                try
                {
                    using (SqlConnection conn = new SqlConnection(Tools.Constring))
                    {
                        conn.Open();
                        String query = "select ST.Unit_Price, SC.Vat_Rate from dbo.StockOrderTra ST inner join dbo.StockCard SC on ST.Stock_Card_ID = SC.ID where ST.ID = @StockOrderTra_ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@StockOrderTra_ID", StockOrderTra_ID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Unit_Price = decimal.Parse(reader["Unit_Price"].ToString());
                                    Vat_Rate = decimal.Parse(reader["Vat_Rate"].ToString());
                                }
                            }
                        }

                        conn.Close();
                    }

                }
                catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                //decimal calc_vat_rate = (Vat_Rate > 0) ? 1 + (Vat_Rate / 100) : 1;
                Unit_Price_Witout_Vat = Unit_Price;

                decimal Total_Price = Unit_Price_Witout_Vat * Toplam_Miktar;
                decimal Total_Vat = ((Total_Price * Vat_Rate) / 100);

                Toplam_Miktar = Math.Round(Toplam_Miktar, 10);
                Unit_Price = Math.Round(Unit_Price, 10);
                Total_Price = Math.Round(Total_Price, 10);
                Total_Vat = Math.Round(Total_Vat, 10);

                try
                {
                    using (SqlConnection conn = new SqlConnection(Tools.Constring))
                    {
                        String query = @"update dbo.StockOrderTra set Quantity = @Quantity, Unit_Price = @Unit_Price, Total_Price = @Total_Price, Total_Vat = @Total_Vat, Edit_User = @Edit_User, Edit_Date = getdate() where ID = @ID";
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("ID", StockOrderTra_ID);
                            cmd.Parameters.AddWithValue("Quantity", Toplam_Miktar);
                            cmd.Parameters.AddWithValue("Unit_Price", Unit_Price);
                            cmd.Parameters.AddWithValue("Total_Price", Total_Price);
                            cmd.Parameters.AddWithValue("Total_Vat", Total_Vat);
                            cmd.Parameters.AddWithValue("Edit_User", Tools.user_ID);
                            rtn = cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                catch (Exception e) { MessageBox.Show("İşlem başarsız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            } 
            else if (Tur == 3) // işlem guncelle toplam tutar
            {

                // bu verilerin doğrudan db den alınmasının sebebi gridden gelen yuvarlama ile tutarların değişmesini engellemek  
                try
                {
                    using (SqlConnection conn = new SqlConnection(Tools.Constring))
                    {
                        conn.Open();
                        String query = "select SC.Vat_Rate from dbo.StockOrderTra ST inner join dbo.StockCard SC on ST.Stock_Card_ID = SC.ID where ST.ID = @StockOrderTra_ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@StockOrderTra_ID", StockOrderTra_ID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Vat_Rate = decimal.Parse (reader ["Vat_Rate"].ToString());
                                }
                            }
                        }

                        conn.Close();
                    }
                }
                catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                decimal calc_vat_rate = (Vat_Rate > 0) ? 1 + (Vat_Rate / 100) : 1;
                decimal Toplam_WitoutVat = Toplam_Tutar / calc_vat_rate;
                Unit_Price = Toplam_WitoutVat / Toplam_Miktar;
                decimal Total_Vat = Toplam_Tutar - Toplam_WitoutVat;

                Unit_Price = Math.Round(Unit_Price, 10);
                Toplam_Tutar = Math.Round(Toplam_WitoutVat, 10);
                Total_Vat = Math.Round(Total_Vat, 10);

                try
                {
                    using (SqlConnection conn = new SqlConnection(Tools.Constring))
                    {
                        String query = @"update dbo.StockOrderTra set Unit_Price = @Unit_Price, Total_Price = @Total_Price, Total_Vat = @Total_Vat, Edit_User = @Edit_User, Edit_Date = getdate() where ID = @ID";
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("ID", StockOrderTra_ID);
                            cmd.Parameters.AddWithValue("Unit_Price", Unit_Price);
                            cmd.Parameters.AddWithValue("Total_Price", Toplam_Tutar);
                            cmd.Parameters.AddWithValue("Total_Vat", Total_Vat);
                            cmd.Parameters.AddWithValue("Edit_User", Tools.user_ID);
                            rtn = cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                catch (Exception e) { MessageBox.Show("İşlem başarsız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            return rtn;
        }


        public int delete_Process (long Tra_ID)
        {
            int rtn = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection (Tools.Constring))
                {
                    String query = @"delete from dbo.StockOrderTra where ID = @Tra_ID";
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand (query, conn))
                    {
                        cmd.Parameters.AddWithValue("Tra_ID", Tra_ID);
                        rtn = cmd.ExecuteNonQuery();                    
                    }
                    conn.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return rtn;
        }


        //Siparis_Edit_Islemler_Listesi işlemleri alanı SONU

    }
}
