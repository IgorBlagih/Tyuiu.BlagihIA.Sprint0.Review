namespace Tyuiu.BlagihIA.Sprint6.TaskReview.V4
{
    partial class FormMain
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
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            buttonCompilare = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBox10 = new TextBox();
            textBoxL = new TextBox();
            textBox4 = new TextBox();
            textBoxK = new TextBox();
            textBox5 = new TextBox();
            textBoxn2 = new TextBox();
            textBox7 = new TextBox();
            textBoxC = new TextBox();
            textBox2 = new TextBox();
            textBoxn1 = new TextBox();
            textBox1 = new TextBox();
            textBoxM = new TextBox();
            textBox3 = new TextBox();
            textBoxN = new TextBox();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            dataGridViewIn = new DataGridView();
            splitter1 = new Splitter();
            panel4 = new Panel();
            textBoxResult = new TextBox();
            groupBox4 = new GroupBox();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(795, 165);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(604, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(191, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // buttonCompilare
            // 
            buttonCompilare.BackColor = Color.FromArgb(128, 255, 128);
            buttonCompilare.Location = new Point(6, 75);
            buttonCompilare.Name = "buttonCompilare";
            buttonCompilare.Size = new Size(140, 47);
            buttonCompilare.TabIndex = 1;
            buttonCompilare.Text = "Выполнить";
            buttonCompilare.UseVisualStyleBackColor = false;
            buttonCompilare.Click += buttonCompilare_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone.Location = new Point(23, 47);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(140, 57);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Создать матрицу";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBoxL);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBoxK);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBoxn2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBoxC);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBoxn1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBoxM);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBoxN);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Menu;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(434, 87);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(151, 16);
            textBox10.TabIndex = 23;
            textBox10.Text = "Конец выбранной строки";
            // 
            // textBoxL
            // 
            textBoxL.BackColor = SystemColors.Window;
            textBoxL.Location = new Point(434, 109);
            textBoxL.Name = "textBoxL";
            textBoxL.Size = new Size(151, 23);
            textBoxL.TabIndex = 22;
            textBoxL.KeyPress += textBoxL_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(266, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 16);
            textBox4.TabIndex = 19;
            textBox4.Text = "Начало выбранной строки";
            // 
            // textBoxK
            // 
            textBoxK.BackColor = SystemColors.Window;
            textBoxK.Location = new Point(266, 109);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(151, 23);
            textBoxK.TabIndex = 18;
            textBoxK.KeyPress += textBoxK_KeyPress;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(434, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 16);
            textBox5.TabIndex = 17;
            textBox5.Text = "Конец диапозона чисел";
            // 
            // textBoxn2
            // 
            textBoxn2.BackColor = SystemColors.Window;
            textBoxn2.Location = new Point(434, 43);
            textBoxn2.Name = "textBoxn2";
            textBoxn2.Size = new Size(142, 23);
            textBoxn2.TabIndex = 16;
            textBoxn2.KeyPress += textBoxn2_KeyPress;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(12, 88);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(109, 16);
            textBox7.TabIndex = 15;
            textBox7.Text = "Номер столбца:";
            // 
            // textBoxC
            // 
            textBoxC.BackColor = SystemColors.Window;
            textBoxC.Location = new Point(12, 109);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(109, 23);
            textBoxC.TabIndex = 14;
            textBoxC.KeyPress += textBoxC_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(266, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 16);
            textBox2.TabIndex = 11;
            textBox2.Text = "Начало диапозона чисел";
            // 
            // textBoxn1
            // 
            textBoxn1.BackColor = SystemColors.Window;
            textBoxn1.Location = new Point(266, 43);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(142, 23);
            textBoxn1.TabIndex = 10;
            textBoxn1.KeyPress += textBoxn1_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(137, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 16);
            textBox1.TabIndex = 9;
            textBox1.Text = "Число столбцов";
            // 
            // textBoxM
            // 
            textBoxM.BackColor = SystemColors.Window;
            textBoxM.Location = new Point(137, 43);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(109, 23);
            textBoxM.TabIndex = 8;
            textBoxM.KeyPress += textBoxM_KeyPress;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(12, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 16);
            textBox3.TabIndex = 7;
            textBox3.Text = "Число строк";
            // 
            // textBoxN
            // 
            textBoxN.BackColor = SystemColors.Window;
            textBoxN.Location = new Point(12, 43);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(109, 23);
            textBoxN.TabIndex = 6;
            textBoxN.KeyPress += textBoxN_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 96);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(795, 96);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewIn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 159);
            panel2.TabIndex = 3;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(0, 0);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.Size = new Size(502, 159);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(502, 261);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 159);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(505, 261);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 159);
            panel4.TabIndex = 5;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 33);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(256, 23);
            textBoxResult.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonCompilare);
            groupBox4.Controls.Add(textBoxResult);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(290, 159);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 420);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel4;
        private DataGridView dataGridViewIn;
        private Button buttonDone;
        private TextBox textBox1;
        private TextBox textBoxM;
        private TextBox textBox3;
        private TextBox textBoxN;
        private TextBox textBox5;
        private TextBox textBoxn2;
        private TextBox textBox7;
        private TextBox textBoxC;
        private TextBox textBox2;
        private TextBox textBoxn1;
        private TextBox textBox10;
        private TextBox textBoxL;
        private TextBox textBox4;
        private TextBox textBoxK;
        private Button buttonCompilare;
        private GroupBox groupBox4;
        private TextBox textBoxResult;
    }
}
