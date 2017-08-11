namespace misafirhane
{
    partial class odalar2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.misafirhaneDataSet = new misafirhane.misafirhaneDataSet();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter = new misafirhane.misafirhaneDataSetTableAdapters.odalarTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.misafirhaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.misafirhaneDataSet1 = new misafirhane.misafirhaneDataSet1();
            this.odalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter1 = new misafirhane.misafirhaneDataSet1TableAdapters.odalarTableAdapter();
            this.odatipiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxkisiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddrumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.odatipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxkisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddrumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOLMAMIŞ ODALAR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 229);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DOLU ODALAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odatipiDataGridViewTextBoxColumn,
            this.odaNumDataGridViewTextBoxColumn,
            this.maxkisiDataGridViewTextBoxColumn,
            this.ddrumDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.odalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(543, 187);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // misafirhaneDataSet
            // 
            this.misafirhaneDataSet.DataSetName = "misafirhaneDataSet";
            this.misafirhaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "odalar";
            this.odalarBindingSource.DataSource = this.misafirhaneDataSet;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odatipiDataGridViewTextBoxColumn1,
            this.odaNumDataGridViewTextBoxColumn1,
            this.maxkisiDataGridViewTextBoxColumn1,
            this.ddrumDataGridViewTextBoxColumn1,
            this.aciklamaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.odalarBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 28);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(543, 195);
            this.dataGridView2.TabIndex = 1;
            // 
            // misafirhaneDataSetBindingSource
            // 
            this.misafirhaneDataSetBindingSource.DataSource = this.misafirhaneDataSet;
            this.misafirhaneDataSetBindingSource.Position = 0;
            // 
            // misafirhaneDataSet1
            // 
            this.misafirhaneDataSet1.DataSetName = "misafirhaneDataSet1";
            this.misafirhaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource1
            // 
            this.odalarBindingSource1.DataMember = "odalar";
            this.odalarBindingSource1.DataSource = this.misafirhaneDataSet1;
            // 
            // odalarTableAdapter1
            // 
            this.odalarTableAdapter1.ClearBeforeFill = true;
            // 
            // odatipiDataGridViewTextBoxColumn1
            // 
            this.odatipiDataGridViewTextBoxColumn1.DataPropertyName = "odatipi";
            this.odatipiDataGridViewTextBoxColumn1.HeaderText = "Oda Tipi";
            this.odatipiDataGridViewTextBoxColumn1.Name = "odatipiDataGridViewTextBoxColumn1";
            this.odatipiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // odaNumDataGridViewTextBoxColumn1
            // 
            this.odaNumDataGridViewTextBoxColumn1.DataPropertyName = "odaNum";
            this.odaNumDataGridViewTextBoxColumn1.HeaderText = "Oda Numarası";
            this.odaNumDataGridViewTextBoxColumn1.Name = "odaNumDataGridViewTextBoxColumn1";
            this.odaNumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxkisiDataGridViewTextBoxColumn1
            // 
            this.maxkisiDataGridViewTextBoxColumn1.DataPropertyName = "maxkisi";
            this.maxkisiDataGridViewTextBoxColumn1.HeaderText = "Max. Kişi Sayısı";
            this.maxkisiDataGridViewTextBoxColumn1.Name = "maxkisiDataGridViewTextBoxColumn1";
            this.maxkisiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ddrumDataGridViewTextBoxColumn1
            // 
            this.ddrumDataGridViewTextBoxColumn1.DataPropertyName = "ddrum";
            this.ddrumDataGridViewTextBoxColumn1.HeaderText = "Odada Kalan";
            this.ddrumDataGridViewTextBoxColumn1.Name = "ddrumDataGridViewTextBoxColumn1";
            this.ddrumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn1
            // 
            this.aciklamaDataGridViewTextBoxColumn1.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn1.HeaderText = "Kat";
            this.aciklamaDataGridViewTextBoxColumn1.Name = "aciklamaDataGridViewTextBoxColumn1";
            this.aciklamaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(567, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oda Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Numarası";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Misafir Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(95, 16);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda Tipi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Odada Kalanlar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // odatipiDataGridViewTextBoxColumn
            // 
            this.odatipiDataGridViewTextBoxColumn.DataPropertyName = "odatipi";
            this.odatipiDataGridViewTextBoxColumn.HeaderText = "Oda Tpi";
            this.odatipiDataGridViewTextBoxColumn.Name = "odatipiDataGridViewTextBoxColumn";
            this.odatipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaNumDataGridViewTextBoxColumn
            // 
            this.odaNumDataGridViewTextBoxColumn.DataPropertyName = "odaNum";
            this.odaNumDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.odaNumDataGridViewTextBoxColumn.Name = "odaNumDataGridViewTextBoxColumn";
            this.odaNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxkisiDataGridViewTextBoxColumn
            // 
            this.maxkisiDataGridViewTextBoxColumn.DataPropertyName = "maxkisi";
            this.maxkisiDataGridViewTextBoxColumn.HeaderText = "Max. Kişi Sayısı";
            this.maxkisiDataGridViewTextBoxColumn.Name = "maxkisiDataGridViewTextBoxColumn";
            this.maxkisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ddrumDataGridViewTextBoxColumn
            // 
            this.ddrumDataGridViewTextBoxColumn.DataPropertyName = "ddrum";
            this.ddrumDataGridViewTextBoxColumn.HeaderText = "Odada Kalan ";
            this.ddrumDataGridViewTextBoxColumn.Name = "ddrumDataGridViewTextBoxColumn";
            this.ddrumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Kat";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // odalar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "odalar2";
            this.Text = "odalar";
            this.Load += new System.EventHandler(this.odalar2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misafirhaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private misafirhaneDataSet misafirhaneDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private misafirhaneDataSetTableAdapters.odalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource misafirhaneDataSetBindingSource;
        private misafirhaneDataSet1 misafirhaneDataSet1;
        private System.Windows.Forms.BindingSource odalarBindingSource1;
        private misafirhaneDataSet1TableAdapters.odalarTableAdapter odalarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odatipiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxkisiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddrumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn odatipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxkisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddrumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}