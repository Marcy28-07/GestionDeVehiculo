using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;

namespace GestionDeVehiculo
{
    public partial class Form1 : Form
    {
        private GestionVehiculos gestionVehiculos = new GestionVehiculos();
        private AccionesVehiculos accionesVehiculo = new AccionesVehiculos();
        private Vehiculo vehiculoSeleccionado;

        public Form1()
        {
            InitializeComponent();
            // Configuración inicial de la interfaz.
            cmbTipoVehiculo.Items.AddRange(new string[] { "Auto", "Camión", "Motocicleta", "Vehículo Eléctrico" });
            // Oculta todos los campos inicialmente
            OcultarCampos();
            lstVehiculo.DataSource = new BindingList<Vehiculo>(gestionVehiculos.ObtenerVehiculo());
            lstVehiculo.DisplayMember = "Marca"; // Cambiar si necesitas mostrar más información
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarCampos();
            switch (cmbTipoVehiculo.SelectedItem.ToString())
            {
                case "Camión":
                    txtCapacidadCarga.Visible = true; // Muestra el campo de capacidad de carga
                    lblCapacidadCarga.Visible = true;
                    break;
                case "Vehículo Eléctrico":
                    txtCapacidadBateria.Visible = true; // Muestra el campo de capacidad de batería
                    lblCapacidadBateria.Visible = true;
                    break;
                case "Auto":
                case "Motocicleta":
                    // No se necesita mostrar más campos, solo marca y modelo
                    break;
            }
        }

        private void OcultarCampos()
        {
            txtCapacidadCarga.Visible = false; // Oculta el campo de capacidad de carga
            txtCapacidadBateria.Visible = false; // Oculta el campo de capacidad de batería

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = null;

            if (cmbTipoVehiculo.SelectedItem.ToString() == "Auto")
            {
                nuevoVehiculo = new Auto(txtMarca.Text, txtModelo.Text);
            }
            else if (cmbTipoVehiculo.SelectedItem.ToString() == "Camión")
            {
                nuevoVehiculo = new Camion
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    CapacidadCarga = int.Parse(txtCapacidadCarga.Text)
                };
            }
            else if (cmbTipoVehiculo.SelectedItem.ToString() == "Vehículo Eléctrico")
            {

                nuevoVehiculo = new VehiculoElectrico
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    CapacidadBateria = double.Parse(txtCapacidadBateria.Text)
                   
                };
            }
            else // Motocicleta
            {
                nuevoVehiculo = new Motocicleta(txtMarca.Text, txtModelo.Text);
            }

            gestionVehiculos.AgregarVehiculo(nuevoVehiculo);
            ActualizarListaVehiculos();
            MessageBox.Show("Vehículo agregado correctamente.");
        }

        private void ActualizarListaVehiculos()
        {
            lstVehiculo.DataSource = new BindingList<Vehiculo>(gestionVehiculos.ObtenerVehiculo());
        }

        private void lstVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiculoSeleccionado = lstVehiculo.SelectedItem as Vehiculo;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                accionesVehiculo.MoverVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo movido.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                accionesVehiculo.IniciarVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo iniciado.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                accionesVehiculo.DetenerVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo detenido.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                try
                {
                    accionesVehiculo.CargarBateria(vehiculoSeleccionado);
                    MessageBox.Show("Batería cargada.");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo eléctrico.");
            }
        }
    }


}