using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(1, 47, 83);
            btn_Iniciar.BackColor = Color.FromArgb(17, 95, 157);
            btn_Iniciar.FlatAppearance.BorderColor = Color.FromArgb(17, 95, 157);
            btn_Cerrar.BackColor = Color.FromArgb(1, 47, 83);
            btn_Cerrar.FlatAppearance.BorderColor = Color.FromArgb(1, 47, 83);
            lb_Error.BackColor = Color.FromArgb(1, 47, 83);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Usuario_TextChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void tb_Pass_TextChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void Validacion() 
        {
            if (String.IsNullOrEmpty(tb_Usuario.Text) || String.IsNullOrEmpty(tb_Pass.Text))
            {
                btn_Iniciar.Enabled = false;
            }

            if (!String.IsNullOrEmpty(tb_Usuario.Text) && !String.IsNullOrEmpty(tb_Pass.Text))
            {
                btn_Iniciar.Enabled = true;
            }
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            var Usuario = tb_Usuario.Text;
            var Pass = tb_Pass.Text;

            using (DbConnection context = new DbConnection()) {
                var User = context.tblUsuario
                    .FirstOrDefault(u => u.UsuarioAlias == Usuario && u.UsuarioPass == Pass);

                if (User != null)
                {
                    
                    Menu menu = new Menu(User);
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    lb_Error.Visible = true;
                }
            }
                
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tb_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Usuario.Text = "";
        }

        private void tb_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Pass.Text = "";
        }
    }
}
