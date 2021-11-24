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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.ВычислениеРазницы". При необходимости она может быть перемещена или удалена.
            this.вычислениеРазницыTableAdapter.Fill(this.индивидуальное3DataSet.ВычислениеРазницы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Выполнить
            try
            {
                int temp;
                int.TryParse(textBox1.Text, out temp);
                if (temp == 0 && comboBox1.Text != "Наименование_Сырья")
                {
                    вычислениеРазницыTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], " +
                "[Поступление_Сырья].[Код_Сырья], Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], " +
                "[Поступление_Сырья].[Фактическое_поступление], [Поступление_Сырья].[Плановое_поступление] - " +
                "[Поступление_Сырья].[Фактическое_поступление] AS Разница FROM(Сырье INNER JOIN " +
                "[Поступление_Сырья] ON Сырье.[Код_Сырья] = [Поступление_Сырья].[Код_Сырья])" +
                " WHERE [" + comboBox1.Text + "] " + textBox1.Text;
                }
                else
                {
                    if (comboBox1.Text == "Наименование_Сырья")
                    {
                        вычислениеРазницыTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], " +
                "[Поступление_Сырья].[Код_Сырья], Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], " +
                "[Поступление_Сырья].[Фактическое_поступление], [Поступление_Сырья].[Плановое_поступление] - " +
                "[Поступление_Сырья].[Фактическое_поступление] AS Разница FROM(Сырье INNER JOIN " +
                "[Поступление_Сырья] ON Сырье.[Код_Сырья] = [Поступление_Сырья].[Код_Сырья])" +
                " WHERE(Сырье.[Наименование_Сырья] like '" + textBox1.Text + "')";
                    }
                    else
                    {
                        вычислениеРазницыTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], " +
                "[Поступление_Сырья].[Код_Сырья], Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], " +
                "[Поступление_Сырья].[Фактическое_поступление], [Поступление_Сырья].[Плановое_поступление] - " +
                "[Поступление_Сырья].[Фактическое_поступление] AS Разница FROM(Сырье INNER JOIN " +
                "[Поступление_Сырья] ON Сырье.[Код_Сырья] = [Поступление_Сырья].[Код_Сырья])" +
                " WHERE [" + comboBox1.Text + "] =" + textBox1.Text;
                    }
                }
                this.вычислениеРазницыTableAdapter.Fill(this.индивидуальное3DataSet.ВычислениеРазницы);
            }
            catch
            {
                MessageBox.Show("неверный запрос");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Отменить
            вычислениеРазницыTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Поступление_Сырья].[Код_поставки], " +
                "[Поступление_Сырья].[Код_Сырья], Сырье.[Наименование_Сырья], [Поступление_Сырья].[Плановое_поступление], " +
                "[Поступление_Сырья].[Фактическое_поступление], [Поступление_Сырья].[Плановое_поступление] - " +
                "[Поступление_Сырья].[Фактическое_поступление] AS Разница FROM(Сырье INNER JOIN " +
                "[Поступление_Сырья] ON Сырье.[Код_Сырья] = [Поступление_Сырья].[Код_Сырья])";
            this.вычислениеРазницыTableAdapter.Fill(this.индивидуальное3DataSet.ВычислениеРазницы);
            textBox1.Text = "";
        }
    }
}
