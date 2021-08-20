
namespace SistemaGestion.Vistas.Mantenciones
{
    partial class Editar_Mantencion
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MetodoPago = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Procedimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Falla = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(603, 268);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(214, 42);
            this.btn_Guardar.TabIndex = 69;
            this.btn_Guardar.Text = "GUARDAR CAMBIOS";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(603, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "Metodo de pago:";
            // 
            // cb_MetodoPago
            // 
            this.cb_MetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_MetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_MetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_MetodoPago.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_MetodoPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_MetodoPago.FormattingEnabled = true;
            this.cb_MetodoPago.Location = new System.Drawing.Point(603, 126);
            this.cb_MetodoPago.Name = "cb_MetodoPago";
            this.cb_MetodoPago.Size = new System.Drawing.Size(214, 25);
            this.cb_MetodoPago.TabIndex = 67;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.text.Location = new System.Drawing.Point(603, 168);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(61, 18);
            this.text.TabIndex = 64;
            this.text.Text = "Estado:";
            // 
            // cb_Estado
            // 
            this.cb_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Estado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Estado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Location = new System.Drawing.Point(603, 204);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(214, 25);
            this.cb_Estado.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Procedimiento:";
            // 
            // tb_Procedimiento
            // 
            this.tb_Procedimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Procedimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Procedimiento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Procedimiento.Location = new System.Drawing.Point(32, 278);
            this.tb_Procedimiento.MaxLength = 500;
            this.tb_Procedimiento.Multiline = true;
            this.tb_Procedimiento.Name = "tb_Procedimiento";
            this.tb_Procedimiento.Size = new System.Drawing.Size(493, 114);
            this.tb_Procedimiento.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Fallas:";
            // 
            // tb_Falla
            // 
            this.tb_Falla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Falla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Falla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Falla.Location = new System.Drawing.Point(32, 115);
            this.tb_Falla.MaxLength = 500;
            this.tb_Falla.Multiline = true;
            this.tb_Falla.Name = "tb_Falla";
            this.tb_Falla.Size = new System.Drawing.Size(493, 114);
            this.tb_Falla.TabIndex = 53;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Titulo.Location = new System.Drawing.Point(330, 16);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(192, 24);
            this.lb_Titulo.TabIndex = 70;
            this.lb_Titulo.Text = "Editar Mantención";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::SistemaGestion.Properties.Resources.close1;
            this.btn_Cerrar.Location = new System.Drawing.Point(827, -5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 34);
            this.btn_Cerrar.TabIndex = 71;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Editar_Mantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(853, 451);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_MetodoPago);
            this.Controls.Add(this.text);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Procedimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Falla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar_Mantencion";
            this.Text = "Editar_Mantencion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_MetodoPago;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Procedimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Falla;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}