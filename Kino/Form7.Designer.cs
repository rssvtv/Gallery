namespace Kino
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.залBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.залBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new Kino.kinoDataSet();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.залBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.залDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рядов = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мест = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Всего_мест = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залTableAdapter = new Kino.kinoDataSetTableAdapters.ЗалTableAdapter();
            this.tableAdapterManager = new Kino.kinoDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingNavigator)).BeginInit();
            this.залBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // залBindingNavigator
            // 
            this.залBindingNavigator.AddNewItem = null;
            this.залBindingNavigator.BindingSource = this.залBindingSource;
            this.залBindingNavigator.CountItem = null;
            this.залBindingNavigator.DeleteItem = null;
            this.залBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.залBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.залBindingNavigatorSaveItem});
            this.залBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.залBindingNavigator.MoveFirstItem = null;
            this.залBindingNavigator.MoveLastItem = null;
            this.залBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.залBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.залBindingNavigator.Name = "залBindingNavigator";
            this.залBindingNavigator.PositionItem = null;
            this.залBindingNavigator.Size = new System.Drawing.Size(666, 31);
            this.залBindingNavigator.TabIndex = 0;
            this.залBindingNavigator.Text = "bindingNavigator1";
            // 
            // залBindingSource
            // 
            this.залBindingSource.DataMember = "Зал";
            this.залBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // залBindingNavigatorSaveItem
            // 
            this.залBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.залBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("залBindingNavigatorSaveItem.Image")));
            this.залBindingNavigatorSaveItem.Name = "залBindingNavigatorSaveItem";
            this.залBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.залBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.залBindingNavigatorSaveItem.Click += new System.EventHandler(this.залBindingNavigatorSaveItem_Click);
            // 
            // залDataGridView
            // 
            this.залDataGridView.AllowUserToAddRows = false;
            this.залDataGridView.AutoGenerateColumns = false;
            this.залDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.залDataGridView.ColumnHeadersHeight = 40;
            this.залDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Рядов,
            this.Мест,
            this.Всего_мест,
            this.dataGridViewTextBoxColumn2});
            this.залDataGridView.DataSource = this.залBindingSource;
            this.залDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.залDataGridView.Location = new System.Drawing.Point(0, 31);
            this.залDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.залDataGridView.Name = "залDataGridView";
            this.залDataGridView.RowHeadersWidth = 51;
            this.залDataGridView.Size = new System.Drawing.Size(666, 320);
            this.залDataGridView.TabIndex = 1;
            this.залDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.залDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Рядов
            // 
            this.Рядов.DataPropertyName = "Рядов";
            this.Рядов.HeaderText = "Рядов";
            this.Рядов.MinimumWidth = 6;
            this.Рядов.Name = "Рядов";
            this.Рядов.Width = 125;
            // 
            // Мест
            // 
            this.Мест.DataPropertyName = "Мест";
            this.Мест.HeaderText = "Мест";
            this.Мест.MinimumWidth = 6;
            this.Мест.Name = "Мест";
            this.Мест.Width = 125;
            // 
            // Всего_мест
            // 
            this.Всего_мест.DataPropertyName = "Всего_мест";
            this.Всего_мест.HeaderText = "Всего мест";
            this.Всего_мест.MinimumWidth = 6;
            this.Всего_мест.Name = "Всего_мест";
            this.Всего_мест.ReadOnly = true;
            this.Всего_мест.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // залTableAdapter
            // 
            this.залTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kino.kinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = this.залTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.СеансTableAdapter = null;
            this.tableAdapterManager.ФильмTableAdapter = null;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 351);
            this.Controls.Add(this.залDataGridView);
            this.Controls.Add(this.залBindingNavigator);
            this.Font = new System.Drawing.Font("STXingkai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "Редактирование залов";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.залBindingNavigator)).EndInit();
            this.залBindingNavigator.ResumeLayout(false);
            this.залBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource залBindingSource;
        private kinoDataSetTableAdapters.ЗалTableAdapter залTableAdapter;
        private kinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator залBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton залBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView залDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Рядов;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мест;
        private System.Windows.Forms.DataGridViewTextBoxColumn Всего_мест;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}