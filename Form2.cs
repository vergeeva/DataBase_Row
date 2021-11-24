using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Индивидуальное
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        char p;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.Сырье". При необходимости она может быть перемещена или удалена.
            this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.ПоступлениеСырья". При необходимости она может быть перемещена или удалена.
            this.поступлениеСырьяTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеСырья);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.Поступление_Сырья". При необходимости она может быть перемещена или удалена.
            //panel1.Visible = false;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Отменить
        //    поступлениеСырьяTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], [Поступление_Сырья].[Код_Сырья]," +
        //        " Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], [Поступление_Сырья].[Фактическое_поступление] " +
        //        "FROM([Поступление_Сырья] INNER JOIN Сырье ON[Поступление_Сырья].[Код_Сырья] = Сырье.[Код_Сырья])";
        //    this.поступлениеСырьяTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеСырья);
        //    textBox1.Text = "";
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //Выполнить
        //    try
        //    {
        //        int temp;
        //        int.TryParse(textBox1.Text, out temp);
        //        if (temp == 0 && (comboBox1.Text == "Код_поставки" || comboBox1.Text == "Плановое_поступление" || comboBox1.Text == "Фактическое_поступление"))
        //        {
        //            поступлениеСырьяTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], [Поступление_Сырья].[Код_Сырья]," +
        //        " Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], [Поступление_Сырья].[Фактическое_поступление] " +
        //        "FROM([Поступление_Сырья] INNER JOIN Сырье ON[Поступление_Сырья].[Код_Сырья] = Сырье.[Код_Сырья]) WHERE [" + comboBox1.Text + "] " + textBox1.Text;
        //        }
        //        else
        //        {
        //            if (comboBox1.Text == "Наименование_Сырья")
        //            {
        //                поступлениеСырьяTableAdapter.Adapter.SelectCommand.CommandText = "SELECT[Поступление_Сырья].[Код_поставки], [Поступление_Сырья].[Код_Сырья], " +
        //                    "Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], [Поступление_Сырья].[Фактическое_поступление] " +
        //                    "FROM([Поступление_Сырья] INNER JOIN Сырье ON[Поступление_Сырья].[Код_Сырья] = Сырье.[Код_Сырья]) " +
        //                    "WHERE(Сырье.[Наименование_Сырья] like '" + textBox1.Text + "')";
        //            }
        //            else
        //            {
        //                поступлениеСырьяTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], [Поступление_Сырья].[Код_Сырья]," +
        //        " Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], [Поступление_Сырья].[Фактическое_поступление] " +
        //        "FROM([Поступление_Сырья] INNER JOIN Сырье ON[Поступление_Сырья].[Код_Сырья] = Сырье.[Код_Сырья]) WHERE [" + comboBox1.Text + "] =" + textBox1.Text;
        //            }
        //        }
        //        this.поступлениеСырьяTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеСырья);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("неверный запрос");
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //Добавить
        //    panel1.Visible = true;
        //    p = '1';
        //    comboBox2.SelectedValue = 1;
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //Изменить
        //    panel1.Visible = true;
        //    p = '2';
        //    DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //    int RawID = Convert.ToInt32(dgvr.Cells[1].Value);
        //    int Plan = Convert.ToInt32(dgvr.Cells[3].Value);
        //    int Fact = Convert.ToInt32(dgvr.Cells[4].Value);
        //    comboBox2.SelectedValue = RawID;
        //    textBox2.Text = Plan.ToString();
        //    textBox3.Text = Fact.ToString();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //Удалить
        //    DataRowView drv = поступлениеСырьяBindingSource.Current as DataRowView;
        //    int ID = Convert.ToInt32(drv.Row["Код_поставки"]);

        //    var result = MessageBox.Show("Удалить данные о поступлении?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        поступлениеСырьяTableAdapter.Connection.Open(); //Открываем подключение
        //        поступлениеСырьяTableAdapter.Adapter.DeleteCommand.Parameters["Код_поставки"].Value = ID;
        //        try
        //        {
        //            поступлениеСырьяTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
        //            поступлениеСырьяTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеСырья);

        //        }
        //        catch
        //        {
        //            MessageBox.Show("Невозможно удалить, так как имеются связи", "Предупреждение");
        //        }
        //            поступлениеСырьяTableAdapter.Connection.Close();
        //        }
        //}

        //private void buttonОтменить_Click(object sender, EventArgs e)
        //{
        //    //Отмена
        //    comboBox2.SelectedValue = 1;
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //    panel1.Visible = false;
        //}

        //private void buttonПрименить_Click(object sender, EventArgs e)
        //{
        //    //Применить
        //    if (textBox2.Text != "" && textBox3.Text != "" && comboBox2.Text != "")
        //    {
        //        if (p == '1')
        //        {//Добавить
        //            int Plan = Convert.ToInt32(textBox2.Text);
        //            int fact = Convert.ToInt32(textBox3.Text);
        //            int ID = Convert.ToInt32(comboBox2.SelectedValue);
        //            поступлениеСырьяTableAdapter.Connection.Open(); //Открываем подключение
        //                                                            //Задаем параметры запроса
        //            поступлениеСырьяTableAdapter.Adapter.InsertCommand.Parameters["Плановое_поступление"].Value = Plan;
        //            поступлениеСырьяTableAdapter.Adapter.InsertCommand.Parameters["Код_Сырья"].Value = ID;
        //            поступлениеСырьяTableAdapter.Adapter.InsertCommand.Parameters["Фактическое_поступление"].Value = fact;
        //            //Выполняем
        //            try
        //            {
        //                поступлениеСырьяTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
        //                поступлениеСырьяTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеСырья);
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Невозможно добавить объект");
        //            }
        //            поступлениеСырьяTableAdapter.Connection.Close(); //Закрываем подключение
        //        }
        //        else
        //            if (p == '2')
        //        {
        //            DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //            int ID = Convert.ToInt32(dgvr.Cells[0].Value);
        //            int RawID = Convert.ToInt32(comboBox2.SelectedValue);
        //            int Plan = Convert.ToInt32(textBox2.Text);
        //            int Fact = Convert.ToInt32(textBox3.Text);

        //            поступлениеСырьяTableAdapter.Connection.Open(); //Открываем подключение

        //            поступлениеСырьяTableAdapter.Adapter.UpdateCommand.Parameters["Код_Сырья"].Value = RawID;

        //            поступлениеСырьяTableAdapter.Adapter.UpdateCommand.Parameters["Плановое_поступление"].Value = Plan;

        //            поступлениеСырьяTableAdapter.Adapter.UpdateCommand.Parameters["Фактическое_поступление"].Value = Fact;

        //            поступлениеСырьяTableAdapter.Adapter.UpdateCommand.Parameters["Original_Код_поставки"].Value = ID;

        //            поступлениеСырьяTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();

        //            поступлениеСырьяTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеСырья);
        //            поступлениеСырьяTableAdapter.Connection.Close();
        //        }

        //        panel1.Visible = false;
        //    }
        //    else MessageBox.Show("Заполните все поля!");

        //}

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Выполнить
            if (toolStripComboBox1.Text == "Наименование_Сырья")
            {
                this.поступлениеСырьяBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "'";
            }
            else
            {
                int temp;
                int.TryParse(toolStripTextBox1.Text, out temp);
                if (temp != 0)
                {
                    this.поступлениеСырьяBindingSource.Filter = "[" + toolStripComboBox1.Text + "] =" + toolStripTextBox1;
                }
                else this.поступлениеСырьяBindingSource.Filter = "[" + toolStripComboBox1.Text + "] " + toolStripTextBox1;

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Отменить
            this.поступлениеСырьяBindingSource.Filter = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.поступлениеСырьяBindingSource.ResetBindings(false);
            this.поступлениеСырьяTableAdapter.Update(this.индивидуальное3DataSet.ПоступлениеСырья);
            this.поступлениеСырьяTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеСырья);

        }
    }
}
