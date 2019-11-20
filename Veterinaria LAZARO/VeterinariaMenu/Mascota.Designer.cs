namespace VeterinariaMenu
{
    partial class Mascota
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsexmasc = new System.Windows.Forms.ComboBox();
            this.txtnombredue = new System.Windows.Forms.TextBox();
            this.txtnombmasc = new System.Windows.Forms.TextBox();
            this.txtedadmasc = new System.Windows.Forms.TextBox();
            this.txttipoanimal = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.dvgmascotas = new System.Windows.Forms.DataGridView();
            this.txtnrolista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(530, 248);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(86, 39);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(104, 203);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(86, 39);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(104, 248);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(86, 39);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(12, 248);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(86, 39);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(12, 203);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(86, 39);
            this.btncargar.TabIndex = 4;
            this.btncargar.Text = "Cargar Nuevo";
            this.btncargar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Dueño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad de la Mascota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo de la mascota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de animal";
            // 
            // cmbsexmasc
            // 
            this.cmbsexmasc.FormattingEnabled = true;
            this.cmbsexmasc.Location = new System.Drawing.Point(143, 142);
            this.cmbsexmasc.Name = "cmbsexmasc";
            this.cmbsexmasc.Size = new System.Drawing.Size(121, 21);
            this.cmbsexmasc.TabIndex = 11;
            // 
            // txtnombredue
            // 
            this.txtnombredue.Location = new System.Drawing.Point(143, 38);
            this.txtnombredue.Name = "txtnombredue";
            this.txtnombredue.Size = new System.Drawing.Size(121, 20);
            this.txtnombredue.TabIndex = 12;
            // 
            // txtnombmasc
            // 
            this.txtnombmasc.Location = new System.Drawing.Point(143, 90);
            this.txtnombmasc.Name = "txtnombmasc";
            this.txtnombmasc.Size = new System.Drawing.Size(121, 20);
            this.txtnombmasc.TabIndex = 13;
            // 
            // txtedadmasc
            // 
            this.txtedadmasc.Location = new System.Drawing.Point(143, 116);
            this.txtedadmasc.Name = "txtedadmasc";
            this.txtedadmasc.Size = new System.Drawing.Size(121, 20);
            this.txtedadmasc.TabIndex = 14;
            // 
            // txttipoanimal
            // 
            this.txttipoanimal.Location = new System.Drawing.Point(143, 168);
            this.txttipoanimal.Name = "txttipoanimal";
            this.txttipoanimal.Size = new System.Drawing.Size(121, 20);
            this.txttipoanimal.TabIndex = 15;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(143, 64);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(121, 20);
            this.txtdireccion.TabIndex = 16;
            // 
            // dvgmascotas
            // 
            this.dvgmascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmascotas.Location = new System.Drawing.Point(270, 12);
            this.dvgmascotas.Name = "dvgmascotas";
            this.dvgmascotas.Size = new System.Drawing.Size(346, 230);
            this.dvgmascotas.TabIndex = 17;
            // 
            // txtnrolista
            // 
            this.txtnrolista.Location = new System.Drawing.Point(143, 12);
            this.txtnrolista.Name = "txtnrolista";
            this.txtnrolista.Size = new System.Drawing.Size(121, 20);
            this.txtnrolista.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Numero de Lista";
            // 
            // Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 299);
            this.Controls.Add(this.txtnrolista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dvgmascotas);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttipoanimal);
            this.Controls.Add(this.txtedadmasc);
            this.Controls.Add(this.txtnombmasc);
            this.Controls.Add(this.txtnombredue);
            this.Controls.Add(this.cmbsexmasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Name = "Mascota";
            this.Text = "Mascota";
            this.Load += new System.EventHandler(this.Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgmascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsexmasc;
        private System.Windows.Forms.TextBox txtnombredue;
        private System.Windows.Forms.TextBox txtnombmasc;
        private System.Windows.Forms.TextBox txtedadmasc;
        private System.Windows.Forms.TextBox txttipoanimal;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.DataGridView dvgmascotas;
        private System.Windows.Forms.TextBox txtnrolista;
        private System.Windows.Forms.Label label7;
    }
}