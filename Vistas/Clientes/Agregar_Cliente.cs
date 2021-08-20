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
    public partial class Agregar_Cliente : Form
    {
        public Agregar_Cliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            //Cargar combobox
            using (DbConnection context = new DbConnection())
            {
                var tipo = context.tblTipoCliente.ToArray();
                cb_Tipo.Items.AddRange(tipo);
                cb_Tipo.DisplayMember = "TipoNombre";
                cb_Tipo.ValueMember = "TipoID";
            }
        }
        
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Nombre.Text) || 
                String.IsNullOrEmpty(tb_Apellidos.Text) ||
                String.IsNullOrEmpty(tb_Telefono.Text) ||
                String.IsNullOrEmpty(tb_Correo.Text) ||
                String.IsNullOrEmpty(tb_Direccion.Text) ||
                cb_Tipo.SelectedIndex == -1) 
            {
                errorProvider1.SetError(btn_Guardar, "Debe ingresar todos los datos");
            } 
            else {
                ClientesModelo cliente = new ClientesModelo();
                cliente.ClienteNombre = tb_Nombre.Text;
                cliente.ClienteApellidos = tb_Apellidos.Text;
                cliente.ClienteTelefono = tb_Telefono.Text;
                cliente.ClienteDireccion = tb_Direccion.Text;
                cliente.ClienteCorreo = tb_Correo.Text;
                TipoCModelo tipo = (TipoCModelo)cb_Tipo.SelectedItem;
                cliente.TipoID = tipo.TipoID;

                using (DbConnection context = new DbConnection())
                {
                    context.tblCliente.Add(cliente);
                    context.SaveChanges();

                    tb_Nombre.Text = "";
                    tb_Apellidos.Text = "";
                    tb_Correo.Text = "";
                    tb_Telefono.Text = "";
                    tb_Direccion.Text = "";

                    MessageBox.Show
                        (
                            "Cliente ingresado.",
                            "AVISO IMPORTANTE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                }
            }
        }

        
    }
}
