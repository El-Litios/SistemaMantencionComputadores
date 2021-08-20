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
    public partial class Editar_Computadores : Form
    {
        private int xClick, yClick;
        private ComputadorModelo _c;
        public Editar_Computadores(ComputadorModelo c)
        {
            InitializeComponent();
            using (DbConnection context = new DbConnection())
            {
                //llenar combobox Proveedores de sistemas operativos
                var Proveedores = context.tblProveedorSistema.ToArray();
                cb_distribuidor.Items.AddRange(Proveedores);
                cb_distribuidor.DisplayMember = "ProveedorNombre";
                cb_distribuidor.ValueMember = "ProveedorID";

                //llenar combobox de Marcas de computadores
                var Marcas = context.tblMarca.ToArray();
                cb_marca.Items.AddRange(Marcas);
                cb_marca.DisplayMember = "MarcaNombre";
                cb_marca.ValueMember = "MarcaID";

                //llenar combobox con el tipo de computador [Escritorio/Notebook/Netbook]
                var Categoria = context.tblCategoriaPc.ToArray();
                cb_categoria.Items.AddRange(Categoria);
                cb_categoria.DisplayMember = "CategoriaNombre";
                cb_categoria.ValueMember = "CategoriaID";
            }

            //Tomar datos
            _c = c;
            tb_Procesador.Text = c.PcProcesador;
            tb_video.Text = c.PcVideo;
            tb_Disco1.Text = c.PcDisco1;
            tb_Disco2.Text = c.PcDisco2;
            tb_Ram.Text = c.PcRam;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cb_categoria.SelectedIndex == -1 ||
                cb_sistema.SelectedIndex == -1 ||
                cb_modelo.SelectedIndex == -1) 
            {
                errorProvider1.SetError(btn_Guardar, "Error, Debe rellenar todos los campos");
            }
            else {
                _c.PcProcesador = tb_Procesador.Text;
                _c.PcVideo = tb_video.Text;
                _c.PcDisco1 = tb_Disco1.Text;
                _c.PcDisco2 = tb_Disco2.Text;
                _c.PcRam = tb_Ram.Text;
                SistemaOperativoModelo sistema = (SistemaOperativoModelo)cb_sistema.SelectedItem;
                _c.SistemaID = sistema.SistemaID;
                ModelosPcModelo modelo = (ModelosPcModelo)cb_modelo.SelectedItem;
                _c.ModeloID = modelo.ModeloID;
                CategoriaPcModelo categoria = (CategoriaPcModelo)cb_categoria.SelectedItem;
                _c.CategoriaID = categoria.CategoriaID;

                using (DbConnection context = new DbConnection())
                {
                    context.Entry(_c).State = EntityState.Modified;
                    context.SaveChanges();

                    MessageBox.Show
                        (
                            "Computador editado correctamente.",
                            "AVISO IMPORTANTE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_distribuidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_sistema.Items.Clear();
            cb_sistema.Enabled = true;
            using (DbConnection context = new DbConnection())
            {
                ProveedorSIstemaModelo P = (ProveedorSIstemaModelo)cb_distribuidor.SelectedItem;
                var SistemaOperativo = context.tblSistemaOperativo
                    .Where(s => s.ProveedorID.Equals(P.ProveedorID))
                    .ToArray();
                cb_sistema.Items.AddRange(SistemaOperativo);
                cb_sistema.DisplayMember = "SistemaNombre";
                cb_sistema.ValueMember = "SistemaID";

            }
        }

        private void cb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_modelo.Items.Clear();
            cb_modelo.Enabled = true;
            using (DbConnection context = new DbConnection())
            {
                MarcaPcModelo M = (MarcaPcModelo)cb_marca.SelectedItem;
                var ModeloPc = context.tblModelo
                    .Where(m => m.MarcaID.Equals(M.MarcaID))
                    .ToArray();
                cb_modelo.Items.AddRange(ModeloPc);
                cb_modelo.DisplayMember = "ModeloNombre";
                cb_modelo.ValueMember = "ModeloID";

            }
        }

        private void Editar_Computadores_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
