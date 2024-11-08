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
            // ��������ͻ���ʵ��
            var client = new TemperatureServiceClient();

            // ���ı����л�ȡ�����¶�����
            int celsius;
            if (int.TryParse(txtCelsius.Text, out celsius))
            {
                // ����WCF�����c2f����
                int fahrenheit = client.c2f(celsius);
                // ��ʾת�����
                lblResult.Text = $"�����¶�: {fahrenheit}";
            }
            else
            {
                lblResult.Text = "��������Ч�������¶�ֵ";
            }
        }

        private void btnF2C_Click_1(object sender, EventArgs e)
        {
            // ��������ͻ���ʵ��
            var client = new TemperatureServiceClient();

            // ���ı����л�ȡ�����¶�����
            int fahrenheit;
            if (int.TryParse(txtFahrenheit.Text, out fahrenheit))
            {
                // ����WCF�����f2c����
                int celsius = client.f2c(fahrenheit);
                // ��ʾת�����
                lblResult.Text = $"�����¶�: {celsius}";
            }
            else
            {
                lblResult.Text = "��������Ч�Ļ����¶�ֵ";
            }
        }
    }
}