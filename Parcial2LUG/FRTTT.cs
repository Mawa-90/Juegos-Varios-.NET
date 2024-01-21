using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LUG
{
    public partial class FRTTT : Form
    {
        public FRTTT()
        {
            InitializeComponent();
        }
        private void FRTTT_Load(object sender, EventArgs e)
        {
            lblTurno.Text = turno.ToString();
            oBLLJugador = new BLLJugador();
            CargaComboJugadores(cmbJugadores1);
            CargaComboJugadores(cmbJugadores1de2);
            CargaComboJugadores(cmbJugadores2de2);
            Jugador1 = new BEJugador();
            Jugador2 = new BEJugador();
            DeshabilitarCombos();
            EstadoJuego(false);
            partidasResumenes = new List<BEResumen>();
            oBLLJuego = new BLLJuego();
            oBEJuego = new BEJuego();
            List<BEJuego> listadoJuegos = oBLLJuego.TraerLista();
            oBEJuego = (from x in listadoJuegos where (x.codigo == 2) select x).First();
            oBLLJuegoTTT = new BLLJuegoTTT();
            oBLLResumen = new BLLResumen();
            listadoBotones = new List<Button>();
        }

        int turno = 1;
        int movimiento = 9;
        int contador = 0;
        int partidasContador = 0;


        BLLJugador oBLLJugador;
        List<BEResumen> partidasResumenes;
        BEJugador Jugador1;
        BEJugador Jugador2;
        BLLJuego oBLLJuego; 
        BEJuego oBEJuego; //Este lo voy a usar para guardar la cantidad de partidas jugadas antes de cerrar. 
        BLLJuegoTTT oBLLJuegoTTT;
        BLLResumen oBLLResumen;

        List<Button> listadoBotones;   

        private void ArmadoBotonesListado()
        {
            listadoBotones.Add(this.button1);
            listadoBotones.Add(this.button2);
            listadoBotones.Add(this.button3);
            listadoBotones.Add(this.button4);
            listadoBotones.Add(this.button5);
            listadoBotones.Add(this.button6);
            listadoBotones.Add(this.button7);
            listadoBotones.Add(this.button8);
            listadoBotones.Add(this.button9);
        }
        
        private void JugadaMaquina()
        {
            if(RB1jugador.Checked == true && turno ==2)
            {
                var random = new Random();
                List<Button> botonesListado = (from x in listadoBotones where string.IsNullOrEmpty(x.Text) select x).ToList();
                int index = random.Next(botonesListado.Count());
                Button boton = botonesListado[index];
                boton.Text = "O";
                contador += 1;
                VerificarGanador();

            }
        }






        #region CargaJugadores
 
        private void CargaTablero()
        {
            lblJ1Ganados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.ganado.ToString()) select x).Count().ToString();
            lblJ1Perdidos.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.perdido.ToString()) select x).Count().ToString();
            lblJ1Empatados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.empatado.ToString()) select x).Count().ToString();

            lblJ2Ganados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.ganado.ToString()) select x).Count().ToString();
            lblJ2Perdidos.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.perdido.ToString()) select x).Count().ToString();
            lblJ2Empatados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.empatado.ToString()) select x).Count().ToString();

        }
        
        
        
        
        
        private void CargaComboJugadores(ComboBox combo)
        {
            combo.DataSource = null;
            combo.DataSource = oBLLJugador.TraerLista();
            combo.DisplayMember = "nombre";
            combo.ValueMember = "codigo";

        }

        private void DeshabilitarCombos()
        {
            cmbJugadores1.Enabled = false;
            cmbJugadores1de2.Enabled = false;
            cmbJugadores2de2.Enabled = false;
        }
        

        private void HabilitarCombos()
        {
            if(RB1jugador.Checked == true) { cmbJugadores1.Enabled = true; RB2jugador.Checked = false; cmbJugadores1de2.Enabled = false; cmbJugadores2de2.Enabled = false; }
            else if(RB2jugador.Checked == true) { cmbJugadores1de2.Enabled = true; cmbJugadores2de2.Enabled = true; RB1jugador.Checked = false; cmbJugadores1.Enabled = false; }
        }

        private void RB1jugador_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCombos();
        }

        private void CargarJugadores()
        {
            if (RB1jugador.Checked == true)
            {
                Jugador1 = (BEJugador)cmbJugadores1.SelectedItem; 
                lblJugador1.Text = Jugador1.nombre;
                lblJugador2.Text = "Maquina";
                ArmadoBotonesListado();
            }
            else if (RB2jugador.Checked == true) 
            {
                Jugador1 = (BEJugador)cmbJugadores1de2.SelectedItem;
                Jugador2 = (BEJugador)cmbJugadores2de2.SelectedItem;
                lblJugador1.Text = Jugador1.nombre;
                lblJugador2.Text = Jugador2.nombre;
            }

        }


        private void btnCargaJug_Click(object sender, EventArgs e)
        {
            CargarJugadores();
            EstadoJuego(true);
            CargaTablero();
            partidasContador++;
        }
               
        private void EstadoJuego(bool estado)
        {
            button1.Enabled = estado;
            button2.Enabled = estado;
            button3.Enabled = estado;
            button4.Enabled = estado;
            button5.Enabled = estado;
            button6.Enabled = estado;
            button7.Enabled = estado;
            button8.Enabled = estado;
            button9.Enabled = estado;
            
        }

        #endregion


        #region juego



        private void button1_Click(object sender, EventArgs e)
        {
            if(turno == 1) { button1.Text = "X"; } else{ button1.Text = "O"; }

      
            contador += 1;

            VerificarGanador();
           
            JugadaMaquina();


        }

        private void AsignarResultado()
        {
            if(turno == 1) { CargarResultados(Jugador1,tipoResultado.ganado); CargarResultados(Jugador2, tipoResultado.perdido); }
            else if(turno ==2) { CargarResultados(Jugador2, tipoResultado.ganado); CargarResultados(Jugador1, tipoResultado.perdido); }
        }

        private void AsignarEmpate()
        {
            CargarResultados(Jugador1, tipoResultado.empatado); 
            CargarResultados(Jugador2, tipoResultado.empatado);
        }


        private void AsignarResultadoModoMaquina()
        {
            if (turno == 1) { CargarResultados(Jugador1, tipoResultado.ganado);  }
            else if (turno == 2) { CargarResultados(Jugador1, tipoResultado.perdido); }
        }

        private void AsignarEmpateModoMaquina()
        {
            CargarResultados(Jugador1, tipoResultado.empatado);
           
        }

        private void ConsultarNuevo()
        {
            DialogResult boton = MessageBox.Show("Desea volver a Jugar???", "Consulta", MessageBoxButtons.OKCancel);

            if (boton == DialogResult.OK)
            {
                partidasContador++;
                Reiniciar();

            }else if(boton == DialogResult.Cancel && RB2jugador.Checked == true)
            {

                SumarCantPartidasJuego();
                SumarPuntajeFinalJugador(Jugador1);
                SumarPuntajeFinalJugador(Jugador2);
                CargarResumenesEnTabla(partidasResumenes);

                this.Close();

            }else if(boton == DialogResult.Cancel && RB1jugador.Checked == true)
            {
                //Aca tengo que poner solo J1 de alguna manera
                SumarCantPartidasJuego();
                SumarPuntajeFinalJugador(Jugador1);
                CargarResumenesEnTabla(partidasResumenes);

                this.Close();
            }
        }
        private void VerificarGanador()
        {
            if((!string.IsNullOrEmpty(button1.Text) && button1.Text == button2.Text && button2.Text==button3.Text) ||
               (!string.IsNullOrEmpty(button4.Text) && button4.Text == button5.Text && button5.Text == button6.Text) ||
               (!string.IsNullOrEmpty(button7.Text) && button7.Text == button8.Text && button8.Text == button9.Text) ||
               (!string.IsNullOrEmpty(button1.Text) && button1.Text == button4.Text && button4.Text == button7.Text) ||
               (!string.IsNullOrEmpty(button2.Text) && button2.Text == button5.Text && button5.Text == button8.Text) ||
               (!string.IsNullOrEmpty(button3.Text) && button3.Text == button6.Text && button6.Text == button9.Text) ||
               (!string.IsNullOrEmpty(button1.Text) && button1.Text == button5.Text && button5.Text == button9.Text) ||
               (!string.IsNullOrEmpty(button3.Text) && button3.Text == button5.Text && button5.Text == button7.Text)) 
            {

                if (RB2jugador.Checked == true)
                {
                    AsignarResultado();
                    MessageBox.Show($"Ha ganado el jugador{turno.ToString()} ");
                    ConsultarNuevo();
                    CargaTablero();

                }else if(RB1jugador.Checked == true)
                {
                    AsignarResultado();
                    MessageBox.Show($"Ha ganado el jugador{turno.ToString()} ");
                    ConsultarNuevo();
                    CargaTablero();
                }
            }
            else if (contador == movimiento) 
            {
                if (RB2jugador.Checked == true)
                {
                    AsignarEmpate();
                    MessageBox.Show("Ha habido un empate");
                    ConsultarNuevo();
                    CargaTablero();
                
                }else if(RB1jugador.Checked == true)
                {
                    AsignarEmpate();
                    MessageBox.Show("Ha habido un empate");
                    ConsultarNuevo();
                    CargaTablero();
                }

            } else
            {
                if (turno == 1) { turno = 2; } else { turno = 1; }

                lblTurno.Text = turno.ToString();
            }

        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button2.Text = "X"; } else { button2.Text = "O"; }

            contador += 1;

            VerificarGanador();
            JugadaMaquina();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button3.Text = "X"; } else { button3.Text = "O"; }

           

            contador += 1;

            VerificarGanador();
            JugadaMaquina();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button4.Text = "X"; } else { button4.Text = "O"; }

            

            contador += 1;

            VerificarGanador();
            JugadaMaquina();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button5.Text = "X"; } else { button5.Text = "O"; }

            

            contador += 1;

            VerificarGanador();
            JugadaMaquina();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button6.Text = "X"; } else { button6.Text = "O"; }

           

            contador += 1;

            VerificarGanador();
            JugadaMaquina();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button7.Text = "X"; } else { button7.Text = "O"; }

            

            contador += 1;

            VerificarGanador();
            JugadaMaquina();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button8.Text = "X"; } else { button8.Text = "O"; }

            

            contador += 1;

            VerificarGanador();
            JugadaMaquina();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turno == 1) { button9.Text = "X"; } else { button9.Text = "O"; }

            contador += 1;

            VerificarGanador();
            JugadaMaquina();
        }



        private void Reiniciar()
        {
            turno = 1;
            contador = 0;
            LimpiarBotones();
            lblTurno.Text = turno.ToString();
        }


        private void LimpiarBotones()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

       


        #endregion


       private void CargarResultados(BEJugador jugador, tipoResultado resultado)
       {
           BEResumen partidaJugador = new BEResumen();

            partidaJugador.cadigoJugador = jugador.codigo;
            partidaJugador.resultado = resultado.ToString();
            partidaJugador.codigoJuego = 2;
            
            partidasResumenes.Add(partidaJugador);



       }

        #region Cargar Finales

        private void SumarCantPartidasJuego()
        {
            oBEJuego.canitdadPartidas += partidasContador; 
            oBLLJuego.Guardar(oBEJuego);
        }

        private void SumarPuntajeFinalJugador(BEJugador jugador) //este proceso hay que repertirlo x 2 en caso de 2 players
        {
            oBLLJugador.CargarPuntos(oBLLJuegoTTT.CalcularPuntos(partidasResumenes, jugador), jugador);
        }

       private void CargarResumenesEnTabla(List<BEResumen> listadoResumenes)
        {
            if (RB2jugador.Checked == true)
            {
                foreach (BEResumen resumen in listadoResumenes)
                {
                    oBLLResumen.Guardar(resumen);
                }
            }else if(RB1jugador.Checked == true)
            {
                foreach (BEResumen resumen in listadoResumenes)
                {
                    if (resumen.cadigoJugador == Jugador1.codigo)
                    {
                        oBLLResumen.Guardar(resumen);
                    }
                }
            }
        }

        #endregion
        enum tipoResultado { ganado,empatado,perdido};

        //private void RB2jugador_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
