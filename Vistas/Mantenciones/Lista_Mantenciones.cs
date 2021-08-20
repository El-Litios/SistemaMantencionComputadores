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
    public partial class Lista_Mantenciones : Form
    {
        public Lista_Mantenciones()
        {
            InitializeComponent();
        }

        private void Lista_Mantenciones_Load(object sender, EventArgs e)
        {
            using(DbConnection context = new DbConnection()){
                CargarListaMantenciones(context.tblMantencion
                    .Include(m => m.Estado)
                    .Include(m => m.Metodo)
                    .ToList());
            }
        }

        private void CargarListaMantenciones(List<MantencionesModelo> listaM) {
            using (DbConnection context = new DbConnection()) {
                lv_mantencion.Items.Clear();
                foreach (var m in listaM)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = m.MantencionID.ToString();
                    lv.SubItems.Add(m.MantencionID.ToString());
                    lv.SubItems.Add(m.MantencionPrecio.ToString());
                    lv.SubItems.Add(m.MantencionImpuesto.ToString());
                    lv.SubItems.Add(m.MantencionTotal.ToString());
                    lv.SubItems.Add(m.Metodo.MetodoNombre);
                    lv.SubItems.Add(m.Estado.EstadoNombre);
                    lv.ForeColor = Color.WhiteSmoke;

                    lv_mantencion.Items.Add(lv);
                }

            }
        
        }

        private void lv_mantencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Detalles.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Mantencion frm = new Agregar_Mantencion();
            frm.ShowDialog();
            using (DbConnection context = new DbConnection())
            {
                CargarListaMantenciones(context.tblMantencion
                    .Include(m => m.Estado)
                    .Include(m => m.Metodo)
                    .ToList());
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lv_mantencion.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection())
            {
                var mantencion = context.tblMantencion
                    .Where(m => m.MantencionID == id).FirstOrDefault();
                if (mantencion != null)
                {
                    Editar_Mantencion frm_editar = new Editar_Mantencion(mantencion);
                    frm_editar.ShowDialog();
                    desactivarBotones(frm_editar);
                    CargarListaMantenciones(context.tblMantencion
                        .Include(m => m.Estado)
                        .Include(m => m.Metodo)
                        .ToList());
                }
            }
        }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lv_mantencion.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection())
            {
                var mantencion = context.tblMantencion
                    .Where(m => m.MantencionID == id).FirstOrDefault();
                if (mantencion != null)
                {
                    Detalle_Mantencion frm_detalle = new Detalle_Mantencion(mantencion);
                    frm_detalle.ShowDialog();
                    desactivarBotones(frm_detalle);
                    CargarListaMantenciones(context.tblMantencion
                        .Include(m => m.Estado)
                        .Include(m => m.Metodo)
                        .ToList());
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                        "Estas seguro de Eliminar el registro?"
                        , "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Eliminar
                int id = Convert.ToInt32(lv_mantencion.SelectedItems[0].Text);
                using (DbConnection context = new DbConnection())
                {
                    var mantencion = context.tblMantencion
                        .Where(m => m.MantencionID == id)
                        .FirstOrDefault();
                    context.Entry(mantencion).State = EntityState.Deleted;
                    context.SaveChanges();
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                    CargarListaMantenciones(context.tblMantencion
                        .Include(m => m.Estado)
                        .Include(m => m.Metodo)
                        .ToList());
                }
            }
        }


        private void desactivarBotones(Form form) {
            if (form.IsDisposed)
            {
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Detalles.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var busqueda = tb_Buscador.Text;
            using (DbConnection context = new DbConnection())
            {
                var ListaFiltrada = context.tblMantencion
                        .Include(m => m.Estado)
                        .Include(m => m.Metodo)
                        .Where(
                             m => m.MantencionID.ToString().Contains(busqueda)).ToList();
                CargarListaMantenciones(ListaFiltrada);
            }
        }
    }
}
