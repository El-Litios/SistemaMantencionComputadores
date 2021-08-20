
namespace SistemaGestion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lb_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaGestion.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaGestion.Properties.Resources.User1;
            this.pictureBox2.Location = new System.Drawing.Point(26, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Usuario.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Usuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Usuario.Location = new System.Drawing.Point(74, 203);
            this.tb_Usuario.MaxLength = 15;
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(266, 30);
            this.tb_Usuario.TabIndex = 2;
            this.tb_Usuario.Text = "Nombre de Usuario";
            this.tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Usuario_MouseClick);
            this.tb_Usuario.TextChanged += new System.EventHandler(this.tb_Usuario_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaGestion.Properties.Resources.Pass;
            this.pictureBox3.Location = new System.Drawing.Point(26, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tb_Pass
            // 
            this.tb_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Pass.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Pass.Location = new System.Drawing.Point(74, 272);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(266, 30);
            this.tb_Pass.TabIndex = 4;
            this.tb_Pass.Text = "Contraseña";
            this.tb_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Pass.UseSystemPasswordChar = true;
            this.tb_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Pass_MouseClick);
            this.tb_Pass.TextChanged += new System.EventHandler(this.tb_Pass_TextChanged);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Iniciar.Enabled = false;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_Iniciar.Location = new System.Drawing.Point(74, 353);
            this.btn_Iniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(266, 36);
            this.btn_Iniciar.TabIndex = 5;
            this.btn_Iniciar.Text = "Iniciar Sesión";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::SistemaGestion.Properties.Resources.close1;
            this.btn_Cerrar.Location = new System.Drawing.Point(389, -2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 26);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lb_Error
            // 
            this.lb_Error.AutoSize = true;
            this.lb_Error.BackColor = System.Drawing.Color.White;
            this.lb_Error.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Error.ForeColor = System.Drawing.Color.Red;
            this.lb_Error.Location = new System.Drawing.Point(92, 421);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(231, 19);
            this.lb_Error.TabIndex = 7;
            this.lb_Error.Text = "USUARIO NO ENCONTRADO";
            this.lb_Error.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 489);
            this.Controls.Add(this.lb_Error);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 489);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lb_Error;
    }
}

