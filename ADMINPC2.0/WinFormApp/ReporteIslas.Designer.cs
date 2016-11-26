namespace WinFormApp
{
    partial class ReporteIslas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numIslaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportIslasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINPCDataSet = new WinFormApp.ADMINPCDataSet();
            this.btnVolverMenuAdmin = new System.Windows.Forms.Button();
            this.reportIslasTableAdapter = new WinFormApp.ADMINPCDataSetTableAdapters.ReportIslasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportIslasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINPCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reportes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numIslaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportIslasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 204);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numIslaDataGridViewTextBoxColumn
            // 
            this.numIslaDataGridViewTextBoxColumn.DataPropertyName = "NumIsla";
            this.numIslaDataGridViewTextBoxColumn.HeaderText = "NumIsla";
            this.numIslaDataGridViewTextBoxColumn.Name = "numIslaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // reportIslasBindingSource
            // 
            this.reportIslasBindingSource.DataMember = "ReportIslas";
            this.reportIslasBindingSource.DataSource = this.aDMINPCDataSet;
            // 
            // aDMINPCDataSet
            // 
            this.aDMINPCDataSet.DataSetName = "ADMINPCDataSet";
            this.aDMINPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVolverMenuAdmin
            // 
            this.btnVolverMenuAdmin.Location = new System.Drawing.Point(541, 290);
            this.btnVolverMenuAdmin.Name = "btnVolverMenuAdmin";
            this.btnVolverMenuAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMenuAdmin.TabIndex = 3;
            this.btnVolverMenuAdmin.Text = "Volver";
            this.btnVolverMenuAdmin.UseVisualStyleBackColor = true;
            this.btnVolverMenuAdmin.Click += new System.EventHandler(this.btnVolverMenuAdmin_Click);
            // 
            // reportIslasTableAdapter
            // 
            this.reportIslasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteIslas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 322);
            this.Controls.Add(this.btnVolverMenuAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteIslas";
            this.Text = "ReporteIslas";
            this.Load += new System.EventHandler(this.ReporteIslas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportIslasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINPCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverMenuAdmin;
        private ADMINPCDataSet aDMINPCDataSet;
        private System.Windows.Forms.BindingSource reportIslasBindingSource;
        private ADMINPCDataSetTableAdapters.ReportIslasTableAdapter reportIslasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIslaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}