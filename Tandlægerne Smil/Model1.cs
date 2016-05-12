namespace Tandlægerne_Smil
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ansat> Ansats { get; set; }
        public virtual DbSet<Behandling> Behandlings { get; set; }
        public virtual DbSet<Behandlingsrum> Behandlingsrums { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Faktura> Fakturas { get; set; }
        public virtual DbSet<Fakturalinjer> Fakturalinjers { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Postnummer> Postnummers { get; set; }
        public virtual DbSet<Stilling> Stillings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Udstyr> Udstyrs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ansat>()
                .Property(e => e.fornavn)
                .IsFixedLength();

            modelBuilder.Entity<Ansat>()
                .Property(e => e.efternavn)
                .IsFixedLength();

            modelBuilder.Entity<Ansat>()
                .Property(e => e.løn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ansat>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Ansat)
                .HasForeignKey(e => e.læge_id);

            modelBuilder.Entity<Behandling>()
                .Property(e => e.navn)
                .IsFixedLength();

            modelBuilder.Entity<Behandling>()
                .Property(e => e.pris)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Behandling>()
                .HasMany(e => e.Fakturalinjers)
                .WithRequired(e => e.Behandling)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Behandlingsrum>()
                .Property(e => e.rum_navn)
                .IsFixedLength();

            modelBuilder.Entity<Behandlingsrum>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Behandlingsrum)
                .HasForeignKey(e => e.lokale_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Patients)
                .WithOptional(e => e.Booking);

            modelBuilder.Entity<Fakturalinjer>()
                .HasOptional(e => e.Faktura)
                .WithRequired(e => e.Fakturalinjer);

            modelBuilder.Entity<Patient>()
                .Property(e => e.fornavn)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.efternavn)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.adresse)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.patient_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Fakturas)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Postnummer>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Postnummer1)
                .HasForeignKey(e => e.postnummer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stilling>()
                .Property(e => e.job_titel)
                .IsFixedLength();

            modelBuilder.Entity<Stilling>()
                .HasMany(e => e.Ansats)
                .WithRequired(e => e.Stilling)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Udstyr>()
                .Property(e => e.navn)
                .IsFixedLength();

            modelBuilder.Entity<Udstyr>()
                .Property(e => e.serienummer)
                .IsFixedLength();

            modelBuilder.Entity<Udstyr>()
                .HasMany(e => e.Behandlings)
                .WithOptional(e => e.Udstyr)
                .HasForeignKey(e => e.krævet_udstyr_id);
        }
    }
}
