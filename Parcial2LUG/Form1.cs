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
using System.Xml;

namespace Parcial2LUG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oBLLJugador = new BLLJugador();
            oBEJugador = new BEJugador();
            oBLLLocalidad = new BLLLocalidad();
            comboLocalidades();
            CargarJugadores();
            LimpiarCampos();
        }

        BLLJugador oBLLJugador;
        BEJugador oBEJugador;
        BLLLocalidad oBLLLocalidad;
       
        private void comboLocalidades()
        {
            cmbLocalidad.DataSource = null;
            cmbLocalidad.DataSource = oBLLLocalidad.TraerLista();
            cmbLocalidad.DisplayMember = "nombreLocalidad";
            cmbLocalidad.ValueMember = "nombreLocalidad";


        }
        private void BuscarUsuario()
        {
            List<BEJugador> listadoUsuarios = oBLLJugador.TraerLista();
            List<BEJugador> buscado = (from x in listadoUsuarios where (x.nombre == txtNomUsuBusq.Text) select x).ToList();
            CargarBuscado(buscado);
            

        }
        private void LimpiarCampos()
        {
            txtApe.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtDNI.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtEdad.Text  = String.Empty;
            txtPuntaje.Text = "0";
            txtCod.Text = "0";
            txtEdad.Text = "0";
        }

        private void CargarBuscado(List<BEJugador> jugador)
        {
            dgvJugador.DataSource = null;
            dgvJugador.DataSource = jugador;


        }



        private void CargarJugadores()
        {
            dgvJugador.DataSource = null;
            dgvJugador.DataSource = oBLLJugador.TraerLista();
        }

        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaTxt();
        }

        private BEJugador CargaJugador()
        {
            BEJugador jugadorCarga = new BEJugador();
            jugadorCarga.codigo = Convert.ToInt32(txtCod.Text);
            jugadorCarga.nombre = Nombre();//
            jugadorCarga.apellido = Apellido();//
            jugadorCarga.mail = Mail();//
            jugadorCarga.DNI = Convert.ToInt32(DNI());//
            jugadorCarga.localidad = cmbLocalidad.SelectedItem.ToString();               
            jugadorCarga.fechaNacimiento = dateTimePicker1.Value;
            jugadorCarga.puntajeAcumulado = Convert.ToInt32(txtPuntaje.Text);
            jugadorCarga.edad = jugadorCarga.CalculoEdad(jugadorCarga);

            return jugadorCarga;
        }

        private void CargaTxt()
        {
            BEJugador jugadorCarga = (BEJugador)dgvJugador.CurrentRow.DataBoundItem;
            txtCod.Text = jugadorCarga.codigo.ToString();
            txtNom.Text = jugadorCarga.nombre;
            txtApe.Text = jugadorCarga.apellido;
            txtMail.Text= jugadorCarga.mail;
            txtDNI.Text =jugadorCarga.DNI.ToString();
            cmbLocalidad.Text = jugadorCarga.localidad; 
            dateTimePicker1.Value = jugadorCarga.fechaNacimiento;
            txtPuntaje.Text = jugadorCarga.puntajeAcumulado.ToString();
            txtEdad.Text =Convert.ToString(jugadorCarga.CalculoEdad(jugadorCarga));

           
        }


        #region CargarChecksUserControls

        private int DNI()
        {
            if (txtDNI.validar() == true)
            {
                return Convert.ToInt32(txtDNI.Text);
            }
            else { throw new Exception("Error DNI Carga"); }

        }

        private string Nombre()
        {
            if (txtNom.checkSoloLetras() == true)
            {
                return txtNom.Text;
            }
            else { throw new Exception("Error de Carga Nombre"); }

        }

        private string Apellido()
        {
            if (txtApe.checkSoloLetras() == true)
            {
                return txtApe.Text;
            }
            else { throw new Exception("Error de Carga Apellido"); }

        }

        private string Mail()
        {
            if (txtMail.checkMail() == true)
            {
                return txtMail.Text;
            }
            else { throw new Exception("Error de Carga Mail"); }

        }


        private void checkCampos()
        {

            if (txtApe.Text == "" || txtDNI.Text == "" || txtCod.Text == "" || cmbLocalidad.Text == "" || txtNom.Text == "" || txtMail.Text == "")
            {
                throw new Exception("No es posible continuar con la operacion, alguno de los campos se encuentra vacíos");
            }


        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "0")
                    {
                        checkCampos();
                        oBLLJugador.Guardar(CargaJugador());
                        CargarJugadores();
                        LimpiarCampos();
                }
                else { MessageBox.Show("El usuario, ya se encuentra registrado. Puede intentar Modificarlo"); }

            }
            catch(XmlException ex)
            {
                MessageBox.Show(ex.Message);

            }catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLJugador.Baja(CargaJugador());
                CargarJugadores();
                LimpiarCampos();

            }catch(XmlException ex)
            {
                MessageBox.Show(ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtNomUsuBusq.Text == string.Empty)
            {
                MessageBox.Show("Favor de insertar algún valor en Campo de Búsqueda");
            }
            {
                BuscarUsuario();
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text != "0")
                {
                    checkCampos();
                    oBLLJugador.Guardar(CargaJugador());
                    CargarJugadores();
                    LimpiarCampos();
                }
                else { MessageBox.Show("El usuario no se encuentra registrado. Puede intentar darlo de alta"); }

            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarJugadores();
            LimpiarCampos();
        }
    }
}
