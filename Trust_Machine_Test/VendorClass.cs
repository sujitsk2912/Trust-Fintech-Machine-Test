using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Trust_Machine_Test
{
    public class VendorClass
    {
        static SqlConnection con = dbConnection.GetConnection();
        static string Query = null;
        static SqlCommand cmd = null;

        //method insert the record to the table

        public static string insertVendorMast(int Vendor_ID,string Vendor_Name)
        {
            string result = null;
            try
            {
                Query = "insert into Vendor_mast values (@Vendor_ID,@Vendor_Name)";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                cmd.Parameters.AddWithValue("@Vendor_ID", Vendor_ID);
                con.Open();
                cmd.ExecuteNonQuery();

                result = "record save in vendor master sucessfully";
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        //method return vendor id
        public static string getVendor_ID()
        {
            string res = null;
            try
            {
                Query = "select max(Vendor_ID) from Vendor_mast";
                cmd = new SqlCommand(res, con);
                con.Open();
                int vendor_id = Convert.ToInt32(cmd.ExecuteScalar());

                res = vendor_id.ToString();
            }
            catch(Exception ex)
            {
                res = ex.Message;
            }
            finally
            { 
                con.Close(); 
            }
            return res;
        }

        //method update record into vendor table

        public static string updateVendorMast(int Vendor_ID, string Vendor_Name)
        {
            string result = null;

            //checking wheter vendor exist or not
            Query = "select count(*) from Vendor_mast where Vendor_ID = @Vendor_ID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Vendore_ID", Vendor_ID);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if(count > 0)
            {
                try
                {
                    Query = "update Vendor_mast set Vendor_Name = @vendor_name where  Vendor_ID = @vendor_id";
                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                    cmd.Parameters.AddWithValue("@Vendor_ID", Vendor_ID);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    result = "record update in vendor master succefully";
                }
                catch(Exception ex)
                {
                    result = ex.Message;
                }
                finally
                {
                    con.Close() ;
                }
            }
            else
            {
                result = "no record exist";
            }
            return result;
        }

        //method delete record into vendor table
        public static string deleteVendorMast(int Vendor_ID)
        {
            string result = null;

            //checking wheter vendor exist or not
            /*Query = "select count(*) from Vendor_mast where Vendor_ID = @Vendor_ID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Vendore_ID", Vendor_ID);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {*/
                try
                {
                    Query = "delete from Vendor_mast where  Vendor_ID = @vendor_id";
                    cmd = new SqlCommand(Query, con);
                    
                    cmd.Parameters.AddWithValue("@Vendor_ID", Vendor_ID);
                    con.Open(); cmd.ExecuteNonQuery();

                    result = "record delete in vendor master succefully";
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            /*}
            else
            {
                result = "delete record";
            }*/
            return result;
        }

        //method search record into vendor table
        public static DataSet searchVendorMast(int Vendor_ID)
        {
            Query = "Select * from Vendor_mast where Vendor_ID = @Vendor_ID";
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@Vendor_ID", Vendor_ID);
            adapter.Fill(dataSet, "Vendor_mast");
            return dataSet;
        }
    }
}