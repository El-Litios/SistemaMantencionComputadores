
namespace SistemaGestion.Vistas.Mantenciones
{
    partial class Agregar_Mantencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Mantencion));
            this.lv_listapcdb = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.modelo = new System.Windows.Forms.ColumnHeader();
            this.marca = new System.Windows.Forms.ColumnHeader();
            this.tipo = new System.Windows.Forms.ColumnHeader();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lv_pcmantencion = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.codigo = new System.Windows.Forms.ColumnHeader();
            this.procesador = new System.Windows.Forms.ColumnHeader();
            this.video = new System.Windows.Forms.ColumnHeader();
            this.disco1 = new System.Windows.Forms.ColumnHeader();
            this.disco2 = new System.Windows.Forms.ColumnHeader();
            this.ram = new System.Windows.Forms.ColumnHeader();
            this.modelopc = new System.Windows.Forms.ColumnHeader();
            this.os = new System.Windows.Forms.ColumnHeader();
            this.categoria = new System.Windows.Forms.ColumnHeader();
            this.btn_AgregarMasPc = new System.Windows.Forms.Button();
            this.btn_ListarEnMantencion = new System.Windows.Forms.Button();
            this.tb_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tb_Falla = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Procedimiento = new System.Windows.Forms.TextBox();
            this.cb_Tipocliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Tecnico = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.tb_Monto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MetodoPago = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_listapcdb
            // 
            this.lv_listapcdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.lv_listapcdb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_listapcdb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.id,
            this.modelo,
            this.marca,
            this.tipo});
            this.lv_listapcdb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lv_listapcdb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_listapcdb.FullRowSelect = true;
            this.lv_listapcdb.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_listapcdb.HideSelection = false;
            this.lv_listapcdb.Location = new System.Drawing.Point(966, 130);
            this.lv_listapcdb.Margin = new System.Windows.Forms.Padding(0);
            this.lv_listapcdb.MultiSelect = false;
            this.lv_listapcdb.Name = "lv_listapcdb";
            this.lv_listapcdb.Size = new System.Drawing.Size(325, 295);
            this.lv_listapcdb.TabIndex = 28;
            this.lv_listapcdb.UseCompatibleStateImageBehavior = false;
            this.lv_listapcdb.View = System.Windows.Forms.View.Details;
            this.lv_listapcdb.SelectedIndexChanged += new System.EventHandler(this.lv_listapcdb_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 50;
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelo.Width = 91;
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.marca.Width = 91;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            this.tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipo.Width = 91;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::SistemaGestion.Properties.Resources.close1;
            this.btn_Cerrar.Location = new System.Drawing.Point(1277, -1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 34);
            this.btn_Cerrar.TabIndex = 29;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lv_pcmantencion
            // 
            this.lv_pcmantencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.lv_pcmantencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_pcmantencion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.codigo,
            this.procesador,
            this.video,
            this.disco1,
            this.disco2,
            this.ram,
            this.modelopc,
            this.os,
            this.categoria});
            this.lv_pcmantencion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lv_pcmantencion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_pcmantencion.FullRowSelect = true;
            this.lv_pcmantencion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_pcmantencion.HideSelection = false;
            this.lv_pcmantencion.Location = new System.Drawing.Point(32, 399);
            this.lv_pcmantencion.Margin = new System.Windows.Forms.Padding(0);
            this.lv_pcmantencion.MultiSelect = false;
            this.lv_pcmantencion.Name = "lv_pcmantencion";
            this.lv_pcmantencion.Size = new System.Drawing.Size(878, 230);
            this.lv_pcmantencion.TabIndex = 30;
            this.lv_pcmantencion.UseCompatibleStateImageBehavior = false;
            this.lv_pcmantencion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // codigo
            // 
            this.codigo.Text = "ID";
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo.Width = 50;
            // 
            // procesador
            // 
            this.procesador.Text = "Procesador";
            this.procesador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.procesador.Width = 103;
            // 
            // video
            // 
            this.video.Text = "Tarjeta gráfica";
            this.video.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.video.Width = 103;
            // 
            // disco1
            // 
            this.disco1.Text = "Disco duro 1";
            this.disco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disco1.Width = 103;
            // 
            // disco2
            // 
            this.disco2.Text = "Disco duro 2";
            this.disco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disco2.Width = 103;
            // 
            // ram
            // 
            this.ram.Text = "Ram";
            this.ram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ram.Width = 103;
            // 
            // modelopc
            // 
            this.modelopc.DisplayIndex = 8;
            this.modelopc.Text = "Modelo";
            this.modelopc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelopc.Width = 103;
            // 
            // os
            // 
            this.os.DisplayIndex = 7;
            this.os.Text = "Sist. operativo";
            this.os.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.os.Width = 103;
            // 
            // categoria
            // 
            this.categoria.Text = "Categoria";
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoria.Width = 103;
            // 
            // btn_AgregarMasPc
            // 
            this.btn_AgregarMasPc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_AgregarMasPc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_AgregarMasPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarMasPc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarMasPc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AgregarMasPc.Image = global::SistemaGestion.Properties.Resources.add;
            this.btn_AgregarMasPc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarMasPc.Location = new System.Drawing.Point(1067, 437);
            this.btn_AgregarMasPc.Name = "btn_AgregarMasPc";
            this.btn_AgregarMasPc.Size = new System.Drawing.Size(95, 35);
            this.btn_AgregarMasPc.TabIndex = 31;
            this.btn_AgregarMasPc.Text = "Agregar";
            this.btn_AgregarMasPc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AgregarMasPc.UseVisualStyleBackColor = false;
            this.btn_AgregarMasPc.Click += new System.EventHandler(this.btn_AgregarMasPc_Click);
            // 
            // btn_ListarEnMantencion
            // 
            this.btn_ListarEnMantencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_ListarEnMantencion.Enabled = false;
            this.btn_ListarEnMantencion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_ListarEnMantencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListarEnMantencion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ListarEnMantencion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ListarEnMantencion.Image = ((System.Drawing.Image)(resources.GetObject("btn_ListarEnMantencion.Image")));
            this.btn_ListarEnMantencion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListarEnMantencion.Location = new System.Drawing.Point(966, 437);
            this.btn_ListarEnMantencion.Name = "btn_ListarEnMantencion";
            this.btn_ListarEnMantencion.Size = new System.Drawing.Size(95, 35);
            this.btn_ListarEnMantencion.TabIndex = 32;
            this.btn_ListarEnMantencion.Text = "Listar";
            this.btn_ListarEnMantencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ListarEnMantencion.UseVisualStyleBackColor = false;
            this.btn_ListarEnMantencion.Click += new System.EventHandler(this.btn_ListarEnMantencion_Click);
            // 
            // tb_Buscador
            // 
            this.tb_Buscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Buscador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Buscador.Location = new System.Drawing.Point(973, 92);
            this.tb_Buscador.MaxLength = 30;
            this.tb_Buscador.Name = "tb_Buscador";
            this.tb_Buscador.PlaceholderText = "Buscador";
            this.tb_Buscador.Size = new System.Drawing.Size(196, 26);
            this.tb_Buscador.TabIndex = 33;
            this.tb_Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(1175, 92);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 26);
            this.btn_Buscar.TabIndex = 34;
            this.btn_Buscar.Text = "Aplicar filtros";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tb_Falla
            // 
            this.tb_Falla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Falla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Falla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Falla.Location = new System.Drawing.Point(32, 91);
            this.tb_Falla.MaxLength = 500;
            this.tb_Falla.Multiline = true;
            this.tb_Falla.Name = "tb_Falla";
            this.tb_Falla.Size = new System.Drawing.Size(286, 114);
            this.tb_Falla.TabIndex = 35;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Titulo.Location = new System.Drawing.Point(537, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(214, 24);
            this.lb_Titulo.TabIndex = 36;
            this.lb_Titulo.Text = "Agregar Mantención";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fallas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Procedimiento:";
            // 
            // tb_Procedimiento
            // 
            this.tb_Procedimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Procedimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Procedimiento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Procedimiento.Location = new System.Drawing.Point(32, 254);
            this.tb_Procedimiento.MaxLength = 500;
            this.tb_Procedimiento.Multiline = true;
            this.tb_Procedimiento.Name = "tb_Procedimiento";
            this.tb_Procedimiento.Size = new System.Drawing.Size(286, 114);
            this.tb_Procedimiento.TabIndex = 38;
            // 
            // cb_Tipocliente
            // 
            this.cb_Tipocliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Tipocliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Tipocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Tipocliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Tipocliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Tipocliente.FormattingEnabled = true;
            this.cb_Tipocliente.Location = new System.Drawing.Point(353, 92);
            this.cb_Tipocliente.Name = "cb_Tipocliente";
            this.cb_Tipocliente.Size = new System.Drawing.Size(214, 25);
            this.cb_Tipocliente.TabIndex = 40;
            this.cb_Tipocliente.SelectedIndexChanged += new System.EventHandler(this.cb_Tipocliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(353, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tipo de cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(353, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cliente:";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Cliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(353, 162);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(214, 25);
            this.cb_Cliente.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(353, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Técnico:";
            // 
            // cb_Tecnico
            // 
            this.cb_Tecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.cb_Tecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Tecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Tecnico.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Tecnico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Tecnico.FormattingEnabled = true;
            this.cb_Tecnico.Location = new System.Drawing.Point(353, 240);
            this.cb_Tecnico.Name = "cb_Tecnico";
            this.cb_Tecnico.Size = new System.Drawing.Size(214, 25);
            this.cb_Tecnico.TabIndex = 44;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.text.Location = new System.Drawing.Point(353, 285);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(61, 18);
            this.text.TabIndex = 47;
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
            this.cb_Estado.Location = new System.Drawing.Point(353, 317);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(214, 25);
            this.cb_Estado.TabIndex = 46;
            // 
            // tb_Monto
            // 
            this.tb_Monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(124)))));
            this.tb_Monto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Monto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Monto.Location = new System.Drawing.Point(603, 92);
            this.tb_Monto.MaxLength = 30;
            this.tb_Monto.Name = "tb_Monto";
            this.tb_Monto.Size = new System.Drawing.Size(214, 26);
            this.tb_Monto.TabIndex = 48;
            this.tb_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(603, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Monto a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(603, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 51;
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
            this.cb_MetodoPago.Location = new System.Drawing.Point(603, 162);
            this.cb_MetodoPago.Name = "cb_MetodoPago";
            this.cb_MetodoPago.Size = new System.Drawing.Size(214, 25);
            this.cb_MetodoPago.TabIndex = 50;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(83)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(603, 229);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(214, 42);
            this.btn_Guardar.TabIndex = 52;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Agregar_Mantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1304, 660);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_MetodoPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Monto);
            this.Controls.Add(this.text);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Tecnico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Tipocliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Procedimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.tb_Falla);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.tb_Buscador);
            this.Controls.Add(this.btn_ListarEnMantencion);
            this.Controls.Add(this.btn_AgregarMasPc);
            this.Controls.Add(this.lv_pcmantencion);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lv_listapcdb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Mantencion";
            this.Text = "Agregar_Mantencion";
            this.Load += new System.EventHandler(this.Agregar_Mantencion_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Agregar_Mantencion_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_listapcdb;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ListView lv_pcmantencion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader modelo;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.Button btn_AgregarMasPc;
        private System.Windows.Forms.Button btn_ListarEnMantencion;
        private System.Windows.Forms.TextBox tb_Buscador;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox tb_Falla;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Procedimiento;
        private System.Windows.Forms.ComboBox cb_Tipocliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Tecnico;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.TextBox tb_Monto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_MetodoPago;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ColumnHeader procesador;
        private System.Windows.Forms.ColumnHeader video;
        private System.Windows.Forms.ColumnHeader disco1;
        private System.Windows.Forms.ColumnHeader disco2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.ColumnHeader os;
        private System.Windows.Forms.ColumnHeader modelopc;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}