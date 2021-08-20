using Microsoft.EntityFrameworkCore;
using SistemaGestion.Models;
using SistemaGestion.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Lista_Usuario : Form
    {
        public Lista_Usuario()
        {
            InitializeComponent();
            

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Usuario frm = new Agregar_Usuario();
            frm.ShowDialog();
            using (DbConnection context = new DbConnection()) {
                CargarLista(context.tblUsuario
                            .Include(u => u.Rol)
                            .ToList());
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            using (DbConnection context = new DbConnection()) {
                var usuario = context.tblUsuario.Where(u => u.UsuarioID == id).FirstOrDefault();
                if (usuario != null) {
                    Editar_Usuario frm_editar = new Editar_Usuario(usuario);
                    frm_editar.ShowDialog();
                    desactivarBotones(frm_editar);
                    CargarLista(context.tblUsuario
                            .Include(u => u.Rol)
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
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                using (DbConnection context = new DbConnection())
                {
                    var usuario = context.tblUsuario
                        .Where(u => u.UsuarioID == id)
                        .FirstOrDefault();
                    context.Entry(usuario).State = EntityState.Deleted;
                    context.SaveChanges();
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                    CargarLista(context.tblUsuario
                            .Include(u => u.Rol)
                            .ToList());
                }
            }
        }

       

        private void Lista_Usuario_Load(object sender, EventArgs e)
        {
            using (DbConnection context = new DbConnection()) {
                CargarLista(context.tblUsuario
                            .Include(u => u.Rol)
                            .ToList());
            }
                
        }

        private void CargarLista(List<UsuarioModelo> listausuarios)
        {
            listView1.Items.Clear();
            using (DbConnection context = new DbConnection())
            {
                foreach (var u in listausuarios)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = u.UsuarioID.ToString();
                    lv.SubItems.Add(u.UsuarioID.ToString());
                    lv.SubItems.Add(u.UsuarioNombre);
                    lv.SubItems.Add(u.UsuarioAP);
                    lv.SubItems.Add(u.UsuarioAM);
                    lv.SubItems.Add(u.UsuarioAlias);
                    lv.SubItems.Add(u.Rol.RolNombre);
                    lv.ForeColor = Color.WhiteSmoke;

                    listView1.Items.Add(lv);
                }
            }
        }
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            var busqueda = tb_Buscador.Text;
            using (DbConnection context= new DbConnection()) {
               var ListaFiltrada = context.tblUsuario
                    .Include(u => u.Rol)
                    .Where(
                        u => u.UsuarioNombre.Contains(busqueda) ||
                        u.UsuarioAlias.Contains(busqueda) || 
                        u.UsuarioAP.Contains(busqueda)).ToList();
                CargarLista(ListaFiltrada);
            }
        }


        //Configuraciones visuales

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }
        private void desactivarBotones(Form form) {
            if (form.IsDisposed) {
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
            }
        }
        
        
    }
}
