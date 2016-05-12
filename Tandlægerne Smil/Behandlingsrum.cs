namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Behandlingsrum")]
    public partial class Behandlingsrum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Behandlingsrum()
        {
            Bookings = new HashSet<Booking>();
            Udstyrs = new HashSet<Udstyr>();
        }

        [Key]
        public short rum_id { get; set; }

        [Required]
        [StringLength(20)]
        public string rum_navn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Udstyr> Udstyrs { get; set; }
    }
}
