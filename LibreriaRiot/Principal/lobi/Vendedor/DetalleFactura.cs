﻿using Common.Cache;
using Common.Models;
using LibreriaRiot.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class DetalleFactura : Form
    {
        private LobiPrincipal instanciaLobi;
        private Ventas factura = new Ventas();
        private SaleModel sale = new SaleModel();
        public DetalleFactura(LobiPrincipal lobi, Ventas _venta)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
            factura = _venta;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.FormClosed += (s, args) => this.Close();
            instanciaLobi.Show();
        }

        private void datosCabecera()
        {
            lbNumeroFactura.Text = "Factura N°:" + sale.ObtenerUltimoIdVentaCabecera().ToString();
            lbNombreCliente.Text = "Cliente: " + factura.NombreCliente!.ToString() + "  " + factura.ApellidoCliente!;
            lbDNICliente.Text = "DNI: " + factura.DNICliente!.ToString();
            lbTelefono.Text = "Telefono: " + factura.Telefono!.ToString();
            lbDireccion.Text = "Direccion: " + factura.Domicilio!.ToString();
            lbPago.Text = "Metodo De Pago: " + factura.TipoPago;
            lbFactura.Text = "Tipo De Factura: " + factura.TipoFactura;
            lbFechaFactura.Text = "Fecha " + factura.FechaFactura.ToString();
            lbNombreVendedor.Text = "Vendedor: " + factura.NombreVendedor!.ToString() + " " + factura.ApellidoVendedor;
            lbDNIVendedor.Text = "DNI: " + factura.DNIVendedor!.ToString();
            lbTotal.Text = "Total: $" + factura.MontoTotal.ToString();
        }

        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            datosCabecera();
            dataGridFactura.DataSource = sale.ObtenerDetalleFacturaUltimaCabecera()!;
            DatosOcultos();
        }

        private void DatosOcultos()
        {
            DataGridViewColumnCollection columns = dataGridFactura.Columns;
            columns["Id_VentaCabecera"].Visible = false;
            columns["FechaFactura"].Visible = false;
            columns["MontoTotal"].Visible = false;
            columns["Id_Cliente"].Visible = false;
            columns["NombreCliente"].Visible = false;
            columns["ApellidoCliente"].Visible = false;
            columns["DNICliente"].Visible = false;
            columns["Telefono"].Visible = false;
            columns["Domicilio"].Visible = false;
            columns["Id_Usuario"].Visible = false;
            columns["NombreVendedor"].Visible = false;
            columns["ApellidoVendedor"].Visible = false;
            columns["DNIVendedor"].Visible = false;
            columns["TipoPago"].Visible = false;
            columns["Id_Libro"].Visible = false;
            columns["PrecioProducto"].Visible = false;
            columns["Categoria"].Visible = false;
            columns["TipoFactura"].Visible = false;
            columns["Estado"].Visible = false;
            dataGridFactura.Columns["NombreEditorial"].HeaderText = "Editorial";
            dataGridFactura.Columns["NombreAutor"].HeaderText = "Autor";
            dataGridFactura.Columns["PrecioProducto"].HeaderText = "Precio Unitario";
            dataGridFactura.Columns["SubTotalProducto"].HeaderText = "Sub-Total";
            dataGridFactura.Columns["SubTotalProducto"].DisplayIndex = dataGridFactura.Columns.Count - 1;
        }

    }
}
