﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProdavanBaseEntities2 : DbContext
    {
        public ProdavanBaseEntities2()
            : base("name=ProdavanBaseEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Postavchik> Postavchik { get; set; }
        public virtual DbSet<Postavka> Postavka { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
        public virtual DbSet<Zakazchik> Zakazchik { get; set; }
    }
}