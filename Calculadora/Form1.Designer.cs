﻿using System;

namespace Calculadora
{
    partial class Form1
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
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonMultiplica = new System.Windows.Forms.Button();
            this.botonDivision = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.botonResultado = new System.Windows.Forms.Button();
            this.botonPunto = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuma.Location = new System.Drawing.Point(33, 87);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(61, 51);
            this.botonSuma.TabIndex = 1;
            this.botonSuma.Text = "+";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.botonSuma_Click);
            // 
            // botonResta
            // 
            this.botonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResta.Location = new System.Drawing.Point(101, 87);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(61, 51);
            this.botonResta.TabIndex = 2;
            this.botonResta.Text = "-";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // botonMultiplica
            // 
            this.botonMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultiplica.Location = new System.Drawing.Point(167, 87);
            this.botonMultiplica.Name = "botonMultiplica";
            this.botonMultiplica.Size = new System.Drawing.Size(61, 51);
            this.botonMultiplica.TabIndex = 3;
            this.botonMultiplica.Text = "*";
            this.botonMultiplica.UseVisualStyleBackColor = true;
            this.botonMultiplica.Click += new System.EventHandler(this.botonMultiplicacion_Click);
            // 
            // botonDivision
            // 
            this.botonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDivision.Location = new System.Drawing.Point(234, 87);
            this.botonDivision.Name = "botonDivision";
            this.botonDivision.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botonDivision.Size = new System.Drawing.Size(61, 51);
            this.botonDivision.TabIndex = 4;
            this.botonDivision.Text = "/";
            this.botonDivision.UseVisualStyleBackColor = true;
            this.botonDivision.Click += new System.EventHandler(this.botonDivision_Click);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(33, 144);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(61, 51);
            this.boton7.TabIndex = 5;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(101, 144);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(61, 51);
            this.boton8.TabIndex = 6;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(167, 144);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(61, 51);
            this.boton9.TabIndex = 7;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(33, 201);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(61, 51);
            this.boton4.TabIndex = 9;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(101, 201);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(61, 51);
            this.boton5.TabIndex = 10;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(167, 199);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(61, 51);
            this.boton6.TabIndex = 11;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // botonResultado
            // 
            this.botonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResultado.Location = new System.Drawing.Point(234, 256);
            this.botonResultado.Name = "botonResultado";
            this.botonResultado.Size = new System.Drawing.Size(61, 106);
            this.botonResultado.TabIndex = 12;
            this.botonResultado.Text = "=";
            this.botonResultado.UseVisualStyleBackColor = true;
            this.botonResultado.Click += new System.EventHandler(this.botonResultado_Click);
            // 
            // botonPunto
            // 
            this.botonPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPunto.Location = new System.Drawing.Point(167, 311);
            this.botonPunto.Name = "botonPunto";
            this.botonPunto.Size = new System.Drawing.Size(61, 51);
            this.botonPunto.TabIndex = 13;
            this.botonPunto.Text = ".";
            this.botonPunto.UseVisualStyleBackColor = true;
            this.botonPunto.Click += new System.EventHandler(this.botonPunto_Click);
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(33, 311);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(128, 51);
            this.boton0.TabIndex = 14;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(234, 199);
            this.botonBorrar.Name = "botonLimpiar";
            this.botonBorrar.Size = new System.Drawing.Size(61, 51);
            this.botonBorrar.TabIndex = 15;
            this.botonBorrar.Text = "CE";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(33, 258);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(61, 49);
            this.boton1.TabIndex = 16;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(101, 258);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(61, 49);
            this.boton2.TabIndex = 17;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(167, 256);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(61, 49);
            this.boton3.TabIndex = 18;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 144);
            this.button1.Name = "botonBorrar";
            this.button1.Size = new System.Drawing.Size(61, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.botonPunto);
            this.Controls.Add(this.botonResultado);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.botonDivision);
            this.Controls.Add(this.botonMultiplica);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button botonMultiplica;
        private System.Windows.Forms.Button botonDivision;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button botonResultado;
        private System.Windows.Forms.Button botonPunto;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button button1;
    }
}

