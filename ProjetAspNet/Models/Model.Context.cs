﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetAspNet.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NotesDeFraisEntities : DbContext
    {
        public NotesDeFraisEntities()
            : base("name=NotesDeFraisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<ExpanseReports> ExpanseReports { get; set; }
        public DbSet<Expanses> Expanses { get; set; }
        public DbSet<ExpanseTypes> ExpanseTypes { get; set; }
        public DbSet<Poles> Poles { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Tvas> Tvas { get; set; }
    }
}
