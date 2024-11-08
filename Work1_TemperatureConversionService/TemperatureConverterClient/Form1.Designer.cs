namespace TemperatureConverterClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            btnC2F = new Button();
            btnF2C = new Button();
            lblResult_label = new Label();
            lblResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 76);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 0;
            label1.Text = "摄氏温度：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 137);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 1;
            label2.Text = "华氏温度：";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(205, 75);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(200, 38);
            txtCelsius.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(205, 141);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(200, 38);
            txtFahrenheit.TabIndex = 3;
            // 
            // btnC2F
            // 
            btnC2F.Location = new Point(61, 223);
            btnC2F.Name = "btnC2F";
            btnC2F.Size = new Size(150, 46);
            btnC2F.TabIndex = 4;
            btnC2F.Text = "C转F";
            btnC2F.UseVisualStyleBackColor = true;
            btnC2F.Click += btnC2F_Click_1;
            // 
            // btnF2C
            // 
            btnF2C.Location = new Point(266, 223);
            btnF2C.Name = "btnF2C";
            btnF2C.Size = new Size(150, 46);
            btnF2C.TabIndex = 5;
            btnF2C.Text = "F转C";
            btnF2C.UseVisualStyleBackColor = true;
            btnF2C.Click += btnF2C_Click_1;
            // 
            // lblResult_label
            // 
            lblResult_label.AutoSize = true;
            lblResult_label.Location = new Point(61, 323);
            lblResult_label.Name = "lblResult_label";
            lblResult_label.Size = new Size(136, 31);
            lblResult_label.TabIndex = 6;
            lblResult_label.Text = "lblResult：";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(205, 325);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(429, 38);
            lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblResult_label);
            Controls.Add(btnF2C);
            Controls.Add(btnC2F);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Button btnC2F;
        private Button btnF2C;
        private Label lblResult_label;
        private TextBox lblResult;
    }
}
