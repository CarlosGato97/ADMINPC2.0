namespace WinFormApp
{
    partial class Isla5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Isla5));
            this.btnVolver5 = new System.Windows.Forms.Button();
            this.btnEnviar5 = new System.Windows.Forms.Button();
            this.txtDescripcion5 = new System.Windows.Forms.TextBox();
            this.txtHora5 = new System.Windows.Forms.TextBox();
            this.txtFecha5 = new System.Windows.Forms.TextBox();
            this.txtNumIsla5 = new System.Windows.Forms.TextBox();
            this.txtID5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver5
            // 
            this.btnVolver5.Location = new System.Drawing.Point(605, 255);
            this.btnVolver5.Name = "btnVolver5";
            this.btnVolver5.Size = new System.Drawing.Size(75, 23);
            this.btnVolver5.TabIndex = 25;
            this.btnVolver5.Text = "Volver";
            this.btnVolver5.UseVisualStyleBackColor = true;
            this.btnVolver5.Click += new System.EventHandler(this.btnVolver5_Click);
            // 
            // btnEnviar5
            // 
            this.btnEnviar5.Location = new System.Drawing.Point(605, 163);
            this.btnEnviar5.Name = "btnEnviar5";
            this.btnEnviar5.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar5.TabIndex = 24;
            this.btnEnviar5.Text = "Enviar";
            this.btnEnviar5.UseVisualStyleBackColor = true;
            this.btnEnviar5.Click += new System.EventHandler(this.btnEnviar5_Click);
            // 
            // txtDescripcion5
            // 
            this.txtDescripcion5.Location = new System.Drawing.Point(34, 133);
            this.txtDescripcion5.Multiline = true;
            this.txtDescripcion5.Name = "txtDescripcion5";
            this.txtDescripcion5.Size = new System.Drawing.Size(564, 164);
            this.txtDescripcion5.TabIndex = 23;
            // 
            // txtHora5
            // 
            this.txtHora5.Location = new System.Drawing.Point(512, 70);
            this.txtHora5.Name = "txtHora5";
            this.txtHora5.Size = new System.Drawing.Size(86, 20);
            this.txtHora5.TabIndex = 22;
            // 
            // txtFecha5
            // 
            this.txtFecha5.Location = new System.Drawing.Point(370, 70);
            this.txtFecha5.Name = "txtFecha5";
            this.txtFecha5.Size = new System.Drawing.Size(86, 20);
            this.txtFecha5.TabIndex = 21;
            // 
            // txtNumIsla5
            // 
            this.txtNumIsla5.Location = new System.Drawing.Point(241, 70);
            this.txtNumIsla5.Name = "txtNumIsla5";
            this.txtNumIsla5.Size = new System.Drawing.Size(49, 20);
            this.txtNumIsla5.TabIndex = 20;
            // 
            // txtID5
            // 
            this.txtID5.Location = new System.Drawing.Point(56, 70);
            this.txtID5.Name = "txtID5";
            this.txtID5.Size = new System.Drawing.Size(86, 20);
            this.txtID5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(473, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(324, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(157, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero de Isla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Isla 5";
            // 
            // Isla5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 304);
            this.Controls.Add(this.btnVolver5);
            this.Controls.Add(this.btnEnviar5);
            this.Controls.Add(this.txtDescripcion5);
            this.Controls.Add(this.txtHora5);
            this.Controls.Add(this.txtFecha5);
            this.Controls.Add(this.txtNumIsla5);
            this.Controls.Add(this.txtID5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Isla5";
            this.Text = "Isla5";
            this.Load += new System.EventHandler(this.Isla5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver5;
        private System.Windows.Forms.Button btnEnviar5;
        private System.Windows.Forms.TextBox txtDescripcion5;
        private System.Windows.Forms.TextBox txtHora5;
        private System.Windows.Forms.TextBox txtFecha5;
        private System.Windows.Forms.TextBox txtNumIsla5;
        private System.Windows.Forms.TextBox txtID5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}