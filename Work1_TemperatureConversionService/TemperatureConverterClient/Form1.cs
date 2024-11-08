using TemperatureServiceReference;

namespace TemperatureConverterClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC2F_Click_1(object sender, EventArgs e)
        {
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
            }
            else
            {
                lblResult.Text = "请输入有效的摄氏温度值";
            }
        }

        private void btnF2C_Click_1(object sender, EventArgs e)
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