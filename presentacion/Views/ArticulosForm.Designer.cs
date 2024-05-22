using System;
using System.Collections.Generic;
using System.Windows.Forms;
using presentacion.Controllers;
using presentacion.Models;

namespace presentacion
{
    partial class ArticulosForm
    {
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxModelo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbBuscador = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 69);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(742, 221);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "";
            this.btnAgregar.Location = new System.Drawing.Point(499, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Tag = "";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(580, 296);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Location = new System.Drawing.Point(662, 296);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(92, 23);
            this.btnEliminarArt.TabIndex = 3;
            this.btnEliminarArt.Text = "Eliminar Artículo";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            // 
            // cboxMarca
            // 
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(6, 22);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(121, 21);
            this.cboxMarca.TabIndex = 4;
            // 
            // cboxModelo
            // 
            this.cboxModelo.FormattingEnabled = true;
            this.cboxModelo.Location = new System.Drawing.Point(133, 22);
            this.cboxModelo.Name = "cboxModelo";
            this.cboxModelo.Size = new System.Drawing.Size(121, 21);
            this.cboxModelo.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(277, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(433, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gbBuscador
            // 
            this.gbBuscador.Controls.Add(this.textBox1);
            this.gbBuscador.Controls.Add(this.btnBuscar);
            this.gbBuscador.Controls.Add(this.cboxMarca);
            this.gbBuscador.Controls.Add(this.lblNombre);
            this.gbBuscador.Controls.Add(this.cboxModelo);
            this.gbBuscador.Location = new System.Drawing.Point(12, 4);
            this.gbBuscador.Name = "gbBuscador";
            this.gbBuscador.Size = new System.Drawing.Size(523, 59);
            this.gbBuscador.TabIndex = 9;
            this.gbBuscador.TabStop = false;
            this.gbBuscador.Text = "Buscador";
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 326);
            this.Controls.Add(this.gbBuscador);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ArticulosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticulosForm";
            this.Load += new System.EventHandler(this.ArticulosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbBuscador.ResumeLayout(false);
            this.gbBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxModelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbBuscador;
    }
}

