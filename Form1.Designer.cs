namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.мебельBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.sataevDataSet1 = new WindowsFormsApp7.sataevDataSet1();
            this.мебельBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sataevDataSet = new WindowsFormsApp7.sataevDataSet();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городаTableAdapter = new WindowsFormsApp7.sataevDataSetTableAdapters.ГородаTableAdapter();
            this.городаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельTableAdapter = new WindowsFormsApp7.sataevDataSetTableAdapters.МебельTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.мебельBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельTableAdapter1 = new WindowsFormsApp7.sataevDataSet1TableAdapters.МебельTableAdapter();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sataevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sataevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(952, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Фильтровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.мебельBindingSource5;
            this.comboBox3.DisplayMember = "Имя";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1058, 197);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.ValueMember = "Имя";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // мебельBindingSource5
            // 
            this.мебельBindingSource5.DataMember = "Мебель";
            this.мебельBindingSource5.DataSource = this.sataevDataSet1;
            // 
            // sataevDataSet1
            // 
            this.sataevDataSet1.DataSetName = "sataevDataSet1";
            this.sataevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мебельBindingSource1
            // 
            this.мебельBindingSource1.DataMember = "Мебель";
            this.мебельBindingSource1.DataSource = this.sataevDataSet;
            // 
            // sataevDataSet
            // 
            this.sataevDataSet.DataSetName = "sataevDataSet";
            this.sataevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(925, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(503, 150);
            this.dataGridView4.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(695, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 38;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(476, 150);
            this.dataGridView2.TabIndex = 24;
            // 
            // городаBindingSource
            // 
            this.городаBindingSource.DataMember = "Города";
            this.городаBindingSource.DataSource = this.sataevDataSet;
            // 
            // городаTableAdapter
            // 
            this.городаTableAdapter.ClearBeforeFill = true;
            // 
            // городаBindingSource1
            // 
            this.городаBindingSource1.DataMember = "Города";
            this.городаBindingSource1.DataSource = this.sataevDataSet;
            // 
            // мебельBindingSource
            // 
            this.мебельBindingSource.DataMember = "Мебель";
            this.мебельBindingSource.DataSource = this.sataevDataSet;
            // 
            // мебельTableAdapter
            // 
            this.мебельTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(706, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 43;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 67);
            this.button5.TabIndex = 45;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(925, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 48;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(803, 334);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 49;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(589, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 51;
            // 
            // мебельBindingSource2
            // 
            this.мебельBindingSource2.DataMember = "Мебель";
            this.мебельBindingSource2.DataSource = this.sataevDataSet;
            // 
            // мебельBindingSource3
            // 
            this.мебельBindingSource3.DataMember = "Мебель";
            this.мебельBindingSource3.DataSource = this.sataevDataSet;
            // 
            // мебельBindingSource4
            // 
            this.мебельBindingSource4.DataMember = "Мебель";
            this.мебельBindingSource4.DataSource = this.sataevDataSet;
            // 
            // мебельTableAdapter1
            // 
            this.мебельTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(695, 165);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 52;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(801, 165);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 53;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(801, 191);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Поиск";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(812, 222);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 56;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(600, 249);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 57;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(706, 249);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 58;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(812, 249);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 561);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sataevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sataevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private sataevDataSet sataevDataSet;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private sataevDataSetTableAdapters.ГородаTableAdapter городаTableAdapter;
        private System.Windows.Forms.BindingSource городаBindingSource1;
        private System.Windows.Forms.BindingSource мебельBindingSource;
        private sataevDataSetTableAdapters.МебельTableAdapter мебельTableAdapter;
        private System.Windows.Forms.BindingSource мебельBindingSource1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource мебельBindingSource2;
        private System.Windows.Forms.BindingSource мебельBindingSource3;
        private System.Windows.Forms.BindingSource мебельBindingSource4;
        private sataevDataSet1 sataevDataSet1;
        private System.Windows.Forms.BindingSource мебельBindingSource5;
        private sataevDataSet1TableAdapters.МебельTableAdapter мебельTableAdapter1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}

