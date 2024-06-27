using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trust_Machine_Test
{
    public partial class Vendor_Crud_Operation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.updateVendorMast(Convert.ToInt32(txtVendorID.Text), txtVendorName.Text);
            Label1.Text = res;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendorMast(Convert.ToInt32(txtVendorID.Text),txtVendorName.Text);
            Label1.Text = res;
            getVendorID();
            txtVendorID.Text = "";
            txtVendorName.Text = "";
        }

        public void getVendorID()
        {
            string res = VendorClass.getVendor_ID();
            res = res + 1;
            txtVendorName.Text = res.ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendorMast(Convert.ToInt32(txtVendorID.Text));
            Label1.Text = res;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet = VendorClass.searchVendorMast(Convert.ToInt32(txtVendorID));

            if (dataSet.Tables[0].Rows.Count != 0)
            {
                txtVendorName.Text = dataSet.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}