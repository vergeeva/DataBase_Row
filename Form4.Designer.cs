
namespace Индивидуальное
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вПроцентахКПлануDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентКПрошломуГодуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подсчетПроцентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.индивидуальное3DataSet = new Индивидуальное.Индивидуальное3DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.подсчетПроцентовTableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.ПодсчетПроцентовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подсчетПроцентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСырьяDataGridViewTextBoxColumn,
            this.наименованиеСырьяDataGridViewTextBoxColumn,
            this.плановоепоступлениеDataGridViewTextBoxColumn,
            this.фактическоепоступлениеDataGridViewTextBoxColumn,
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn,
            this.вПроцентахКПлануDataGridViewTextBoxColumn,
            this.процентКПрошломуГодуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.подсчетПроцентовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 270);
            this.dataGridView1.TabIndex = 1;
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
            this.наименованиеСырьяDataGridViewTextBoxColumn.Width = 150;
            // 
            // плановоепоступлениеDataGridViewTextBoxColumn
            // 
            this.плановоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.плановоепоступлениеDataGridViewTextBoxColumn.Name = "плановоепоступлениеDataGridViewTextBoxColumn";
            this.плановоепоступлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // фактическоепоступлениеDataGridViewTextBoxColumn
            // 
            this.фактическоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Name = "фактическоепоступлениеDataGridViewTextBoxColumn";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // поступлениезапрошлыйгодDataGridViewTextBoxColumn
            // 
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn.DataPropertyName = "Поступление_за_прошлый_год";
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn.HeaderText = "На прошлый год";
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn.Name = "поступлениезапрошлыйгодDataGridViewTextBoxColumn";
            this.поступлениезапрошлыйгодDataGridViewTextBoxColumn.Width = 125;
            // 
            // вПроцентахКПлануDataGridViewTextBoxColumn
            // 
            this.вПроцентахКПлануDataGridViewTextBoxColumn.DataPropertyName = "В процентах к плану";
            this.вПроцентахКПлануDataGridViewTextBoxColumn.HeaderText = "В процентах к плану";
            this.вПроцентахКПлануDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вПроцентахКПлануDataGridViewTextBoxColumn.Name = "вПроцентахКПлануDataGridViewTextBoxColumn";
            this.вПроцентахКПлануDataGridViewTextBoxColumn.ReadOnly = true;
            this.вПроцентахКПлануDataGridViewTextBoxColumn.Width = 125;
            // 
            // процентКПрошломуГодуDataGridViewTextBoxColumn
            // 
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.DataPropertyName = "Процент к прошлому году";
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.HeaderText = "Процент к прошлому году";
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.Name = "процентКПрошломуГодуDataGridViewTextBoxColumn";
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.ReadOnly = true;
            this.процентКПрошломуГодуDataGridViewTextBoxColumn.Width = 125;
            // 
            // подсчетПроцентовBindingSource
            // 
            this.подсчетПроцентовBindingSource.DataMember = "ПодсчетПроцентов";
            this.подсчетПроцентовBindingSource.DataSource = this.индивидуальное3DataSet;
            // 
            // индивидуальное3DataSet
            // 
            this.индивидуальное3DataSet.DataSetName = "Индивидуальное3DataSet";
            this.индивидуальное3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 26);
            this.button2.TabIndex = 12;
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
            this.button1.TabIndex = 11;
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
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите значение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтровать по полю:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Наименование_Сырья",
            "Плановое_поступление",
            "Фактическое_поступление",
            "Поступление_за_прошлый_год"});
            this.comboBox1.Location = new System.Drawing.Point(15, 306);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // подсчетПроцентовTableAdapter
            // 
            this.подсчетПроцентовTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Подсчет процентов к плану";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подсчетПроцентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Индивидуальное3DataSet индивидуальное3DataSet;
        private System.Windows.Forms.BindingSource подсчетПроцентовBindingSource;
        private Индивидуальное3DataSetTableAdapters.ПодсчетПроцентовTableAdapter подсчетПроцентовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поступлениезапрошлыйгодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вПроцентахКПлануDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентКПрошломуГодуDataGridViewTextBoxColumn;
    }
}