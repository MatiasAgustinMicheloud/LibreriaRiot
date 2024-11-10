using Common.Cache;
using Common.Models;
using Domain;
using LibreriaRiot.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class DetalleVenta : Form
    {
        private LobiPrincipal instanciaLobi;
        private RealizarVenta? detalle;
        public int IdClienteSeleccionado { get; set; }
        private ClienteConInformacion? cliente;
        private SaleModel saleModel = new SaleModel();
        private ClienteModel clientModel = new();
        public DetalleVenta(RealizarVenta detalleCatalogo, LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
            detalle = detalleCatalogo;
        }

        private void msgError(string msg, Label label)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string nombre = lbNombreApellido.Text;
            string dni = lbDNI.Text;
            DateTime fechaHoy = DateTime.Now;
            float total = (float)Carrito.ObtenerTotal();
            int idCliente = cliente?.IdCliente ?? 0; // Si cliente es nulo, establece el ID a 0
            int idUsuario = UserLoginCache.Id;
            int idTipoFactura = saleModel.ObtenerIdTipoFactura(cbTipoFactura.Text);
            int idMetodoPago = saleModel.ObtenerIdMetodoPago(cbMetodoPago.Text);
            Venta_Cabecera venta_Cabecera = new Venta_Cabecera();
            List<Venta_Detalle> detallesVenta = new List<Venta_Detalle>();

            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;
            lbErrorMenssage3.Visible = false;


            if (cbMetodoPago.SelectedIndex == -1 || cbMetodoPago.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona una Forma de Pago", lbErrorMenssage1);
                return;
            }
            else if (cbTipoFactura.SelectedIndex == -1 || cbTipoFactura.SelectedItem.ToString() == "")
            {

                msgError("Por favor, seleccione un tipo de factura", lbErrorMenssage2);
                return;
            }
            else if (nombre == "Nombre y Apellido")
            {
                msgError("Por favor, seleccione un Cliente", lbErrorMenssage3);
            }
            else
            {

                DialogResult confirmResult = MessageBox.Show("¿Desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    Ventas ventas = new Ventas()
                    {
                        NombreCliente = nombre,
                        DNICliente = dni,
                        Domicilio = cliente!.Domicilio,
                        Telefono = cliente!.PersonaTelefono,
                        TipoPago = cbMetodoPago.Text,
                        TipoFactura = cbTipoFactura.Text,
                        NombreVendedor = UserLoginCache.Nombre + UserLoginCache.Apellido,
                        DNIVendedor = UserLoginCache.DNI,
                        FechaFactura = fechaHoy,
                        MontoTotal = total,
                    };

                    foreach (var libroEnCarrito in Carrito.LibrosEnCarrito)
                    {
                        Venta_Detalle detalle = new Venta_Detalle
                        {
                            PrecioProducto = (float)libroEnCarrito.Item1.Precio,
                            Cantidad = libroEnCarrito.Item2,
                            SubTotalProducto = (float)libroEnCarrito.Item1.Precio * libroEnCarrito.Item2,
                            Id_Libro = libroEnCarrito.Item1.Id_Libro,
                            Id_VentaCabecera = venta_Cabecera.Id_VentaCabecera,
                        };

                        detallesVenta.Add(detalle);
                    }

                    bool ventaAgregada = saleModel.AgregarNuevaVenta(fechaHoy, total, idCliente, idUsuario, idMetodoPago, idTipoFactura, detallesVenta);

                    if (ventaAgregada)
                    {
                        foreach (var libroVendido in Carrito.LibrosEnCarrito)
                        {
                            saleModel.ActualizarStockLibro(libroVendido.Item1.Id_Libro, libroVendido.Item2);
                        }
                        Carrito.VaciarCarrito();
                        this.Close();
                        DetalleFactura factura = new DetalleFactura(instanciaLobi, ventas);
                        factura.Show();
                    }
                }
            }
        }

        public void ActualizarDetallesCliente(int idCliente)
        {
            cliente = clientModel.ImportarCliente(idCliente);

            if (cliente != null)
            {
                lbNombreApellido.Text = cliente.PersonaNombre + " " + cliente.PersonaApellido;
                lbDNI.Text = cliente.PersonaDNI;
            }
        }

        private void LimpiarCampos()
        {

            cbMetodoPago.SelectedIndex = -1;
            cbTipoFactura.SelectedIndex = -1;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //instanciaLobi.OpenChildForm(new Vendedor.RealizarVenta(instanciaLobi));
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.CargarCliente(instanciaLobi, this));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerClientes tablaClientes = new VerClientes(instanciaLobi, this);
            tablaClientes.Show();
        }

        private void horaFecha_Tick_1(object sender, EventArgs e)
        {
            Lhora.Text = DateTime.Now.ToLongTimeString();
            Lfecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            opcionesPago();
            opcionesFacturas();
        }

        private void opcionesFacturas()
        {
            SaleModel saleModel = new();
            var tipoFactura = saleModel.ObtenerFactura();

            tipoFactura.Insert(0, "Seleccione Factura");

            cbTipoFactura.DataSource = tipoFactura;

            cbTipoFactura.SelectedIndex = 0;
        }

        private void opcionesPago()
        {
            SaleModel saleModel = new();
            var tipoPago = saleModel.ObtenerPago();

            tipoPago.Insert(0, "Seleccione Pago");

            cbMetodoPago.DataSource = tipoPago;

            cbMetodoPago.SelectedIndex = 0;
        }


    }
}
