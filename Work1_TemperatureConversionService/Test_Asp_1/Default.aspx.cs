using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Test_Asp_1
{
    public partial class _Default : Page
    {
        Bitmap image;
        Graphics g;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Sum"] == null)
                ViewState["Sum"] = 0;
            lblAmount.Text = "0";
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

        protected void btnCoffee_Click(object sender, EventArgs e)
        {
            Int32 Sum = (Int32)ViewState["Sum"];
            Response.ContentType = "gif";
            if (Sum >= 75) {
                Sum = Sum - 75;
                ViewState["Sum"] = Sum;
                lblAmount.Text = Convert.ToString(Sum);
                lblCoffee.Text = "Please take your coffee here";
                lblRtn.Text = "[ ]";
                RtnChanges(Sum);
                g.FillRectangle(Brushes.LightYellow, 0, 250, 300, 250);
                g.DrawRectangle(Pens.Red, 0, 249, 299, 249);
                Font font = new Font("Alba Super", 20, FontStyle.Regular);
                g.DrawString("Please take your coffee", font, Brushes.Brown, 10, 250);
                SolidBrush brownBrush = new SolidBrush(Color.Brown);
                int x = 50;
                int y = 300;
                int w = 200;
                int h = 50;
                for (int i = 0; i < 15; i++) {
                    Rectangle rec = new Rectangle(x, y, w, h);
                    g.DrawEllipse(Pens.PowderBlue, rec);
                    g.FillEllipse(brownBrush, rec);
                    x = x + 2; y = y + 10;
                    w = w - 4; h = h - 2;
                }
                image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            }
            else {
                lblCoffee.Text = "Please deposit more money";
                lblAmount.Text = Convert.ToString(Sum);
                lblRtn.Text = "[    ]";
            }
        }

        protected void btnRtn_Click(object sender, EventArgs e)
        {
            Int32 Sum = (Int32)ViewState["Sum"];
            if (Sum > 0) {
                lblRtn.Text = "Please take the money here";
                RtnChanges(Sum);
                image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
                Sum = 0;
                ViewState["Sum"] = Sum;
            }
            else
                lblRtn.Text = "You have not deposited money";
        }

        protected void RtnChanges(Int32 amount)
        {
            Int32 quarters = (Int32)(amount / 25);
            image = new Bitmap(300, 500);
            g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Gold, 0, 0, 300, 250);
            g.DrawRectangle(Pens.Red, 0, 0, 299, 249);
            g.FillRectangle(Brushes.White, 0, 250, 300, 250);
            Font font = new Font("", 18, FontStyle.Italic);
            g.DrawString("Please take your change", font, Brushes.Brown, 10, 0); SolidBrush silverBrush = new SolidBrush(Color.Silver); int x = 10; int y = 50;
            int w = 50; int h = 50;
            for (int i = 1; i <= quarters; i++)
            {
                Rectangle rec = new Rectangle(x, y, w, h); g.DrawEllipse(Pens.PowderBlue, rec); g.FillEllipse(silverBrush, rec);
                if (i < 5)
                {
                    x = x + 52;
                }
                else
                {
                    y = 120; x = x - 50;
                }
            }
        }
    }
}