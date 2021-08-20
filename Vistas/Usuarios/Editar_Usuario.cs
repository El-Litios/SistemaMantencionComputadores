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

namespace SistemaGestion.Vistas.Usuarios
{
    public partial class Editar_Usuario : Form
    {
        private int xClick, yClick;
        private UsuarioModelo _u;
        private RolModelo rol;
        public Editar_Usuario(UsuarioModelo u)
        {
            InitializeComponent();
            //Cargar combobox
            using (DbConnection context = new DbConnection())
            {
                var Rol = context.tblRolUsuario.ToArray();
                cb_Roles.Items.AddRange(Rol);
                cb_Roles.DisplayMember = "RolNombre";
                cb_Roles.ValueMember = "RolID";
            }

            //Tomar datos
            _u = u;
            tb_Nombre.Text = u.UsuarioNombre;
            tb_ApellidoP.Text = u.UsuarioAP;
            tb_ApellidoM.Text = u.UsuarioAM;
            tb_Usuario.Text = u.UsuarioAlias;
            

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_Roles.SelectedIndex == -1) {
                errorProvider1.SetError(btn_GuardarCambios, "Error, Debe seleccionar un Rol");
            }
            else {
                _u.UsuarioAlias = tb_Usuario.Text;
                _u.UsuarioNombre = tb_Nombre.Text;
                _u.UsuarioAP = tb_ApellidoP.Text;
                _u.UsuarioAM = tb_ApellidoM.Text;
                rol = (RolModelo)cb_Roles.SelectedItem;
                _u.RolID = rol.RolID;

                using (DbConnection context = new DbConnection())
                {
                    context.Entry(_u).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show(
                        "Usuario Editado Correctamente",
                        "Notificacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Dispose();
                }
            }

        }

        private void Editar_Usuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
