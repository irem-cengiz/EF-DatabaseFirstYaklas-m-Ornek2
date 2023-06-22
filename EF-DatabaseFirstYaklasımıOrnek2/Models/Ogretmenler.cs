using System;
using System.Collections.Generic;

namespace EF_DatabaseFirstYaklasımıOrnek2.Models
{
    public partial class Ogretmenler
    {
        public int OgretmenId { get; set; }
        public string OgretmenAd { get; set; } = null!;
        public string OgretmenSoyAd { get; set; } = null!;
    }
}
