using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Linq;
using System.Data.SqlClient;



namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        static string conStr = @"Data Source=10.10.0.120;Initial Catalog=sataev;User ID=abd31_21;Password=123456qwerty.";

        DataContext context = new DataContext(conStr);

        public Form1()
        {
            InitializeComponent();

            Table<Мат> Материал = context.GetTable<Мат>();
            dataGridView1.DataSource = Материал.ToList();

            Table<Меб> Мебель = context.GetTable<Меб>();
            dataGridView4.DataSource = Мебель.ToList();

            Table<Зак> Заказ = context.GetTable<Зак>();
            dataGridView2.DataSource = Заказ.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sataevDataSet1.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter1.Fill(this.sataevDataSet1.Мебель);





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ID = Convert.ToInt32(textBox6.Text)
            Зак NewЗак = new Зак { Мебель = Convert.ToInt32(textBox7.Text), Количество = textBox8.Text, ДатаЗаказа = textBox1.Text, ДатаПоставки = textBox4.Text, Город = Convert.ToInt32(textBox9.Text) };
            context.GetTable<Зак>().InsertOnSubmit(NewЗак);
            context.SubmitChanges();
            MessageBox.Show("Успешно!!");
            dataGridView2.DataSource = conStr.ToArray();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var f = context.GetTable<Меб>().Where(x => x.Имя.Contains(Convert.ToString(comboBox3.SelectedValue)));
            dataGridView4.DataSource = f.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Зак currentCustome = context.GetTable<Зак>().FirstOrDefault(
             x => x.ID == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            currentCustome.Мебель = Convert.ToInt32(textBox2.Text);
            currentCustome.Количество = textBox3.Text;
            currentCustome.ДатаЗаказа = textBox10.Text;
            currentCustome.ДатаПоставки = textBox11.Text;
            currentCustome.Город = Convert.ToInt32(textBox12.Text);
            context.SubmitChanges();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        { }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var Материал = context.GetTable<Мат>().Where(x => x.Материал.Contains(textBox5.Text));
            dataGridView1.DataSource = Материал.ToList();

        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   

