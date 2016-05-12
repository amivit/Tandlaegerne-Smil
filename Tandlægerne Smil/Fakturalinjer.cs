namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fakturalinjer")]
    public partial class Fakturalinjer
    {
        [Key]
        public long faktura_id { get; set; }

        public long behandling_id { get; set; }

        public DateTime? tidspunkt { get; set; }

        public virtual Behandling Behandling { get; set; }

        public virtual Faktura Faktura { get; set; }
    }
}
