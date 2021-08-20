
namespace SistemaGestion.Vistas.Computadores
{
    partial class Lista_Computadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_computadores = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.procesador = new System.Windows.Forms.ColumnHeader();
            this.video = new System.Windows.Forms.ColumnHeader();
            this.disco1 = new System.Windows.Forms.ColumnHeader();
            this.disco2 = new System.Windows.Forms.ColumnHeader();
            this.ram = new System.Windows.Forms.ColumnHeader();
            this.modelo = new System.Windows.Forms.ColumnHeader();
            this.sistema = new System.Windows.Forms.ColumnHeader();
            this.categoria = new System.Windows.Forms.ColumnHeader();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tb_Buscador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_computadores
            // 
            this.lv_computadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.lv_computadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_computadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.id,
            this.procesador,
            this.video,
            this.disco1,
            this.disco2,
            this.ram,
            this.modelo,
            this.sistema,
            this.categoria});
            this.lv_computadores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lv_computadores.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_computadores.FullRowSelect = true;
            this.lv_computadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_computadores.HideSelection = false;
            this.lv_computadores.Location = new System.Drawing.Point(12, 60);
            this.lv_computadores.Margin = new System.Windows.Forms.Padding(0);
            this.lv_computadores.MultiSelect = false;
            this.lv_computadores.Name = "lv_computadores";
            this.lv_computadores.Size = new System.Drawing.Size(1276, 375);
            this.lv_computadores.TabIndex = 21;
            this.lv_computadores.UseCompatibleStateImageBehavior = false;
            this.lv_computadores.View = System.Windows.Forms.View.Details;
            this.lv_computadores.SelectedIndexChanged += new System.EventHandler(this.lv_computadores_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 80;
            // 
            // procesador
            // 
            this.procesador.Text = "Procesador";
            this.procesador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.procesador.Width = 150;
            // 
            // video
            // 
            this.video.Text = "Tarjeta de vIdeo";
            this.video.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.video.Width = 150;
            // 
            // disco1
            // 
            this.disco1.Text = "Disco duro 1";
            this.disco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disco1.Width = 150;
            // 
            // disco2
            // 
            this.disco2.Text = "Disco duro 2";
            this.disco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disco2.Width = 150;
            // 
            // ram
            // 
            this.ram.Text = "Memoria RAM";
            this.ram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ram.Width = 150;
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelo.Width = 150;
            // 
            // sistema
            // 
            this.sistema.Text = "Sistema operativo";
            this.sistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sistema.Width = 150;
            // 
            // categoria
            // 
            this.categoria.Text = "Categoria";
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoria.Width = 149;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Eliminar.Image = global::SistemaGestion.Properties.Resources.delete;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(1190, 470);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 35);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Editar.Image = global::SistemaGestion.Properties.Resources.edit;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(130, 470);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 35);
            this.btn_Editar.TabIndex = 19;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agregar.Image = global::SistemaGestion.Properties.Resources.add;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(12, 470);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(95, 35);
            this.btn_Agregar.TabIndex = 18;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(226, 16);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 26);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.Text = "Aplicar filtros";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tb_Buscador
            // 
            this.tb_Buscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Buscador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Buscador.Location = new System.Drawing.Point(12, 16);
            this.tb_Buscador.MaxLength = 30;
            this.tb_Buscador.Name = "tb_Buscador";
            this.tb_Buscador.PlaceholderText = "Buscador";
            this.tb_Buscador.Size = new System.Drawing.Size(198, 26);
            this.tb_Buscador.TabIndex = 16;
            this.tb_Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lista_Computadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1297, 548);
            this.Controls.Add(this.lv_computadores);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.tb_Buscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Computadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Computadores";
            this.Load += new System.EventHandler(this.Lista_Computadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_computadores;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader procesador;
        private System.Windows.Forms.ColumnHeader apellidos;
        private System.Windows.Forms.ColumnHeader correo;
        private System.Windows.Forms.ColumnHeader telefono;
        private System.Windows.Forms.ColumnHeader direccion;
        private System.Windows.Forms.ColumnHeader tipocliente;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox tb_Buscador;
        private System.Windows.Forms.ColumnHeader video;
        private System.Windows.Forms.ColumnHeader disco1;
        private System.Windows.Forms.ColumnHeader disco2;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.ColumnHeader modelo;
        private System.Windows.Forms.ColumnHeader sistema;
        private System.Windows.Forms.ColumnHeader categoria;
    }
}