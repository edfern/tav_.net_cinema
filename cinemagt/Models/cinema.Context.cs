﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cinemagt.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaConnection : DbContext
    {
        public CinemaConnection()
            : base("name=CinemaConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Functions> Functions { get; set; }
        public DbSet<movies> movies { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<salesdetail> salesdetail { get; set; }
        public DbSet<tickets> tickets { get; set; }
    }
}
