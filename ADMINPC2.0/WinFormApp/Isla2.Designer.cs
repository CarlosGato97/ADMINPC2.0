namespace WinFormApp
{
    partial class Isla2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Isla2));
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.txtHora2 = new System.Windows.Forms.TextBox();
            this.txtFecha2 = new System.Windows.Forms.TextBox();
            this.txtNumIsla2 = new System.Windows.Forms.TextBox();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver2
            // 
            this.btnVolver2.Location = new System.Drawing.Point(605, 255);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(75, 23);
            this.btnVolver2.TabIndex = 25;
            this.btnVolver2.Text = "Volver";
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(605, 163);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar2.TabIndex = 24;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            this.btnEnviar2.Click += new System.EventHandler(this.btnEnviar2_Click);
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(34, 133);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(564, 164);
            this.txtDescripcion2.TabIndex = 23;
            // 
            // txtHora2
            // 
            this.txtHora2.Location = new System.Drawing.Point(512, 70);
            this.txtHora2.Name = "txtHora2";
            this.txtHora2.Size = new System.Drawing.Size(86, 20);
            this.txtHora2.TabIndex = 22;
            // 
            // txtFecha2
            // 
            this.txtFecha2.Location = new System.Drawing.Point(370, 70);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(86, 20);
            this.txtFecha2.TabIndex = 21;
            // 
            // txtNumIsla2
            // 
            this.txtNumIsla2.Location = new System.Drawing.Point(241, 70);
            this.txtNumIsla2.Name = "txtNumIsla2";
            this.txtNumIsla2.Size = new System.Drawing.Size(49, 20);
            this.txtNumIsla2.TabIndex = 20;
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(56, 70);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(86, 20);
            this.txtID2.TabIndex = 19;
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
            this.label1.Text = "Isla 2";
            // 
            // Isla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 311);
            this.Controls.Add(this.btnVolver2);
            this.Controls.Add(this.btnEnviar2);
            this.Controls.Add(this.txtDescripcion2);
            this.Controls.Add(this.txtHora2);
            this.Controls.Add(this.txtFecha2);
            this.Controls.Add(this.txtNumIsla2);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Isla2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isla2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TextBox txtHora2;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.TextBox txtNumIsla2;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}