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
    public partial class Agregar_Usuario : Form
    {
        private int yClick, xClick;
        public Agregar_Usuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            using (DbConnection context = new DbConnection())
            {
                var Rol = context.tblRolUsuario.ToArray();
                cb_Roles.Items.AddRange(Rol);
                cb_Roles.DisplayMember = "RolNombre";
                cb_Roles.ValueMember = "RolID";
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Nombre.Text) ||
                String.IsNullOrEmpty(tb_ApellidoP.Text) ||
                String.IsNullOrEmpty(tb_ApellidoM.Text) ||
                String.IsNullOrEmpty(tb_Usuario.Text) ||
                String.IsNullOrEmpty(tb_Pass.Text) ||
                cb_Roles.SelectedIndex == -1)
            {
                errorProvider1.SetError(btn_Guardar, "Debe ingresar todos los datos");
            }
            else {
                 UsuarioModelo usuario = new UsuarioModelo();
                 usuario.UsuarioNombre = tb_Nombre.Text;
                 usuario.UsuarioAP = tb_ApellidoP.Text;
                 usuario.UsuarioAM = tb_ApellidoM.Text;
                 usuario.UsuarioAlias = tb_Usuario.Text;
                 usuario.UsuarioPass = tb_Pass.Text;
                 RolModelo rol = (RolModelo)cb_Roles.SelectedItem;
                 usuario.RolID = rol.RolID;

                 using (DbConnection context = new DbConnection()) {
                     context.tblUsuario.Add(usuario);
                     context.SaveChanges();

                     MessageBox.Show
                         (
                             "Usuario registrado.",
                             "AVISO IMPORTANTE",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information
                         );
                 }
                
            }
        }

       

        private void Agregar_Usuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
