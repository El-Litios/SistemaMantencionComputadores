using Microsoft.EntityFrameworkCore;
using SistemaGestion.Models;
using SistemaGestion.Vistas.Computadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestion.Vistas.Mantenciones
{
    public partial class Agregar_Mantencion : Form
    {
        private int xClick, yClick;
        private int IDPC;
        public Agregar_Mantencion()
        {
            InitializeComponent();
            using (DbConnection context = new DbConnection()) {

                //Llenar combobox tipo de cliente
                var TipoCliente = context.tblTipoCliente.ToArray();
                cb_Tipocliente.Items.AddRange(TipoCliente);
                cb_Tipocliente.DisplayMember = "TipoNombre";
                cb_Tipocliente.ValueMember = "TipoID";

                //Llenar combobox Tecnico
                var Tecnico = context.tblUsuario
                    .Where(u => u.RolID.Equals(2))
                    .ToArray();
                cb_Tecnico.Items.AddRange(Tecnico);
                cb_Tecnico.DisplayMember = "UsuarioNombreCompleto";
                cb_Tecnico.ValueMember = "UsuarioID";

                //Llenar combobox Metodo de pago
                var Metodo = context.tblMetodoPago.ToArray();
                cb_MetodoPago.Items.AddRange(Metodo);
                cb_MetodoPago.DisplayMember = "MetodoNombre";
                cb_MetodoPago.ValueMember = "MetodoID";

                //Llenar combobox Estado de Mantencion
                var Estado = context.tblEstadoMantencion.ToArray();
                cb_Estado.Items.AddRange(Estado);
                cb_Estado.DisplayMember = "EstadoNombre";
                cb_Estado.ValueMember = "EstadoID";
            }
        }

        private void cb_Tipocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Cliente.Items.Clear();
            cb_Cliente.Enabled = true;
            using (DbConnection context = new DbConnection()) {
                TipoCModelo T = (TipoCModelo)cb_Tipocliente.SelectedItem;
                var Cliente = context.tblCliente
                    .Where(c => c.TipoID.Equals(T.TipoID))
                    .ToArray();
                cb_Cliente.Items.AddRange(Cliente);
                cb_Cliente.DisplayMember = "ClienteNombreCompleto";
                cb_Cliente.ValueMember = "ClienteID";
            }
        }

        private void LlenarListaPC(List<ComputadorModelo> listaPC) {
            using (DbConnection context = new DbConnection())
            {
                lv_listapcdb.Items.Clear();
                foreach (var c in listaPC)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = c.ComputadorID.ToString();
                    lv.SubItems.Add(c.ComputadorID.ToString());
                    lv.SubItems.Add(c.Modelo.ModeloNombre);
                    lv.SubItems.Add(c.Modelo.Marca.MarcaNombre);
                    lv.SubItems.Add(c.Categoria.CategoriaNombre);
                    lv.ForeColor = Color.WhiteSmoke;

                    lv_listapcdb.Items.Add(lv);
                }
            }
        }

        private void Agregar_Mantencion_Load(object sender, EventArgs e)
        {
            using (DbConnection context = new DbConnection()) {
                LlenarListaPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .ThenInclude(M => M.Marca)
                            .Include(c => c.Categoria)
                            .ToList());
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = tb_Buscador.Text;
            using (DbConnection context = new DbConnection())
            {
                var ListaFiltrada = context.tblComputador
                     .Include(c => c.Modelo)
                     .ThenInclude(M => M.Marca)
                     .Include(c => c.Categoria)
                     .Where(
                         c => c.ComputadorID.Equals(Convert.ToInt32(busqueda)) ||
                         c.Modelo.ModeloNombre.Contains(busqueda) ||
                         c.Modelo.Marca.MarcaNombre.Contains(busqueda) ||
                         c.Categoria.CategoriaNombre.Contains(busqueda))
                     .ToList();
                LlenarListaPC(ListaFiltrada);
            }
        }

        private void lv_listapcdb_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ListarEnMantencion.Enabled = true;
        }

        private void btn_ListarEnMantencion_Click(object sender, EventArgs e)
        {
            IDPC = Convert.ToInt32(lv_listapcdb.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection()) {
                var listaPC = context.tblComputador
                                .Include(c => c.Modelo)
                                .Include(c => c.Categoria)
                                .Include(c => c.Sistema)
                                .Where(c => c.ComputadorID.Equals(IDPC))
                                .ToList();
                foreach (var c in listaPC)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = c.ComputadorID.ToString();
                    lv.SubItems.Add(c.ComputadorID.ToString());
                    lv.SubItems.Add(c.PcProcesador);
                    lv.SubItems.Add(c.PcVideo);
                    lv.SubItems.Add(c.PcDisco1);
                    lv.SubItems.Add(c.PcDisco2);
                    lv.SubItems.Add(c.PcRam);
                    lv.SubItems.Add(c.Modelo.ModeloNombre);
                    lv.SubItems.Add(c.Sistema.SistemaNombre);
                    lv.SubItems.Add(c.Categoria.CategoriaNombre);
                    lv.ForeColor = Color.WhiteSmoke;

                    lv_pcmantencion.Items.Add(lv);
                }
            }

            lv_listapcdb.SelectedItems.Clear();
            btn_ListarEnMantencion.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Falla.Text) ||
                String.IsNullOrEmpty(tb_Procedimiento.Text) ||
                String.IsNullOrEmpty(tb_Monto.Text) ||
                cb_Cliente.SelectedIndex == -1 ||
                cb_MetodoPago.SelectedIndex == -1 ||
                cb_Tecnico.SelectedIndex == -1 ||
                cb_Estado.SelectedIndex == -1 ||
                lv_pcmantencion.Items.Count == 0)
            {
                errorProvider1.SetError(btn_Guardar, "Faltan datos");
            }
            else {
                int monto = Convert.ToInt32(tb_Monto.Text);
                MantencionesModelo Mantencion = new MantencionesModelo();
                Mantencion.MantencionFallas = tb_Falla.Text;
                Mantencion.MantencionProceso = tb_Procedimiento.Text;
                Mantencion.MantencionFecha = DateTime.Now;
                Mantencion.MantencionPrecio = Convert.ToInt32(tb_Monto.Text);
                MetodoPagoModelo Metodo = (MetodoPagoModelo)cb_MetodoPago.SelectedItem;
                Mantencion.MetodoID = Metodo.MetodoID;
                ClientesModelo Cliente = (ClientesModelo)cb_Cliente.SelectedItem;
                Mantencion.ClienteID = Cliente.ClienteID;
                UsuarioModelo Usuario = (UsuarioModelo)cb_Tecnico.SelectedItem;
                Mantencion.UsuarioID = Usuario.UsuarioID;
                EstadoMantencionModelo Estado = (EstadoMantencionModelo)cb_Estado.SelectedItem;
                Mantencion.EstadoID = Estado.EstadoID;
                if (cb_Tipocliente.SelectedIndex == 0)
                {
                    int porcentaje = Convert.ToInt32(monto * 0.2);
                    Mantencion.MantencionImpuesto = porcentaje;
                    int total = monto + porcentaje;
                    Mantencion.MantencionTotal = total;
                }
                else {
                    int porcentaje = Convert.ToInt32(monto * 0.1);
                    Mantencion.MantencionImpuesto = porcentaje;
                    int total = monto + porcentaje;
                    Mantencion.MantencionTotal = total;
                }

                using (DbConnection context = new DbConnection()) {
                    using (var t = context.Database.BeginTransaction()) {
                        try
                        {
                            context.Add(Mantencion);
                            context.SaveChanges();
                            foreach (ListViewItem c in lv_pcmantencion.Items)
                            {
                                var Detalle = new DetalleMantencionesModelo();

                                Detalle.ComputadorID = Convert.ToInt32(c.Text);
                                Detalle.MantencionID = Mantencion.MantencionID;
                                context.Add(Detalle);
                            }
                            context.SaveChanges();
                            t.Commit();
                        }   
                        catch (Exception E)
                        {
                            t.Rollback();
                            MessageBox.Show(E.Message);
                        }
                    }
                }

                    
                
            }
        }

        private void btn_AgregarMasPc_Click(object sender, EventArgs e)
        {
            Agregar_Computadores frm = new Agregar_Computadores();
            frm.ShowDialog();
            using (DbConnection context = new DbConnection())
            {
                LlenarListaPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .ThenInclude(m => m.Marca)
                            .Include(c => c.Categoria)
                            .Include(c => c.Sistema)
                            .ToList());
            }
        }

        private void Agregar_Mantencion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
