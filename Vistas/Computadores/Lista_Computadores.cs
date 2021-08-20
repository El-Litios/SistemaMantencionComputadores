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

namespace SistemaGestion.Vistas.Computadores
{
    public partial class Lista_Computadores : Form
    {
        public Lista_Computadores()
        {
            InitializeComponent();
        }

        private void Lista_Computadores_Load(object sender, EventArgs e)
        {
            using (DbConnection context = new DbConnection()) {
                CargarListadoPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .Include(c => c.Categoria)
                            .Include(c => c.Sistema)
                            .ToList());
            }
        }

        private void CargarListadoPC(List<ComputadorModelo> listaPC) {
            using (DbConnection  context = new DbConnection()) {
                lv_computadores.Items.Clear();
                foreach (var c in listaPC) {
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

                    lv_computadores.Items.Add(lv);
                }
            }
        }

        //Buscador
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var busqueda = tb_Buscador.Text;
            using (DbConnection context = new DbConnection())
            {
                var ListaFiltrada = context.tblComputador
                     .Include(c => c.Modelo)
                     .Include(c => c.Categoria)
                     .Include(c => c.Sistema)
                     .Where(
                         c => c.PcProcesador.Contains(busqueda) ||
                         c.PcVideo.Contains(busqueda) ||
                         c.Modelo.ModeloNombre.Contains(busqueda))
                     .ToList();
                CargarListadoPC(ListaFiltrada);
            }
        }

        //Formulario para agregar Computadores
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Computadores frm = new Agregar_Computadores();
            frm.ShowDialog();
            using (DbConnection context = new DbConnection())
            {
                CargarListadoPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .Include(c => c.Categoria)
                            .Include(c => c.Sistema)
                            .ToList());
            }
        }

        //Formulario para editar Computadores
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lv_computadores.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection())
            {
                var pc = context.tblComputador.Where(c => c.ComputadorID == id).FirstOrDefault();
                if (pc != null)
                {
                    Editar_Computadores frm_editar = new Editar_Computadores(pc);
                    frm_editar.ShowDialog();
                    desactivarBotones(frm_editar);
                    CargarListadoPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .Include(c => c.Categoria)
                            .Include(c => c.Sistema)
                            .ToList());
                }
            }
        }

        //Eliminar Computadores
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                        "Estas seguro de Eliminar el registro?"
                        , "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Eliminar
                int id = Convert.ToInt32(lv_computadores.SelectedItems[0].Text);
                using (DbConnection context = new DbConnection())
                {
                    var pc = context.tblComputador
                        .Where(c => c.ComputadorID == id)
                        .FirstOrDefault();
                    context.Entry(pc).State = EntityState.Deleted;
                    context.SaveChanges();
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                    CargarListadoPC(context.tblComputador
                            .Include(c => c.Modelo)
                            .Include(c => c.Categoria)
                            .Include(c => c.Sistema)
                            .ToList());
                }
            }
        }

        private void desactivarBotones(Form form)
        {
            if (form.IsDisposed)
            {
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
            }
        }

        private void lv_computadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        
    }
}
