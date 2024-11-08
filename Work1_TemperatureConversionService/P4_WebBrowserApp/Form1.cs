using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_WebBrowserApp.WeatherServiceReference;
using P4_WebBrowserApp.TranslationServiceReference;

namespace P4_WebBrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 禁用WebBrowser控件的脚本错误提示
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            // 检查输入的网址是否为空
            if (!string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                // 使用 WebBrowser 控件导航到用户输入的网址
                webBrowser1.Navigate(txtUrl.Text);
            }
            else
            {
                MessageBox.Show("请输入有效的网址");
            }
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCityName.Text))
            {
                try
                {
                    // 手动创建绑定和终结点地址
                    var binding = new System.ServiceModel.BasicHttpBinding();
                    var endpoint = new System.ServiceModel.EndpointAddress("http://ws.webxml.com.cn/WebServices/WeatherWebService.asmx");

                    // 使用手动配置的终结点创建客户端
                    var client = new WeatherServiceReference.WeatherWebServiceSoapClient(binding, endpoint);

                    // 获取指定城市的天气预报
                    var weatherData = client.getWeatherbyCityName(txtCityName.Text.Trim());

                    if (weatherData != null && weatherData.Length > 0)
                    {
                        // 显示天气信息
                        lblWeatherResult.Text = string.Join("\n", weatherData);
                    }
                    else
                    {
                        lblWeatherResult.Text = "未找到该城市的天气信息。";
                    }
                }
                catch (Exception ex)
                {
                    lblWeatherResult.Text = $"查询失败: {ex.Message}";
                }
            }
            else
            {
                MessageBox.Show("请输入城市名称。");
            }
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            lblWeatherResult.Text = "查询结果：";
            txtCountryName.Clear();
            txtCityName.Clear();
        }

        private void btnEnToCn_Click(object sender, EventArgs e)
        {
            // 检查输入的文本是否为空
            if (!string.IsNullOrWhiteSpace(txtInputText.Text))
            {
                try
                {
                    // 手动创建绑定和终结点地址
                    var binding = new System.ServiceModel.BasicHttpBinding();
                    var endpoint = new System.ServiceModel.EndpointAddress("http://fy.webxml.com.cn/webservices/EnglishChinese.asmx");

                    // 创建翻译服务客户端
                    var client = new TranslationServiceReference.EnglishChineseSoapClient(binding, endpoint);

                    // 调用翻译服务进行中英双向翻译
                    var translationResult = client.TranslatorString(txtInputText.Text.Trim());

                    // 显示翻译结果
                    if (translationResult.Length >= 4)
                    {
                        txtOutputText.Text = "【音标】" + translationResult[1] + "\r\n";
                        txtOutputText.Text += "【释义】" + translationResult[3];
                    }
                    else
                    {
                        txtOutputText.Text = "未找到翻译结果。";
                    }
                }
                catch (Exception ex)
                {
                    // 显示错误信息
                    txtOutputText.Text = $"翻译失败: {ex.Message}";
                }
            }
            else
            {
                MessageBox.Show("请输入要翻译的文本。");
            }
        }

        private void btnTransClear_Click(object sender, EventArgs e)
        {
            txtInputText.Clear();
            txtOutputText.Clear();
        }
    }
}
