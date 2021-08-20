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

namespace SistemaGestion.Vistas.Clientes
{
    public partial class Lista_Cliente : Form
    {
        public Lista_Cliente()
        {
            InitializeComponent();
            
        }

        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_Cliente);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm = new Agregar_Cliente();
            frm.ShowDialog();
            using (DbConnection context = new DbConnection())
            {
                CargarLista(context.tblCliente
                            .Include(c => c.Tipo)
                            .ToList());
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lv_clientes.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection())
            {
                var cliente = context.tblCliente.Where(c => c.ClienteID == id).FirstOrDefault();
                if (cliente != null)
                {
                    Editar_Cliente frm_editar = new Editar_Cliente(cliente);
                    frm_editar.ShowDialog();
                    desactivarBotones(frm_editar);
                    CargarLista(context.tblCliente
                            .Include(c => c.Tipo)
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
                int id = Convert.ToInt32(lv_clientes.SelectedItems[0].Text);
                using (DbConnection context = new DbConnection())
                {
                    var cliente = context.tblCliente
                        .Where(c => c.ClienteID == id)
                        .FirstOrDefault();
                    context.Entry(cliente).State = EntityState.Deleted;
                    context.SaveChanges();
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                    CargarLista(context.tblCliente
                            .Include(c => c.Tipo)
                            .ToList());
                }
            }
        }

        private void Lista_Cliente_Load(object sender, EventArgs e)
        {
            using(DbConnection context = new DbConnection()){
                CargarLista(context.tblCliente
                                .Include(c => c.Tipo)
                                .ToList());
            }
        }

        private void CargarLista(List<ClientesModelo> listacliente)
        {
            lv_clientes.Items.Clear();
            using (DbConnection context = new DbConnection())
            {
                foreach (var c in listacliente)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = c.ClienteID.ToString();
                    lv.SubItems.Add(c.ClienteID.ToString());
                    lv.SubItems.Add(c.ClienteNombre);
                    lv.SubItems.Add(c.ClienteApellidos);
                    lv.SubItems.Add(c.ClienteCorreo);
                    lv.SubItems.Add(c.ClienteTelefono);
                    lv.SubItems.Add(c.ClienteDireccion);
                    lv.SubItems.Add(c.Tipo.TipoNombre);
                    lv.ForeColor = Color.WhiteSmoke;

                    lv_clientes.Items.Add(lv);
                }
            }
        }

        private void lv_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        private void desactivarBotones(Form form)
        {
            if (form.IsDisposed)
            {
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var busqueda = tb_Buscador.Text;
            using (DbConnection context = new DbConnection())
            {
                var ListaFiltrada = context.tblCliente
                     .Include(c => c.Tipo)
                     .Where(
                         c => c.ClienteNombre.Contains(busqueda) ||
                         c.ClienteApellidos.Contains(busqueda) ||
                         c.ClienteTelefono.Contains(busqueda)).ToList();
                CargarLista(ListaFiltrada);
            }
        }
    }
}
