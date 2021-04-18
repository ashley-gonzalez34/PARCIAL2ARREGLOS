
namespace PARCIAL2ARREGLOS
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.listBoxContenido = new System.Windows.Forms.ListBox();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.buttonPrimerParcial = new System.Windows.Forms.Button();
            this.buttonSegundoParcial = new System.Windows.Forms.Button();
            this.buttonTercerParcial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.listBoxPromedio = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNombrePromedios = new System.Windows.Forms.Button();
            this.buttonPromedio1 = new System.Windows.Forms.Button();
            this.buttonPromedio2 = new System.Windows.Forms.Button();
            this.buttonPromedio3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.buttonp1 = new System.Windows.Forms.Button();
            this.buttonp2 = new System.Windows.Forms.Button();
            this.buttonp3 = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonClasificacion = new System.Windows.Forms.Button();
            this.textBoxClasificar = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.comboBoxpromedio = new System.Windows.Forms.ComboBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCargar.Location = new System.Drawing.Point(26, 23);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(91, 53);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // listBoxContenido
            // 
            this.listBoxContenido.FormattingEnabled = true;
            this.listBoxContenido.Location = new System.Drawing.Point(137, 12);
            this.listBoxContenido.Name = "listBoxContenido";
            this.listBoxContenido.Size = new System.Drawing.Size(264, 225);
            this.listBoxContenido.TabIndex = 1;
            // 
            // buttonNombre
            // 
            this.buttonNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNombre.Location = new System.Drawing.Point(13, 116);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(119, 23);
            this.buttonNombre.TabIndex = 2;
            this.buttonNombre.Text = "Nombre";
            this.buttonNombre.UseVisualStyleBackColor = false;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // buttonPrimerParcial
            // 
            this.buttonPrimerParcial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPrimerParcial.Location = new System.Drawing.Point(13, 145);
            this.buttonPrimerParcial.Name = "buttonPrimerParcial";
            this.buttonPrimerParcial.Size = new System.Drawing.Size(119, 23);
            this.buttonPrimerParcial.TabIndex = 3;
            this.buttonPrimerParcial.Text = "PrimerParcial";
            this.buttonPrimerParcial.UseVisualStyleBackColor = false;
            this.buttonPrimerParcial.Click += new System.EventHandler(this.buttonPrimerParcial_Click);
            // 
            // buttonSegundoParcial
            // 
            this.buttonSegundoParcial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSegundoParcial.Location = new System.Drawing.Point(13, 174);
            this.buttonSegundoParcial.Name = "buttonSegundoParcial";
            this.buttonSegundoParcial.Size = new System.Drawing.Size(119, 23);
            this.buttonSegundoParcial.TabIndex = 4;
            this.buttonSegundoParcial.Text = "Segundo Parcial";
            this.buttonSegundoParcial.UseVisualStyleBackColor = false;
            this.buttonSegundoParcial.Click += new System.EventHandler(this.buttonSegundoParcial_Click);
            // 
            // buttonTercerParcial
            // 
            this.buttonTercerParcial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTercerParcial.Location = new System.Drawing.Point(12, 202);
            this.buttonTercerParcial.Name = "buttonTercerParcial";
            this.buttonTercerParcial.Size = new System.Drawing.Size(119, 23);
            this.buttonTercerParcial.TabIndex = 5;
            this.buttonTercerParcial.Text = "TercerParcial";
            this.buttonTercerParcial.UseVisualStyleBackColor = false;
            this.buttonTercerParcial.Click += new System.EventHandler(this.buttonTercerParcial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ORDENAMIENTO";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(407, 12);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(260, 225);
            this.listBoxResultado.TabIndex = 7;
            // 
            // listBoxPromedio
            // 
            this.listBoxPromedio.FormattingEnabled = true;
            this.listBoxPromedio.Location = new System.Drawing.Point(137, 283);
            this.listBoxPromedio.Name = "listBoxPromedio";
            this.listBoxPromedio.Size = new System.Drawing.Size(378, 186);
            this.listBoxPromedio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ORDENAMIENTO PROMEDIOS";
            // 
            // buttonNombrePromedios
            // 
            this.buttonNombrePromedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNombrePromedios.Location = new System.Drawing.Point(754, 32);
            this.buttonNombrePromedios.Name = "buttonNombrePromedios";
            this.buttonNombrePromedios.Size = new System.Drawing.Size(149, 23);
            this.buttonNombrePromedios.TabIndex = 10;
            this.buttonNombrePromedios.Text = "Alumnos";
            this.buttonNombrePromedios.UseVisualStyleBackColor = false;
            this.buttonNombrePromedios.Click += new System.EventHandler(this.buttonNombrePromedios_Click);
            // 
            // buttonPromedio1
            // 
            this.buttonPromedio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPromedio1.Location = new System.Drawing.Point(754, 116);
            this.buttonPromedio1.Name = "buttonPromedio1";
            this.buttonPromedio1.Size = new System.Drawing.Size(149, 23);
            this.buttonPromedio1.TabIndex = 11;
            this.buttonPromedio1.Text = "Promedio3";
            this.buttonPromedio1.UseVisualStyleBackColor = false;
            this.buttonPromedio1.Click += new System.EventHandler(this.buttonPromedio1_Click);
            // 
            // buttonPromedio2
            // 
            this.buttonPromedio2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPromedio2.Location = new System.Drawing.Point(754, 87);
            this.buttonPromedio2.Name = "buttonPromedio2";
            this.buttonPromedio2.Size = new System.Drawing.Size(149, 23);
            this.buttonPromedio2.TabIndex = 12;
            this.buttonPromedio2.Text = "Promedio 2";
            this.buttonPromedio2.UseVisualStyleBackColor = false;
            this.buttonPromedio2.Click += new System.EventHandler(this.buttonPromedio2_Click);
            // 
            // buttonPromedio3
            // 
            this.buttonPromedio3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPromedio3.Location = new System.Drawing.Point(754, 58);
            this.buttonPromedio3.Name = "buttonPromedio3";
            this.buttonPromedio3.Size = new System.Drawing.Size(149, 23);
            this.buttonPromedio3.TabIndex = 13;
            this.buttonPromedio3.Text = "Promedio1";
            this.buttonPromedio3.UseVisualStyleBackColor = false;
            this.buttonPromedio3.Click += new System.EventHandler(this.buttonPromedio3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ORDENAMIENTO POR SECCIONES";
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGeneral.Location = new System.Drawing.Point(763, 290);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(149, 31);
            this.buttonGeneral.TabIndex = 15;
            this.buttonGeneral.Text = "General";
            this.buttonGeneral.UseVisualStyleBackColor = false;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // buttonp1
            // 
            this.buttonp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonp1.Location = new System.Drawing.Point(763, 320);
            this.buttonp1.Name = "buttonp1";
            this.buttonp1.Size = new System.Drawing.Size(149, 31);
            this.buttonp1.TabIndex = 16;
            this.buttonp1.Text = "Parcial 1";
            this.buttonp1.UseVisualStyleBackColor = false;
            this.buttonp1.Click += new System.EventHandler(this.buttonp1_Click);
            // 
            // buttonp2
            // 
            this.buttonp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonp2.Location = new System.Drawing.Point(763, 350);
            this.buttonp2.Name = "buttonp2";
            this.buttonp2.Size = new System.Drawing.Size(149, 31);
            this.buttonp2.TabIndex = 17;
            this.buttonp2.Text = "Parcial 2";
            this.buttonp2.UseVisualStyleBackColor = false;
            this.buttonp2.Click += new System.EventHandler(this.buttonp2_Click);
            // 
            // buttonp3
            // 
            this.buttonp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonp3.Location = new System.Drawing.Point(763, 380);
            this.buttonp3.Name = "buttonp3";
            this.buttonp3.Size = new System.Drawing.Size(149, 31);
            this.buttonp3.TabIndex = 18;
            this.buttonp3.Text = "Parcial 3";
            this.buttonp3.UseVisualStyleBackColor = false;
            this.buttonp3.Click += new System.EventHandler(this.buttonp3_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.Color.Red;
            this.buttonSuma.Location = new System.Drawing.Point(673, 32);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(75, 140);
            this.buttonSuma.TabIndex = 19;
            this.buttonSuma.Text = "Suma";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonClasificacion
            // 
            this.buttonClasificacion.BackColor = System.Drawing.Color.Aqua;
            this.buttonClasificacion.Location = new System.Drawing.Point(521, 337);
            this.buttonClasificacion.Name = "buttonClasificacion";
            this.buttonClasificacion.Size = new System.Drawing.Size(204, 72);
            this.buttonClasificacion.TabIndex = 20;
            this.buttonClasificacion.Text = "CLASIFICACION";
            this.buttonClasificacion.UseVisualStyleBackColor = false;
            this.buttonClasificacion.Click += new System.EventHandler(this.buttonClasificacion_Click);
            // 
            // textBoxClasificar
            // 
            this.textBoxClasificar.Location = new System.Drawing.Point(137, 246);
            this.textBoxClasificar.Name = "textBoxClasificar";
            this.textBoxClasificar.Size = new System.Drawing.Size(530, 20);
            this.textBoxClasificar.TabIndex = 24;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalir.Location = new System.Drawing.Point(217, 492);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(437, 40);
            this.buttonSalir.TabIndex = 25;
            this.buttonSalir.Text = "Salir del programa";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // comboBoxpromedio
            // 
            this.comboBoxpromedio.FormattingEnabled = true;
            this.comboBoxpromedio.Location = new System.Drawing.Point(521, 290);
            this.comboBoxpromedio.Name = "comboBoxpromedio";
            this.comboBoxpromedio.Size = new System.Drawing.Size(177, 21);
            this.comboBoxpromedio.TabIndex = 26;
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Red;
            this.buttonApagar.Location = new System.Drawing.Point(26, 325);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(79, 97);
            this.buttonApagar.TabIndex = 27;
            this.buttonApagar.Text = "Salir 2";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 629);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.comboBoxpromedio);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxClasificar);
            this.Controls.Add(this.buttonClasificacion);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonp3);
            this.Controls.Add(this.buttonp2);
            this.Controls.Add(this.buttonp1);
            this.Controls.Add(this.buttonGeneral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPromedio3);
            this.Controls.Add(this.buttonPromedio2);
            this.Controls.Add(this.buttonPromedio1);
            this.Controls.Add(this.buttonNombrePromedios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPromedio);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTercerParcial);
            this.Controls.Add(this.buttonSegundoParcial);
            this.Controls.Add(this.buttonPrimerParcial);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.listBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.ListBox listBoxContenido;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.Button buttonPrimerParcial;
        private System.Windows.Forms.Button buttonSegundoParcial;
        private System.Windows.Forms.Button buttonTercerParcial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.ListBox listBoxPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNombrePromedios;
        private System.Windows.Forms.Button buttonPromedio1;
        private System.Windows.Forms.Button buttonPromedio2;
        private System.Windows.Forms.Button buttonPromedio3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGeneral;
        private System.Windows.Forms.Button buttonp1;
        private System.Windows.Forms.Button buttonp2;
        private System.Windows.Forms.Button buttonp3;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonClasificacion;
        private System.Windows.Forms.TextBox textBoxClasificar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBoxpromedio;
        private System.Windows.Forms.Button buttonApagar;
    }
}

