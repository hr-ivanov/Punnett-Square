namespace PunnettSquareGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIncDom = new System.Windows.Forms.TextBox();
            this.radioButtonIncDom = new System.Windows.Forms.RadioButton();
            this.radioButtonGenotype = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFullDom = new System.Windows.Forms.TextBox();
            this.radioButtonFullDom = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.radioButtonComp = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLethal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonLethal = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNonCum = new System.Windows.Forms.TextBox();
            this.radioButtonNonCum = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPolCum = new System.Windows.Forms.TextBox();
            this.radioButtonPolCum = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxEpi = new System.Windows.Forms.TextBox();
            this.radioButtonEp = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(13, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(853, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(1110, 63);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(477, 126);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 32);
            this.textBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(891, 218);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 219);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxIncDom);
            this.tabPage1.Controls.Add(this.radioButtonIncDom);
            this.tabPage1.Controls.Add(this.radioButtonGenotype);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxFullDom);
            this.tabPage1.Controls.Add(this.radioButtonFullDom);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Dominant allele/s:";
            // 
            // textBoxIncDom
            // 
            this.textBoxIncDom.Enabled = false;
            this.textBoxIncDom.Location = new System.Drawing.Point(209, 139);
            this.textBoxIncDom.Name = "textBoxIncDom";
            this.textBoxIncDom.Size = new System.Drawing.Size(148, 32);
            this.textBoxIncDom.TabIndex = 6;
            // 
            // radioButtonIncDom
            // 
            this.radioButtonIncDom.AutoSize = true;
            this.radioButtonIncDom.Location = new System.Drawing.Point(22, 111);
            this.radioButtonIncDom.Name = "radioButtonIncDom";
            this.radioButtonIncDom.Size = new System.Drawing.Size(228, 29);
            this.radioButtonIncDom.TabIndex = 5;
            this.radioButtonIncDom.Text = "Incomplete Dominance";
            this.radioButtonIncDom.UseVisualStyleBackColor = true;
            this.radioButtonIncDom.CheckedChanged += new System.EventHandler(this.radioButtonIncDom_CheckedChanged);
            // 
            // radioButtonGenotype
            // 
            this.radioButtonGenotype.AutoSize = true;
            this.radioButtonGenotype.Location = new System.Drawing.Point(22, 16);
            this.radioButtonGenotype.Name = "radioButtonGenotype";
            this.radioButtonGenotype.Size = new System.Drawing.Size(233, 29);
            this.radioButtonGenotype.TabIndex = 4;
            this.radioButtonGenotype.Text = "Genotype only (Default)";
            this.radioButtonGenotype.UseVisualStyleBackColor = true;
            this.radioButtonGenotype.CheckedChanged += new System.EventHandler(this.radioButtonGenotype_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(410, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 99);
            this.label8.TabIndex = 3;
            this.label8.Text = "Please enter the dominant alleles in the order of power, separated by a comma!\r\nE" +
    "xample: A,B,D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dominant allele/s:";
            // 
            // textBoxFullDom
            // 
            this.textBoxFullDom.Enabled = false;
            this.textBoxFullDom.Location = new System.Drawing.Point(209, 78);
            this.textBoxFullDom.Name = "textBoxFullDom";
            this.textBoxFullDom.Size = new System.Drawing.Size(148, 32);
            this.textBoxFullDom.TabIndex = 1;
            this.textBoxFullDom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radioButtonFullDom
            // 
            this.radioButtonFullDom.AutoSize = true;
            this.radioButtonFullDom.Location = new System.Drawing.Point(22, 50);
            this.radioButtonFullDom.Name = "radioButtonFullDom";
            this.radioButtonFullDom.Size = new System.Drawing.Size(288, 29);
            this.radioButtonFullDom.TabIndex = 0;
            this.radioButtonFullDom.Text = "Full Dominance/Codominance";
            this.radioButtonFullDom.UseVisualStyleBackColor = true;
            this.radioButtonFullDom.CheckedChanged += new System.EventHandler(this.radioButtonFullDom_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxComp);
            this.tabPage2.Controls.Add(this.radioButtonComp);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBoxLethal);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.radioButtonLethal);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dominant allele/s:";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Enabled = false;
            this.textBoxComp.Location = new System.Drawing.Point(212, 108);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(147, 32);
            this.textBoxComp.TabIndex = 5;
            // 
            // radioButtonComp
            // 
            this.radioButtonComp.AutoSize = true;
            this.radioButtonComp.Location = new System.Drawing.Point(19, 78);
            this.radioButtonComp.Name = "radioButtonComp";
            this.radioButtonComp.Size = new System.Drawing.Size(167, 29);
            this.radioButtonComp.TabIndex = 4;
            this.radioButtonComp.Text = "Complementary";
            this.radioButtonComp.UseVisualStyleBackColor = true;
            this.radioButtonComp.CheckedChanged += new System.EventHandler(this.radioButtonComp_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(404, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 121);
            this.label10.TabIndex = 3;
            this.label10.Text = "Please enter the dominant alleles in the order of power, separated by a comma!\r\nE" +
    "xample: A,B,D";
            // 
            // textBoxLethal
            // 
            this.textBoxLethal.Enabled = false;
            this.textBoxLethal.Location = new System.Drawing.Point(178, 45);
            this.textBoxLethal.Name = "textBoxLethal";
            this.textBoxLethal.Size = new System.Drawing.Size(147, 32);
            this.textBoxLethal.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lethal allele/s:";
            // 
            // radioButtonLethal
            // 
            this.radioButtonLethal.AutoSize = true;
            this.radioButtonLethal.Location = new System.Drawing.Point(18, 18);
            this.radioButtonLethal.Name = "radioButtonLethal";
            this.radioButtonLethal.Size = new System.Drawing.Size(143, 29);
            this.radioButtonLethal.TabIndex = 0;
            this.radioButtonLethal.Text = "Lethal Action";
            this.radioButtonLethal.UseVisualStyleBackColor = true;
            this.radioButtonLethal.CheckedChanged += new System.EventHandler(this.radioButtonLethal_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBoxNonCum);
            this.tabPage3.Controls.Add(this.radioButtonNonCum);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBoxPolCum);
            this.tabPage3.Controls.Add(this.radioButtonPolCum);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(692, 181);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "s";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Key allele/s:";
            // 
            // textBoxNonCum
            // 
            this.textBoxNonCum.Enabled = false;
            this.textBoxNonCum.Location = new System.Drawing.Point(165, 123);
            this.textBoxNonCum.Name = "textBoxNonCum";
            this.textBoxNonCum.Size = new System.Drawing.Size(72, 32);
            this.textBoxNonCum.TabIndex = 4;
            // 
            // radioButtonNonCum
            // 
            this.radioButtonNonCum.AutoSize = true;
            this.radioButtonNonCum.Location = new System.Drawing.Point(19, 93);
            this.radioButtonNonCum.Name = "radioButtonNonCum";
            this.radioButtonNonCum.Size = new System.Drawing.Size(258, 29);
            this.radioButtonNonCum.TabIndex = 3;
            this.radioButtonNonCum.TabStop = true;
            this.radioButtonNonCum.Text = "Non-Cumulative Polygenic";
            this.radioButtonNonCum.UseVisualStyleBackColor = true;
            this.radioButtonNonCum.CheckedChanged += new System.EventHandler(this.radioButtonNonCum_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Additive allele/s:";
            // 
            // textBoxPolCum
            // 
            this.textBoxPolCum.Enabled = false;
            this.textBoxPolCum.Location = new System.Drawing.Point(195, 47);
            this.textBoxPolCum.Name = "textBoxPolCum";
            this.textBoxPolCum.Size = new System.Drawing.Size(72, 32);
            this.textBoxPolCum.TabIndex = 1;
            // 
            // radioButtonPolCum
            // 
            this.radioButtonPolCum.AutoSize = true;
            this.radioButtonPolCum.Location = new System.Drawing.Point(19, 17);
            this.radioButtonPolCum.Name = "radioButtonPolCum";
            this.radioButtonPolCum.Size = new System.Drawing.Size(214, 29);
            this.radioButtonPolCum.TabIndex = 0;
            this.radioButtonPolCum.TabStop = true;
            this.radioButtonPolCum.Text = "Cumulative Polygenic";
            this.radioButtonPolCum.UseVisualStyleBackColor = true;
            this.radioButtonPolCum.CheckedChanged += new System.EventHandler(this.radioButtonPolCum_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBoxEpi);
            this.tabPage4.Controls.Add(this.radioButtonEp);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(692, 181);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Epistatic alleles:";
            // 
            // textBoxEpi
            // 
            this.textBoxEpi.Enabled = false;
            this.textBoxEpi.Location = new System.Drawing.Point(198, 50);
            this.textBoxEpi.Name = "textBoxEpi";
            this.textBoxEpi.Size = new System.Drawing.Size(100, 32);
            this.textBoxEpi.TabIndex = 1;
            // 
            // radioButtonEp
            // 
            this.radioButtonEp.AutoSize = true;
            this.radioButtonEp.Checked = true;
            this.radioButtonEp.Location = new System.Drawing.Point(26, 18);
            this.radioButtonEp.Name = "radioButtonEp";
            this.radioButtonEp.Size = new System.Drawing.Size(103, 29);
            this.radioButtonEp.TabIndex = 0;
            this.radioButtonEp.TabStop = true;
            this.radioButtonEp.Text = "Epistatic";
            this.radioButtonEp.UseVisualStyleBackColor = true;
            this.radioButtonEp.CheckedChanged += new System.EventHandler(this.radioButtonEp_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 32);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "♀";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(480, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "♂";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(381, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 89);
            this.label3.TabIndex = 9;
            this.label3.Text = "✕";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1073, 112);
            this.label4.TabIndex = 10;
            this.label4.Text = "Punnett Square Generator";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(895, 503);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(692, 267);
            this.dataGridView2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(989, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(656, 57);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genotype/Phenotype Frequencies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(582, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 57);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(704, 774);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(162, 46);
            this.labelTotal.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 844);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGenerate;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private Label labelTotal;
        private RadioButton radioButtonFullDom;
        private TextBox textBoxFullDom;
        private Label label7;
        private Label label8;
        private RadioButton radioButtonGenotype;
        private RadioButton radioButtonLethal;
        private TextBox textBoxLethal;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxComp;
        private RadioButton radioButtonComp;
        private Label label12;
        private TextBox textBoxIncDom;
        private RadioButton radioButtonIncDom;
        private TabPage tabPage3;
        private RadioButton radioButtonPolCum;
        private TextBox textBoxPolCum;
        private Label label13;
        private Label label14;
        private TextBox textBoxNonCum;
        private RadioButton radioButtonNonCum;
        private TabPage tabPage4;
        private TextBox textBoxEpi;
        private RadioButton radioButtonEp;
        private Label label15;
        private RadioButton radioButton1;
    }
}