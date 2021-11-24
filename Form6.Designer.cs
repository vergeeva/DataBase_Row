
namespace Индивидуальное
{
    partial class Form6
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.сырьеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.индивидуальное3DataSet = new Индивидуальное.Индивидуальное3DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поступлениеСырья1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.сырьеTableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.СырьеTableAdapter();
            this.поступлениеСырья1TableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.ПоступлениеСырья1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.сырьеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениеСырья1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.сырьеBindingSource;
            this.comboBox1.DisplayMember = "Наименование_Сырья";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Код_Сырья";
            // 
            // сырьеBindingSource
            // 
            this.сырьеBindingSource.DataMember = "Сырье";
            this.сырьеBindingSource.DataSource = this.индивидуальное3DataSet;
            this.сырьеBindingSource.CurrentChanged += new System.EventHandler(this.сырьеBindingSource_CurrentChanged);
            // 
            // индивидуальное3DataSet
            // 
            this.индивидуальное3DataSet.DataSetName = "Индивидуальное3DataSet";
            this.индивидуальное3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите сырье:";
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
            this.фактическоепоступлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поступлениеСырья1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 242);
            this.dataGridView1.TabIndex = 2;
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
            this.наименованиеСырьяDataGridViewTextBoxColumn.Width = 150;
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
            // поступлениеСырья1BindingSource
            // 
            this.поступлениеСырья1BindingSource.DataMember = "ПоступлениеСырья1";
            this.поступлениеСырья1BindingSource.DataSource = this.индивидуальное3DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поступление сырья:";
            // 
            // сырьеTableAdapter
            // 
            this.сырьеTableAdapter.ClearBeforeFill = true;
            // 
            // поступлениеСырья1TableAdapter
            // 
            this.поступлениеСырья1TableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form6";
            this.Text = "Главная \"Сырье\"";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сырьеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениеСырья1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Индивидуальное3DataSet индивидуальное3DataSet;
        private System.Windows.Forms.BindingSource сырьеBindingSource;
        private Индивидуальное3DataSetTableAdapters.СырьеTableAdapter сырьеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource поступлениеСырья1BindingSource;
        private Индивидуальное3DataSetTableAdapters.ПоступлениеСырья1TableAdapter поступлениеСырья1TableAdapter;
    }
}