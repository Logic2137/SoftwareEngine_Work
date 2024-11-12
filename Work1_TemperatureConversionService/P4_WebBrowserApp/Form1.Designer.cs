namespace P4_WebBrowserApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblWeatherResult = new System.Windows.Forms.Label();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.btnEnToCn = new System.Windows.Forms.Button();
            this.btnTransClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1355, 794);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(69, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1085, 26);
            this.txtUrl.TabIndex = 1;
            // 
            // btnNavigate
            // 
            this.btnNavigate.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNavigate.Font = new System.Drawing.Font("华文彩云", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNavigate.Location = new System.Drawing.Point(1173, 11);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(139, 29);
            this.btnNavigate.TabIndex = 2;
            this.btnNavigate.Text = "Go";
            this.btnNavigate.UseVisualStyleBackColor = false;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(69, 403);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(118, 21);
            this.txtCityName.TabIndex = 3;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(19, 409);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(29, 12);
            this.label_city.TabIndex = 4;
            this.label_city.Text = "城市";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(19, 379);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(29, 12);
            this.label_country.TabIndex = 5;
            this.label_country.Text = "国家";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(69, 370);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(118, 21);
            this.txtCountryName.TabIndex = 6;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(21, 441);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(75, 23);
            this.btnGetWeather.TabIndex = 7;
            this.btnGetWeather.Text = "查询天气";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblWeatherResult
            // 
            this.lblWeatherResult.AutoSize = true;
            this.lblWeatherResult.Location = new System.Drawing.Point(19, 488);
            this.lblWeatherResult.Name = "lblWeatherResult";
            this.lblWeatherResult.Size = new System.Drawing.Size(65, 12);
            this.lblWeatherResult.TabIndex = 8;
            this.lblWeatherResult.Text = "查询结果：";
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.Location = new System.Drawing.Point(112, 441);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(75, 23);
            this.btnClearTxt.TabIndex = 9;
            this.btnClearTxt.Text = "清空";
            this.btnClearTxt.UseVisualStyleBackColor = true;
            this.btnClearTxt.Click += new System.EventHandler(this.btnClearTxt_Click);
            // 
            // txtInputText
            // 
            this.txtInputText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInputText.Location = new System.Drawing.Point(853, 408);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(221, 77);
            this.txtInputText.TabIndex = 10;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutputText.Location = new System.Drawing.Point(1091, 408);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(221, 77);
            this.txtOutputText.TabIndex = 11;
            // 
            // btnEnToCn
            // 
            this.btnEnToCn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnToCn.Location = new System.Drawing.Point(853, 365);
            this.btnEnToCn.Name = "btnEnToCn";
            this.btnEnToCn.Size = new System.Drawing.Size(221, 29);
            this.btnEnToCn.TabIndex = 12;
            this.btnEnToCn.Text = "翻译";
            this.btnEnToCn.UseVisualStyleBackColor = true;
            this.btnEnToCn.Click += new System.EventHandler(this.btnEnToCn_Click);
            // 
            // btnTransClear
            // 
            this.btnTransClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransClear.Location = new System.Drawing.Point(1091, 365);
            this.btnTransClear.Name = "btnTransClear";
            this.btnTransClear.Size = new System.Drawing.Size(221, 29);
            this.btnTransClear.TabIndex = 13;
            this.btnTransClear.Text = "清空面板";
            this.btnTransClear.UseVisualStyleBackColor = true;
            this.btnTransClear.Click += new System.EventHandler(this.btnTransClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 841);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransClear);
            this.Controls.Add(this.btnEnToCn);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.lblWeatherResult);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeatherResult;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.Button btnEnToCn;
        private System.Windows.Forms.Button btnTransClear;
        private System.Windows.Forms.Label label1;
    }
}

