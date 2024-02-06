namespace Kino
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.kinoDataSet = new Kino.kinoDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new Kino.kinoDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new Kino.kinoDataSetTableAdapters.TableAdapterManager();
            this.пользовательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пользовательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пользовательDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).BeginInit();
            this.пользовательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.kinoDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kino.kinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.СеансTableAdapter = null;
            this.tableAdapterManager.ФильмTableAdapter = null;
            // 
            // пользовательBindingNavigator
            // 
            this.пользовательBindingNavigator.AddNewItem = null;
            this.пользовательBindingNavigator.BindingSource = this.пользовательBindingSource;
            this.пользовательBindingNavigator.CountItem = null;
            this.пользовательBindingNavigator.DeleteItem = null;
            this.пользовательBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.пользовательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.пользовательBindingNavigatorSaveItem});
            this.пользовательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пользовательBindingNavigator.MoveFirstItem = null;
            this.пользовательBindingNavigator.MoveLastItem = null;
            this.пользовательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пользовательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пользовательBindingNavigator.Name = "пользовательBindingNavigator";
            this.пользовательBindingNavigator.PositionItem = null;
            this.пользовательBindingNavigator.Size = new System.Drawing.Size(796, 31);
            this.пользовательBindingNavigator.TabIndex = 0;
            this.пользовательBindingNavigator.Text = "bindingNavigator1";
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
            // пользовательBindingNavigatorSaveItem
            // 
            this.пользовательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пользовательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательBindingNavigatorSaveItem.Image")));
            this.пользовательBindingNavigatorSaveItem.Name = "пользовательBindingNavigatorSaveItem";
            this.пользовательBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.пользовательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пользовательBindingNavigatorSaveItem.Click += new System.EventHandler(this.пользовательBindingNavigatorSaveItem_Click);
            // 
            // пользовательDataGridView
            // 
            this.пользовательDataGridView.AllowUserToAddRows = false;
            this.пользовательDataGridView.AutoGenerateColumns = false;
            this.пользовательDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.пользовательDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользовательDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.пользовательDataGridView.DataSource = this.пользовательBindingSource;
            this.пользовательDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.пользовательDataGridView.Location = new System.Drawing.Point(0, 31);
            this.пользовательDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.пользовательDataGridView.Name = "пользовательDataGridView";
            this.пользовательDataGridView.RowHeadersWidth = 51;
            this.пользовательDataGridView.Size = new System.Drawing.Size(796, 402);
            this.пользовательDataGridView.TabIndex = 1;
            this.пользовательDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пользовательDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Роль";
            this.dataGridViewTextBoxColumn2.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 433);
            this.Controls.Add(this.пользовательDataGridView);
            this.Controls.Add(this.пользовательBindingNavigator);
            this.Font = new System.Drawing.Font("STXingkai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form12";
            this.Text = "Редактирование паролей пользователей";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).EndInit();
            this.пользовательBindingNavigator.ResumeLayout(false);
            this.пользовательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private kinoDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private kinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользовательBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пользовательBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView пользовательDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}