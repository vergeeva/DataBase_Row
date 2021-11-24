
namespace Индивидуальное
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.индивидуальное3DataSet = new Индивидуальное.Индивидуальное3DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сырьеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.поступлениеСырьяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поступлениеСырьяTableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.ПоступлениеСырьяTableAdapter();
            this.сырьеTableAdapter = new Индивидуальное.Индивидуальное3DataSetTableAdapters.СырьеTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.кодпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование_Сырья = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.плановоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоепоступлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сырьеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениеСырьяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // индивидуальное3DataSet
            // 
            this.индивидуальное3DataSet.DataSetName = "Индивидуальное3DataSet";
            this.индивидуальное3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпоставкиDataGridViewTextBoxColumn,
            this.кодСырьяDataGridViewTextBoxColumn,
            this.Наименование_Сырья,
            this.плановоепоступлениеDataGridViewTextBoxColumn,
            this.фактическоепоступлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поступлениеСырьяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(857, 354);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // сырьеBindingSource1
            // 
            this.сырьеBindingSource1.DataMember = "Сырье";
            this.сырьеBindingSource1.DataSource = this.индивидуальное3DataSet;
            // 
            // поступлениеСырьяBindingSource
            // 
            this.поступлениеСырьяBindingSource.DataMember = "ПоступлениеСырья";
            this.поступлениеСырьяBindingSource.DataSource = this.индивидуальное3DataSet;
            // 
            // поступлениеСырьяTableAdapter
            // 
            this.поступлениеСырьяTableAdapter.ClearBeforeFill = true;
            // 
            // сырьеTableAdapter
            // 
            this.сырьеTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.поступлениеСырьяBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(902, 28);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Наименование_Сырья",
            "Плановое_поступление",
            "Фактическое_поступление"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(215, 28);
            this.toolStripComboBox1.ToolTipText = "Фильтровать по полю";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox1.ToolTipText = "Введите значение";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(91, 25);
            this.toolStripButton3.Text = "Выполнить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(81, 25);
            this.toolStripButton4.Text = "Отменить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // кодпоставкиDataGridViewTextBoxColumn
            // 
            this.кодпоставкиDataGridViewTextBoxColumn.DataPropertyName = "Код_поставки";
            this.кодпоставкиDataGridViewTextBoxColumn.HeaderText = "Код_поставки";
            this.кодпоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпоставкиDataGridViewTextBoxColumn.Name = "кодпоставкиDataGridViewTextBoxColumn";
            this.кодпоставкиDataGridViewTextBoxColumn.Visible = false;
            this.кодпоставкиDataGridViewTextBoxColumn.Width = 90;
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
            // Наименование_Сырья
            // 
            this.Наименование_Сырья.DataPropertyName = "Код_Сырья";
            this.Наименование_Сырья.DataSource = this.сырьеBindingSource1;
            this.Наименование_Сырья.DisplayMember = "Наименование_Сырья";
            this.Наименование_Сырья.HeaderText = "Наименование_Сырья";
            this.Наименование_Сырья.MinimumWidth = 6;
            this.Наименование_Сырья.Name = "Наименование_Сырья";
            this.Наименование_Сырья.ValueMember = "Код_Сырья";
            this.Наименование_Сырья.Width = 200;
            // 
            // плановоепоступлениеDataGridViewTextBoxColumn
            // 
            this.плановоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Плановое_поступление";
            this.плановоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.плановоепоступлениеDataGridViewTextBoxColumn.Name = "плановоепоступлениеDataGridViewTextBoxColumn";
            this.плановоепоступлениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // фактическоепоступлениеDataGridViewTextBoxColumn
            // 
            this.фактическоепоступлениеDataGridViewTextBoxColumn.DataPropertyName = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.HeaderText = "Фактическое_поступление";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Name = "фактическоепоступлениеDataGridViewTextBoxColumn";
            this.фактическоепоступлениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 410);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Поступление сырья";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.индивидуальное3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сырьеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениеСырьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Индивидуальное3DataSet индивидуальное3DataSet;
        private System.Windows.Forms.BindingSource поступлениеСырьяBindingSource;
        private Индивидуальное3DataSetTableAdapters.ПоступлениеСырьяTableAdapter поступлениеСырьяTableAdapter;
        private Индивидуальное3DataSetTableAdapters.СырьеTableAdapter сырьеTableAdapter;
        private System.Windows.Forms.BindingSource сырьеBindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Наименование_Сырья;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановоепоступлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическоепоступлениеDataGridViewTextBoxColumn;
    }
}