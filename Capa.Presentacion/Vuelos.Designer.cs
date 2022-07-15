namespace Capa.Presentacion
{
    partial class Vuelos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtCiudadOrigen = new System.Windows.Forms.TextBox();
            this.TextEstadoVuelo = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtNumeroVuelo = new System.Windows.Forms.TextBox();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinutoSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinutoLlegada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoraLlegada = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DGVuelos = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de origen :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad de destino :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora de salida :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de vuelo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Aerolinea :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hora de llegada :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado de vuelo :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(776, 117);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(355, 22);
            this.txtCiudadDestino.TabIndex = 2;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(280, 214);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(110, 22);
            this.txtHoraSalida.TabIndex = 5;
            this.txtHoraSalida.TextChanged += new System.EventHandler(this.txtHoraSalida_TextChanged);
            // 
            // txtCiudadOrigen
            // 
            this.txtCiudadOrigen.Location = new System.Drawing.Point(234, 117);
            this.txtCiudadOrigen.Name = "txtCiudadOrigen";
            this.txtCiudadOrigen.Size = new System.Drawing.Size(355, 22);
            this.txtCiudadOrigen.TabIndex = 1;
            // 
            // TextEstadoVuelo
            // 
            this.TextEstadoVuelo.Location = new System.Drawing.Point(776, 267);
            this.TextEstadoVuelo.Name = "TextEstadoVuelo";
            this.TextEstadoVuelo.Size = new System.Drawing.Size(355, 22);
            this.TextEstadoVuelo.TabIndex = 10;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(234, 267);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(355, 22);
            this.txtAerolinea.TabIndex = 9;
            // 
            // txtNumeroVuelo
            // 
            this.txtNumeroVuelo.Location = new System.Drawing.Point(776, 164);
            this.txtNumeroVuelo.Name = "txtNumeroVuelo";
            this.txtNumeroVuelo.Size = new System.Drawing.Size(355, 22);
            this.txtNumeroVuelo.TabIndex = 4;
            // 
            // DTFecha
            // 
            this.DTFecha.Location = new System.Drawing.Point(234, 162);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(355, 22);
            this.DTFecha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hora :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Minuto :";
            // 
            // txtMinutoSalida
            // 
            this.txtMinutoSalida.Location = new System.Drawing.Point(463, 211);
            this.txtMinutoSalida.Name = "txtMinutoSalida";
            this.txtMinutoSalida.Size = new System.Drawing.Size(126, 22);
            this.txtMinutoSalida.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(947, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Minuto :";
            // 
            // txtMinutoLlegada
            // 
            this.txtMinutoLlegada.Location = new System.Drawing.Point(1005, 211);
            this.txtMinutoLlegada.Name = "txtMinutoLlegada";
            this.txtMinutoLlegada.Size = new System.Drawing.Size(126, 22);
            this.txtMinutoLlegada.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(773, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Hora :";
            // 
            // txtHoraLlegada
            // 
            this.txtHoraLlegada.Location = new System.Drawing.Point(822, 214);
            this.txtHoraLlegada.Name = "txtHoraLlegada";
            this.txtHoraLlegada.Size = new System.Drawing.Size(110, 22);
            this.txtHoraLlegada.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(1006, 308);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 28);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DGVuelos
            // 
            this.DGVuelos.AllowUserToAddRows = false;
            this.DGVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVuelos.Location = new System.Drawing.Point(109, 352);
            this.DGVuelos.Name = "DGVuelos";
            this.DGVuelos.RowHeadersWidth = 51;
            this.DGVuelos.RowTemplate.Height = 24;
            this.DGVuelos.Size = new System.Drawing.Size(1022, 240);
            this.DGVuelos.TabIndex = 26;
            this.DGVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVuelos_CellContentClick);
            this.DGVuelos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVuelos_CellMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(382, 39);
            this.label13.TabIndex = 27;
            this.label13.Text = "Administrador de vuelos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(109, 308);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 28);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(240, 308);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 28);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(371, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 28);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(874, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 28);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 658);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DGVuelos);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMinutoLlegada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHoraLlegada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMinutoSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.txtNumeroVuelo);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.TextEstadoVuelo);
            this.Controls.Add(this.txtCiudadOrigen);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtCiudadDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vuelos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.TextBox txtCiudadOrigen;
        private System.Windows.Forms.TextBox TextEstadoVuelo;
        private System.Windows.Forms.TextBox txtAerolinea;
        private System.Windows.Forms.TextBox txtNumeroVuelo;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinutoSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinutoLlegada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoraLlegada;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGVuelos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

