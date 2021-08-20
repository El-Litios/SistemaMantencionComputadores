using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestion.Models
{
    class DbConnection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BdMantencionpc;");


        //Migrations

        //Usuarios
        public DbSet<RolModelo> tblRolUsuario { get; set; }
        public DbSet<UsuarioModelo> tblUsuario { get; set; }

        //Clientes
        public DbSet<TipoCModelo> tblTipoCliente { get; set; }
        public DbSet<ClientesModelo> tblCliente { get; set; }

        //Computadores
        public DbSet<MarcaPcModelo> tblMarca { get; set; }
        public DbSet<ModelosPcModelo> tblModelo { get; set; }
        public DbSet<ProveedorSIstemaModelo> tblProveedorSistema { get; set; }
        public DbSet<SistemaOperativoModelo> tblSistemaOperativo { get; set; }
        public DbSet<CategoriaPcModelo> tblCategoriaPc { get; set; }
        public DbSet<ComputadorModelo> tblComputador { get; set; }


        //Mantenciones
        public DbSet<EstadoMantencionModelo> tblEstadoMantencion { get; set; }
        public DbSet<MetodoPagoModelo> tblMetodoPago { get; set; }
        public DbSet<MantencionesModelo> tblMantencion { get; set; }
        public DbSet<DetalleMantencionesModelo> tblDetalleMantencion { get; set; }
    }
}
