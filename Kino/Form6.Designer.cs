namespace Kino
{
    partial class Form6
    {
        
        private System.ComponentModel.IContainer components = null;

     
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.kinoDataSet = new Kino.kinoDataSet();
            this.залBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залTableAdapter = new Kino.kinoDataSetTableAdapters.ЗалTableAdapter();
            this.tableAdapterManager = new Kino.kinoDataSetTableAdapters.TableAdapterManager();
            this.залDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рядов = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мест = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Всего_мест = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залBindingSource
            // 
            this.залBindingSource.DataMember = "Зал";
            this.залBindingSource.DataSource = this.kinoDataSet;
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
            // залDataGridView
            // 
            this.залDataGridView.AllowUserToAddRows = false;
            this.залDataGridView.AutoGenerateColumns = false;
            this.залDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.залDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.залDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Рядов,
            this.Мест,
            this.Всего_мест});
            this.залDataGridView.DataSource = this.залBindingSource;
            this.залDataGridView.Location = new System.Drawing.Point(27, 14);
            this.залDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.залDataGridView.Name = "залDataGridView";
            this.залDataGridView.ReadOnly = true;
            this.залDataGridView.RowHeadersWidth = 51;
            this.залDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.залDataGridView.Size = new System.Drawing.Size(783, 280);
            this.залDataGridView.TabIndex = 1;
            this.залDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.залDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Рядов
            // 
            this.Рядов.DataPropertyName = "Рядов";
            this.Рядов.HeaderText = "Рядов";
            this.Рядов.MinimumWidth = 6;
            this.Рядов.Name = "Рядов";
            this.Рядов.ReadOnly = true;
            this.Рядов.Width = 125;
            // 
            // Мест
            // 
            this.Мест.DataPropertyName = "Мест";
            this.Мест.HeaderText = "Мест";
            this.Мест.MinimumWidth = 6;
            this.Мест.Name = "Мест";
            this.Мест.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Редактирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(840, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.залDataGridView);
            this.Font = new System.Drawing.Font("STXingkai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Залы";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource залBindingSource;
        private kinoDataSetTableAdapters.ЗалTableAdapter залTableAdapter;
        private kinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView залDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Рядов;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мест;
        private System.Windows.Forms.DataGridViewTextBoxColumn Всего_мест;
    }
}