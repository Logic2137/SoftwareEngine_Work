using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Coffee
{
    public partial class _Default : Page
    {
        Bitmap image;
        Graphics g;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQuarter_Click(object sender, EventArgs e)
        {
            // insert quarter
            Int32 Sum = (Int32)ViewState["Sum"]; 
            Sum = Sum + 25;
            ViewState["Sum"] = Sum;
            lblAmount.Text = Convert.ToString(Sum);
            lblRtn.Text = "[  ]";
        }

        protected void BtnDollar_Click(object sender, EventArgs e)
        {
            Int32 Sum = (Int32)ViewState["Sum"];
            Sum = Sum + 100;
            ViewState["Sum"] = Sum;
            lblAmount.Text = Convert.ToString(Sum);
            lblRtn.Text = "[ ]";
        }
    }
}