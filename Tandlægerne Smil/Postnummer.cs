namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Postnummer")]
    public partial class Postnummer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postnummer()
        {
            Patients = new HashSet<Patient>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short postnr { get; set; }

        [StringLength(24)]
        public string distrikt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
