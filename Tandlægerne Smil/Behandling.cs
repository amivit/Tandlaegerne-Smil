namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Behandling")]
    public partial class Behandling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Behandling()
        {
            Fakturalinjers = new HashSet<Fakturalinjer>();
        }

        [Key]
        public long behandling_id { get; set; }

        [StringLength(100)]
        public string navn { get; set; }

        public decimal? pris { get; set; }

        public int? anslået_tid { get; set; }

        public int? krævet_udstyr_id { get; set; }

        public virtual Udstyr Udstyr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fakturalinjer> Fakturalinjers { get; set; }
    }
}
