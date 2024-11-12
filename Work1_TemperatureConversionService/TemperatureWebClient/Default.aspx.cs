using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TemperatureWebClient.TemperatureServiceReference_ForAsp;  // 使用服务引用命名空间

namespace TemperatureWebClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // 摄氏转华氏按钮的点击事件
        protected void btnC2F_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnC2F_Click");
            // 创建服务客户端实例
            var client = new TemperatureServiceClient();

            // 从文本框中获取摄氏温度输入
            int celsius;
            if (int.TryParse(txtCelsius.Text, out celsius))
            {
                // 调用WCF服务的c2f方法
                int fahrenheit = client.c2f(celsius);
                // 显示转换结果
                lblResult.Text = $"华氏温度: {fahrenheit}";
                Console.WriteLine($"华氏温度: {fahrenheit}");
            }
            else
            {
                lblResult.Text = "请输入有效的摄氏温度值";
                Console.WriteLine("请输入有效的摄氏温度值");
            }
        }


        // 华氏转摄氏按钮的点击事件
        protected void btnF2C_Click(object sender, EventArgs e)
        {
            // 创建服务客户端实例
            var client = new TemperatureServiceClient();

            // 从文本框中获取华氏温度输入
            int fahrenheit;
            if (int.TryParse(txtFahrenheit.Text, out fahrenheit))
            {
                // 调用WCF服务的f2c方法
                int celsius = client.f2c(fahrenheit);
                // 显示转换结果
                lblResult.Text = $"摄氏温度: {celsius}";
            }
            else
            {
                lblResult.Text = "请输入有效的华氏温度值";
            }
        }
    }
}