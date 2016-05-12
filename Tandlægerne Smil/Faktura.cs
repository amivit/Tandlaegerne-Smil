namespace Tandlægerne_Smil
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Faktura")]
    public partial class Faktura
    {
        [Key]
        public long faktura_id { get; set; }

        public long patient_id { get; set; }

        public bool betalt { get; set; }

        public DateTime faktura_dato { get; set; }

        public virtual Fakturalinjer Fakturalinjer { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
