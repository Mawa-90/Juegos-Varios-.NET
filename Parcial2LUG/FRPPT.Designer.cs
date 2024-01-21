namespace Parcial2LUG
{
    partial class FRPPT
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
            this.btnCargaJug = new System.Windows.Forms.Button();
            this.cmbJugadores2de2 = new System.Windows.Forms.ComboBox();
            this.cmbJugadores1de2 = new System.Windows.Forms.ComboBox();
            this.cmbJugadores1 = new System.Windows.Forms.ComboBox();
            this.RB2jugador = new System.Windows.Forms.RadioButton();
            this.RB1jugador = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJ2Empatados = new System.Windows.Forms.Label();
            this.lblJ1Empatados = new System.Windows.Forms.Label();
            this.lblJ2Perdidos = new System.Windows.Forms.Label();
            this.lblJ1Perdidos = new System.Windows.Forms.Label();
            this.lblJ2Ganados = new System.Windows.Forms.Label();
            this.lblJ1Ganados = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNRound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPuntosJ1 = new System.Windows.Forms.Label();
            this.lblPuntosJ2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargaJug
            // 
            this.btnCargaJug.Location = new System.Drawing.Point(636, 173);
            this.btnCargaJug.Name = "btnCargaJug";
            this.btnCargaJug.Size = new System.Drawing.Size(115, 48);
            this.btnCargaJug.TabIndex = 24;
            this.btnCargaJug.Text = "Cargar ";
            this.btnCargaJug.UseVisualStyleBackColor = true;
            this.btnCargaJug.Click += new System.EventHandler(this.btnCargaJug_Click);
            // 
            // cmbJugadores2de2
            // 
            this.cmbJugadores2de2.FormattingEnabled = true;
            this.cmbJugadores2de2.Location = new System.Drawing.Point(588, 124);
            this.cmbJugadores2de2.Name = "cmbJugadores2de2";
            this.cmbJugadores2de2.Size = new System.Drawing.Size(163, 24);
            this.cmbJugadores2de2.TabIndex = 23;
            // 
            // cmbJugadores1de2
            // 
            this.cmbJugadores1de2.FormattingEnabled = true;
            this.cmbJugadores1de2.Location = new System.Drawing.Point(588, 90);
            this.cmbJugadores1de2.Name = "cmbJugadores1de2";
            this.cmbJugadores1de2.Size = new System.Drawing.Size(163, 24);
            this.cmbJugadores1de2.TabIndex = 22;
            // 
            // cmbJugadores1
            // 
            this.cmbJugadores1.FormattingEnabled = true;
            this.cmbJugadores1.Location = new System.Drawing.Point(588, 46);
            this.cmbJugadores1.Name = "cmbJugadores1";
            this.cmbJugadores1.Size = new System.Drawing.Size(163, 24);
            this.cmbJugadores1.TabIndex = 21;
            // 
            // RB2jugador
            // 
            this.RB2jugador.AutoSize = true;
            this.RB2jugador.Location = new System.Drawing.Point(478, 94);
            this.RB2jugador.Name = "RB2jugador";
            this.RB2jugador.Size = new System.Drawing.Size(100, 20);
            this.RB2jugador.TabIndex = 20;
            this.RB2jugador.TabStop = true;
            this.RB2jugador.Text = "2 Jugadores";
            this.RB2jugador.UseVisualStyleBackColor = true;
            // 
            // RB1jugador
            // 
            this.RB1jugador.AutoSize = true;
            this.RB1jugador.Location = new System.Drawing.Point(478, 47);
            this.RB1jugador.Name = "RB1jugador";
            this.RB1jugador.Size = new System.Drawing.Size(85, 20);
            this.RB1jugador.TabIndex = 19;
            this.RB1jugador.TabStop = true;
            this.RB1jugador.Text = "1 Jugador";
            this.RB1jugador.UseVisualStyleBackColor = true;
            this.RB1jugador.CheckedChanged += new System.EventHandler(this.RB1jugador_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccionar Tipo Partida";
            // 
            // lblJ2Empatados
            // 
            this.lblJ2Empatados.AutoSize = true;
            this.lblJ2Empatados.Location = new System.Drawing.Point(342, 400);
            this.lblJ2Empatados.Name = "lblJ2Empatados";
            this.lblJ2Empatados.Size = new System.Drawing.Size(27, 16);
            this.lblJ2Empatados.TabIndex = 43;
            this.lblJ2Empatados.Text = "-----";
            // 
            // lblJ1Empatados
            // 
            this.lblJ1Empatados.AutoSize = true;
            this.lblJ1Empatados.Location = new System.Drawing.Point(342, 363);
            this.lblJ1Empatados.Name = "lblJ1Empatados";
            this.lblJ1Empatados.Size = new System.Drawing.Size(27, 16);
            this.lblJ1Empatados.TabIndex = 42;
            this.lblJ1Empatados.Text = "-----";
            // 
            // lblJ2Perdidos
            // 
            this.lblJ2Perdidos.AutoSize = true;
            this.lblJ2Perdidos.Location = new System.Drawing.Point(251, 400);
            this.lblJ2Perdidos.Name = "lblJ2Perdidos";
            this.lblJ2Perdidos.Size = new System.Drawing.Size(27, 16);
            this.lblJ2Perdidos.TabIndex = 41;
            this.lblJ2Perdidos.Text = "-----";
            // 
            // lblJ1Perdidos
            // 
            this.lblJ1Perdidos.AutoSize = true;
            this.lblJ1Perdidos.Location = new System.Drawing.Point(251, 363);
            this.lblJ1Perdidos.Name = "lblJ1Perdidos";
            this.lblJ1Perdidos.Size = new System.Drawing.Size(27, 16);
            this.lblJ1Perdidos.TabIndex = 40;
            this.lblJ1Perdidos.Text = "-----";
            // 
            // lblJ2Ganados
            // 
            this.lblJ2Ganados.AutoSize = true;
            this.lblJ2Ganados.Location = new System.Drawing.Point(142, 400);
            this.lblJ2Ganados.Name = "lblJ2Ganados";
            this.lblJ2Ganados.Size = new System.Drawing.Size(27, 16);
            this.lblJ2Ganados.TabIndex = 39;
            this.lblJ2Ganados.Text = "-----";
            // 
            // lblJ1Ganados
            // 
            this.lblJ1Ganados.AutoSize = true;
            this.lblJ1Ganados.Location = new System.Drawing.Point(142, 363);
            this.lblJ1Ganados.Name = "lblJ1Ganados";
            this.lblJ1Ganados.Size = new System.Drawing.Size(27, 16);
            this.lblJ1Ganados.TabIndex = 38;
            this.lblJ1Ganados.Text = "-----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Empatados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Perdidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Jugador 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Jugador 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ganados";
            // 
            // lblJugador2
            // 
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Location = new System.Drawing.Point(293, 18);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(35, 16);
            this.lblJugador2.TabIndex = 47;
            this.lblJugador2.Text = "-------";
            // 
            // lblJugador1
            // 
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Location = new System.Drawing.Point(145, 18);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(35, 16);
            this.lblJugador1.TabIndex = 46;
            this.lblJugador1.Text = "-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Jugador 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Jugador 1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Referencia :  1- Piedra  2-Papel  3-Tijera";
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(52, 126);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(100, 22);
            this.txtJ1.TabIndex = 49;
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(332, 126);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(100, 22);
            this.txtJ2.TabIndex = 50;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(185, 173);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(115, 48);
            this.btnMostrar.TabIndex = 51;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Round:";
            // 
            // lblNRound
            // 
            this.lblNRound.AutoSize = true;
            this.lblNRound.Location = new System.Drawing.Point(224, 259);
            this.lblNRound.Name = "lblNRound";
            this.lblNRound.Size = new System.Drawing.Size(27, 16);
            this.lblNRound.TabIndex = 53;
            this.lblNRound.Text = "-----";
            this.lblNRound.Click += new System.EventHandler(this.lblNRound_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Contador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(357, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Contador";
            // 
            // lblPuntosJ1
            // 
            this.lblPuntosJ1.AutoSize = true;
            this.lblPuntosJ1.Location = new System.Drawing.Point(96, 173);
            this.lblPuntosJ1.Name = "lblPuntosJ1";
            this.lblPuntosJ1.Size = new System.Drawing.Size(14, 16);
            this.lblPuntosJ1.TabIndex = 56;
            this.lblPuntosJ1.Text = "0";
            // 
            // lblPuntosJ2
            // 
            this.lblPuntosJ2.AutoSize = true;
            this.lblPuntosJ2.Location = new System.Drawing.Point(382, 173);
            this.lblPuntosJ2.Name = "lblPuntosJ2";
            this.lblPuntosJ2.Size = new System.Drawing.Size(14, 16);
            this.lblPuntosJ2.TabIndex = 57;
            this.lblPuntosJ2.Text = "0";
            this.lblPuntosJ2.Click += new System.EventHandler(this.lblPuntosJ2_Click);
            // 
            // FRPPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.lblPuntosJ2);
            this.Controls.Add(this.lblPuntosJ1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNRound);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtJ2);
            this.Controls.Add(this.txtJ1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblJ2Empatados);
            this.Controls.Add(this.lblJ1Empatados);
            this.Controls.Add(this.lblJ2Perdidos);
            this.Controls.Add(this.lblJ1Perdidos);
            this.Controls.Add(this.lblJ2Ganados);
            this.Controls.Add(this.lblJ1Ganados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargaJug);
            this.Controls.Add(this.cmbJugadores2de2);
            this.Controls.Add(this.cmbJugadores1de2);
            this.Controls.Add(this.cmbJugadores1);
            this.Controls.Add(this.RB2jugador);
            this.Controls.Add(this.RB1jugador);
            this.Controls.Add(this.label2);
            this.Name = "FRPPT";
            this.Text = "FRPPT";
            this.Load += new System.EventHandler(this.FRPPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargaJug;
        private System.Windows.Forms.ComboBox cmbJugadores2de2;
        private System.Windows.Forms.ComboBox cmbJugadores1de2;
        private System.Windows.Forms.ComboBox cmbJugadores1;
        private System.Windows.Forms.RadioButton RB2jugador;
        private System.Windows.Forms.RadioButton RB1jugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJ2Empatados;
        private System.Windows.Forms.Label lblJ1Empatados;
        private System.Windows.Forms.Label lblJ2Perdidos;
        private System.Windows.Forms.Label lblJ1Perdidos;
        private System.Windows.Forms.Label lblJ2Ganados;
        private System.Windows.Forms.Label lblJ1Ganados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJ1;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNRound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPuntosJ1;
        private System.Windows.Forms.Label lblPuntosJ2;
    }
}