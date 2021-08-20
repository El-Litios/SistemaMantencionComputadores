
namespace SistemaGestion.Vistas.Clientes
{
    partial class Editar_Cliente
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
            this.components = new System.ComponentModel.Container();
            this.btn_GuardarCambios = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GuardarCambios
            // 
            this.btn_GuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_GuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarCambios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarCambios.Location = new System.Drawing.Point(108, 509);
            this.btn_GuardarCambios.Name = "btn_GuardarCambios";
            this.btn_GuardarCambios.Size = new System.Drawing.Size(214, 42);
            this.btn_GuardarCambios.TabIndex = 47;
            this.btn_GuardarCambios.Text = "GUARDAR CAMBIOS";
            this.btn_GuardarCambios.UseVisualStyleBackColor = false;
            this.btn_GuardarCambios.Click += new System.EventHandler(this.btn_GuardarCambios_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(184, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Correo:";
            // 
            // tb_Correo
            // 
            this.tb_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Correo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Correo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Correo.Location = new System.Drawing.Point(109, 368);
            this.tb_Correo.MaxLength = 60;
            this.tb_Correo.Name = "tb_Correo";
            this.tb_Correo.Size = new System.Drawing.Size(214, 26);
            this.tb_Correo.TabIndex = 45;
            this.tb_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(175, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Dirección:";
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Direccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Direccion.Location = new System.Drawing.Point(109, 298);
            this.tb_Direccion.MaxLength = 60;
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(214, 26);
            this.tb_Direccion.TabIndex = 43;
            this.tb_Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(178, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Telefono:";
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Telefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Telefono.Location = new System.Drawing.Point(108, 229);
            this.tb_Telefono.MaxLength = 25;
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(214, 26);
            this.tb_Telefono.TabIndex = 41;
            this.tb_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(177, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellidos:";
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Apellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Apellidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Apellidos.Location = new System.Drawing.Point(108, 161);
            this.tb_Apellidos.MaxLength = 100;
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(214, 26);
            this.tb_Apellidos.TabIndex = 39;
            this.tb_Apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(181, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Nombre.Location = new System.Drawing.Point(108, 93);
            this.tb_Nombre.MaxLength = 30;
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(214, 26);
            this.tb_Nombre.TabIndex = 37;
            this.tb_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::SistemaGestion.Properties.Resources.close1;
            this.btn_Cerrar.Location = new System.Drawing.Point(402, -2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 34);
            this.btn_Cerrar.TabIndex = 36;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Titulo.Location = new System.Drawing.Point(144, 8);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(144, 24);
            this.lb_Titulo.TabIndex = 35;
            this.lb_Titulo.Text = "Editar Cliente";
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Tipo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Tipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(108, 445);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(214, 25);
            this.cb_Tipo.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(154, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo de Cliente:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Editar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(428, 600);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_GuardarCambios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Apellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lb_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar_Cliente";
            this.Text = "Editar_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarCambios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}