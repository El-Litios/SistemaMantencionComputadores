using SistemaGestion.Vistas.Clientes;
using SistemaGestion.Vistas.Usuarios;
using SistemaGestion.Vistas.Mantenciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaGestion.Vistas.Computadores;
using SistemaGestion.Models;

namespace SistemaGestion
{
    public partial class Menu : Form
    {
        public int xClick = 0, yClick = 0;
        private UsuarioModelo u;
        public Menu(UsuarioModelo _u)
        {
            InitializeComponent();
            u = _u;
            lbl_Nombre.Text = u.UsuarioNombre + " " + u.UsuarioAP;
            if (u.RolID == 2) {
                btn_FormUsuarios.Visible = false;
                button3.Visible = false;
            }
            //Form
            this.BackColor = Color.FromArgb(1, 47, 83);
            p_botonera.BackColor = Color.FromArgb(1, 42, 74);

            //Imagenes
            img_Menu.BackColor = Color.FromArgb(1, 42, 74);

            //Botones
            btn_Cerrar.BackColor = Color.FromArgb(1, 47, 83);
            btn_Cerrar.FlatAppearance.BorderColor = Color.FromArgb(1, 47, 83);
            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Visible = true;
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Visible = true;
        }

        private void btn_FormUsuarios_Click(object sender, EventArgs e)
        {
            CerrarTodo();
            p_Forms.Controls.Clear();
            Lista_Usuario lista = new Lista_Usuario();
            lista.TopLevel = false;
            lista.AutoScroll = true;
            p_Forms.Controls.Add(lista);
            lista.Show();
        }

        private void btn_From_Click(object sender, EventArgs e)
        {
            CerrarTodo();
            p_Forms.Controls.Clear();
            Lista_Cliente lista = new Lista_Cliente();
            lista.TopLevel = false;
            lista.AutoScroll = true;
            p_Forms.Controls.Add(lista);
            lista.Show();
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarTodo();
            p_Forms.Controls.Clear();
            Lista_Mantenciones lista = new Lista_Mantenciones();
            lista.TopLevel = false;
            lista.AutoScroll = true;
            p_Forms.Controls.Add(lista);
            lista.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarTodo();
            p_Forms.Controls.Clear();
            Lista_Computadores lista = new Lista_Computadores();
            lista.TopLevel = false;
            lista.AutoScroll = true;
            p_Forms.Controls.Add(lista);
            lista.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }


        private void CerrarTodo() {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu" && Application.OpenForms[i].Name != "Login")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
