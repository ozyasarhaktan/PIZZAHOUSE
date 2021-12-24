
namespace OrderMangerBlank
{
    partial class sepetform
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
            this.pizzaDataSet5 = new OrderMangerBlank.PizzaDataSet5();
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepetTableAdapter = new OrderMangerBlank.PizzaDataSet5TableAdapters.SepetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaDataSet10 = new OrderMangerBlank.PizzaDataSet10();
            this.sepet1TableAdapter = new OrderMangerBlank.PizzaDataSet10TableAdapters.Sepet1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaDataSet5
            // 
            this.pizzaDataSet5.DataSetName = "PizzaDataSet5";
            this.pizzaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "Sepet";
            this.sepetBindingSource.DataSource = this.pizzaDataSet5;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(868, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 48);
            this.button1.TabIndex = 56;
            this.button1.Text = "Seepeti Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pWeDataGridViewTextBoxColumn,
            this.pCatDataGridViewTextBoxColumn,
            this.pPrDataGridViewTextBoxColumn,
            this.pQuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sepet1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(76, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(932, 276);
            this.dataGridView2.TabIndex = 57;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "PId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "PId";
            this.pIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pWeDataGridViewTextBoxColumn
            // 
            this.pWeDataGridViewTextBoxColumn.DataPropertyName = "PWe";
            this.pWeDataGridViewTextBoxColumn.HeaderText = "PWe";
            this.pWeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pWeDataGridViewTextBoxColumn.Name = "pWeDataGridViewTextBoxColumn";
            this.pWeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pCatDataGridViewTextBoxColumn
            // 
            this.pCatDataGridViewTextBoxColumn.DataPropertyName = "PCat";
            this.pCatDataGridViewTextBoxColumn.HeaderText = "PCat";
            this.pCatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pCatDataGridViewTextBoxColumn.Name = "pCatDataGridViewTextBoxColumn";
            this.pCatDataGridViewTextBoxColumn.Width = 125;
            // 
            // pPrDataGridViewTextBoxColumn
            // 
            this.pPrDataGridViewTextBoxColumn.DataPropertyName = "PPr";
            this.pPrDataGridViewTextBoxColumn.HeaderText = "PPr";
            this.pPrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pPrDataGridViewTextBoxColumn.Name = "pPrDataGridViewTextBoxColumn";
            this.pPrDataGridViewTextBoxColumn.Width = 125;
            // 
            // pQuDataGridViewTextBoxColumn
            // 
            this.pQuDataGridViewTextBoxColumn.DataPropertyName = "PQu";
            this.pQuDataGridViewTextBoxColumn.HeaderText = "PQu";
            this.pQuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pQuDataGridViewTextBoxColumn.Name = "pQuDataGridViewTextBoxColumn";
            this.pQuDataGridViewTextBoxColumn.Width = 125;
            // 
            // sepet1BindingSource
            // 
            this.sepet1BindingSource.DataMember = "Sepet1";
            this.sepet1BindingSource.DataSource = this.pizzaDataSet10;
            // 
            // pizzaDataSet10
            // 
            this.pizzaDataSet10.DataSetName = "PizzaDataSet10";
            this.pizzaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepet1TableAdapter
            // 
            this.sepet1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "AMOUNT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(247, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "00";
            // 
            // sepetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "sepetform";
            this.Text = "sepetform";
            this.Load += new System.EventHandler(this.sepetform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PizzaDataSet5 pizzaDataSet5;
        private System.Windows.Forms.BindingSource sepetBindingSource;
        private PizzaDataSet5TableAdapters.SepetTableAdapter sepetTableAdapter;
        private System.Windows.Forms.Button button1;
        private PizzaDataSet10 pizzaDataSet10;
        private System.Windows.Forms.BindingSource sepet1BindingSource;
        private PizzaDataSet10TableAdapters.Sepet1TableAdapter sepet1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}