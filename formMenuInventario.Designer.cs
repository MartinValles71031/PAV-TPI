namespace MandaleFruta
{
    partial class formMenuInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuInventario));
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTipoArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(53, 39);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(202, 57);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "&Artículos";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(223, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTipoArticulo
            // 
            this.btnTipoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnTipoArticulo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoArticulo.Location = new System.Drawing.Point(53, 128);
            this.btnTipoArticulo.Name = "btnTipoArticulo";
            this.btnTipoArticulo.Size = new System.Drawing.Size(202, 57);
            this.btnTipoArticulo.TabIndex = 6;
            this.btnTipoArticulo.Text = "&Categorías";
            this.btnTipoArticulo.UseVisualStyleBackColor = false;
            this.btnTipoArticulo.Click += new System.EventHandler(this.btnTipoArticulo_Click);
            // 
            // formMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 263);
            this.Controls.Add(this.btnTipoArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenuInventario";
            this.Text = "Mandale Fruta";
            this.Load += new System.EventHandler(this.frmMenuInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTipoArticulo;
    }
}