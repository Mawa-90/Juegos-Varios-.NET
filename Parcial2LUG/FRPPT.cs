using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LUG
{
    public partial class FRPPT : Form
    {
        public FRPPT()
        {
            InitializeComponent();
        }

        private void FRPPT_Load(object sender, EventArgs e)
        {
            oBLLJugador = new BLLJugador();
            CargaComboJugadores(cmbJugadores1);
            CargaComboJugadores(cmbJugadores1de2);
            CargaComboJugadores(cmbJugadores2de2);
            Jugador1 = new BEJugador();
            Jugador2 = new BEJugador();
            DeshabilitarCombos();
            partidasResumenes = new List<BEResumen>();
            oBLLJuego = new BLLJuego();
            oBEJuego = new BEJuego();
            List<BEJuego> listadoJuegos = oBLLJuego.TraerLista();
            oBEJuego = (from x in listadoJuegos where (x.codigo == 1) select x).First();
            oBLLJuegoPPT = new BLLJuegoPPT();
            oBLLResumen = new BLLResumen();
            lblNRound.Text = contador.ToString();
            JuegoHabilitar(false);
            DeshabilitarJuego();


        }



        BLLJugador oBLLJugador;
        List<BEResumen> partidasResumenes;
        BEJugador Jugador1;
        BEJugador Jugador2;
        BLLJuego oBLLJuego;
        BEJuego oBEJuego;  
        BLLJuegoPPT oBLLJuegoPPT;
        BLLResumen oBLLResumen;

        int movimiento = 3;
        int contador = 1;
        int partidasContador = 0;
        List<int> listadoReferencias = new List<int>() { 1,2,3};

        private void CargaComboJugadores(ComboBox combo)
        {
            combo.DataSource = null;
            combo.DataSource = oBLLJugador.TraerLista();
            combo.DisplayMember = "nombre";
            combo.ValueMember = "codigo";

        }

        private void DeshabilitarJuego()
        {
            btnMostrar.Enabled = false;
            txtJ1.Enabled = false;
            txtJ2.Enabled = false;
        }
        private void DeshabilitarCombos()
        {
            cmbJugadores1.Enabled = false;
            cmbJugadores1de2.Enabled = false;
            cmbJugadores2de2.Enabled = false;
        }


        private void HabilitarCombos()
        {
            if (RB1jugador.Checked == true) { cmbJugadores1.Enabled = true; RB2jugador.Checked = false; cmbJugadores1de2.Enabled = false; cmbJugadores2de2.Enabled = false; }
            else if (RB2jugador.Checked == true) { cmbJugadores1de2.Enabled = true; cmbJugadores2de2.Enabled = true; RB1jugador.Checked = false; cmbJugadores1.Enabled = false; }
        }

      
        private void RB1jugador_CheckedChanged_1(object sender, EventArgs e)
        {
            HabilitarCombos();
        }

        private void JuegoHabilitar(bool indicador)
        {
            if (RB2jugador.Checked == true)
            {
                txtJ1.Enabled = indicador;
                txtJ2.Enabled = indicador;
                txtJ1.PasswordChar = '*';
                txtJ2.PasswordChar = '*';
                btnMostrar.Enabled = indicador;

            }else if(RB1jugador.Checked == true)
            {
                txtJ1.Enabled = indicador;
                btnMostrar.Enabled = indicador;
                
            }
        }
        private void CargaTablero()
        {
            lblJ1Ganados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.ganado.ToString()) select x).Count().ToString();
            lblJ1Perdidos.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.perdido.ToString()) select x).Count().ToString();
            lblJ1Empatados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador1.codigo && x.resultado == tipoResultado.empatado.ToString()) select x).Count().ToString();

            lblJ2Ganados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.ganado.ToString()) select x).Count().ToString();
            lblJ2Perdidos.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.perdido.ToString()) select x).Count().ToString();
            lblJ2Empatados.Text = (from x in partidasResumenes where (x.cadigoJugador == Jugador2.codigo && x.resultado == tipoResultado.empatado.ToString()) select x).Count().ToString();

        }


        private void CargarJugadores()
        {
            if (RB1jugador.Checked == true && RB2jugador.Checked == false)
            {
                Jugador1 = (BEJugador)cmbJugadores1.SelectedItem;
                lblJugador1.Text = Jugador1.nombre;
                lblJugador2.Text = "Maquina";
               
            }
            else if (RB2jugador.Checked == true && RB1jugador.Checked == false)
            {
                Jugador1 = (BEJugador)cmbJugadores1de2.SelectedItem;
                Jugador2 = (BEJugador)cmbJugadores2de2.SelectedItem;
                lblJugador1.Text = Jugador1.nombre;
                lblJugador2.Text = Jugador2.nombre;
            }

        }

        private int JuegoRandom()
        {
            Random r = new Random();
            int resultado;
            resultado = r.Next(listadoReferencias.Count);
            return resultado;

        }

        private void btnCargaJug_Click(object sender, EventArgs e)
        {
            
            CargarJugadores();
            JuegoHabilitar(true);
            CargaTablero();
            partidasContador++;
        }


        #region Juego

        int contadorRoundJ1 = 0;
        int contadorRoundJ2 = 0;
        private void VerificadorReferencias()
        {
            if((txtJ1.Text == "1" || txtJ1.Text == "2" || txtJ1.Text == "3") &&  (txtJ2.Text == "1" || txtJ2.Text == "2" || txtJ2.Text == "3"))
            {
                VerificadorRound();
                
            }
            else { throw new Exception("Algunas de las referencias se encuentran mal en alguno de los dos textBox, favor de corregirlas."); }
        }
        private void VerificadorRound()
        {
            if((txtJ1.Text == "1" && txtJ2.Text =="3") ||(txtJ1.Text == "2" && txtJ2.Text == "1") ||(txtJ1.Text == "3" && txtJ2.Text == "2"))
            {
                contadorRoundJ1 ++;

            }else if((txtJ2.Text == "1" && txtJ1.Text == "3") || (txtJ2.Text == "2" && txtJ1.Text == "1") || (txtJ2.Text == "3" && txtJ1.Text == "2"))
            {
                contadorRoundJ2 ++;
            }

        }

        private void VerificadorPartida()
        {
            if(contadorRoundJ1 == 2) 
            {
                CargarResultados(Jugador1, tipoResultado.ganado);
                CargarResultados(Jugador2, tipoResultado.perdido);
                MessageBox.Show($"Ha ganado el jugador 1");
                ConsultarNuevo();
                CargaTablero();

            }
            else if(contadorRoundJ2 == 2)
            {
                CargarResultados(Jugador2, tipoResultado.ganado);
                CargarResultados(Jugador1, tipoResultado.perdido);
                MessageBox.Show($"Ha ganado el jugador 2");
                ConsultarNuevo();
                CargaTablero();
            }
            else if((contador == movimiento)) 
            {
                if(contadorRoundJ1 > contadorRoundJ2)
                {
                    CargarResultados(Jugador1, tipoResultado.ganado);
                    CargarResultados(Jugador2, tipoResultado.perdido);
                    MessageBox.Show($"Ha ganado el jugador 1");
                    ConsultarNuevo();
                    CargaTablero();
                }
                else if(contadorRoundJ2 > contadorRoundJ1)
                {
                    CargarResultados(Jugador2, tipoResultado.ganado);
                    CargarResultados(Jugador1, tipoResultado.perdido);
                    MessageBox.Show($"Ha ganado el jugador 2");
                    ConsultarNuevo();
                    CargaTablero();
                }
                else if(contadorRoundJ1 == contadorRoundJ2)
                {
                    CargarResultados(Jugador1, tipoResultado.empatado);
                    CargarResultados(Jugador2, tipoResultado.empatado);
                    MessageBox.Show("Ha habido un empate");
                    ConsultarNuevo();
                    CargaTablero();
                }
               
            }else { contador++; }
        }


        private void ConsultarNuevo()
        {
            DialogResult boton = MessageBox.Show("Desea volver a Jugar???", "Consulta", MessageBoxButtons.OKCancel);

            if (boton == DialogResult.OK)
            {
                partidasContador++;
                Reiniciar();

            }
            else if (boton == DialogResult.Cancel && RB2jugador.Checked == true)
            {

                SumarCantPartidasJuego();
                SumarPuntajeFinalJugador(Jugador1);
                SumarPuntajeFinalJugador(Jugador2);
                CargarResumenesEnTabla(partidasResumenes);

                this.Close();

            }
            else if (boton == DialogResult.Cancel && RB1jugador.Checked == true)
            {
                //Aca tengo que poner solo J1 de alguna manera
                SumarCantPartidasJuego();
                SumarPuntajeFinalJugador(Jugador1);
                CargarResumenesEnTabla(partidasResumenes);

                this.Close();
            }
        }

        private string DevolverElemento(string textbox)
        {
            if(textbox == "1") { return "Piedra"; }
            else if (textbox == "2") { return "Papel"; }
            else if (textbox == "3") { return "Tijera"; }

            return textbox;
        }
        private void LimpiarJugada()
        {
            txtJ1.Text = string.Empty;
            txtJ2.Text = string.Empty;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(RB1jugador.Checked == true) { txtJ2.Text = (JuegoRandom()+1).ToString();}
                VerificadorReferencias();
                MessageBox.Show($"{DevolverElemento(txtJ1.Text)} Vs {DevolverElemento(txtJ2.Text)}");
                VerificadorPartida();
                lblNRound.Text = contador.ToString();
                ActualizarPuntajesRound();
                LimpiarJugada();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CargarResultados(BEJugador jugador, tipoResultado resultado)
        {
            BEResumen partidaJugador = new BEResumen();

            partidaJugador.cadigoJugador = jugador.codigo;
            partidaJugador.resultado = resultado.ToString();
            partidaJugador.codigoJuego = 1;
           
            partidasResumenes.Add(partidaJugador);



        }



        private void ActualizarPuntajesRound()
        {
            lblPuntosJ1.Text = contadorRoundJ1.ToString();
            lblPuntosJ2.Text = contadorRoundJ2.ToString();
        }

        private void Reiniciar()
        {
            contador = 1;
            contadorRoundJ1 = 0;
            contadorRoundJ2 = 0;
        }

        #endregion













        #region Cargar Finales

        private void SumarCantPartidasJuego()
        {
            oBEJuego.canitdadPartidas += partidasContador;
            oBLLJuego.Guardar(oBEJuego);
        }

        private void SumarPuntajeFinalJugador(BEJugador jugador) //este proceso hay que repertirlo x 2 en caso de 2 players
        {
            oBLLJugador.CargarPuntos(oBLLJuegoPPT.CalcularPuntos(partidasResumenes, jugador), jugador);
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




        enum tipoResultado { ganado, empatado, perdido };

        private void lblNRound_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntosJ2_Click(object sender, EventArgs e)
        {

        }
    }
}
