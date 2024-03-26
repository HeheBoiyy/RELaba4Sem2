namespace RELaba4Sem2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            GetDictinary = new Button();
            GenerateText = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 433);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(GetDictinary);
            tabPage1.Controls.Add(GenerateText);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Генерация текста";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // GetDictinary
            // 
            GetDictinary.Location = new Point(521, 295);
            GetDictinary.Name = "GetDictinary";
            GetDictinary.Size = new Size(145, 45);
            GetDictinary.TabIndex = 7;
            GetDictinary.Text = "Получить словарь данных";
            GetDictinary.UseVisualStyleBackColor = true;
            GetDictinary.Click += GetDictinary_Click;
            // 
            // GenerateText
            // 
            GenerateText.Location = new Point(521, 219);
            GenerateText.Name = "GenerateText";
            GenerateText.Size = new Size(145, 49);
            GenerateText.TabIndex = 6;
            GenerateText.Text = "Сгенерировать текст";
            GenerateText.UseVisualStyleBackColor = true;
            GenerateText.Click += GenerateText_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 144);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Случайный выбор";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(466, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 73);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 3;
            label2.Text = "Выберите регистр:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 12);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 2;
            label1.Text = "Количество предложений в тексте:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 9);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(420, 374);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(chart1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(771, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(18, 26);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(340, 291);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 47);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 100);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 150);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button GetDictinary;
        private Button GenerateText;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
