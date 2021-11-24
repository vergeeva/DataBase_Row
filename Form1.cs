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
    public partial class Form1 : Form
    {
        char p;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.Сырье". При необходимости она может быть перемещена или удалена.
            this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
            //panel1.Visible = false;
        }


        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //Добавить
        //    //panel1.Visible = true;
        //    p = '1';
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{//Изменить
        //    //panel1.Visible = true;
        //    p = '2';
        //    DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //    string RawName = dgvr.Cells[1].Value as String;
        //    //textBoxСырье.Text = RawName;

        //}

 //       private void button5_Click(object sender, EventArgs e)
 //       {
 //           //Удалить
 //           var result = MessageBox.Show("Удалить сырье?", "Вопрос",
 //MessageBoxButtons.YesNo,
 //MessageBoxIcon.Question);
 //           if (result == DialogResult.Yes)
 //           {
 //               DataGridViewRow dgvr = dataGridView1.CurrentRow;
 //               int ID = Convert.ToInt32(dgvr.Cells[0].Value);
 //               String Raw_Name = dgvr.Cells[1].Value as String;

 //               try
 //               {
 //                   сырьеTableAdapter.Delete(ID, Raw_Name);
 //                   this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
 //               }
 //               catch
 //               {
 //                   MessageBox.Show("Удаление невозможно, так как у элемента имеются связи", "Предупреждение");
 //               }
 //           }
 //       }

        private void buttonОтменить_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            //textBoxСырье.Text = "";
        }

        //private void buttonПрименить_Click(object sender, EventArgs e)
        //{
        //    if (textBoxСырье.Text != "")
        //    {
        //        if (p == '1')
        //        {
        //            сырьеTableAdapter.Insert(textBoxСырье.Text);
        //        }
        //        else
        //            if (p == '2')
        //        {
        //            DataGridViewRow dgvr = dataGridView1.CurrentRow;
        //            int ID = Convert.ToInt32(dgvr.Cells[0].Value);
        //            string RawName = dgvr.Cells[1].Value as String;
        //            сырьеTableAdapter.Update(textBoxСырье.Text, ID, RawName);
        //        }
        //        this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
        //        panel1.Visible = false;
        //    }
        //    else MessageBox.Show("Заполните поле!");
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{//Выполнить
        //    try
        //    {
        //        int temp;
        //        int.TryParse(textBox1.Text, out temp);
        //        if (temp == 0 && comboBox1.Text == "Код_Сырья")
        //        {
        //            сырьеTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Код_Сырья], " +
        //           "[Наименование_Сырья] FROM Сырье WHERE [" + comboBox1.Text + "] " + textBox1.Text;
        //        }
        //        else
        //        {
        //            if (comboBox1.Text == "Наименование_Сырья")
        //            {
        //                сырьеTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Код_Сырья], " +
        //                  "[Наименование_Сырья] FROM Сырье WHERE [" + comboBox1.Text + "] like '" + textBox1.Text + "'";
        //            }
        //            else
        //            {
        //                сырьеTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Код_Сырья], " +
        //                  "[Наименование_Сырья] FROM Сырье WHERE [" + comboBox1.Text + "] =" + textBox1.Text;
        //            }
        //        }
        //        this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("неверный запрос");
        //    }
        //   // this.сырьеBindingSource.Filter = ;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{//Отмениить
        //    сырьеTableAdapter.Adapter.SelectCommand.CommandText = "SELECT [Код_Сырья], [Наименование_Сырья] FROM Сырье";
        //    this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
        //    textBox1.Text = "";
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Обновить
            this.сырьеBindingSource.ResetBindings(false);
            this.сырьеTableAdapter.Update(this.индивидуальное3DataSet.Сырье);
            this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.сырьеBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "'";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.сырьеTableAdapter.Fill(this.индивидуальное3DataSet.Сырье);
            this.сырьеBindingSource.Filter = "";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
