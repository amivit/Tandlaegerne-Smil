namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Bookings = new HashSet<Booking>();
            Fakturas = new HashSet<Faktura>();
        }

        [Key]
        public long patient_id { get; set; }

        [Required]
        [StringLength(20)]
        public string fornavn { get; set; }

        [Required]
        [StringLength(20)]
        public string efternavn { get; set; }

        public long cpr { get; set; }

        [Required]
        [StringLength(50)]
        public string adresse { get; set; }

        public short postnummer { get; set; }

        public int? telefon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktura> Fakturas { get; set; }

        public virtual Postnummer Postnummer1 { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
