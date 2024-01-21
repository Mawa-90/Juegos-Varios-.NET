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
using System.Windows.Forms.DataVisualization.Charting;

namespace Parcial2LUG
{
    public partial class FRReporte : Form
    {
        public FRReporte()
        {
            InitializeComponent();
        }

        private void FRReporte_Load(object sender, EventArgs e)
        {
            //this.chartHistorial.RefreshReport();
            this.reportViewer1.RefreshReport();
            CargarReporte();
            CargaComboJugadores();
            CargaComboJuegos();
            CargaChart();



           
        }

        BLLResumenReporte oBLLResumenReporte = new BLLResumenReporte();
        BLLJugador oBLLJugador = new BLLJugador();
        BLLJuego oBLLJuego = new BLLJuego();
       
        private void CargaComboJugadores()
        {
            cmbJugador.DataSource = null;
            cmbJugador.DataSource = oBLLJugador.TraerLista();
            cmbJuego.DisplayMember = "nombre";
            cmbJuego.ValueMember = "codigo";
        }

        private void CargaComboJuegos()
        {
            cmbJuego.DataSource = null;
            cmbJuego.DataSource = oBLLJuego.TraerLista();
            cmbJuego.DisplayMember = "nombre";
            cmbJuego.ValueMember = "codigo";
        }

        private void CargarReporte()
        {
            List<BEResumenReporte> listadoReporte = oBLLResumenReporte.TraerLista();
            this.reportViewer1.LocalReport.DataSources[0].Value = null;
            this.reportViewer1.LocalReport.DataSources[0].Value = listadoReporte;
            this.reportViewer1.RefreshReport();
        }

