
namespace SistemaGestion.Vistas.Mantenciones
{
    partial class Lista_Mantenciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Mantenciones));
            this.lv_mantencion = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.precio = new System.Windows.Forms.ColumnHeader();
            this.impuesto = new System.Windows.Forms.ColumnHeader();
            this.total = new System.Windows.Forms.ColumnHeader();
            this.metodopago = new System.Windows.Forms.ColumnHeader();
            this.estado = new System.Windows.Forms.ColumnHeader();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Detalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_mantencion
            // 
            this.lv_mantencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.lv_mantencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_mantencion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.id,
            this.precio,
            this.impuesto,
            this.total,
            this.metodopago,
            this.estado});
            this.lv_mantencion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lv_mantencion.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_mantencion.FullRowSelect = true;
            this.lv_mantencion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_mantencion.HideSelection = false;
            this.lv_mantencion.Location = new System.Drawing.Point(10, 61);
            this.lv_mantencion.Margin = new System.Windows.Forms.Padding(0);
            this.lv_mantencion.MultiSelect = false;
            this.lv_mantencion.Name = "lv_mantencion";
            this.lv_mantencion.Size = new System.Drawing.Size(1276, 375);
            this.lv_mantencion.TabIndex = 27;
            this.lv_mantencion.UseCompatibleStateImageBehavior = false;
            this.lv_mantencion.View = System.Windows.Forms.View.Details;
            this.lv_mantencion.SelectedIndexChanged += new System.EventHandler(this.lv_mantencion_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 90;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precio.Width = 237;
            // 
            // impuesto
            // 
            this.impuesto.Text = "Impuesto";
            this.impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.impuesto.Width = 237;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.Width = 237;
            // 
            // metodopago
            // 
            this.metodopago.Text = "Metodo de pago";
            this.metodopago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metodopago.Width = 237;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estado.Width = 237;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(1188, 471);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 35);
            this.btn_Eliminar.TabIndex = 26;
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
            this.btn_Editar.Location = new System.Drawing.Point(128, 471);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 35);
            this.btn_Editar.TabIndex = 25;
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
            this.btn_Agregar.Location = new System.Drawing.Point(10, 471);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(95, 35);
            this.btn_Agregar.TabIndex = 24;
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
            this.button3.Location = new System.Drawing.Point(224, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 26);
            this.button3.TabIndex = 23;
            this.button3.Text = "Aplicar filtros";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_Buscador
            // 
            this.tb_Buscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Buscador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Buscador.Location = new System.Drawing.Point(10, 17);
            this.tb_Buscador.MaxLength = 30;
            this.tb_Buscador.Name = "tb_Buscador";
            this.tb_Buscador.PlaceholderText = "Buscador";
            this.tb_Buscador.Size = new System.Drawing.Size(198, 26);
            this.tb_Buscador.TabIndex = 22;
            this.tb_Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Detalles
            // 
            this.btn_Detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Detalles.Enabled = false;
            this.btn_Detalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detalles.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Detalles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Detalles.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detalles.Image")));
            this.btn_Detalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detalles.Location = new System.Drawing.Point(249, 471);
            this.btn_Detalles.Name = "btn_Detalles";
            this.btn_Detalles.Size = new System.Drawing.Size(102, 35);
            this.btn_Detalles.TabIndex = 28;
            this.btn_Detalles.Text = "Detalles";
            this.btn_Detalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Detalles.UseVisualStyleBackColor = false;
            this.btn_Detalles.Click += new System.EventHandler(this.btn_Detalles_Click);
            // 
            // Lista_Mantenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1297, 548);
            this.Controls.Add(this.btn_Detalles);
            this.Controls.Add(this.lv_mantencion);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_Buscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Mantenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Mantenciones";
            this.Load += new System.EventHandler(this.Lista_Mantenciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_mantencion;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.ColumnHeader impuesto;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader metodopago;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_Buscador;
        private System.Windows.Forms.Button btn_Detalles;
    }
}