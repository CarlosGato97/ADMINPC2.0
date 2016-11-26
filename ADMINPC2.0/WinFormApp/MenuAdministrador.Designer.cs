namespace WinFormApp
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.linkIslas = new System.Windows.Forms.LinkLabel();
            this.linkLaboratorio = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // linkIslas
            // 
            this.linkIslas.AutoSize = true;
            this.linkIslas.BackColor = System.Drawing.Color.Transparent;
            this.linkIslas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkIslas.LinkColor = System.Drawing.Color.Black;
            this.linkIslas.Location = new System.Drawing.Point(16, 67);
            this.linkIslas.Name = "linkIslas";
            this.linkIslas.Size = new System.Drawing.Size(115, 20);
            this.linkIslas.TabIndex = 1;
            this.linkIslas.TabStop = true;
            this.linkIslas.Text = "Reportes de Islas";
            this.linkIslas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIslas_LinkClicked);
            // 
            // linkLaboratorio
            // 
            this.linkLaboratorio.AutoSize = true;
            this.linkLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.linkLaboratorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLaboratorio.LinkColor = System.Drawing.Color.Black;
            this.linkLaboratorio.Location = new System.Drawing.Point(16, 123);
            this.linkLaboratorio.Name = "linkLaboratorio";
            this.linkLaboratorio.Size = new System.Drawing.Size(158, 20);
            this.linkLaboratorio.TabIndex = 2;
            this.linkLaboratorio.TabStop = true;
            this.linkLaboratorio.Text = "Reportes del Laboratorio";
            this.linkLaboratorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLaboratorio_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(17, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 214);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLaboratorio);
            this.Controls.Add(this.linkIslas);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdministrador";
            this.Text = "MenuAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkIslas;
        private System.Windows.Forms.LinkLabel linkLaboratorio;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}