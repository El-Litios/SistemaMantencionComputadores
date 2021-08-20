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
    public partial class Editar_Mantencion : Form
    {
        MantencionesModelo _m;
        public Editar_Mantencion(MantencionesModelo m)
        {
            InitializeComponent();
            //Cargar combobox
            using (DbConnection context = new DbConnection())
            {
                var Metodo = context.tblMetodoPago.ToArray();
                cb_MetodoPago.Items.AddRange(Metodo);
                cb_MetodoPago.DisplayMember = "MetodoNombre";
                cb_MetodoPago.ValueMember = "MetodoID";

                var Estado = context.tblEstadoMantencion.ToArray();
                cb_Estado.Items.AddRange(Estado);
                cb_Estado.DisplayMember = "EstadoNombre";
                cb_Estado.ValueMember = "EstadoID";
            }

            _m = m;
            tb_Falla.Text = m.MantencionFallas;
            tb_Procedimiento.Text = m.MantencionProceso;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cb_Estado.SelectedIndex == -1 || 
                cb_MetodoPago.SelectedIndex == -1 ||
                String.IsNullOrEmpty(tb_Falla.Text) ||
                String.IsNullOrEmpty(tb_Procedimiento.Text))
            {
                errorProvider1.SetError(btn_Guardar, "Error, Debe ingresar todos los datos");
            }
            else
            {
                _m.MantencionFallas = tb_Falla.Text;
                _m.MantencionProceso = tb_Procedimiento.Text;
                EstadoMantencionModelo Estado = (EstadoMantencionModelo)cb_Estado.SelectedItem;
                _m.EstadoID = Estado.EstadoID;
                MetodoPagoModelo Metodo = (MetodoPagoModelo)cb_MetodoPago.SelectedItem;
                _m.MetodoID = Metodo.MetodoID;

                using (DbConnection context = new DbConnection())
                {
                    context.Entry(_m).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show(
                        "Mantencion Editada Correctamente",
                        "Notificacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Dispose();
                }
            }
        }
    }
}
