﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control7.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusatovaControl7Entities : DbContext
    {
        public MusatovaControl7Entities()
            : base("name=MusatovaControl7Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accounting> Accounting { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Material> Material { get; set; }
    }
}