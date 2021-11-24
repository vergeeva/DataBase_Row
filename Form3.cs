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
    public partial class Form3 : Form
    {
        char p;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.Сырье". При необходимости она может быть перемещена или удалена.
            this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.ПоступлениеПрошлыйГод". При необходимости она может быть перемещена или удалена.
            this.поступлениеПрошлыйГодTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеПрошлыйГод);
            //panel1.Visible = false;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Отменить фильтр
        //    поступлениеПрошлыйГодTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_прошлый_год].Код, [Поступление_прошлый_год].[Код_сырья], " +
        //        "Сырье.[Наименование_Сырья], [Поступление_прошлый_год].[Поступление_за_прошлый_год] FROM([Поступление_прошлый_год] INNER JOIN" +
        //        " Сырье ON[Поступление_прошлый_год].[Код_сырья] = Сырье.[Код_Сырья])";
        //    this.поступлениеПрошлыйГодTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеПрошлыйГод);
        //    //textBox1.Text = "";
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //Выполнить
        //    try
        //    {
        //        int temp;
        //        int.TryParse(textBox1.Text, out temp);
        //        if (temp == 0 && (comboBox1.Text == "Код" || comboBox1.Text == "Поступление_за_прошлый_год"))
        //        {
        //            поступлениеПрошлыйГодTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_прошлый_год].Код, [Поступление_прошлый_год].[Код_сырья], " +
        //        "Сырье.[Наименование_Сырья], [Поступление_прошлый_год].[Поступление_за_прошлый_год] FROM([Поступление_прошлый_год] INNER JOIN" +
        //        " Сырье ON[Поступление_прошлый_год].[Код_сырья] = Сырье.[Код_Сырья]) WHERE [" + comboBox1.Text + "] " + textBox1.Text;
        //        }
        //        else
        //        {
        //            if (comboBox1.Text == "Наименование_Сырья")
        //            {
        //                поступлениеПрошлыйГодTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_прошлый_год].Код, [Поступление_прошлый_год].[Код_сырья], " +
        //        "Сырье.[Наименование_Сырья], [Поступление_прошлый_год].[Поступление_за_прошлый_год] FROM([Поступление_прошлый_год] INNER JOIN" +
        //        " Сырье ON[Поступление_прошлый_год].[Код_сырья] = Сырье.[Код_Сырья]) " +
        //                    "WHERE(Сырье.[Наименование_Сырья] like '" + textBox1.Text + "')";
        //            }
        //            else
        //            {
        //                поступлениеПрошлыйГодTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_прошлый_год].Код, [Поступление_прошлый_год].[Код_сырья], " +
        //        "Сырье.[Наименование_Сырья], [Поступление_прошлый_год].[Поступление_за_прошлый_год] FROM([Поступление_прошлый_год] INNER JOIN" +
        //        " Сырье ON[Поступление_прошлый_год].[Код_сырья] = Сырье.[Код_Сырья]) WHERE [" + comboBox1.Text + "] =" + textBox1.Text;
        //            }
        //        }
        //        this.поступлениеПрошлыйГодTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеПрошлыйГод);
        //    }
        //    catch
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
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //Изменить
        //    panel1.Visible = true;
        //    p = '2';
        //    DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //    int RawID = Convert.ToInt32(dgvr.Cells[1].Value);
        //    int LastYear = Convert.ToInt32(dgvr.Cells[3].Value);
        //    comboBox2.SelectedValue = RawID;
        //    textBox2.Text = LastYear.ToString();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //Удалить
        //    DataRowView drv = поступлениеПрошлыйГодBindingSource.Current as DataRowView;
        //    int ID = Convert.ToInt32(drv.Row["Код"]);

        //    var result = MessageBox.Show("Удалить данные о поступлении за прошлый год?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        поступлениеПрошлыйГодTableAdapter.Connection.Open(); //Открываем подключение
        //        поступлениеПрошлыйГодTableAdapter.Adapter.DeleteCommand.Parameters["Код"].Value = ID;
        //        try
        //        {
        //            поступлениеПрошлыйГодTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
        //            поступлениеПрошлыйГодTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеПрошлыйГод);

        //        }
        //        catch
        //        {
        //            MessageBox.Show("Невозможно удалить, так как имеются связи", "Предупреждение");
        //        }
        //        поступлениеПрошлыйГодTableAdapter.Connection.Close();
        //    }
        //}

        //private void buttonОтменить_Click(object sender, EventArgs e)
        //{
        //    //Отмена
        //    comboBox2.SelectedValue = 1;
        //    textBox2.Text = "";
        //    panel1.Visible = false;
        //}

        //private void buttonПрименить_Click(object sender, EventArgs e)
        //{
        //    //Применить
        //    if (textBox2.Text != "" && comboBox2.Text != "")
        //    {
        //        if (p == '1')
        //        {//Добавить
        //            int LastYear = Convert.ToInt32(textBox2.Text);
        //            int ID = Convert.ToInt32(comboBox2.SelectedValue);
        //            поступлениеПрошлыйГодTableAdapter.Connection.Open(); //Открываем подключение
        //                                                                 //Задаем параметры запроса
        //            поступлениеПрошлыйГодTableAdapter.Adapter.InsertCommand.Parameters["Поступление_за_прошлый_год"].Value = LastYear;
        //            поступлениеПрошлыйГодTableAdapter.Adapter.InsertCommand.Parameters["Код_сырья"].Value = ID;
        //            //Выполняем
        //            try
        //            {
        //                поступлениеПрошлыйГодTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
        //                поступлениеПрошлыйГодTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеПрошлыйГод);
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Невозможно добавить объект");
        //            }
        //            поступлениеПрошлыйГодTableAdapter.Connection.Close(); //Закрываем подключение
        //        }
        //        else
        //            if (p == '2')
        //        {
        //            DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //            int ID = Convert.ToInt32(dgvr.Cells[0].Value);
        //            int RawID = Convert.ToInt32(comboBox2.SelectedValue);
        //            int LastYear = Convert.ToInt32(textBox2.Text);

        //            поступлениеПрошлыйГодTableAdapter.Connection.Open(); //Открываем подключение

        //            поступлениеПрошлыйГодTableAdapter.Adapter.UpdateCommand.Parameters["Код_сырья"].Value = RawID;

        //            поступлениеПрошлыйГодTableAdapter.Adapter.UpdateCommand.Parameters["Поступление_за_прошлый_год"].Value = LastYear;

        //            поступлениеПрошлыйГодTableAdapter.Adapter.UpdateCommand.Parameters["Original_Код"].Value = ID;

        //            поступлениеПрошлыйГодTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();

        //            поступлениеПрошлыйГодTableAdapter.Fill(индивидуальное3DataSet.ПоступлениеПрошлыйГод);
        //            поступлениеПрошлыйГодTableAdapter.Connection.Close();
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
                this.поступлениеПрошлыйГодBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "'";
            }
            else
            {
                int temp;
                int.TryParse(toolStripTextBox1.Text, out temp);
                if (temp != 0)
                {
                    this.поступлениеПрошлыйГодBindingSource.Filter = "[" + toolStripComboBox1.Text + "] =" + toolStripTextBox1;
                }
                else this.поступлениеПрошлыйГодBindingSource.Filter = "[" + toolStripComboBox1.Text + "] " + toolStripTextBox1;

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Отменить
            this.поступлениеПрошлыйГодBindingSource.Filter = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.поступлениеПрошлыйГодBindingSource.ResetBindings(false);
            this.поступлениеПрошлыйГодTableAdapter.Update(this.индивидуальное3DataSet.ПоступлениеПрошлыйГод);
            this.поступлениеПрошлыйГодTableAdapter.Fill(this.индивидуальное3DataSet.ПоступлениеПрошлыйГод);

        }
    }
}
