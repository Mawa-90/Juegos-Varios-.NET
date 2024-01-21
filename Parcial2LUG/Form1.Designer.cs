namespace Parcial2LUG
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
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtNomUsuBusq = new Parcial2LUG.Nombre();
            this.txtMail = new Parcial2LUG.Mail();
            this.txtApe = new Parcial2LUG.Nombre();
            this.txtNom = new Parcial2LUG.Nombre();
            this.txtDNI = new Parcial2LUG.DNI();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJugador
            // 
            this.dgvJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugador.Location = new System.Drawing.Point(12, 12);
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.Size = new System.Drawing.Size(776, 178);
            this.dgvJugador.TabIndex = 0;
            this.dgvJugador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugador_CellContentClick);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(322, 284);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(143, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Location = new System.Drawing.Point(322, 210);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(143, 20);
            this.txtPuntaje.TabIndex = 7;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(322, 247);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(143, 20);
            this.txtCod.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(322, 377);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(106, 44);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(673, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 44);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fec. Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Puntaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Edad";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(445, 377);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 44);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(445, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 44);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(673, 293);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(106, 44);
            this.btnMostrarTodos.TabIndex = 30;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Búsqueda Nombre";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(100, 366);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(143, 21);
            this.cmbLocalidad.TabIndex = 32;
            // 
            // txtNomUsuBusq
            // 
            this.txtNomUsuBusq.Location = new System.Drawing.Point(638, 205);
            this.txtNomUsuBusq.Name = "txtNomUsuBusq";
            this.txtNomUsuBusq.Size = new System.Drawing.Size(150, 25);
            this.txtNomUsuBusq.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(96, 324);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(148, 27);
            this.txtMail.TabIndex = 26;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(93, 247);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(150, 25);
            this.txtApe.TabIndex = 25;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(94, 205);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 25);
            this.txtNom.TabIndex = 24;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(94, 284);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(149, 26);
            this.txtDNI.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNomUsuBusq);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dgvJugador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJugador;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DNI txtDNI;
        private Nombre txtNom;
        private Nombre txtApe;
        private Mail txtMail;
        private Nombre txtNomUsuBusq;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLocalidad;
    }
}

