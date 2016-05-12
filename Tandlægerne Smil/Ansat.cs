namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ansat")]
    public partial class Ansat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ansat()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int ansat_id { get; set; }

        public int stilling_id { get; set; }

        [Required]
        [StringLength(20)]
        public string fornavn { get; set; }

        [StringLength(20)]
        public string efternavn { get; set; }

        public decimal? løn { get; set; }

        public bool aktiv { get; set; }

        public bool elev { get; set; }

        public virtual Stilling Stilling { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
