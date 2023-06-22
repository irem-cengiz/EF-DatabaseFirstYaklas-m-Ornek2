using System;
using System.Collections.Generic;

namespace EF_DatabaseFirstYaklasımıOrnek2.Models
{
    public partial class KritikSeviyeUrunBilgisi
    {
        public string ÜrünAdı { get; set; } = null!;
        public string Kategori { get; set; } = null!;
        public string TedarikçiFirma { get; set; } = null!;
        public short? MinimumSiparisAdedi { get; set; }
        public decimal? BirimFiyat { get; set; }
    }
}
