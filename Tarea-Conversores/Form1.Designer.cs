﻿
namespace Tarea_Conversores
{
    partial class Form1
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
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblDeCantidad = new System.Windows.Forms.Label();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblDEConversor = new System.Windows.Forms.Label();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Moneda ",
            "Masa ",
            "Volumen",
            "Longitud",
            "Almacenamiento ",
            "Tiempo",
            "Energía",
            "Tasa de transmisión de datos",
            "Consumo de combustible",
            "Frecuencia",
            "Presión",
            "Temperatura",
            "Ángulo Plano"});
            this.cboTipoConversor.Location = new System.Drawing.Point(207, 48);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(226, 35);
            this.cboTipoConversor.TabIndex = 21;
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadConversores.Location = new System.Drawing.Point(206, 189);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(226, 35);
            this.txtCantidadConversores.TabIndex = 20;
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Items.AddRange(new object[] {
            "Dolar ",
            "Euro",
            "Quetzal ",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cboAConversores.Location = new System.Drawing.Point(207, 144);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(226, 35);
            this.cboAConversores.TabIndex = 19;
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Items.AddRange(new object[] {
            "Dolar ",
            "Euro",
            "Quetzal ",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cboDeConversores.Location = new System.Drawing.Point(207, 91);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(226, 35);
            this.cboDeConversores.TabIndex = 18;
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(35, 251);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(215, 32);
            this.lblRespuestaConversores.TabIndex = 17;
            this.lblRespuestaConversores.Text = "RESPUESTA: ?";
            // 
            // lblDeCantidad
            // 
            this.lblDeCantidad.AutoSize = true;
            this.lblDeCantidad.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeCantidad.Location = new System.Drawing.Point(35, 192);
            this.lblDeCantidad.Name = "lblDeCantidad";
            this.lblDeCantidad.Size = new System.Drawing.Size(165, 32);
            this.lblDeCantidad.TabIndex = 16;
            this.lblDeCantidad.Text = "CANTIDAD:";
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(35, 147);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(42, 32);
            this.lblAConversor.TabIndex = 15;
            this.lblAConversor.Text = "A:";
            // 
            // lblDEConversor
            // 
            this.lblDEConversor.AutoSize = true;
            this.lblDEConversor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEConversor.Location = new System.Drawing.Point(35, 94);
            this.lblDEConversor.Name = "lblDEConversor";
            this.lblDEConversor.Size = new System.Drawing.Size(62, 32);
            this.lblDEConversor.TabIndex = 14;
            this.lblDEConversor.Text = "DE:";
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(35, 51);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(88, 32);
            this.lblTipoConversor.TabIndex = 13;
            this.lblTipoConversor.Text = "TIPO:";
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(168, 325);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(240, 40);
            this.btnConvertirConversores.TabIndex = 12;
            this.btnConvertirConversores.Text = "CONVERTIR";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblDeCantidad);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.lblDEConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblDeCantidad;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblDEConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Button btnConvertirConversores;
    }
}

