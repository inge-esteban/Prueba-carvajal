namespace Capa.Presentacion
{
    partial class ListaVuelos
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
            this.DGVuelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVuelos
            // 
            this.DGVuelos.AllowUserToAddRows = false;
            this.DGVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVuelos.Location = new System.Drawing.Point(0, 0);
            this.DGVuelos.Name = "DGVuelos";
            this.DGVuelos.RowHeadersWidth = 51;
            this.DGVuelos.RowTemplate.Height = 24;
            this.DGVuelos.Size = new System.Drawing.Size(1243, 438);
            this.DGVuelos.TabIndex = 0;
            // 
            // ListaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.DGVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaVuelos";
            this.Text = "ListaVuelos";
            this.Load += new System.EventHandler(this.ListaVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVuelos;
    }
}