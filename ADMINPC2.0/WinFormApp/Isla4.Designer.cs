﻿namespace WinFormApp
{
    partial class Isla4
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
            this.btnVolver4 = new System.Windows.Forms.Button();
            this.btnEnviar4 = new System.Windows.Forms.Button();
            this.txtDescripcion4 = new System.Windows.Forms.TextBox();
            this.txtHora4 = new System.Windows.Forms.TextBox();
            this.txtFecha4 = new System.Windows.Forms.TextBox();
            this.txtNumIsla4 = new System.Windows.Forms.TextBox();
            this.txtID4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver4
            // 
            this.btnVolver4.Location = new System.Drawing.Point(605, 255);
            this.btnVolver4.Name = "btnVolver4";
            this.btnVolver4.Size = new System.Drawing.Size(75, 23);
            this.btnVolver4.TabIndex = 25;
            this.btnVolver4.Text = "Volver";
            this.btnVolver4.UseVisualStyleBackColor = true;
            this.btnVolver4.Click += new System.EventHandler(this.btnVolver4_Click);
            // 
            // btnEnviar4
            // 
            this.btnEnviar4.Location = new System.Drawing.Point(605, 163);
            this.btnEnviar4.Name = "btnEnviar4";
            this.btnEnviar4.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar4.TabIndex = 24;
            this.btnEnviar4.Text = "Enviar";
            this.btnEnviar4.UseVisualStyleBackColor = true;
            this.btnEnviar4.Click += new System.EventHandler(this.btnEnviar4_Click);
            // 
            // txtDescripcion4
            // 
            this.txtDescripcion4.Location = new System.Drawing.Point(34, 133);
            this.txtDescripcion4.Multiline = true;
            this.txtDescripcion4.Name = "txtDescripcion4";
            this.txtDescripcion4.Size = new System.Drawing.Size(564, 164);
            this.txtDescripcion4.TabIndex = 23;
            // 
            // txtHora4
            // 
            this.txtHora4.Location = new System.Drawing.Point(512, 70);
            this.txtHora4.Name = "txtHora4";
            this.txtHora4.Size = new System.Drawing.Size(86, 20);
            this.txtHora4.TabIndex = 22;
            // 
            // txtFecha4
            // 
            this.txtFecha4.Location = new System.Drawing.Point(370, 70);
            this.txtFecha4.Name = "txtFecha4";
            this.txtFecha4.Size = new System.Drawing.Size(86, 20);
            this.txtFecha4.TabIndex = 21;
            // 
            // txtNumIsla4
            // 
            this.txtNumIsla4.Location = new System.Drawing.Point(241, 70);
            this.txtNumIsla4.Name = "txtNumIsla4";
            this.txtNumIsla4.Size = new System.Drawing.Size(49, 20);
            this.txtNumIsla4.TabIndex = 20;
            // 
            // txtID4
            // 
            this.txtID4.Location = new System.Drawing.Point(56, 70);
            this.txtID4.Name = "txtID4";
            this.txtID4.Size = new System.Drawing.Size(86, 20);
            this.txtID4.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero de Isla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Isla 4";
            // 
            // Isla4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 307);
            this.Controls.Add(this.btnVolver4);
            this.Controls.Add(this.btnEnviar4);
            this.Controls.Add(this.txtDescripcion4);
            this.Controls.Add(this.txtHora4);
            this.Controls.Add(this.txtFecha4);
            this.Controls.Add(this.txtNumIsla4);
            this.Controls.Add(this.txtID4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Isla4";
            this.Text = "Isla4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver4;
        private System.Windows.Forms.Button btnEnviar4;
        private System.Windows.Forms.TextBox txtDescripcion4;
        private System.Windows.Forms.TextBox txtHora4;
        private System.Windows.Forms.TextBox txtFecha4;
        private System.Windows.Forms.TextBox txtNumIsla4;
        private System.Windows.Forms.TextBox txtID4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}