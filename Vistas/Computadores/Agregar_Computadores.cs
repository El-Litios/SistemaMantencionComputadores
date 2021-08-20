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
    public partial class Agregar_Computadores : Form
    {
        public Agregar_Computadores()
        {
            InitializeComponent();
            using (DbConnection context = new DbConnection()) {
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

        }

        private void cb_distribuidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_sistema.Items.Clear();
            cb_sistema.Enabled = true;
            using (DbConnection context = new DbConnection()) {
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

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Procesador.Text) ||
                String.IsNullOrEmpty(tb_video.Text) ||
                String.IsNullOrEmpty(tb_Disco1.Text) ||
                String.IsNullOrEmpty(tb_Disco2.Text) ||
                String.IsNullOrEmpty(tb_Ram.Text) ||
                cb_sistema.SelectedIndex == -1 ||
                cb_modelo.SelectedIndex == -1 ||
                cb_categoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(btn_Guardar, "Debe ingresar todos los datos");
            }
            else {
                ComputadorModelo pc = new ComputadorModelo();
                pc.PcProcesador = tb_Procesador.Text;
                pc.PcVideo = tb_video.Text;
                pc.PcDisco1 = tb_Disco1.Text;
                pc.PcDisco2 = tb_Disco2.Text;
                pc.PcRam = tb_Ram.Text;
                SistemaOperativoModelo sistema = (SistemaOperativoModelo)cb_sistema.SelectedItem;
                pc.SistemaID = sistema.SistemaID;
                ModelosPcModelo modelo = (ModelosPcModelo)cb_modelo.SelectedItem;
                pc.ModeloID = modelo.ModeloID;
                CategoriaPcModelo categoria = (CategoriaPcModelo)cb_categoria.SelectedItem;
                pc.CategoriaID = categoria.CategoriaID;

                using (DbConnection context = new DbConnection()) {
                    context.tblComputador.Add(pc);
                    context.SaveChanges();

                    MessageBox.Show
                        (
                            "Computador registrado correctamente.",
                            "AVISO IMPORTANTE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                }
            }
        }
    }
}
