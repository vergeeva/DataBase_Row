
namespace Индивидуальное
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разницаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вычислениеРазницыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.индивидуальное3DataSet = new Индивидуальное.Индивидуальное3DataSet();
            this.вычислениеРазницыTableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.ВычислениеРазницыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вычислениеРазницыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 307);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите значение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фильтровать по полю:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Код_поставки",
            "Наименование_Сырья",
            "Плановое_поступление",
            "Фактическое_поступление"});
            this.comboBox1.Location = new System.Drawing.Point(15, 306);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпоставкиDataGridViewTextBoxColumn,
            this.кодСырьяDataGridViewTextBoxColumn,
            this.наименованиеСырьяDataGridViewTextBoxColumn,
            this.плановоепоступлениеDataGridViewTextBoxColumn,
            this.фактическоепоступлениеDataGridViewTextBoxColumn,
            this.разницаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вычислениеРазницыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // кодпоставкиDataGridViewTextBoxColumn
            // 
            this.кодпоставкиDataGridViewTextBoxColumn.DataPropertyName = "Код_поставки";
            this.кодпоставкиDataGridViewTextBoxColumn.HeaderText = "Код_поставки";
            this.кодпоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпоставкиDataGridViewTextBoxColumn.Name = "кодпоставкиDataGridViewTextBoxColumn";
            this.кодпоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСырьяDataGridViewTextBoxColumn
            // 
            this.кодСырьяDataGridViewTextBoxColumn.DataPropertyName = "Код_Сырья";
            this.кодСырьяDataGridViewTextBoxColumn.HeaderText = "Код_Сырья";
            this.кодСырьяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСырьяDataGridViewTextBoxColumn.Name = "кодСырьяDataGridViewTextBoxColumn";
            this.кодСырьяDataGridViewTextBoxColumn.Visible = false;
            this.кодСырьяDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеСырьяDataGridViewTextBoxColumn
            // 
            this.наименованиеСырьяDataGridViewTextBoxColumn.DataPropertyName = "Наименование_Сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.HeaderText = "Наименование_Сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеСырьяDataGridViewTextBoxColumn.Name = "наименованиеСырьяDataGridViewTextBoxColumn";
            this.наименованиеСырьяDataGridViewTextBoxColumn.Width = 130;
            // 
            // плановоепоступлениеDataGridViewTextBoxColumn
            // 
            this.плановоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.плановоепоступлениеDataGridViewTextBoxColumn.Name = "плановоепоступлениеDataGridViewTextBoxColumn";
            this.плановоепоступлениеDataGridViewTextBoxColumn.Width = 140;
            // 
            // фактическоепоступлениеDataGridViewTextBoxColumn
            // 
            this.фактическоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Name = "фактическоепоступлениеDataGridViewTextBoxColumn";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // разницаDataGridViewTextBoxColumn
            // 
            this.разницаDataGridViewTextBoxColumn.DataPropertyName = "Разница";
            this.разницаDataGridViewTextBoxColumn.HeaderText = "Разница";
            this.разницаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.разницаDataGridViewTextBoxColumn.Name = "разницаDataGridViewTextBoxColumn";
            this.разницаDataGridViewTextBoxColumn.ReadOnly = true;
            this.разницаDataGridViewTextBoxColumn.Width = 125;
            // 
            // вычислениеРазницыBindingSource
            // 
            this.вычислениеРазницыBindingSource.DataMember = "ВычислениеРазницы";
            this.вычислениеРазницыBindingSource.DataSource = this.индивидуальное3DataSet;
            // 
            // индивидуальное3DataSet
            // 
            this.индивидуальное3DataSet.DataSetName = "Индивидуальное3DataSet";
            this.индивидуальное3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вычислениеРазницыTableAdapter
            // 
            this.вычислениеРазницыTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Вычисление разницы";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вычислениеРазницыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Индивидуальное3DataSet индивидуальное3DataSet;
        private System.Windows.Forms.BindingSource вычислениеРазницыBindingSource;
        private Индивидуальное3DataSetTableAdapters.ВычислениеРазницыTableAdapter вычислениеРазницыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разницаDataGridViewTextBoxColumn;
    }
}