        private void CargarReporteCustom(List<BEResumenReporte> listadoReporte)
        {
            
            this.reportViewer1.LocalReport.DataSources[0].Value = null;
            this.reportViewer1.LocalReport.DataSources[0].Value = listadoReporte;
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<BEResumenReporte> listadoReporte = oBLLResumenReporte.TraerLista();
            BEJugador jugador = (BEJugador)cmbJugador.SelectedItem;
            BEJuego juego = (BEJuego)cmbJuego.SelectedItem;

            if (chJugador.Checked == true && chJuego.Checked == false)
            {
                List<BEResumenReporte> resultado = (from x in listadoReporte where x.cadigoJugador == jugador.codigo select x).ToList();
                CargarReporteCustom(resultado);
                CargaChartPPT(resultado);
                CargaChartTTT(resultado);


            }
            else if(chJugador.Checked == false && chJuego.Checked == true)
            {

                List<BEResumenReporte> resultado = (from x in listadoReporte where x.codigoJuego == juego.codigo select x).ToList();
                CargarReporteCustom(resultado);
            }
            else if(chJugador.Checked == true && chJuego.Checked == true)
            {
                List<BEResumenReporte> resultado = (from x in listadoReporte where x.cadigoJugador == jugador.codigo select x).ToList();
                CargaChartPPT(resultado);
                CargaChartTTT(resultado);
                List<BEResumenReporte> resultado2 = (from x in resultado where x.codigoJuego == juego.codigo select x).ToList();
                CargarReporteCustom(resultado2);
                
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }






        #region Chartz

        private void CargaChart()
        {
            List<BEJuego> listadoJuegos = oBLLJuego.TraerLista();
            int cantJuegos = listadoJuegos.Count();

            Dictionary<string, int> juegos = new Dictionary<string, int>();


            for (int i = 1; i <= cantJuegos; i++)
            {
                BEJuego juego = (BEJuego)(from x in listadoJuegos where (x.codigo == i) select x).First();
                string clave = juego.nombre;
                List<BEJuego> result = (from x in listadoJuegos where x.codigo == i select x).ToList();

                juegos.Add(clave, result.Sum(x => x.canitdadPartidas));
            }



            chartJuego.Titles.Clear();
            chartJuego.ChartAreas.Clear();
            chartJuego.Series.Clear();

            Title Titulo = new Title("Partidas Por Juego");
            Titulo.Font = new Font("Tahoma", 16, FontStyle.Bold);
            chartJuego.Titles.Add(Titulo);


            ChartArea Area = new ChartArea();

            chartJuego.ChartAreas.Add(Area);


            Series serie = new Series("Partidas Por Juego");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.DataBindXY(juegos.Keys, juegos.Values);



            chartJuego.Series.Add(serie);

            chartJuego.Series[0].XValueMember = "Juegos";
            chartJuego.Series[0].YValueMembers = "Cant Partidas";



        }

        private void CargaChartPPT(List<BEResumenReporte> listadoFiltradoJugador)
        {
            List<BEResumenReporte> listadoFiltrado = (from x in listadoFiltradoJugador where x.codigoJuego ==1 select x).ToList();
            int cantGanado = listadoFiltrado.Count(x => x.resultado == "ganado");
            int cantPerdido = listadoFiltrado.Count(x => x.resultado == "perdido");
            int cantEmpatado = listadoFiltrado.Count(x => x.resultado == "empatado");

            List<int> resultados = new List<int>();
            resultados.Add(cantGanado);
            resultados.Add(cantPerdido);
            resultados.Add(cantEmpatado);

            List<string> tipoResultado = new List<string>();
            tipoResultado.Add("ganado");
            tipoResultado.Add("perdido");
            tipoResultado.Add("empatado");

            Dictionary<string, int> historial = new Dictionary<string, int>();


            for (int i = 0; i <= 2; i++)
            {
                
                historial.Add(tipoResultado[i], resultados[i]);
            }

            

            chartHistorial.Titles.Clear();
            chartHistorial.ChartAreas.Clear();
            chartHistorial.Series.Clear();

            Title Titulo = new Title("Historial Jugador - PPT");
            Titulo.Font = new Font("Tahoma", 16, FontStyle.Bold);
            chartHistorial.Titles.Add(Titulo);


            ChartArea Area = new ChartArea();

            chartHistorial.ChartAreas.Add(Area);


            Series serie = new Series("Partidas Por Juego");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.DataBindXY(historial.Keys, historial.Values);



            chartHistorial.Series.Add(serie);

            chartHistorial.Series[0].XValueMember = "Tipo Resultados";
            chartHistorial.Series[0].YValueMembers = "resultados";



        }

       

        private void CargaChartTTT(List<BEResumenReporte> listadoFiltradoJugador)
        {
            List<BEResumenReporte> listadoFiltrado = (from x in listadoFiltradoJugador where x.codigoJuego == 2 select x).ToList();
            int cantGanado = listadoFiltrado.Count(x => x.resultado == "ganado");
            int cantPerdido = listadoFiltrado.Count(x => x.resultado == "perdido");
            int cantEmpatado = listadoFiltrado.Count(x => x.resultado == "empatado");

            List<int> resultados = new List<int>();
            resultados.Add(cantGanado);
            resultados.Add(cantPerdido);
            resultados.Add(cantEmpatado);

            List<string> tipoResultado = new List<string>();
            tipoResultado.Add("ganado");
            tipoResultado.Add("perdido");
            tipoResultado.Add("empatado");

            Dictionary<string, int> historial = new Dictionary<string, int>();


            for (int i = 0; i <= 2; i++)
            {

                historial.Add(tipoResultado[i], resultados[i]);
            }



            chartHistorial2.Titles.Clear();
            chartHistorial2.ChartAreas.Clear();
            chartHistorial2.Series.Clear();

            Title Titulo = new Title("Historial Jugador - TTT");
            Titulo.Font = new Font("Tahoma", 16, FontStyle.Bold);
            chartHistorial2.Titles.Add(Titulo);


            ChartArea Area = new ChartArea();

            chartHistorial2.ChartAreas.Add(Area);


            Series serie = new Series("Partidas Por Juego");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.DataBindXY(historial.Keys, historial.Values);



            chartHistorial2.Series.Add(serie);

            chartHistorial2.Series[0].XValueMember = "Tipo Resultados";
            chartHistorial2.Series[0].YValueMembers = "resultados";



        }



        #endregion
    }
}
