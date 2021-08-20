
namespace SistemaGestion.Vistas.Clientes
{
    partial class Lista_Cliente
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_Buscador = new System.Windows.Forms.TextBox();
            this.lv_clientes = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.nombre = new System.Windows.Forms.ColumnHeader();
            this.apellidos = new System.Windows.Forms.ColumnHeader();
            this.correo = new System.Windows.Forms.ColumnHeader();
            this.telefono = new System.Windows.Forms.ColumnHeader();
            this.direccion = new System.Windows.Forms.ColumnHeader();
            this.tipocliente = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
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
            this.btn_Eliminar.TabIndex = 14;
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
            this.btn_Editar.Location = new System.Drawing.Point(132, 470);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 35);
            this.btn_Editar.TabIndex = 13;
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
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(226, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Aplicar filtros";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tb_Buscador.TabIndex = 10;
            this.tb_Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_clientes
            // 
            this.lv_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.lv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.id,
            this.nombre,
            this.apellidos,
            this.correo,
            this.telefono,
            this.direccion,
            this.tipocliente});
            this.lv_clientes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lv_clientes.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_clientes.FullRowSelect = true;
            this.lv_clientes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_clientes.HideSelection = false;
            this.lv_clientes.Location = new System.Drawing.Point(12, 60);
            this.lv_clientes.Margin = new System.Windows.Forms.Padding(0);
            this.lv_clientes.MultiSelect = false;
            this.lv_clientes.Name = "lv_clientes";
            this.lv_clientes.Size = new System.Drawing.Size(1276, 375);
            this.lv_clientes.TabIndex = 15;
            this.lv_clientes.UseCompatibleStateImageBehavior = false;
            this.lv_clientes.View = System.Windows.Forms.View.Details;
            this.lv_clientes.SelectedIndexChanged += new System.EventHandler(this.lv_clientes_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 120;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Width = 192;
            // 
            // apellidos
            // 
            this.apellidos.Text = "Apellidos";
            this.apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellidos.Width = 192;
            // 
            // correo
            // 
            this.correo.Text = "Correo";
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correo.Width = 192;
            // 
            // telefono
            // 
            this.telefono.Text = "Telefono";
            this.telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telefono.Width = 192;
            // 
            // direccion
            // 
            this.direccion.Text = "Dirección";
            this.direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.direccion.Width = 192;
            // 
            // tipocliente
            // 
            this.tipocliente.Text = "Tipo";
            this.tipocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipocliente.Width = 192;
            // 
            // Lista_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1297, 548);
            this.Controls.Add(this.lv_clientes);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_Buscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Cliente";
            this.Text = "Lista_Clientes";
            this.Load += new System.EventHandler(this.Lista_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_Buscador;
        private System.Windows.Forms.ListView lv_clientes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader apellidos;
        private System.Windows.Forms.ColumnHeader apm;
        private System.Windows.Forms.ColumnHeader usuario;
        private System.Windows.Forms.ColumnHeader rol;
        private System.Windows.Forms.ColumnHeader correo;
        private System.Windows.Forms.ColumnHeader telefono;
        private System.Windows.Forms.ColumnHeader direccion;
        private System.Windows.Forms.ColumnHeader tipocliente;
    }
}