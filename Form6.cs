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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "индивидуальное3DataSet.Сырье". При необходимости она может быть перемещена или удалена.
            this.сырьеTableAdapter.Fill(индивидуальное3DataSet.Сырье);
            comboBox1.SelectedValue = 1;
            поступлениеСырья1TableAdapter.Fill(индивидуальное3DataSet.ПоступлениеСырья1, Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void сырьеBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = сырьеBindingSource.Current as DataRowView;
            int ID = 0;
            if (drv != null)
            {
                ID = Convert.ToInt32(comboBox1.SelectedValue);
            }
            поступлениеСырья1TableAdapter.Fill(индивидуальное3DataSet.ПоступлениеСырья1, ID);
        }
    }
}
