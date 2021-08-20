
namespace SistemaGestion.Vistas.Usuarios
{
    partial class Editar_Usuario
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
            this.cb_Roles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ApellidoM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ApellidoP = new System.Windows.Forms.TextBox();
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
            this.btn_GuardarCambios.Location = new System.Drawing.Point(107, 457);
            this.btn_GuardarCambios.Name = "btn_GuardarCambios";
            this.btn_GuardarCambios.Size = new System.Drawing.Size(214, 42);
            this.btn_GuardarCambios.TabIndex = 38;
            this.btn_GuardarCambios.Text = "GUARDAR CAMBIOS";
            this.btn_GuardarCambios.UseVisualStyleBackColor = false;
            this.btn_GuardarCambios.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_Roles
            // 
            this.cb_Roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Roles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Roles.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Roles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Roles.FormattingEnabled = true;
            this.cb_Roles.Location = new System.Drawing.Point(111, 370);
            this.cb_Roles.Name = "cb_Roles";
            this.cb_Roles.Size = new System.Drawing.Size(214, 25);
            this.cb_Roles.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(183, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Usuario:";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Usuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Usuario.Location = new System.Drawing.Point(111, 302);
            this.tb_Usuario.MaxLength = 30;
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(214, 26);
            this.tb_Usuario.TabIndex = 33;
            this.tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(149, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Apellido Materno:";
            // 
            // tb_ApellidoM
            // 
            this.tb_ApellidoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_ApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ApellidoM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ApellidoM.Location = new System.Drawing.Point(111, 234);
            this.tb_ApellidoM.MaxLength = 50;
            this.tb_ApellidoM.Name = "tb_ApellidoM";
            this.tb_ApellidoM.Size = new System.Drawing.Size(214, 26);
            this.tb_ApellidoM.TabIndex = 31;
            this.tb_ApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(180, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Nombre.Location = new System.Drawing.Point(107, 96);
            this.tb_Nombre.MaxLength = 30;
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(214, 26);
            this.tb_Nombre.TabIndex = 29;
            this.tb_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::SistemaGestion.Properties.Resources.close1;
            this.btn_Cerrar.Location = new System.Drawing.Point(399, -1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 34);
            this.btn_Cerrar.TabIndex = 28;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Titulo.Location = new System.Drawing.Point(132, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(164, 24);
            this.lb_Titulo.TabIndex = 27;
            this.lb_Titulo.Text = "Editar Usuarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(200, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(149, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Apellido Paterno:";
            // 
            // tb_ApellidoP
            // 
            this.tb_ApellidoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_ApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ApellidoP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ApellidoP.Location = new System.Drawing.Point(111, 165);
            this.tb_ApellidoP.MaxLength = 50;
            this.tb_ApellidoP.Name = "tb_ApellidoP";
            this.tb_ApellidoP.Size = new System.Drawing.Size(214, 26);
            this.tb_ApellidoP.TabIndex = 40;
            this.tb_ApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(428, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ApellidoP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_GuardarCambios);
            this.Controls.Add(this.cb_Roles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ApellidoM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lb_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar_Usuario";
            this.Text = "Editar_Usuario";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editar_Usuario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarCambios;
        private System.Windows.Forms.ComboBox cb_Roles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ApellidoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ApellidoP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}