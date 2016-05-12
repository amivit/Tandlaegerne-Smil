namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Udstyr")]
    public partial class Udstyr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Udstyr()
        {
            Behandlings = new HashSet<Behandling>();
        }

        [Key]
        public int udstyr_id { get; set; }

        [Required]
        [StringLength(50)]
        public string navn { get; set; }

        public short? rum_id { get; set; }

        [StringLength(10)]
        public string serienummer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Behandling> Behandlings { get; set; }

        public virtual Behandlingsrum Behandlingsrum { get; set; }
    }
}
