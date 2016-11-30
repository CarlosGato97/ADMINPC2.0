namespace WinFormApp
{
    partial class BorrarReactivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarReactivo));
            this.btnBorr = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBus = new System.Windows.Forms.Button();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorr
            // 
            this.btnBorr.Location = new System.Drawing.Point(203, 136);
            this.btnBorr.Name = "btnBorr";
            this.btnBorr.Size = new System.Drawing.Size(75, 23);
            this.btnBorr.TabIndex = 0;
            this.btnBorr.Text = "Borrar";
            this.btnBorr.UseVisualStyleBackColor = true;
            this.btnBorr.Click += new System.EventHandler(this.btnBorr_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(81, 136);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "volver";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(284, 12);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(75, 23);
            this.btnBus.TabIndex = 2;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(178, 15);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(100, 20);
            this.txtBus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el numero de Reactivo:";
            // 
            // txtReac
            // 
            this.txtReac.Location = new System.Drawing.Point(178, 83);
            this.txtReac.Name = "txtReac";
            this.txtReac.Size = new System.Drawing.Size(100, 20);
            this.txtReac.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(114, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reactivo:";
            // 
            // BorrarReactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrarReactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrarReactivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorr;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReac;
        private System.Windows.Forms.Label label2;
    }
}