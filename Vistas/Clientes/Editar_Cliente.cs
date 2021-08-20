using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestion.Vistas.Clientes
{
    public partial class Editar_Cliente : Form
    {
        private int xClick, yClick;
        private ClientesModelo _c;
        private TipoCModelo tipo;
        public Editar_Cliente(ClientesModelo c)
        {
            InitializeComponent();
            //Cargar combobox
            using (DbConnection context = new DbConnection())
            {
                var tipo = context.tblTipoCliente.ToArray();
                cb_Tipo.Items.AddRange(tipo);
                cb_Tipo.DisplayMember = "TipoNombre";
                cb_Tipo.ValueMember = "TipoID";
            }

            //Tomar datos
            _c = c;
            tb_Nombre.Text = c.ClienteNombre;
            tb_Apellidos.Text = c.ClienteApellidos;
            tb_Correo.Text = c.ClienteCorreo;
            tb_Telefono.Text = c.ClienteTelefono;
            tb_Direccion.Text = c.ClienteDireccion;
        }

        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            if (cb_Tipo.SelectedIndex == -1)
            {
                errorProvider1.SetError(btn_GuardarCambios, "Error, Debe seleccionar un Tipo de Cliente");
            }
            else
            {
                _c.ClienteNombre = tb_Nombre.Text;
                _c.ClienteApellidos = tb_Apellidos.Text;
                _c.ClienteCorreo = tb_Correo.Text;
                _c.ClienteTelefono = tb_Telefono.Text;
                _c.ClienteDireccion = tb_Direccion.Text;
                tipo = (TipoCModelo)cb_Tipo.SelectedItem;
                _c.TipoID = tipo.TipoID;

                using (DbConnection context = new DbConnection())
                {
                    context.Entry(_c).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show(
                        "Cliente Editado Correctamente",
                        "Notificacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Dispose();
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
