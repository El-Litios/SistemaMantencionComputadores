using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaGestion.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategoriaPc",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategoriaPc", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "tblEstadoMantencion",
                columns: table => new
                {
                    EstadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEstadoMantencion", x => x.EstadoID);
                });

            migrationBuilder.CreateTable(
                name: "tblMarca",
                columns: table => new
                {
                    MarcaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMarca", x => x.MarcaID);
                });

            migrationBuilder.CreateTable(
                name: "tblMetodoPago",
                columns: table => new
                {
                    MetodoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetodoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMetodoPago", x => x.MetodoID);
                });

            migrationBuilder.CreateTable(
                name: "tblProveedorSistema",
                columns: table => new
                {
                    ProveedorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedorNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProveedorSistema", x => x.ProveedorID);
                });

            migrationBuilder.CreateTable(
                name: "tblRolUsuario",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRolUsuario", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "tblTipoCliente",
                columns: table => new
                {
                    TipoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTipoCliente", x => x.TipoID);
                });

            migrationBuilder.CreateTable(
                name: "tblModelo",
                columns: table => new
                {
                    ModeloID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeloNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblModelo", x => x.ModeloID);
                    table.ForeignKey(
                        name: "FK_tblModelo_tblMarca_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "tblMarca",
                        principalColumn: "MarcaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSistemaOperativo",
                columns: table => new
                {
                    SistemaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SistemaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProveedorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSistemaOperativo", x => x.SistemaID);
                    table.ForeignKey(
                        name: "FK_tblSistemaOperativo_tblProveedorSistema_ProveedorID",
                        column: x => x.ProveedorID,
                        principalTable: "tblProveedorSistema",
                        principalColumn: "ProveedorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUsuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioPass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_tblUsuario_tblRolUsuario_RolID",
                        column: x => x.RolID,
                        principalTable: "tblRolUsuario",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteApellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCliente", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_tblCliente_tblTipoCliente_TipoID",
                        column: x => x.TipoID,
                        principalTable: "tblTipoCliente",
                        principalColumn: "TipoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblComputador",
                columns: table => new
                {
                    ComputadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PcRam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PcDisco1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PcDisco2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PcProcesador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PcVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloID = table.Column<int>(type: "int", nullable: false),
                    SistemaID = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblComputador", x => x.ComputadorID);
                    table.ForeignKey(
                        name: "FK_tblComputador_tblCategoriaPc_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "tblCategoriaPc",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblComputador_tblModelo_ModeloID",
                        column: x => x.ModeloID,
                        principalTable: "tblModelo",
                        principalColumn: "ModeloID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblComputador_tblSistemaOperativo_SistemaID",
                        column: x => x.SistemaID,
                        principalTable: "tblSistemaOperativo",
                        principalColumn: "SistemaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMantencion",
                columns: table => new
                {
                    MantencionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MantencionFallas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MantencionProceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MantencionFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MantencionPrecio = table.Column<int>(type: "int", nullable: false),
                    MantencionImpuesto = table.Column<int>(type: "int", nullable: false),
                    MantencionTotal = table.Column<int>(type: "int", nullable: false),
                    MetodoID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    EstadoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMantencion", x => x.MantencionID);
                    table.ForeignKey(
                        name: "FK_tblMantencion_tblCliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "tblCliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMantencion_tblEstadoMantencion_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "tblEstadoMantencion",
                        principalColumn: "EstadoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMantencion_tblMetodoPago_MetodoID",
                        column: x => x.MetodoID,
                        principalTable: "tblMetodoPago",
                        principalColumn: "MetodoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMantencion_tblUsuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "tblUsuario",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDetalleMantencion",
                columns: table => new
                {
                    DetalleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MantencionID = table.Column<int>(type: "int", nullable: false),
                    ComputadorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDetalleMantencion", x => x.DetalleID);
                    table.ForeignKey(
                        name: "FK_tblDetalleMantencion_tblComputador_ComputadorID",
                        column: x => x.ComputadorID,
                        principalTable: "tblComputador",
                        principalColumn: "ComputadorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblDetalleMantencion_tblMantencion_MantencionID",
                        column: x => x.MantencionID,
                        principalTable: "tblMantencion",
                        principalColumn: "MantencionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCliente_TipoID",
                table: "tblCliente",
                column: "TipoID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComputador_CategoriaID",
                table: "tblComputador",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComputador_ModeloID",
                table: "tblComputador",
                column: "ModeloID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComputador_SistemaID",
                table: "tblComputador",
                column: "SistemaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblDetalleMantencion_ComputadorID",
                table: "tblDetalleMantencion",
                column: "ComputadorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblDetalleMantencion_MantencionID",
                table: "tblDetalleMantencion",
                column: "MantencionID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMantencion_ClienteID",
                table: "tblMantencion",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMantencion_EstadoID",
                table: "tblMantencion",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMantencion_MetodoID",
                table: "tblMantencion",
                column: "MetodoID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMantencion_UsuarioID",
                table: "tblMantencion",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_tblModelo_MarcaID",
                table: "tblModelo",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblSistemaOperativo_ProveedorID",
                table: "tblSistemaOperativo",
                column: "ProveedorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsuario_RolID",
                table: "tblUsuario",
                column: "RolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblDetalleMantencion");

            migrationBuilder.DropTable(
                name: "tblComputador");

            migrationBuilder.DropTable(
                name: "tblMantencion");

            migrationBuilder.DropTable(
                name: "tblCategoriaPc");

            migrationBuilder.DropTable(
                name: "tblModelo");

            migrationBuilder.DropTable(
                name: "tblSistemaOperativo");

            migrationBuilder.DropTable(
                name: "tblCliente");

            migrationBuilder.DropTable(
                name: "tblEstadoMantencion");

            migrationBuilder.DropTable(
                name: "tblMetodoPago");

            migrationBuilder.DropTable(
                name: "tblUsuario");

            migrationBuilder.DropTable(
                name: "tblMarca");

            migrationBuilder.DropTable(
                name: "tblProveedorSistema");

            migrationBuilder.DropTable(
                name: "tblTipoCliente");

            migrationBuilder.DropTable(
                name: "tblRolUsuario");
        }
    }
}
