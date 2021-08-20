using Microsoft.EntityFrameworkCore;
using SistemaGestion.Models;
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
    public partial class Detalle_Mantencion : Form
    {
        MantencionesModelo _m;
        public Detalle_Mantencion(MantencionesModelo m)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Select();
            _m = m;
        }

        private void Detalle_Mantencion_Load(object sender, EventArgs e)
        {
            using (DbConnection context = new DbConnection())
            {
               var detalle = context.tblMantencion
                    .Where(m => m.MantencionID == _m.MantencionID)
                    .Include(m => m.Estado)
                    .Include(m => m.Metodo)
                    .Include(m => m.Cliente)
                    .Include(m => m.Usuario)
                    .Include(m => m.ListaDetalleM)
                    .ThenInclude(dm => dm.Computador).ThenInclude(pc => pc.Categoria)
                    .Include(m => m.ListaDetalleM)
                    .ThenInclude(dm=>dm.Computador).ThenInclude(pc => pc.Modelo)
                    .Include(m => m.ListaDetalleM)
                    .ThenInclude(dm => dm.Computador).ThenInclude(pc => pc.Sistema)
                    .FirstOrDefault();

                if (detalle != null)
                {
                    lbl_ID.Text = detalle.MantencionID.ToString();
                    lbl_Cliente.Text = detalle.Cliente.ClienteNombre + " " + detalle.Cliente.ClienteApellidos;
                    lbl_Costo.Text = detalle.MantencionPrecio.ToString();
                    lbl_Estado.Text = detalle.Estado.EstadoNombre;
                    lbl_Fecha.Text = detalle.MantencionFecha.ToString();
                    lbl_Impuesto.Text = detalle.MantencionImpuesto.ToString();
                    lbl_Metodo.Text = detalle.Metodo.MetodoNombre;
                    lbl_Tecnico.Text = detalle.Usuario.UsuarioNombre + " " + detalle.Usuario.UsuarioAP + " " + detalle.Usuario.UsuarioAM;
                    lbl_Total.Text = detalle.MantencionTotal.ToString();
                    tb_Falla.Text = detalle.MantencionFallas;
                    tb_Procedimiento.Text = detalle.MantencionProceso;

                    foreach (var dm in detalle.ListaDetalleM)
                    {
                        ListViewItem lv = new ListViewItem();
                        lv.Text = "";
                        lv.SubItems.Add(dm.Computador.ComputadorID.ToString());
                        lv.SubItems.Add(dm.Computador.PcProcesador);
                        lv.SubItems.Add(dm.Computador.PcVideo);
                        lv.SubItems.Add(dm.Computador.PcDisco1);
                        lv.SubItems.Add(dm.Computador.PcDisco2);
                        lv.SubItems.Add(dm.Computador.PcRam);
                        lv.SubItems.Add(dm.Computador.Modelo.ModeloNombre);
                        lv.SubItems.Add(dm.Computador.Sistema.SistemaNombre);
                        lv.SubItems.Add(dm.Computador.Categoria.CategoriaNombre);
                        lv.ForeColor = Color.WhiteSmoke;

                        lv_pc.Items.Add(lv);
                    }
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
