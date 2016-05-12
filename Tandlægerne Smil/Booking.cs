namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Patients = new HashSet<Patient>();
        }

        [Key]
        public int booking_id { get; set; }

        public DateTime tidspunkt { get; set; }

        public short lokale_id { get; set; }

        public int? læge_id { get; set; }

        public long patient_id { get; set; }

        public bool ankommet { get; set; }

        public virtual Ansat Ansat { get; set; }

        public virtual Behandlingsrum Behandlingsrum { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
