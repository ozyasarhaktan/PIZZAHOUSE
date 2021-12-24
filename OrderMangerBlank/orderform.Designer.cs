
namespace OrderMangerBlank
{
    partial class orderform
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pizzaDataSet2 = new OrderMangerBlank.PizzaDataSet2();
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter = new OrderMangerBlank.PizzaDataSet2TableAdapters.Product2TableAdapter();
            this.pizzaDataSet3 = new OrderMangerBlank.PizzaDataSet3();
            this.product2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter1 = new OrderMangerBlank.PizzaDataSet3TableAdapters.Product2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pizzaDataSet4 = new OrderMangerBlank.PizzaDataSet4();
            this.product2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter2 = new OrderMangerBlank.PizzaDataSet4TableAdapters.Product2TableAdapter();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(978, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 48);
            this.button1.TabIndex = 55;
            this.button1.Text = "Seepete Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.pNameDataGridViewTextBoxColumn,
            this.PCat,
            this.pWeDataGridViewTextBoxColumn,
            this.pPrDataGridViewTextBoxColumn,
            this.pQuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.product2BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 398);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // pizzaDataSet2
            // 
            this.pizzaDataSet2.DataSetName = "PizzaDataSet2";
            this.pizzaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product2BindingSource
            // 
            this.product2BindingSource.DataMember = "Product2";
            this.product2BindingSource.DataSource = this.pizzaDataSet2;
            // 
            // product2TableAdapter
            // 
            this.product2TableAdapter.ClearBeforeFill = true;
            // 
            // pizzaDataSet3
            // 
            this.pizzaDataSet3.DataSetName = "PizzaDataSet3";
            this.pizzaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product2BindingSource1
            // 
            this.product2BindingSource1.DataMember = "Product2";
            this.product2BindingSource1.DataSource = this.pizzaDataSet3;
            // 
            // product2TableAdapter1
            // 
            this.product2TableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(741, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Product Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(745, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 30);
            this.textBox1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(740, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Product Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(985, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Product Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(740, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Product Quantity:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(978, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 30);
            this.textBox2.TabIndex = 67;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(749, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 30);
            this.textBox3.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Patates",
            "İçecek",
            "Pizza",
            "Hamburger"});
            this.comboBox1.Location = new System.Drawing.Point(745, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1007, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(741, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Product Weight:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(746, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 30);
            this.textBox4.TabIndex = 72;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(1058, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(93, 30);
            this.textBox5.TabIndex = 74;
            // 
            // pizzaDataSet4
            // 
            this.pizzaDataSet4.DataSetName = "PizzaDataSet4";
            this.pizzaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product2BindingSource2
            // 
            this.product2BindingSource2.DataMember = "Product2";
            this.product2BindingSource2.DataSource = this.pizzaDataSet4;
            // 
            // product2TableAdapter2
            // 
            this.product2TableAdapter2.ClearBeforeFill = true;
            // 
            // PId
            // 
            this.PId.DataPropertyName = "PId";
            this.PId.HeaderText = "PId";
            this.PId.MinimumWidth = 6;
            this.PId.Name = "PId";
            this.PId.ReadOnly = true;
            this.PId.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // PCat
            // 
            this.PCat.DataPropertyName = "PCat";
            this.PCat.HeaderText = "PCat";
            this.PCat.MinimumWidth = 6;
            this.PCat.Name = "PCat";
            this.PCat.Width = 125;
            // 
            // pWeDataGridViewTextBoxColumn
            // 
            this.pWeDataGridViewTextBoxColumn.DataPropertyName = "PWe";
            this.pWeDataGridViewTextBoxColumn.HeaderText = "PWe";
            this.pWeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pWeDataGridViewTextBoxColumn.Name = "pWeDataGridViewTextBoxColumn";
            this.pWeDataGridViewTextBoxColumn.Width = 125;
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
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "orderform";
            this.Text = "orderform";
            this.Load += new System.EventHandler(this.orderform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzaDataSet2 pizzaDataSet2;
        private System.Windows.Forms.BindingSource product2BindingSource;
        private PizzaDataSet2TableAdapters.Product2TableAdapter product2TableAdapter;
        private PizzaDataSet3 pizzaDataSet3;
        private System.Windows.Forms.BindingSource product2BindingSource1;
        private PizzaDataSet3TableAdapters.Product2TableAdapter product2TableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private PizzaDataSet4 pizzaDataSet4;
        private System.Windows.Forms.BindingSource product2BindingSource2;
        private PizzaDataSet4TableAdapters.Product2TableAdapter product2TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQuDataGridViewTextBoxColumn;
    }
}