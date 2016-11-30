namespace WinFormApp
{
    partial class BorrarIsla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarIsla));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumIsla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBorr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(86, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Isla:";
            // 
            // txtNumIsla
            // 
            this.txtNumIsla.Location = new System.Drawing.Point(178, 93);
            this.txtNumIsla.Name = "txtNumIsla";
            this.txtNumIsla.Size = new System.Drawing.Size(100, 20);
            this.txtNumIsla.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el numero de la Isla:";
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(178, 25);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(100, 20);
            this.txtBus.TabIndex = 10;
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(284, 22);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(75, 23);
            this.btnBus.TabIndex = 9;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(81, 146);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "volver";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBorr
            // 
            this.btnBorr.Location = new System.Drawing.Point(203, 146);
            this.btnBorr.Name = "btnBorr";
            this.btnBorr.Size = new System.Drawing.Size(75, 23);
            this.btnBorr.TabIndex = 7;
            this.btnBorr.Text = "Borrar";
            this.btnBorr.UseVisualStyleBackColor = true;
            this.btnBorr.Click += new System.EventHandler(this.btnBorr_Click);
            // 
            // BorrarIsla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumIsla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrarIsla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrarIsla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumIsla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBorr;
    }
}